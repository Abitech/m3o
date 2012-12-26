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
        string licencePlateNumber;
        int invalidReadingCounter;

        bool isEpcValid = false;

        Strings strings = Resources.strings;

        public Form_Waybill(ListViewItem row)
        {
            this.order = (TubesOrder)row.Tag;

            InitializeComponent();

            this.Text = "";

            ReadTag.Text = strings["ReadTag"];

            TubeStatusT.Text = strings["TubeStatus"];
            TubeStatusNew.Text = strings["TubeStatusNew"];
            TubeStatusOld.Text = strings["TubeStatusOld"];
            
            WaybillNumberT.Text = strings["WaybillNumber"];            
            TubesNumberT.Text = strings["TubesNumber"];

            SendWaybill.Text = strings["SendWaybill"];

            WaybillDispatchingStatus.Text = "";
            EpcLabel.Text = "";
        }

        private void ReadTag_Click(object sender, EventArgs e)
        {
            var data = new byte[6];

            if (invalidReadingCounter >= 2)
            {
                EpcLabel.Text = strings["EpcReadingStatusTotalFailure"];
                ReadTag.Enabled = false;
                epc = "FAILURE";
                licencePlateNumber = "FAILURE";
                isEpcValid = true;
                return;
            }

            if (!RfidReader.GetSelectedTag(out tag))
            {
                EpcLabel.Text = strings["EpcReadingStatusMissing"];
                isEpcValid = false;
                invalidReadingCounter++;
                return;
            }

            if (!RfidReader.ReadTag(tag, MemoryBankType.USER, 0, 6, out data))
            {
                EpcLabel.Text = strings["EpcReadingStatusFailure"];
                isEpcValid = false;
                invalidReadingCounter++;
                return;
            }

            invalidReadingCounter = 0;

            licencePlateNumber = System.Text.Encoding.UTF8.GetString(data, 0, 6);
            epc = RfidReader.ByteArrayToHexString(tag.GetId());

            EpcLabel.Text = "\n" + licencePlateNumber + "\n";

            isEpcValid = true;
        }

        private void sendWaybill_Click(object sender, EventArgs e)
        {
            var isValid = true;
            WaybillDispatchingStatus.Text = String.Empty;

            #region Проверка формы
            if (!TubeStatusOld.Checked && !TubeStatusNew.Checked)
            {
                WaybillDispatchingStatus.Text += strings["TubeStatusNotChecked"] + "\n";
                isValid = false;
            }

            if (WaybillNumber.Text.Length == 0)
            {
                WaybillDispatchingStatus.Text += strings["WaybillNumberMissing"] + "\n";
                isValid = false;
            }

            else if (Helper.TryParse(WaybillNumber.Text) == false)
            {
                WaybillDispatchingStatus.Text += strings["WaybillNumberWrongFormat"] + "\n";
                isValid = false;
            }

            if (TubesNumber.Text.Length == 0)
            {
                WaybillDispatchingStatus.Text += strings["TubesNumberMissing"] + "\n";
                isValid = false;
            }

            else if (Helper.TryParse(TubesNumber.Text) == false)
            {
                WaybillDispatchingStatus.Text += strings["TubesNumberWrongFormat"] + "\n";
                isValid = false;
            }

            if (isEpcValid == false)
            {
                WaybillDispatchingStatus.Text += strings["EpcNotValid"] + "\n";
                isValid = false;
            }

            if (isValid == false)
            {
                WaybillDispatchingStatus.Text = strings["WaybillNotValid"] + " " + WaybillDispatchingStatus.Text;
                WaybillDispatchingStatus.ForeColor = Color.Red;
                return;
            }

            #endregion

            var waybill = new Waybill
            {
                trackId = order.trackId,
                waybillNumber = Int32.Parse(WaybillNumber.Text),
                waybillTubesType = TubeStatusNew.Checked ? 1 : 0,
                waybillTubesNumber = Int32.Parse(TubesNumber.Text),
                epc = this.epc,
                licencePlateNumber = this.licencePlateNumber,
                dateCreated = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            };

            var response = RfidReader.web.SendWaybill(waybill);            

            if (response.status == RpcResponse.StatusCode.Ok || response.status == RpcResponse.StatusCode.DuplicatedMessage)
            {
                WaybillDispatchingStatus.Text = strings["WaybillDispatchingStatusOK"];
                WaybillDispatchingStatus.ForeColor = Color.Green;

                TubeStatusOld.Checked = false;
                TubeStatusNew.Checked = false;
                WaybillNumber.Text = "";
                TubesNumber.Text = "";
                EpcLabel.Text = "";
                ReadTag.Enabled = true;

                invalidReadingCounter = 0;

            }
            else
            {
                WaybillDispatchingStatus.Text = strings["WaybillDispatchingStatusFailure"];
                WaybillDispatchingStatus.ForeColor = Color.Red;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void epcLabel_ParentChanged(object sender, EventArgs e)
        {

        }

        private void wayBillNumberT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}