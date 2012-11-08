using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using com.abitech.rfid;
using com.caen.RFIDLibrary;

namespace RFID_UHF_Net
{
    public partial class OrderList : Form
    {
        private void Sync()
        {
            orderLog.Items.Clear();

            var orders = RfidReader.web.SyncronizeOrders();

            //MessageBox.Show(orders.Count.ToString());

            foreach (var order in orders)
            {
                var item = new ListViewItem { Text = order.districtId.ToString() }; //order.trackId.ToString()
                item.SubItems.Add(order.TubeDiameter[order.tubeDiameter - 1]);
                item.SubItems.Add(order.tubesNumber.ToString());

                var statusString = String.Empty;

                if (order.orderStatus == TubesOrder.OrderStatus.New)
                    statusString = "В обработке";
                else if (order.orderStatus == TubesOrder.OrderStatus.Declined)
                    statusString = "Отменена";
                else if (order.orderStatus == TubesOrder.OrderStatus.Completed)
                    statusString = "Обработана";

                item.SubItems.Add(statusString);
                item.Tag = order;
                orderLog.Items.Add(item);

            }
        }

        public OrderList()
        {
            InitializeComponent();
            Sync();
        }

        private void orderLog_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void orderLog_ItemActivated(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var row = orderLog.FocusedItem;
            var order = (TubesOrder)row.Tag;

            var result = MessageBox.Show("Отменить заявку?", "Отмена заявки", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.OK)
            {
                RfidReader.web.UpdateOrderStatus((TubesOrder)orderLog.FocusedItem.Tag, TubesOrder.OrderStatus.Declined);
            }

            Sync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var row = orderLog.FocusedItem;
            var order = (TubesOrder)row.Tag;
            
            var result = MessageBox.Show("Считать данные с метки?", "Транспортная метка", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.OK)
            {
                CAENRFIDTag tag;

                if (!RfidReader.GetSelectedTag(out tag))
                {
                    MessageBox.Show("Метка не обнаружена. Повторите операцию.");
                    return;
                }

                order.epc = System.BitConverter.ToString(tag.GetId());
                RfidReader.web.UpdateOrderStatus((TubesOrder)orderLog.FocusedItem.Tag, TubesOrder.OrderStatus.Completed);
                row.SubItems[3].Text = order.orderStatus.ToString();
            }
        }        
    }       
}