using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace com.abitech.rfid
{
    /// <summary>
    /// Класс записи и чтения с sqlite-базы
    /// </summary>
    public class RfidTagsCollector
    {
        private readonly SQLiteConnection connection;

        public RfidTagsCollector(string connectionString)
        {
            connectionString = "data source=" + connectionString;
            connection = new SQLiteConnection(connectionString);
            connection.Open();
            CreateTables();
        }

        /// <summary>
        /// Иниализация новой базы
        /// </summary>
        void CreateTables()
        {
            using (var cmd = new SQLiteCommand(connection))
            {
                cmd.CommandText = @"CREATE TABLE IF NOT EXISTS orders (
                    [orderId] integer PRIMARY KEY AUTOINCREMENT NOT NULL,
                    [trackId] integer DEFAULT NULL,
                    [districtId] integer NOT NULL,
                    [tubeDiameter] integer NOT NULL,
                    [tubesNumber] integer NOT NULL,
                    [orderStatus] integer NOT NULL,
                    [dateCreated] char(23) NOT NULL,
                    [isDelivered] integer NOT NULL
                    );";
                cmd.ExecuteNonQuery();
            }
        }

        public void CreateOrder(TubesOrder order)
        {
            var transaction = connection.BeginTransaction();

            //Register a new session
            var cmd = new SQLiteCommand(@"
            INSERT INTO orders       ( districtId,  tubeDiameter,  tubesNumber,  orderStatus,  dateCreated,  isDelivered)
                               VALUES(@districtId, @tubeDiameter, @tubesNumber, @orderStatus, @dateCreated, @isDelivered)", connection);
            cmd.Parameters.AddWithValue("@districtId", order.districtId);
            cmd.Parameters.AddWithValue("@tubeDiameter", order.tubeDiameter);
            cmd.Parameters.AddWithValue("@tubesNumber", order.tubesNumber);
            cmd.Parameters.AddWithValue("@orderStatus", (int)order.orderStatus);
            cmd.Parameters.AddWithValue("@dateCreated", order.dateCreated);
            cmd.Parameters.AddWithValue("@isDelivered", order.deliveryStatus);
            cmd.ExecuteNonQuery();

            transaction.Commit();
        }

        /// <summary>
        /// Возвращает список неотправленных на сервер сессий чтения
        /// </summary>
        public List<TubesOrder> GetUnshippedOrders()
        {
            var orders = new List<TubesOrder>();
            var sessionCmd = new SQLiteCommand(@"SELECT * from orders where isDelivered <> " +
                (int)TubesOrder.DeliveryStatus.Shipped, connection);

            using (var reader = sessionCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var order = new TubesOrder
                    {
                        orderId = reader.GetInt32(0),
                        trackId = reader.IsDBNull(1) ? null : (int?)reader.GetInt32(1), 
                        districtId = reader.GetInt32(2),
                        tubeDiameter = reader.GetInt32(3),
                        tubesNumber = reader.GetInt32(4),
                        orderStatus = (TubesOrder.OrderStatus)reader.GetInt32(5),
                        dateCreated = reader.GetString(6),
                        deliveryStatus = (TubesOrder.DeliveryStatus)reader.GetInt32(7)
                    };

                    orders.Add(order); 
                }
            }
            return orders;
        }
        
        /// <summary>
        /// Закрытие соединения
        /// </summary>
        /// <remarks>По каким-то причинам в Win CE закрытие не работает в деструкторе,
        /// поэтому был вынес его в этот метод</remarks>
        public void Close()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Dispose();
            }
        }

        public void UpdateOrders(List<TubesOrder> orders)
        {
            foreach (var order in orders)
            {
                var cmd = new SQLiteCommand("UPDATE orders SET isDelivered = @delivery_status, trackId = @trackId where orderId = @orderId", connection);
                cmd.Parameters.AddWithValue("@orderId", (int)order.orderId);
                cmd.Parameters.AddWithValue("@trackId", order.trackId);
                cmd.Parameters.AddWithValue("@delivery_status", order.deliveryStatus);
                cmd.ExecuteNonQuery();
            }
        }
    }
}