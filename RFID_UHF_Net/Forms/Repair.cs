using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using com.abitech.rfid;
using System.Threading;

namespace RFID_UHF_Net.Forms
{
    public partial class RepairForm : Form
    {
        private Strings strings;

		public RepairForm()
        {
            InitializeComponent();

            strings = Resources.strings;

            this.Text = "";

            notification.Visible = false;

            ogpwLabel.Text = strings["ogwp"];
            cjpLabel.Text = strings["cjp"];
            oilwellNumberLabel.Text = strings["oilwellNumber"];
            tubeDiameterIdLabel.Text = strings["tubeDiameter"];
			createRepairButton.Text = strings["send"];

            tubeDiameterIdComboBox.Items.Add(new ComboBoxItem() { id = 1, value = "60" });
            tubeDiameterIdComboBox.Items.Add(new ComboBoxItem() { id = 2, value = "73" });
            tubeDiameterIdComboBox.Items.Add(new ComboBoxItem() { id = 3, value = "73 выс" });
            tubeDiameterIdComboBox.Items.Add(new ComboBoxItem() { id = 4, value = "89" });            
        }

        private void createRepairButton_Click(object sender, EventArgs e)
        {
            (sender as Button).Enabled = false;
            var isValid = true;
            notification.Text = "";
            notificationLabel.Text = "";
			notification.Visible = false;

            ogpwTextBox.BackColor = Color.White;
            cjpTextBox.BackColor = Color.White;
            oilwellNumberTextBox.BackColor = Color.White;
            tubeDiameterIdComboBox.BackColor = Color.White;

            #region Валидация полей
            if (ogpwTextBox.Text.Length == 0)
            {
                notification.Text += "<li>" + strings["ogpwMissing"] + "</li>";
                ogpwTextBox.BackColor = Color.Red;
                isValid = false;
            }

            else if (Helper.TryParse(ogpwTextBox.Text) == false)
            {
                notification.Text += "<li>" + strings["ogpwWrongFormat"] + "</li>";
                ogpwTextBox.BackColor = Color.Red;
                isValid = false;
            }

            //ГУ
            if (cjpTextBox.Text.Length == 0)
            {
                notification.Text += "<li>" + strings["cjpMissing"] + "</li>";
                cjpTextBox.BackColor = Color.Red;
                isValid = false;
            }

            else if (Helper.TryParse(cjpTextBox.Text) == false)
            {
                notification.Text += "<li>" + strings["cjpWrongFormat"] + "</li>";
                cjpTextBox.BackColor = Color.Red;
                isValid = false;
            }

            //Скважина
            if (oilwellNumberTextBox.Text.Length == 0)
            {
                notification.Text += "<li>" + strings["oilwellNumberMissing"] + "</li>";
                oilwellNumberTextBox.BackColor = Color.Red;
                isValid = false;
            }

            else if (Helper.TryParse(oilwellNumberTextBox.Text) == false)
            {
                notification.Text += "<li>" + strings["oilwellNumberWrongFormat"] + "</li>";
                oilwellNumberTextBox.BackColor = Color.Red;
                isValid = false;
            }

            //Диаметр
            if (tubeDiameterIdComboBox.SelectedItem == null)
            {
                notification.Text += "<li>" + strings["tubeDiameterNotSelected"] + "</li>";
                tubeDiameterIdComboBox.BackColor = Color.Red;
                isValid = false;
            }

            if (isValid == false)
            {
                notification.Text = "<ul>" + notification.Text + "</ul>";
                notification.Visible = true;
                createRepairButton.Enabled = true;
                return;
            }
            #endregion

            notificationLabel.Text = strings["messageSending"];
            notificationLabel.ForeColor = Color.BlueViolet;

            var repair = new Repair
                {
                    ogpw = Int32.Parse(ogpwTextBox.Text),
                    cjp = Int32.Parse(cjpTextBox.Text),
                    oilwellNumber = Int32.Parse(oilwellNumberTextBox.Text),
                    tubeDiameterId = ((ComboBoxItem)tubeDiameterIdComboBox.SelectedItem).id
                };

            var response = RfidReader.web.CreateRepair(repair);

            if (response.error == null)
            {
                notificationLabel.Text = strings["dispatchingStatusOK"];
                notificationLabel.ForeColor = Color.Green;

                #if !DEBUG          
                ogpwTextBox.Text = "";
                cjpTextBox.Text = "";
                oilwellNumberTextBox.Text = "";
                tubeDiameterIdComboBox.SelectedItem = null;
                #endif                                       
            }
            else
            {
                notificationLabel.Text = strings["repeatAttempt"];
                notificationLabel.ForeColor = Color.Red;
             }
            
            createRepairButton.Enabled = true;
        }
    }
}