using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using com.caen.RFIDLibrary;
using com.abitech.rfid;

namespace RFID_UHF_Net
{
    public partial class TagsOperation : Form
    {
        CAENRFIDTag tag;
        TubesOrder order;
        
        public TagsOperation()
        {
            InitializeComponent();
        }

        private void TagsOperation_Load(object sender, EventArgs e)
        {

        }

        private void CreateNewOrder_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = new byte[4];

            if (!RfidReader.GetSelectedTag(out tag))
            {
                epcLabel.Text = "Метка не обнаружена. Повторите операцию.";
                return;
            }

            if (!RfidReader.ReadTag(tag, MemoryBankType.USER, 0, 4, out data))
            {
                epcLabel.Text = "Не удалось счиать данные о заявке на метке. Повторите операцию.";
                return;
            }

            var trackId = BitConverter.ToInt32(data, 0);
            var orders = RfidReader.web.SyncronizeOrders();
            var flag = false;
            foreach (var order in orders)
            {
                if (order.trackId == trackId)
                {
                    this.order = order;
                    districtIdT.Text = order.districtId.ToString();
                    tubesLengthT.Text = order.tubeDiameter.ToString();
                    tubesNumberT.Text = order.tubesNumber.ToString();
                    epcLabel.Text = System.BitConverter.ToString(tag.GetId());
                    flag = true;
                    break;
                }
            }

            if (!flag)
            {
                epcLabel.Text = "Незарегистрированный номер заявки.";
            }
        }

        private void acceptShipping_Click(object sender, EventArgs e)
        {
            RfidReader.web.UpdateOrderStatus(order, TubesOrder.OrderStatus.Completed);
        }

        private void declineOrder_Click(object sender, EventArgs e)
        {
            RfidReader.web.UpdateOrderStatus(order, TubesOrder.OrderStatus.Declined);
        }
    }
}