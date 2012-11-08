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
    public partial class Form_OrderList : Form
    {
        private void Sync()
        {
            orderLog.Items.Clear();

            var orders = RfidReader.web.SyncronizeOrders();

            foreach (var order in orders)
            {
                var item = new ListViewItem { Text = order.districtId.ToString() }; //order.trackId.ToString()
                item.SubItems.Add(order.TubeDiameter[order.tubesDiameter]);
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

        public Form_OrderList()
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

            if (row == null) return;

            var order = (TubesOrder)row.Tag;

            var result = MessageBox.Show("Отменить заявку?", "Отмена заявки", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.OK)
            {
                RfidReader.web.UpdateOrderStatus((TubesOrder)orderLog.FocusedItem.Tag, TubesOrder.OrderStatus.Declined);
                row.SubItems[3].Text = order.orderStatus.ToString();
            }

            Sync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var row = orderLog.FocusedItem;

            if (row == null) return;

            var order = (TubesOrder)row.Tag;
            
            var result = MessageBox.Show("Закрыть заявку?", "Закрытие заявки", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.OK)
            {
                RfidReader.web.UpdateOrderStatus((TubesOrder)orderLog.FocusedItem.Tag, TubesOrder.OrderStatus.Completed);
                row.SubItems[3].Text = order.orderStatus.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var row = orderLog.FocusedItem;
            if (row == null) return;

            var waybillForm = new Form_Waybill(row);
            waybillForm.Show();
        }        
    }       
}