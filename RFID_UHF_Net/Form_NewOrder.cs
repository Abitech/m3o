using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using com.abitech.rfid;

namespace RFID_UHF_Net
{
    public partial class Form_NewOrder : Form
    {
        public Form_NewOrder()
        {
            InitializeComponent();

            tubesDiameterT.Items.Add(new ComboBoxItem() { id = 0, value = "60" });
            tubesDiameterT.Items.Add(new ComboBoxItem() { id = 1, value = "73" });
            tubesDiameterT.Items.Add(new ComboBoxItem() { id = 2, value = "73 выс" });
            tubesDiameterT.Items.Add(new ComboBoxItem() { id = 3, value = "89" });

            orderTypeT.Items.Add(new ComboBoxItem() { id = 0, value = "Доставка НКТ" });
            orderTypeT.Items.Add(new ComboBoxItem() { id = 1, value = "Уборка НКТ" });
        }

        private void CreateNewOrder_Click(object sender, EventArgs e)
        {
            OrderDispatchingStatusT.Visible = false;

            var order = new TubesOrder
            {
            orderType = ((ComboBoxItem)tubesDiameterT.SelectedItem).id,
            districtId = Int32.Parse(districtIdT.Text),
            tubesDiameter = ((ComboBoxItem)tubesDiameterT.SelectedItem).id,
            tubesNumber = Int32.Parse(tubesNumberT.Text),
            orderStatus = TubesOrder.OrderStatus.New,
            dateCreated = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            };

            var response = RfidReader.web.SendOrder(order);

            if (response.status == RpcResponse.StatusCode.Ok || response.status == RpcResponse.StatusCode.DuplicatedMessage)
            {
                OrderDispatchingStatusT.Text = "Заявка доставлена";
                OrderDispatchingStatusT.ForeColor = Color.Green;
            }
            else
            {
                OrderDispatchingStatusT.Text = "Заявку доставить не удалось. Повторите отправку.";
                OrderDispatchingStatusT.ForeColor = Color.Red;
            }

            OrderDispatchingStatusT.Visible = true;
        }

        private void label1_ParentChanged(object sender, EventArgs e)
        {

        }

        private void tubesNumberT_TextChanged(object sender, EventArgs e)
        {

        }

        private void tubesLengthT_TextChanged(object sender, EventArgs e)
        {

        }

        private void districtIdT_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_ParentChanged(object sender, EventArgs e)
        {

        }

        private void label3_ParentChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NewOrder_Load(object sender, EventArgs e)
        {

        }

        private void orderTypeT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}