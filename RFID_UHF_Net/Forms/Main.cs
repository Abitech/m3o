using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using com.abitech.rfid;
using Microsoft.WindowsCE.Forms;
using com.caen.RFIDLibrary;

namespace RFID_UHF_Net.Forms
{

	public partial class MainForm : Form
	{
		volatile bool shouldStop = true;
		bool isTeamNumberUpdated = false;
		Thread deviceActivityThread;
		Thread updatingTeamNumberThread;
		DeviceKeyRequest deviceKeyRequest = new DeviceKeyRequest();
		M3ClientInitializationStatus status;

		public MainForm()
		{
			InitializeComponent();
			EnableControls(false);

			#if !DEBUG
			testWaybillForm.Visible = false;
			testWaybillForm.Enabled = false;
			#endif

			status = M3Client.Init();

			if (status == M3ClientInitializationStatus.ClientConfigurationMissing)
			{
				titleLabel.Text = i8n.strings["technicalAssistanceNeeded"];
				// notificationLabel.Text = i8n.strings["clientConfigurationMissing"];
				return;
			}
			else if (status == M3ClientInitializationStatus.ReaderNotReady)
			{
				titleLabel.Text = i8n.strings["readerNotReady"];
				return;
			}
			else if (status == M3ClientInitializationStatus.Ok)
			{
				titleLabel.Text = i8n.strings["waitForConnection"];
			}

			//Пока не получим номер НГДУ, бригады и должность (бригадир, мастер базы),
			//контролы разблокированы не будут
			updatingTeamNumberThread = new Thread(new ThreadStart(() => { GetDeviceDescription(); }));
			updatingTeamNumberThread.Start();

			//Сообщаем серверу каждые N секунд, что устройство в сети
			//и имеет такие-то координаты
			deviceActivityThread = new Thread(new ThreadStart(() => { SendNetworkStatus(); }));

			#if !DEBUG
			deviceActivityThread.IsBackground = true;
			deviceActivityThread.Start();
			#endif

			// M3Client.InitGps();

			if (M3Client.configuration.Language == "ru")
			{
				languageSelectorRuRadioButton.Checked = true;
			}
			else if (M3Client.configuration.Language == "kz")
			{
				languageSelectorKzRadioButton.Checked = true;
			}
		}

		//Манипуляция с контролами
		public void EnableControls(bool state)
		{
			newRepairButton.Enabled = state;
			newOrderButton.Enabled = state;
			orderListButton.Enabled = state;
			newActButton.Enabled = state;
		}

		public void i8nalize()
		{
			newRepairButton.Text = i8n.strings["newRepair"];
			newOrderButton.Text = i8n.strings["newOrder"];
			orderListButton.Text = i8n.strings["orderList"];
			newActButton.Text = i8n.strings["newAct"];
		}

		private void ReInit(string language)
		{
			i8n.strings.SetLanguage(language);

			newRepairButton.Text = i8n.strings["newRepair"];
			newOrderButton.Text = i8n.strings["newOrder"];
			orderListButton.Text = i8n.strings["orderList"];
			newActButton.Text = i8n.strings["newAct"];

			M3Client.configuration.Language = language;
			M3Client.configuration.Save();
		}

		private void UpdateTitleLabel()
		{
			if (M3Client.configuration.Role == Roles.repairForeman)
			{
				titleLabel.Text = i8n.strings["ogpd"]
				  + M3Client.configuration.Location
				  + " " + i8n.strings["team"]
				  + M3Client.configuration.Team;
			}
			else if (M3Client.configuration.Role == Roles.tubeMaster)
			{
				titleLabel.Text = M3Client.configuration.Location + " " + M3Client.configuration.Team;
				newRepairButton.Enabled = false;
				newOrderButton.Enabled = false;
				newActButton.Enabled = false;
			}
		}

		//Потоки для мониторинга
		public void SendNetworkStatus()
		{
			var time = DateTime.Now.AddSeconds(5);

			while (shouldStop)
			{
				if (time.CompareTo(DateTime.Now) < 0)
				{
					var notification = DateTime.Now.ToString("HH:mm:ss") + "\n";

					if (M3Client.gpsInfo.nPosFix > 0)
					{
						notification += "GPS in On\n";
					}

					notification += "Спутников: " + M3Client.gpsInfo.nSatInUse + "/" + M3Client.gpsInfo.nSatNum + "\nКоординаты: " + M3Client.gpsInfo.dLatitude + " " + M3Client.gpsInfo.dLongitude + "\n";

					var onlineStatusResponse = M3Client.web.UpdateOnlineStatus(new DeviceActivity());

					if (onlineStatusResponse.error == null)
					{
						notification += "Данные отправлены на сервер\n";
					}

					// this.Invoke((System.Threading.ThreadStart)delegate() { notificationLabel.Text = notification; });

					time = DateTime.Now.AddSeconds(5);
				}
			}
		}

		public void GetDeviceDescription()
		{
			var time = DateTime.Now.AddSeconds(20);
			RpcResponse<DeviceDescription> response;

			while (shouldStop)
			{
				if (time.CompareTo(DateTime.Now) > 0)
				{
					continue;
				}

				time = DateTime.Now.AddSeconds(5);
				response = M3Client.web.GetDeviceDescription();

				if (response.error != null)
				{
					continue;
				}

				//Если запуск впервый раз
				if (isTeamNumberUpdated == false)
				{
					this.Invoke((System.Threading.ThreadStart)delegate() { EnableControls(true); });
				}

				isTeamNumberUpdated = true;

				M3Client.configuration.Update(response.result);
				this.Invoke((System.Threading.ThreadStart)delegate(){ UpdateTitleLabel(); });
			}
		}

		//События

		private void MainFormClosing(object sender, CancelEventArgs e)
		{
			shouldStop = false;

			if (M3Client.reader != null)
			{
				M3Client.reader.Disconnect();
			}

			if (deviceActivityThread != null && deviceActivityThread.Join(5000) == false)
			{
				deviceActivityThread.Abort();
			}

			if (updatingTeamNumberThread != null && updatingTeamNumberThread.Join(5000) == false)
			{
				updatingTeamNumberThread.Abort();
			}

			if (M3Client.gps != null && M3Client.gps.Close())
			{
				MessageBox.Show("Успешное закрытие GPS");
			}

			Application.Exit();
		}

		private void RepairForm_Click(object sender, EventArgs e)
		{
			var repairForm = new RepairForm();
			repairForm.Show();
		}

		private void OrderForm_Click(object sender, EventArgs e)
		{
			(sender as Button).Enabled = false;
			var response = M3Client.repairs;
			var flag = true;
			if (response.error != null)
			{
				MessageBox.Show(i8n.strings["repeatAttempt"]);
				flag = false;
			}
			else if (response.result == null || response.result.Count == 0)
			{
				MessageBox.Show(i8n.strings["noRepairsAvailable"]);
				flag = false;
			}

			(sender as Button).Enabled = true;

			if (flag == true)
			{
				var form = new OrderForm(response.result);
				form.ShowDialog();
			}
		}

		private void OrdersForm_Click(object sender, EventArgs e)
		{
			(sender as Button).Enabled = false;
			var response = M3Client.web.GetOrders();
			var flag = true;

			if (response.error != null)
			{
				MessageBox.Show(i8n.strings["repeatAttempt"]);
				flag = false;
			}
			else if (response.result == null || response.result.Count == 0)
			{
				MessageBox.Show(i8n.strings["noOrdersAvailable"]);
				flag = false;
			}

			(sender as Button).Enabled = true;

			if (flag == true)
			{
				var form = new OrderListForm(response.result);
				form.ShowDialog();
			}
		}

		private void ActFormButton_Click(object sender, EventArgs e)
		{
			(sender as Button).Enabled = false;
			var response = M3Client.repairs;
			var flag = true;

			if (response.error != null)
			{
				MessageBox.Show(i8n.strings["repeatAttempt"]);
				flag = false;
			}
			else if (response.result == null || response.result.Count == 0)
			{
				MessageBox.Show(i8n.strings["noRepairsAvailable"]);
				flag = false;
			}

			(sender as Button).Enabled = true;

			if (flag == true)
			{
				var form = new ActForm();
				form.ShowDialog();
			}
		}

		private void TestWaybillForm_Click(object sender, EventArgs e)
		{
			var waybillForm = new WaybillForm(new OrderListRecord(), null);

			waybillForm.Show();
		}

		private void LanguageSelectorKz_CheckedChanged(object sender, EventArgs e)
		{
			ReInit("kz");
		}

		private void LanguageSelectorRu_CheckedChanged(object sender, EventArgs e)
		{
			ReInit("ru");
		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			var tab = (TabControl)sender;
			if (tab.SelectedIndex == 0)
			{
				deviceKeyRequest.masterKey = string.Empty;
				deviceKeyRequest.id = 0;
				maintenanceLabel.Text = "";
				requestNewDeviceKeyResultButton.Enabled = false;
				getDeviceListButton.Enabled = false;
				serverLocationUrlTextBox.Text = "";
				deviceListComboBox = new ComboBox();
			}
			else if (tab.SelectedIndex == 1)
			{
				if (status == M3ClientInitializationStatus.Ok)
				{
					requestDeviceDescriptionButton.Enabled = true;
				}
				else
				{
					requestDeviceDescriptionButton.Enabled = false;
				}
			}
		}

		private void ReadMasterCardResultButton_Click(object sender, EventArgs e)
		{
			(sender as Button).Enabled = false;
			CAENRFIDTag tag;

			if (M3Client.GetSelectedTag(out tag))
			{
				maintenanceLabel.Text = i8n.strings["masterCardReadingStatusSuccess"];
				getDeviceListButton.Enabled = true;
				deviceKeyRequest.masterKey = M3Client.ByteArrayToHexString(tag.GetId());
				if (serverLocationUrlTextBox.Text.Length == 0)
				{
					serverLocationUrlTextBox.Text = "http://217.196.24.86:81/";
				}
			}
			else
			{
				maintenanceLabel.Text = i8n.strings["masterCardReadingStatusFailure"];
			}
			(sender as Button).Enabled = true;
		}

		private void requestNewDeviceKeyResultButton_Click(object sender, EventArgs e)
		{
			(sender as Button).Enabled = false;
			if (serverLocationUrlTextBox.Text.Length == 0)
			{
				maintenanceLabel.Text = i8n.strings["serverLocationUrlMissing"];
				return;
			}

			deviceKeyRequest.id = ((ComboBoxItem)deviceListComboBox.SelectedItem).id;
			M3Client.configuration.Server = serverLocationUrlTextBox.Text;

			var response = M3Client.web.GetNewDeviceKey(deviceKeyRequest);

			if (response.error != null)
			{
				maintenanceLabel.Text = i8n.strings["getNewDeviceKeyFailure"] + " Код ошибки: " + response.error;
			}
			else
			{
				maintenanceLabel.Text = i8n.strings["getNewDeviceKeySuccess"];
				M3Client.configuration.DeviceKey = response.result.deviceKey;
				M3Client.configuration.Save();
				requestNewDeviceKeyResultButton.Enabled = false;
				requestDeviceDescriptionButton.Enabled = true;
			}
			(sender as Button).Enabled = true;
		}

		private void getDeviceListButton_Click(object sender, EventArgs e)
		{
			(sender as Button).Enabled = false;

			if (serverLocationUrlTextBox.Text.Length == 0)
			{
				maintenanceLabel.Text = i8n.strings["serverLocationUrlMissing"];
				(sender as Button).Enabled = true;
				return;
			}

			M3Client.configuration.Server = serverLocationUrlTextBox.Text;
			var response = M3Client.web.GetDeviceList(deviceKeyRequest);

			if (response.error != null)
			{
				maintenanceLabel.Text = i8n.strings["getDeviceListFailure"] + " Код ошибки: " + response.error;
				(sender as Button).Enabled = true;
				return;
			}
			else
			{
				maintenanceLabel.Text = "";
			}

			deviceListComboBox.Items.Clear();

			foreach (var device in response.result)
			{
				var description = "#" + device.id + " " + i8n.strings["ogpd"] + " " + device.location + " " + i8n.strings["team"] + " " + device.team;
				deviceListComboBox.Items.Add(new ComboBoxItem() { id = Int32.Parse(device.id), value = description });
			}
			requestNewDeviceKeyResultButton.Enabled = true;
		}

		private void requestDeviceDescriptionButton_Click(object sender, EventArgs e)
		{
			(sender as Button).Enabled = false;
			var response = M3Client.web.GetDeviceDescription();
			if (response.error == null)
			{
				maintenanceLabel.Text = i8n.strings["getDeviceDescriptionSuccess"];
				M3Client.configuration.Update(response.result);
				UpdateTitleLabel();
				EnableControls(true);
			}
			else
			{
				maintenanceLabel.Text = i8n.strings["repeatAttempt"] + " Код ошибки: " + response.error;
			}
			(sender as Button).Enabled = true;
		}

		private void eraseConfigurationButton_Click(object sender, EventArgs e)
		{
			(sender as Button).Enabled = false;
			M3Client.configuration.Server = "";
			M3Client.configuration.DeviceKey = "";
			M3Client.configuration.Location = "";
			M3Client.configuration.Team = "";
			M3Client.configuration.Role = Roles.tubeMaster;
			M3Client.configuration.Save();
			(sender as Button).Enabled = true;
		}
	}
}