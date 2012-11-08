using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace com.abitech.rfid
{
    public class ComboBoxItem
    {
        public string value;
        public int id;

        public override string ToString()
        {
            return value;
        }
    }

    public class TubesOrder
    {
        public enum DeliveryStatus { Unshipped = 0, Shipped = 1 };
        public enum OrderStatus { New = 0, Completed = 3, Declined = 4 };
        public enum OrderType { Delivery = 0, Dispatch = 1 };
        public string[] TubeDiameter = new string[4] { "60", "73", "73 выс", "89" };

        public int? trackId;

        public int orderType;
        public int districtId;
        public int tubesDiameter;
        public int tubesNumber;

        //Товарно-транспортная накладная
        public int oldTubesNumber;
        public int newTubesNumber;
        public string epc;

        public OrderStatus orderStatus;
        public string dateCreated;
        public DeliveryStatus deliveryStatus = DeliveryStatus.Unshipped;
    }
}