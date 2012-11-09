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
    public partial class Form_Waybill : Form
    {
        CAENRFIDTag tag;
        TubesOrder order;
        string epc;

        public Form_Waybill(ListViewItem row)
        {
            this.order = (TubesOrder)row.Tag;
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
                epcLabel.Text = "Не удалось считать данные о заявке на метке. Повторите операцию.";
                return;
            }

            epc = BitConverter.ToString(tag.GetId()).Replace("-", "");

            epcLabel.Text = epc;
        }

        private void sendWaybill_Click(object sender, EventArgs e)
        {
            var waybill = new TubesOrder
            {
                trackId = order.trackId,
                oldTubesNumber = Int32.Parse(oldTubesNumberT.Text),
                newTubesNumber = Int32.Parse(newTubesNumberT.Text),
                epc = this.epc,
                dateCreated = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            };

            RfidReader.web.SendWaybill(waybill);
        }
    }
}