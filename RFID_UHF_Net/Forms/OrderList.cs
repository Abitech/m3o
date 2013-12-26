using System;
using System.Collections.Generic;
using System.Windows.Forms;
using com.abitech.rfid;

namespace com.abitech.rfid.Forms
{
    public partial class OrderListForm : Form
    {
        private Strings strings;

		private Dictionary<int, string> orderTypeDictionary;
		private Dictionary<int, string> rodDiameterDictionary;
		private Dictionary<int, string> pumpDictionary;
		private Dictionary<int, string> tubeDiameterDictionary;

		public OrderListForm(List<OrderListRecord> orders)
        {
            InitializeComponent();

			strings = i8n.strings;
			this.Text = "";

            oilwellNumberColumnHeader.Text = strings["oilwellNumber"];
			orderTypeColumnHeader.Text = strings["orderType"];
            tubeDiameterColumnHeader.Text = strings["tubeDiameterAbbr"];
            orderedTubesAmountColumnHeader.Text = strings["orderedTubesAmount"];
            shippedTubesAmountColumnHeader.Text = strings["shippedTubesAmount"];
            cancelOrderButton.Text = strings["cancelOrder"];
            attachWaybillButton.Text = strings["attachWaybill"];

			orderTypeDictionary = new Dictionary<int, string>
                {
                    { 1, strings["orderTypeTubesDelivery"] },
                    { 2, strings["orderTypeTubesCleaning"] },
                    { 3, strings["orderTypeRodDelivery"] },
                    { 4, strings["orderTypeRodCleaning"] },
                    { 5, strings["orderTypePumpDelivery"] },
					{ 6, strings["orderTypePumpCleaning"] },					 
                };

			rodDiameterDictionary = new Dictionary<int, string>
				{
                    { 1, "22" },
                    { 2, "19" },
                    { 3, "22 со скребком" },
                    { 4, "19 со скребком" },
					{ 1000, strings["otherOption"] },
				};

 			pumpDictionary = new Dictionary<int, string>
				{
                    { 1, "44" },
                    { 2, "57" },
                    { 3, "70" },
					{ 1000, strings["otherOption"] },
				};

			tubeDiameterDictionary = new Dictionary<int, string>
                {
                    { 1, "60" },
                    { 2, "73" },
                    { 3, "73 выс" },
                    { 4, "89" },
					{ 1000, strings["otherOption"] },
                };

            if (M3Client.configuration.Role != Roles.repairForeman)
            {
                cancelOrderButton.Enabled = false;
            }

			SetOrders(orders);
        }

		public bool SetOrders(List<OrderListRecord> orders)
		{
			ordersListView.Items.Clear();			

			foreach (var order in orders)
			{
				var item = new ListViewItem { Text = order.ogpw.ToString() + "—" + order.cjp.ToString() + "—" + order.oilwellNumber.ToString() };
				item.SubItems.Add(orderTypeDictionary[order.orderTypeId]);

				if (order.orderTypeId == 1 || order.orderTypeId == 2)
				{
					item.SubItems.Add(tubeDiameterDictionary[order.tubeDiameterId]);
				}
				else if (order.orderTypeId == 3 || order.orderTypeId == 4)
				{
					item.SubItems.Add(rodDiameterDictionary[order.tubeDiameterId]);
				}
				else if (order.orderTypeId == 5 || order.orderTypeId == 6)
				{
					item.SubItems.Add(pumpDictionary[order.tubeDiameterId]);
				}

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