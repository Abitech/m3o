﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using com.caen.RFIDLibrary;
using RFID_UHF_Net;
using System.IO;
using System.Reflection;
using Microsoft.WindowsCE.Forms;
using System.Runtime.InteropServices;


namespace com.abitech.rfid
{
	enum MemoryBankType
	{
		Other = -1,
		Reserved = 0,
		EPC = 1,
		TID = 2,
		USER = 3
	};

    class M3Client
    {
		public static string configurationPath { get; private set; }
		public static RfidWebClient web { get; private set; }
		public static Configuration configuration { get; private set; }
		public static CAENRFIDReader reader {  get; private set; }
		public static CAENRFIDLogicalSource source { get; private set; }
		
		static RpcResponse<List<Repair>> _repairs;

		public static GpsParse gps;
		public static GpsParse.GPS_PARSE_INFO gpsInfo = new GpsParse.GPS_PARSE_INFO();
		public static double dUTCTime;

		public static bool Init()
		{
			configurationPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase) + @"\config.xml";
			configuration = Configuration.Deserialize(configurationPath);

			Resources.Init();
			Resources.strings.SetLanguage(configuration.Language);

			web = new RfidWebClient(configuration);

			try
			{
				reader = new CAENRFIDReader();
				reader.Connect(CAENRFIDPort.CAENRFID_RS232, "MOC1");
				System.Threading.Thread.Sleep(500);
				M3Client.source = M3Client.reader.GetSources()[0];
			}
			catch (CAENRFIDException e)
			{
				return false;
			}
			return true;
		}
		
		public static void InitGps()
		{
			gps = new GpsParse();
			var gpsMessageWindow = new GpsMessageWindow(OnReceivingGpsData);

			if (gps.Open(gpsMessageWindow.Hwnd, "COM2:", 9600, GetGpsInfoDelegate))
			{
				MessageBox.Show("Соединение с GPS удалось");
			}
			else
			{
				gps.Close();
			}
		}

#pragma unmanaged
		public static void GetGpsInfoDelegate(ref GpsParse.GPS_PARSE_INFO info)
		{
			try
			{
				dUTCTime = info.dUTCTime;
			}
			catch (Exception e)				   
			{
				Console.WriteLine(e.Message);
			}
		}
#pragma managed

		public static void OnReceivingGpsData(Message msg)
		{
			try
			{
				if (msg == null || msg.WParam == null)
				{
					MessageBox.Show("msg == null || msg.WParam == null");
				}

				gpsInfo = (GpsParse.GPS_PARSE_INFO)Marshal.PtrToStructure(msg.WParam, typeof(GpsParse.GPS_PARSE_INFO));
			}
			catch (Exception e)
			{
				MessageBox.Show("GPS умер " + e.Message);
			}
		}

		public static RpcResponse<List<Repair>> repairs
		{
			get
			{
				if (_repairs == null || _repairs.result == null)
				{
					_repairs = web.GetRepairs();
				}

				return _repairs;
			}

			set
			{
				_repairs = value;
			}
		}

		public void AddRepair(Repair repair)
		{
			if (_repairs != null)
			{
				_repairs.result.Add(repair);
			}
		}

        public static bool GetSelectedTag(out CAENRFIDTag tag)
        {
            try
            {
                CAENRFIDTag[] tags;
                tags = source.InventoryTag();

                if (tags != null)
                {
                    tag = tags[0];
                    return true;
                }
                else
                {
                    tag = null;
                    return false;
                }
            }
            catch
            {
                tag = null;
                return false;
            }
        }

        public static byte[] HexStringToByteArray(string s)
        {
            s = s.Replace(" ", "");
            byte[] buffer = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            return buffer;
        }

        public static string ByteArrayToHexString(byte[] data)
        {
            StringBuilder sb = new StringBuilder(data.Length * 3);
            foreach (byte b in data)
                sb.Append(Convert.ToString(b, 16).PadLeft(2, '0'));
            return sb.ToString().ToUpper().Replace("-", "");
        }

        public static bool ReadTag(CAENRFIDTag tag, MemoryBankType MemType, int nStartAddr, int nLength, out byte[] data)
        {
            try
            {
                data = source.ReadTagData_EPC_C1G2(tag, (short)MemType, (short)nStartAddr, (short)nLength);
            }
            catch
            {
                data = null;
                return false;
            }

            return true;
        }

        public static bool WriteTag(CAENRFIDTag tag, MemoryBankType MemType, int nStartAddr, int nLength, byte[] data)
        {
            try
            {
                source.WriteTagData_EPC_C1G2(tag, (short)MemType, (short)nStartAddr, (short)nLength, data);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}