using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using CodeBetter.Json;
using System.Windows.Forms;

namespace com.abitech.rfid
{
    /// <summary>
    /// Используется модификация стандарта JSON-RPC:
    ///     В result записывается некие данные, которые возвращает сервер в ответ на запрос; 
    ///     В error записывается либо null, если всё прошло нормально, либо же код ошибки.
    ///     В последнем случае в result записывается возможное словесное описание ошибки.
	///     
	///		Поле id отсутствует.
    /// </summary>

    /// <summary>
    /// Перечисление определяет возможный статус запроса, возвращаемый сервером.
    /// InternalServerError и ConnectionFail могут
    /// быть установлены самим клиентом в SendPostData
    /// </summary>
    public enum ResponseCode
    {
        CorruptedResponse = -1,
        Ok = 0,
        InternalServerError = 1,
        InvalidDeviceKey = 2,
        CorruptedChecksum = 3,
        CorruptedFormat = 4,
        DuplicatedMessage = 5,
        EmptyRequest = 6,
		AccessDenied = 7,
		IncorrectId = 8,
		OwnerMismatch = 9,
		ActionForbidden = 10
    };

    public class RpcResponse<T>
    {
        public T result;
        public string error;
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

		public RpcResponse<List<Repair>> GetRepairs()
		{
			return SendPostData<List<Repair>>("json/dev/get/repairs", "{}");
		}

		public RpcResponse<List<OrderListRecord>> GetOrders()
		{
			return SendPostData<List<OrderListRecord>>("json/dev/get/orders", "{}");
		}

		public RpcResponse<DeviceDescription> GetDeviceDescription()
		{
			return SendPostData<DeviceDescription>("json/dev/maint/descr", "{}");
		}

		#region CreateSomething
		public RpcResponse<string> CreateRepair(Repair repair)
        {
            return SendPostData<string>("json/dev/create/repair/", Converter.Serialize(repair));
        }

        public RpcResponse<string> CreateOrder(Order order)
        {
            return SendPostData<string>("json/dev/create/order/", Converter.Serialize(order));
        }

		public RpcResponse<string> CreateWaybill(Waybill waybill)
		{
			return SendPostData<string>("json/dev/create/waybill/", Converter.Serialize(waybill));
		}

		public RpcResponse<string> CreateAct(Act act)
		{
			return SendPostData<string>("json/dev/create/act/", Converter.Serialize(act));
		}

		public RpcResponse<string> UpdateOnlineStatus(DeviceActivity deviceCheck)
		{
			return SendPostData<string>("json/dev/maint/online/", Converter.Serialize(deviceCheck));		
		}

		public RpcResponse<string> CancelOrder(int id)
		{
			return SendPostData<string>("json/dev/cancel/order/", Converter.Serialize(new Envelope { id = id }));
		}
		#endregion

        /// <summary>
        /// Отправка и обработка данных. Обёртка над UploadString.
        /// </summary>
        /// <param name="url">Метод</param>
        /// <param name="data">Параметры</param>
        RpcResponse<T> SendPostData<T>(string url, string jsonString)
        {
            try
            {
                #if DEBUG
                MessageBox.Show(jsonString);
                #endif

                var jsonHashString = String.Empty;
                var inHashBytes = UniEncoding.GetBytes(jsonString);
                var outHashBytes = Sha1.ComputeHash(inHashBytes);

                //фактически jsonString преобразуется дважды
                foreach (var b in outHashBytes)
                {
                    jsonHashString += b.ToString("x2");
                }

                var byteArray = UniEncoding.GetBytes("json=" + jsonString + "&key=" + Configuration.DeviceKey + "&checksum=" + jsonHashString);
                var webRequest = (HttpWebRequest)WebRequest.Create(Configuration.Server + url);

                // webRequest.Proxy = null;  //На Шindows Mobile работает некорректно
                webRequest.Method = "POST";
                webRequest.AllowAutoRedirect = false;
                webRequest.ContentType = "application/x-www-form-urlencoded";
                webRequest.ContentLength = byteArray.Length;
                webRequest.Timeout = 5000;

                var webpageStream = webRequest.GetRequestStream();
                webpageStream.Write(byteArray, 0, byteArray.Length);
                webpageStream.Close();

                //обработка
                using (var webResponse = webRequest.GetResponse())
                {
					var responseString = new StreamReader(webResponse.GetResponseStream()).ReadToEnd();

					#if DEBUG
                    MessageBox.Show(responseString);
					#endif

					return Converter.Deserialize<RpcResponse<T>>(responseString);
                }
            }

            catch (Exception e)
            {
                 return new RpcResponse<T> { error = ResponseCode.InternalServerError.ToString() };
            }
        }
	}
}
