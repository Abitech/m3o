using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using com.caen.RFIDLibrary;
using RFID_UHF_Net;


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

    class RfidReader
    {
        public static RfidWebClient web;
        public static Configuration configuration;
        public static CAENRFIDReader reader;
        public static CAENRFIDLogicalSource source;

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