﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CodeBetter.Json;

namespace com.abitech.rfid
{
    /// <summary>
    /// Используется модификация стандарта JSON-RPC:
    ///     В result записывается некие данные, которые возвращает сервер в ответ на запрос; 
    ///     В error записывается либо null, если всё прошло нормально, либо же код ошибки.
    ///     В последнем случае в result записывается возможное словесное описание ошибки. 
    /// </summary>
    public class RpcResponse
    {
        public string result;
        public StatusCode status;

        /// <summary>
        /// Перечисление определяет возможный статус запроса, возвращаемый сервером.
        /// InternalServerError и ConnectionFail могут
        /// быть установлены самим клиентом в SendPostData
        /// </summary>
        public enum StatusCode
        {
            CorruptedResponse = -1,
            Ok = 0,
            InternalServerError = 1,
            InvalidDeviceKey = 2,
            CorruptedChecksum = 3,
            CorruptedFormat = 4,
            DuplicatedMessage = 5,
            EmptyRequest = 6,
            ConnectionFail = 7
        };

        public RpcResponse()
        {

        }
    }

    /// <summary>
    /// Класс, отвечающий за посылку данных считывания на сервер
    /// </summary>
    public class RfidWebClient
    {
        /// <summary>
        /// Определяет настройки подключения: сервер, ключ устройства.
        /// Смотри файл config.xml.
        /// </summary>
        readonly Configuration Configuration;

        readonly SHA1CryptoServiceProvider Sha1 = new SHA1CryptoServiceProvider();
        readonly UTF8Encoding UniEncoding = new UTF8Encoding();

        /// <summary>
        ///  Инициализация вебклиента
        /// </summary>
        /// <param name="conf"></param>
        public RfidWebClient(Configuration configuration)
        {
            this.Configuration = configuration;
        }

        public RpcResponse SendOrder(TubesOrder order)
        {
            var url = "order/" + Configuration.DeviceKey + "/";

            return SendPostData(url, Converter.Serialize(order));
        }

        public RpcResponse SendWaybill(Waybill waybill)
        {
            var url = "waybill/" + Configuration.DeviceKey + "/";

            return SendPostData(url, Converter.Serialize(waybill));
        }

        /// <summary>
        /// Запрос у сервера списка невыполненных заявок
        /// </summary>
        public List<TubesOrder> SyncronizeOrders()
        {
            var url = "order/list/" + Configuration.DeviceKey + "/";
            var response = SendPostData(url, String.Empty);
            //var json = "{\"result\":[{\"trackId\":\"1\",\"districtId\":\"100\",\"tubesLength\":\"1200\",\"tubesNumber\":\"100\",\"orderStatus\":\"0\"},{\"trackId\":\"2\",\"districtId\":\"1100\",\"tubesLength\":\"1200\",\"tubesNumber\":\"100\",\"orderStatus\":\"0\"},{\"trackId\":\"3\",\"districtId\":\"12\",\"tubesLength\":\"54\",\"tubesNumber\":\"87\",\"orderStatus\":\"0\"},{\"trackId\":\"4\",\"districtId\":\"123\",\"tubesLength\":\"321\",\"tubesNumber\":\"456\",\"orderStatus\":\"0\"}],\"error\":null}";
            //var response = RfidJson.Deserialize(json);

            if (response.status != RpcResponse.StatusCode.Ok)
            {
                return null;
            }

            var jsonOrders = Regex.Split(response.result.Replace("\"", ""), "\\},\\{");

            var orders = new List<TubesOrder>();

            foreach (var jsonOrder in jsonOrders)
            {
                var match = Regex.Match(jsonOrder, ".*trackId:(\\d+).*districtId:(\\d+).*tubesDiameter:(\\d+).*tubesNumber:(\\d+).*orderStatus:(\\d+).*shippedTubes:(\\d+).*groupUnit:(\\d+).*orderType:(\\d+).*");
                if (match.Success)
                {
                    orders.Add(new TubesOrder()
                        {
                            trackId = Int32.Parse(match.Groups[1].Value),
                            districtId = Int32.Parse(match.Groups[2].Value),
                            tubesDiameter = Int32.Parse(match.Groups[3].Value),
                            tubesNumber = Int32.Parse(match.Groups[4].Value),
                            orderStatus = (TubesOrder.OrderStatus)Int32.Parse(match.Groups[5].Value),
                            shippedTubes = Int32.Parse(match.Groups[6].Value),
                            groupUnit = Int32.Parse(match.Groups[7].Value),
                            orderType = Int32.Parse(match.Groups[8].Value)
                        });
                }
            }

            return orders;
        }

        /// <summary>
        /// Отправка и обработка данных. Обёртка над UploadString.
        /// </summary>
        /// <param name="url">Метод</param>
        /// <param name="data">Параметры</param>
        RpcResponse SendPostData(string url, string jsonString)
        {
            try
            {
                #if DEBUG
                MessageBox.Show(jsonString);
                #endif

                var jsonHashString = "&checksum=";
                var inHashBytes = UniEncoding.GetBytes(jsonString);
                var outHashBytes = Sha1.ComputeHash(inHashBytes);

                foreach (var b in outHashBytes)
                {
                    jsonHashString += b.ToString("x2");
                }

                var byteArray = UniEncoding.GetBytes("json=" + jsonString + jsonHashString); //фактически jsonString преобразуется дважды
                var webRequest = (HttpWebRequest)WebRequest.Create(Configuration.Server + url);

                //На DL770 падает
                //webRequest.Proxy = null;  //ставим в null; в противном случае webRequest начинает поиск прокси и тратит кучу времени 
                webRequest.Method = "POST";
                webRequest.AllowAutoRedirect = false;
                webRequest.ContentType = "application/x-www-form-urlencoded";
                webRequest.ContentLength = byteArray.Length;
                webRequest.Timeout = 5000;

                var webpageStream = webRequest.GetRequestStream();
                webpageStream.Write(byteArray, 0, byteArray.Length);
                webpageStream.Close();

                //обработка
                using (var response = webRequest.GetResponse())
                {
                    var responseStr = new StreamReader(response.GetResponseStream()).ReadToEnd();

                    #if DEBUG
                    MessageBox.Show(responseStr);
                    #endif      
                    //Использовал самописный десериализатор, т.к. CodeBetter, цитирую:
                    //On the whole I found it works; From memory it does not deal with nulls nicely,
                    //and I think I had to tweak datetime serialisation to make it work the way
                    //other json serialisers do.
                    //
                    //Иными словами, Converter.Deserialize<RpcResponse>(responseStr) валится на "result":"null"

                    return RfidJson.Deserialize(responseStr);
                }
            }

            catch (Exception e)
            {
                var response = new RpcResponse();
                response.result = e.Message;
                response.status = RpcResponse.StatusCode.InternalServerError;

                #if DEBUG
                MessageBox.Show(response.result);
                #endif

                return response;
            }
        }

        internal void UpdateOrderStatus(TubesOrder order, TubesOrder.OrderStatus status)
        {
            order.dateCreated = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            order.orderStatus = status;
            SendOrder(order);
        }
    }
}
