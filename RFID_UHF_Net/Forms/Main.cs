using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using com.abitech.rfid;
using Microsoft.WindowsCE.Forms;

namespace RFID_UHF_Net.Forms
{

	public partial class MainForm : Form
	{
		private Strings strings;
		private Configuration configuration;
		private volatile bool shouldStop = true;
		private Thread deviceActivityThread;


		public MainForm()
		{
			if (M3Client.Init() == false)
			{
				return;
			}

			configuration = M3Client.configuration;
			strings = Resources.strings;

			InitializeComponent();
#if !DEBUG
			gpsLabel.Visible = false;
#endif

			/* Получаем номер бригады/или должность и роль устройства */

			var response = M3Client.web.GetDeviceDescription();

			if (response.error == null)
			{
				configuration.Team = response.result.team;
				configuration.Role = response.result.role;
				configuration.Save();
			}

			/* 
			 * Сообщаем серверу каждые N секунд, что устройство в сети
			 * и имеет такие-то координаты
			 * 
			 */

			deviceActivityThread = new Thread(new ThreadStart(() =>
			{
				var time = DateTime.Now.AddSeconds(10);

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

						this.Invoke((System.Threading.ThreadStart)delegate() { gpsLabel.Text = notification; });

						time = DateTime.Now.AddSeconds(10);
					}
				}
			}));
			deviceActivityThread.IsBackground = true;
			//deviceActivityThread.Start();

			// M3Client.InitGps();

			if (configuration.Language == "ru")
			{
				languageSelectorRuRadioButton.Checked = true;
			}
			else if (configuration.Language == "kz")
			{
				languageSelectorKzRadioButton.Checked = true;
			}

			newRepairButton.Text = strings["newRepair"];
			newOrderButton.Text = strings["newOrder"];
			orderListButton.Text = strings["orderList"];
			newActButton.Text = strings["newAct"];

			if (configuration.Role == Roles.repairForeman)
			{
				teamNumberLabel.Text = configuration.Location + " " + strings["team"] + configuration.Team;
			}
			else if (configuration.Role == Roles.tubeMaster)
			{
				teamNumberLabel.Text = configuration.Location + " " + configuration.Team;
				newRepairButton.Enabled = false;
				newOrderButton.Enabled = false;
				newActButton.Enabled = false;
			}

#if !DEBUG
			testWaybillForm.Visible = false;
			testWaybillForm.Enabled = false;
#endif
		}

		private void ReInit(string language)
		{
			Resources.strings.SetLanguage(language);

			newRepairButton.Text = strings["newRepair"];
			newOrderButton.Text = strings["newOrder"];
			orderListButton.Text = strings["orderList"];
			newActButton.Text = strings["newAct"];

			configuration.Language = language;
			configuration.Save();
		}

		private void MainFormClosing(object sender, CancelEventArgs e)
		{
			shouldStop = false;
			M3Client.reader.Disconnect();

			if (deviceActivityThread.Join(5000) == false)
			{
				deviceActivityThread.Abort();
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

			if (response.error != null)
			{
				MessageBox.Show(strings["repeatAttempt"]);
				(sender as Button).Enabled = true;
				return;
			}

			MessageBox.Show("Работает. OrderForm_Click");

			(sender as Button).Enabled = true;
			var form = new OrderForm(response.result);
			form.ShowDialog();
		}

		private void OrdersForm_Click(object sender, EventArgs e)
		{
			(sender as Button).Enabled = false;
			var response = M3Client.web.GetOrders();

			if (response.error != null)
			{
				MessageBox.Show(strings["repeatAttempt"]);
				(sender as Button).Enabled = true;
				return;
			}

			(sender as Button).Enabled = true;
			var form = new OrdersForm(response.result);
			form.ShowDialog();
		}

		private void ActFormButton_Click(object sender, EventArgs e)
		{
			(sender as Button).Enabled = false;
			var response = M3Client.repairs;

			if (response.error != null)
			{
				MessageBox.Show(strings["repeatAttempt"]);
				(sender as Button).Enabled = true;
				return;
			}

			(sender as Button).Enabled = true;
			var form = new ActForm(response.result);
			form.ShowDialog();
		}

		private void TestWaybillForm_Click(object sender, EventArgs e)
		{
			var waybillForm = new WaybillForm(new OrderListRecord());

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
	}
}