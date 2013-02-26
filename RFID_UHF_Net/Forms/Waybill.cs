using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using com.caen.RFIDLibrary;
using com.abitech.rfid;

namespace RFID_UHF_Net.Forms
{
    public partial class WaybillForm : Form
    {
        CAENRFIDTag tag;
		OrderListRecord orderRecord;

        string epc;
        string licencePlateNumber;
        int invalidReadingCounter;

        bool isEpcValid = false;

        Strings strings = Resources.strings;

		public WaybillForm(OrderListRecord orderRecord)
        {
            InitializeComponent();

			this.orderRecord = orderRecord;
            
			this.Text = "";

            readTagButton.Text = strings["readTag"];

            tubeStatusLabel.Text = strings["tubeStatus"];
            tubeStatusNew.Text = strings["tubeStatusNew"];
            tubeStatusOld.Text = strings["tubeStatusOld"];
            
            waybillNumberLabel.Text = strings["waybillNumber"];            
            tubesNumberLabel.Text = strings["tubesNumber"];

            sendWaybillButton.Text = strings["send"];

            notificationLabel.Text = "";
            epcLabel.Text = "";
        }

        private void ReadTag_Click(object sender, EventArgs e)
        {
            var data = new byte[6];

            if (invalidReadingCounter >= 2)
            {
                epcLabel.Text = strings["epcReadingStatusTotalFailure"];
                readTagButton.Enabled = false;
                epc = "FAILURE";
                licencePlateNumber = "FAILURE";
                isEpcValid = true;
                return;
            }

            if (!RfidReader.GetSelectedTag(out tag))
            {
                epcLabel.Text = strings["epcReadingStatusMissing"];
                isEpcValid = false;
                invalidReadingCounter++;
                return;
            }

            if (!RfidReader.ReadTag(tag, MemoryBankType.USER, 0, 6, out data))
            {
                epcLabel.Text = strings["epcReadingStatusFailure"];
                isEpcValid = false;
                invalidReadingCounter++;
                return;
            }

            invalidReadingCounter = 0;

            licencePlateNumber = System.Text.Encoding.UTF8.GetString(data, 0, 6);
            epc = RfidReader.ByteArrayToHexString(tag.GetId());

            epcLabel.Text = "\n" + licencePlateNumber + "\n";

            isEpcValid = true;
        }

        private void sendWaybill_Click(object sender, EventArgs e)
        {
            (sender as Button).Enabled = false;
            var isValid = true;
			notification.Text = "";
            notificationLabel.Text = "";

			tubeStatusOld.BackColor = Color.White;
			tubeStatusNew.BackColor = Color.White;
			tubesNumberTextBox.BackColor = Color.White;
			waybillNumberTextBox.BackColor = Color.White;

            #region Валидация полей
            if (!tubeStatusOld.Checked && !tubeStatusNew.Checked)
            {
				notification.Text += "<li>" + strings["tubeStatusNotChecked"] + "</li>";
				tubeStatusOld.BackColor = Color.Red;
				tubeStatusNew.BackColor = Color.Red;
                isValid = false;
            }

            if (waybillNumberTextBox.Text.Length == 0)
            {
				notification.Text += "<li>" + strings["waybillNumberMissing"] + "</li>";
				waybillNumberTextBox.BackColor = Color.Red;
                isValid = false;
            }

            else if (Helper.TryParse(waybillNumberTextBox.Text) == false)
            {
				notification.Text += "<li>" + strings["waybillNumberWrongFormat"] + "</li>";
				waybillNumberTextBox.BackColor = Color.Red;
                isValid = false;
            }

            if (tubesNumberTextBox.Text.Length == 0)
            {
				notification.Text += "<li>" + strings["tubesNumberMissing"] + "</li>";
				tubesNumberTextBox.BackColor = Color.Red;
                isValid = false;
            }

            else if (Helper.TryParse(tubesNumberTextBox.Text) == false)
            {
				notification.Text += "<li>" + strings["tubesNumberWrongFormat"] + "</li>";
				tubesNumberTextBox.BackColor = Color.Red;
                isValid = false;
            }

            if (isEpcValid == false)
            {
				notification.Text += "<li>" + strings["epcNotValid"] + "</li>";
                isValid = false;
            }

            if (isValid == false)
            {
				notification.Text = "<ul>" + notification.Text + "</ul>";
				notification.Visible = true;
				(sender as Button).Enabled = true;
                return;
            }

            #endregion

            var waybill = new Waybill
            {
                id = orderRecord.id,
                number = Int32.Parse(waybillNumberTextBox.Text),
                tubeTypeId = tubeStatusNew.Checked ? 1 : 2,
                tubesNumber = Int32.Parse(tubesNumberTextBox.Text),
                epc = this.epc,
                licencePlateNumber = this.licencePlateNumber
            };

			var response = RfidReader.web.CreateWaybill(waybill);         

            if (response.error == null)
            {
				notificationLabel.Text = strings["dispatchingStatusOK"];
				notificationLabel.ForeColor = Color.Green;
			    isEpcValid = false;
                tubeStatusOld.Checked = false;
                tubeStatusNew.Checked = false;
                waybillNumberTextBox.Text = "";
                tubesNumberTextBox.Text = "";
                epcLabel.Text = "";
                readTagButton.Enabled = true;

                invalidReadingCounter = 0;

            }
            else
            {
				notificationLabel.Text = strings["repeatAttempt"];
				notificationLabel.ForeColor = Color.Red;
            }

            (sender as Button).Enabled = true;
        }
    }
}