using System;
using System.Drawing;
using System.Windows.Forms;
using com.abitech.rfid;
using System.Collections.Generic;
using CodeBetter.Json;

namespace RFID_UHF_Net.Forms
{
    public partial class OrderForm : Form
    {
        private Strings strings;
        private List<Repair> repairs;

        public OrderForm(List<Repair> repairs)
        {
            InitializeComponent();

            strings = i8n.strings;
            this.Text = "";

            this.repairs = repairs;

			SetRepairs();

            orderReasonIdLabel.Text = strings["orderReason"];
            orderTypeIdLabel.Text = strings["orderType"];

            tubesNumberLabel.Text = strings["tubesNumber"];
            createNewOrderButton.Text = strings["send"];
            approachIdLabel.Text = strings["districtApproach"];
            dateExpectedLabel.Text = strings["dateExpected"];

            orderTypeIdComboBox.Items.Add(new ComboBoxItem() { id = 1, value = strings["orderTypeTubesDelivery"] });
            orderTypeIdComboBox.Items.Add(new ComboBoxItem() { id = 2, value = strings["orderTypeTubesCleaning"] });

            orderReasonIdComboBox.Items.Add(new ComboBoxItem() { id = 1, value = strings["orderReasonReplacement"] });
            orderReasonIdComboBox.Items.Add(new ComboBoxItem() { id = 2, value = strings["orderReasonBath"] });
            orderReasonIdComboBox.Items.Add(new ComboBoxItem() { id = 3, value = strings["orderReasonAssessment"] });

            approachIdComboBox.Items.Add(new ComboBoxItem() { id = 1, value = strings["districtApproachDriverInTheFront"] });
            approachIdComboBox.Items.Add(new ComboBoxItem() { id = 2, value = strings["districtApproachDriverInTheRear"] });
            approachIdComboBox.Items.Add(new ComboBoxItem() { id = 3, value = strings["districtApproachPassengerInTheFront"] });
            approachIdComboBox.Items.Add(new ComboBoxItem() { id = 4, value = strings["districtApproachPassengerInTheRear"] });

            dateExpectedDateTimePicker.Value = DateTime.Now;
            dateExpectedDateTimePicker.ShowUpDown = true;
            dateExpectedDateTimePicker.CustomFormat = "H:mm dd-MM-yy";
            dateExpectedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        }

        private void SetRepairs()
        {
			var tubeDiameter = new TubeDiameter();

            foreach (var repair in repairs)
            {
				var description = strings["ogwp"] + " " + repair.ogpw + " " + strings["cjp"] + " " + repair.cjp + " " + strings["oilwellNumberAbbr"] + " " + repair.oilwellNumber + " ø" + tubeDiameter[repair.tubeDiameterId];
				repairsComboBox.Items.Add(new ComboBoxItem() { id = repair.id, value = description });
            }
        }

        private void CreateNewOrder_Click(object sender, EventArgs e)
        {
            (sender as Button).Enabled = false;
            var isValid = true;
            notification.Text = "<font face='Arial'>";
            notificationLabel.Text = "";
			notification.Visible = false;

            repairsComboBox.BackColor = Color.White;
            orderTypeIdComboBox.BackColor = Color.White;
            orderReasonIdComboBox.BackColor = Color.White;
            tubesNumberTextBox.BackColor = Color.White;
			approachIdLabel.BackColor = Color.White;

            #region Валидация полей
            //Выбор ремонта
            if (repairsComboBox.SelectedItem == null)
            {
                notification.Text += "<li>" + strings["repairNotSelected"] + "</li>";
                repairsComboBox.BackColor = Color.Red;
                isValid = false;
            }
            //Тип заявки
            if (orderTypeIdComboBox.SelectedItem == null)
            {
                notification.Text += "<li>" + strings["orderTypeNotSelected"] + "</li>";
                orderTypeIdComboBox.BackColor = Color.Red;
                isValid = false;
            }

            //Основание для заявки
            if (orderReasonIdComboBox.SelectedItem == null)
            {
                notification.Text += "<li>" + strings["orderReasonNotSelected"] + "</li>";
                orderReasonIdComboBox.BackColor = Color.Red;
                isValid = false;
            }

            //Кол-во
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

			if (approachIdComboBox.SelectedItem == null)
			{
				notification.Text += "<li>" + strings["districtApproachNotSelected"] + "</li>";
				approachIdComboBox.BackColor = Color.Red;
                isValid = false;			 
			}

            if (isValid == false)
            {
                notification.Text = "<ul>" + notification.Text + "</ul></font>";
                notification.Visible = true;
				(sender as Button).Enabled = true;
                return;
            }
            #endregion

			notificationLabel.Text = strings["messageSending"];
			notificationLabel.ForeColor = Color.BlueViolet;
			notificationLabel.Refresh();

            var order = new Order
            {
                id = ((ComboBoxItem)repairsComboBox.SelectedItem).id,
                orderTypeId = ((ComboBoxItem)orderTypeIdComboBox.SelectedItem).id,
                orderReasonId = ((ComboBoxItem)orderReasonIdComboBox.SelectedItem).id,
                tubesNumber = Int32.Parse(tubesNumberTextBox.Text),
                approachId = ((ComboBoxItem)approachIdComboBox.SelectedItem).id,
                dateExpected = dateExpectedDateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss")
            };

            var response = M3Client.web.CreateOrder(order);

            if (response.error == null)
            {
                notificationLabel.Text = DateTime.Now.ToString("HH:mm") + " " + strings["dispatchingStatusOK"];
                notificationLabel.ForeColor = Color.Green;

                #if !DEBUG
                repairsComboBox.SelectedItem = null;
                orderTypeIdComboBox.SelectedItem = null;
                orderReasonIdComboBox.SelectedItem = null;
				tubesNumberTextBox.Text = "";
                approachIdComboBox.SelectedItem = null;
                #endif
            }
            else
            {
				notificationLabel.Text = DateTime.Now.ToString("HH:mm") + " " + strings["repeatAttempt"];
                notificationLabel.ForeColor = Color.Red;
            }

			(sender as Button).Enabled = true;
        }
    }
}