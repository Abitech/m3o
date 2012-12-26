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
        public enum OrderStatus { New = 0, Completed = 3, Declined = 4 };
        public enum OrderType { Delivery = 0, Dispatch = 1 };
        public string[] TubeDiameter = new string[4] { "60", "73", "73 выс", "89" };

        public int? trackId;

        public int orderType;
        public int groupUnit;
        public int districtId;
        public int tubesDiameter;
        public int tubesNumber;

        public int shippedTubes; //Общее количество труб по всем ТТН

        public OrderStatus orderStatus;
        public string dateCreated;
    }

    /// <summary>
    /// ТТН
    /// </summary>
    public class Waybill
    {
        public int? trackId;
        public int waybillNumber;
        public int waybillTubesType;
        public int waybillTubesNumber;
        public string epc;
        public string licencePlateNumber; // Номер транспортного средства
        public string dateCreated;
    }
}