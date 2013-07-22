using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using com.abitech.rfid;
using com.caen.RFIDLibrary;

namespace RFID_UHF_Net.Forms
{
    public partial class OrderListForm : Form
    {
        private Strings strings;

		public OrderListForm(List<OrderListRecord> orders)
        {
            InitializeComponent();

			strings = i8n.strings;
			this.Text = "";

			SetOrders(orders);

            oilwellNumberColumnHeader.Text = strings["oilwellNumber"];
            tubeDiameterColumnHeader.Text = strings["tubeDiameterAbbr"];
            orderedTubesAmountColumnHeader.Text = strings["orderedTubesAmount"];
            shippedTubesAmountColumnHeader.Text = strings["shippedTubesAmount"];
            cancelOrderButton.Text = strings["cancelOrder"];
            attachWaybillButton.Text = strings["attachWaybill"];

            if (M3Client.configuration.Role != Roles.repairForeman)
            {
                cancelOrderButton.Enabled = false;
            }
        }

		public bool SetOrders(List<OrderListRecord> orders)
		{
			ordersListView.Items.Clear();

			var tubeDiameter = new TubeDiameter();

			foreach (var order in orders)
			{
				var item = new ListViewItem { Text = order.ogpw.ToString() + "—" + order.cjp.ToString() + "—" + order.oilwellNumber.ToString() };
				item.SubItems.Add(order.orderTypeId == 1 ? strings["orderTypeTubesDelivery"] : strings["orderTypeTubesCleaning"]);
				item.SubItems.Add(tubeDiameter[order.tubeDiameterId]);
				item.SubItems.Add(order.tubesNumber.ToString());
				item.SubItems.Add(order.tubesNumberByWaybills.ToString());

				item.Tag = order;
				ordersListView.Items.Add(item);
			}

			return true;
		}

        private void decline_Order_Click(object sender, EventArgs e)
        {
            var row = ordersListView.FocusedItem;

            if (row == null)
            {
                MessageBox.Show(strings["orderNotSelected"]);
                return;
            }

            var order = (OrderListRecord)row.Tag;

            var result = MessageBox.Show(strings["doYouWantToCancelOrder"], "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.OK)
            {
				var response = M3Client.web.CancelOrder(order.id);

				if (response.error == null)
				{
					ordersListView.Items.Remove(row);
				}
				else
				{
					MessageBox.Show(strings["repeatAttempt"]);
				}
            }
        }

        private void attach_Waybill_Click(object sender, EventArgs e)
        {
            var row = ordersListView.FocusedItem;

            if (row == null)
            {
                MessageBox.Show(strings["orderNotSelected"]);
                return;
            }

            var waybillForm = new WaybillForm((OrderListRecord)row.Tag, this);
            waybillForm.Show();
        }        
    }       
}