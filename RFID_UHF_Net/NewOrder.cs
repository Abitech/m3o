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
    public partial class NewOrder : Form
    {
        public NewOrder()
        {
            InitializeComponent();
        }

        private void CreateNewOrder_Click(object sender, EventArgs e)
        {
            var order = new TubesOrder
            {
            districtId = Int32.Parse(districtIdT.Text),
            tubeDiameter = ((TubeDiameter)tubeDiameterT.SelectedItem).id,
            tubesNumber = Int32.Parse(tubesNumberT.Text),
            orderStatus = TubesOrder.OrderStatus.New,
            dateCreated = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            };

            RfidReader.web.SendOrder(order);
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
    }
}