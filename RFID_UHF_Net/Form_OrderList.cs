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
        private Strings strings = Resources.strings;

        public bool Sync()
        {
            orderLog.Items.Clear();

            var orders = RfidReader.web.SyncronizeOrders();

            if (orders == null)
            {
                MessageBox.Show(strings["SyncingOrderListFailure"]);
                return false;
            }

            foreach (var order in orders)
            {
                var item = new ListViewItem { Text = order.groupUnit.ToString() + "/" + order.districtId.ToString() };
                item.SubItems.Add(order.orderType == 0 ? strings["OrderTypeTubesDelivery"] : strings["OrderTypeTubesCleaning"]);
                item.SubItems.Add(order.TubeDiameter[order.tubesDiameter]);
                item.SubItems.Add(order.tubesNumber.ToString());
                item.SubItems.Add(order.shippedTubes.ToString());

                item.Tag = order;
                orderLog.Items.Add(item);
            }

            return true;
        }

        public Form_OrderList()
        {
            InitializeComponent();

            DistrictId.Text = strings["DistrictId"];
            TubesDiameter.Text = strings["TubesDiameter"];
            OrderedTubesAmount.Text = strings["OrderedTubesAmount"];
            ShippedTubesAmount.Text = strings["ShippedTubesAmount"];
            CloseOrder.Text = strings["CloseOrder"];
            CancelOrder.Text = strings["CancelOrder"];
            this.Text = "";
            AttachWaybill.Text = strings["AttachWaybill"];
        }

        private void orderLog_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void orderLog_ItemActivated(object sender, EventArgs e)
        {            
        }

        private void decline_Order_Click(object sender, EventArgs e)
        {
            var row = orderLog.FocusedItem;

            if (row == null)
            {
                MessageBox.Show(strings["OrderNotSelected"]);
                return;
            }

            var order = (TubesOrder)row.Tag;

            var result = MessageBox.Show(strings["DoYouWantToCancelOrder"], "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.OK)
            {
                RfidReader.web.UpdateOrderStatus(order, TubesOrder.OrderStatus.Declined);
                Sync();
            }
        }

        private void complete_Order_Click(object sender, EventArgs e)
        {
            var row = orderLog.FocusedItem;

            if (row == null)
            {
                MessageBox.Show(strings["OrderNotSelected"]);
                return;
            }

            var order = (TubesOrder)row.Tag;

            var result = MessageBox.Show(strings["DoYouWantToCloseOrder"], "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.OK)
            {
                RfidReader.web.UpdateOrderStatus(order, TubesOrder.OrderStatus.Completed);
                Sync();
            }
        }

        private void attach_Waybill_Click(object sender, EventArgs e)
        {
            var row = orderLog.FocusedItem;

            if (row == null)
            {
                MessageBox.Show(strings["OrderNotSelected"]);
                return;
            }

            var waybillForm = new Form_Waybill(row);
            waybillForm.Show();
            this.Close();
        }        
    }       
}