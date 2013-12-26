using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using com.abitech.rfid;

namespace com.abitech.rfid.Forms
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

			createActButton.Text = strings["send"];

			tubesNumberNewLabel.Text = strings["tubesNumberNew"];
			tubesNumberOldLabel.Text = strings["tubesNumberOld"];
			rodNumberNewLabel.Text = strings["rodNumberNew"];
			rodNumberOldLabel.Text = strings["rodNumberOld"];
			pumpTextLabel.Text = strings["pump"];
			pumpNewRadioButton.Text = strings["newSing"];
			pumpOldRadioButton.Text = strings["oldSing"];

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
			tubesNumberNewTextBox.BackColor = Color.White;
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
			//Кол-во новых НКТ
			if (tubesNumberNewTextBox.Text.Length == 0)
			{
				notification.Text += "<li>" + strings["tubesNumberMissing"] + "</li>";
				tubesNumberNewTextBox.BackColor = Color.Red;
				isValid = false;
			}
			else if (Helper.TryParse(tubesNumberNewTextBox.Text) == false)
			{
				notification.Text += "<li>" + strings["tubesNumberWrongFormat"] + "</li>";
				tubesNumberNewTextBox.BackColor = Color.Red;
				isValid = false;
			}

			//Кол-во б.у. НКТ
			if (tubesNumberOldTextBox.Text.Length == 0)
			{
				notification.Text += "<li>" + strings["tubesNumberMissing"] + "</li>";
				tubesNumberOldTextBox.BackColor = Color.Red;
				isValid = false;
			}
			else if (Helper.TryParse(tubesNumberOldTextBox.Text) == false)
			{
				notification.Text += "<li>" + strings["tubesNumberWrongFormat"] + "</li>";
				tubesNumberOldTextBox.BackColor = Color.Red;
				isValid = false;
			}

			//Кол-во новых штанг
			if (rodNumberNewTextBox.Text.Length == 0)
			{
				notification.Text += "<li>" + strings["rodNumberMissing"] + "</li>";
				rodNumberNewTextBox.BackColor = Color.Red;
				isValid = false;
			}
			else if (Helper.TryParse(rodNumberNewTextBox.Text) == false)
			{
				notification.Text += "<li>" + strings["tubesNumberWrongFormat"] + "</li>";
				rodNumberNewTextBox.BackColor = Color.Red;
				isValid = false;
			}

			//Кол-во старых штанг
			if (rodNumberOldTextBox.Text.Length == 0)
			{
				notification.Text += "<li>" + strings["rodNumberMissing"] + "</li>";
				rodNumberOldTextBox.BackColor = Color.Red;
				isValid = false;
			}
			else if (Helper.TryParse(rodNumberOldTextBox.Text) == false)
			{
				notification.Text += "<li>" + strings["tubesNumberWrongFormat"] + "</li>";
				rodNumberOldTextBox.BackColor = Color.Red;
				isValid = false;
			}

			//Насос
			if (!pumpNewRadioButton.Checked && !pumpOldRadioButton.Checked)
			{
				notification.Text += "<li>" + strings["pumpStatusNotChecked"] + "</li>";
				pumpNewRadioButton.BackColor = Color.Red;
				pumpOldRadioButton.BackColor = Color.Red;
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
				tubesNumberNew = Int32.Parse(tubesNumberNewTextBox.Text),
				tubesNumberOld = Int32.Parse(tubesNumberOldTextBox.Text),
				rodNumberNew = Int32.Parse(rodNumberNewTextBox.Text),
				rodNumberOld = Int32.Parse(rodNumberOldTextBox.Text),
				pumpTypeId = pumpNewRadioButton.Checked ? 1 : 2
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
				tubesNumberNewTextBox.Text = "";
				tubesNumberOldTextBox.Text = "";
				rodNumberNewTextBox.Text = "";
				rodNumberOldTextBox.Text = "";
				pumpNewRadioButton.Checked = false;
				pumpOldRadioButton.Checked = false;
				#endif
			}
			else
			{
				notificationLabel.Text = DateTime.Now.ToString("HH:mm") + " " + strings["repeatAttempt"];
				notificationLabel.ForeColor = Color.Red;
			}

			(sender as Button).Enabled = true;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void tubesNumberNewTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void ActForm_Closing(object sender, CancelEventArgs e)
		{
			MessageBox.Show("ActForm_Closing");
			M3Client.otherFormIsClosed = true;
		}

		private void ActForm_LostFocus(object sender, EventArgs e)
		{

			this.Activate();
		}
	}
}