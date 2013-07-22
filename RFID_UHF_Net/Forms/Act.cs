using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using com.abitech.rfid;

namespace RFID_UHF_Net.Forms
{
	public partial class ActForm : Form
	{
		private Strings strings;

		public ActForm()
		{
			InitializeComponent();

			this.strings = i8n.strings;
			this.Text = "";

			actTypeIdComboBox.Items.Add(new ComboBoxItem() { id = 1, value = strings["actTypeExtraction"] });
			actTypeIdComboBox.Items.Add(new ComboBoxItem() { id = 2, value = strings["actTypeDescent"] });

			tubesNumberLabel.Text = strings["tubesNumber"];
			createActButton.Text = strings["send"];

			SetRepairs();
		}

		private void SetRepairs()
		{
			var tubeDiameter = new TubeDiameter();
			var repairs = M3Client.repairs.result;
			repairsComboBox.Items.Clear();

			if (repairs == null)
			{
				MessageBox.Show(i8n.strings["noRepairsAvailable"]);
				return;
			}

			foreach (var repair in repairs)
			{
				var description = strings["ogwp"] + " " + repair.ogpw + " " + strings["cjp"] + " " + repair.cjp + " " + strings["oilwellNumberAbbr"] + " " + repair.oilwellNumber + " ø" + tubeDiameter[repair.tubeDiameterId];
				repairsComboBox.Items.Add(new ComboBoxItem() { id = repair.id, value = description });
			}
		}

		private void createActButton_Click(object sender, EventArgs e)
		{
			(sender as Button).Enabled = false;
			var isValid = true;
			notification.Text = "<font face='Arial'>";
			notificationLabel.Text = "";

			actTypeIdComboBox.BackColor = Color.White;
			tubesNumberTextBox.BackColor = Color.White;
			repairsComboBox.BackColor = Color.White;

			#region Валидация полей
			//Выбор ремонта
			if (repairsComboBox.SelectedItem == null)
			{
				notification.Text += "<li>" + strings["repairNotSelected"] + "</li>";
				repairsComboBox.BackColor = Color.Red;
				isValid = false;
			}
			// Тип акта
			if (actTypeIdComboBox.SelectedItem == null)
			{
				notification.Text += "<li>" + strings["actTypeNotSelected"] + "</li>";
				actTypeIdComboBox.BackColor = Color.Red;
				isValid = false;
			}
			//Кол-во НКТ
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

			var act = new Act
			{
				id = ((ComboBoxItem)repairsComboBox.SelectedItem).id,
				actTypeId = ((ComboBoxItem)actTypeIdComboBox.SelectedItem).id,
				tubesNumber = Int32.Parse(tubesNumberTextBox.Text)
			};

			var response = M3Client.web.CreateAct(act);

			if (response.error == null)
			{
				notificationLabel.Text = DateTime.Now.ToString("HH:mm") + " " + strings["dispatchingStatusOK"];
				notificationLabel.ForeColor = Color.Green;
				M3Client.repairs = null;
				SetRepairs();

				#if !DEBUG
                repairsComboBox.SelectedItem = null;
                actTypeIdComboBox.SelectedItem = null;
				tubesNumberTextBox.Text = "";
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