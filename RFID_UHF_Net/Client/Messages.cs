using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace com.abitech.rfid
{
    public enum OrderType { Delivery = 0, Dispatch = 1 };

	public class TubeDiameter
	{
		private Dictionary<int, string> tubeDiameters = new Dictionary<int, string>
                {
                    { 1, "60" },
                    { 2, "73" },
                    { 3, "73 выс" },
                    { 4, "89" }
                };
		 public string this[int id]
			{
				get
				{
					if (tubeDiameters.ContainsKey(id) == false)
					{
						return String.Empty;
					}

					return tubeDiameters[id];
				}
			}
	}

    public class ComboBoxItem
    {
        public int id;
        public string value;

        public override string ToString()
        {
            return value;
        }
    }

	public class Envelope
	{
		public int id;
	}

	public class StringEnvelope
	{
		public string deviceKey;
	}

	public class DeviceKeyRequest
	{
		public string masterKey;
		public int id;
	}

	public class DeviceDescription
	{
		public string location;
		public string team;
		public Roles role;
	}

	public class ShortDeviceDescription
	{
		public string id;
		public string location;
		public string team;
	}

	public class DeviceActivity
	{
		public int locationX;
		public int locationY;
	}

    public class Repair
    {
        public int id;
        public int ogpw;
        public int cjp;
        public int oilwellNumber;
        public int tubeDiameterId;
    }

    public class Order
    {
        public int id;      
        public int orderReasonId;
        public int orderTypeId;
        public int tubesNumber;
        public int approachId;
        public string dateExpected;
    }

	public class OrderListRecord
	{
		public int id;
		public int ogpw;
		public int cjp;
		public int oilwellNumber;
		public int orderTypeId;
		public int tubeDiameterId;
		public int tubesNumber;
		public int tubesNumberByWaybills;
	}

	public class Act
	{
		public int id;
		public int actTypeId;
		public int tubesNumber;
	}

    /// <summary>
    /// ТТН
    /// </summary>
    public class Waybill
    {
        public int id;
        public int number;
        public int tubeTypeId;
        public int tubesNumber;
        public string epc;
        public string licencePlateNumber;
    }
}
