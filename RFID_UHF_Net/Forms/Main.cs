using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using com.abitech.rfid;
using com.caen.RFIDLibrary;

namespace RFID_UHF_Net.Forms
{

	public partial class MainForm : Form
	{
		private Strings strings;
		private Configuration configuration;
		private String path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase) + @"\config.xml";

		public MainForm()
		{
			RfidReader.configuration = Configuration.Deserialize(path);
			configuration = RfidReader.configuration;

			Resources.Init();
			Resources.strings.SetLanguage(configuration.Language);
			strings = Resources.strings;

			RfidReader.web = new RfidWebClient(configuration);

			try
			{
				RfidReader.reader = new CAENRFIDReader();
				RfidReader.reader.Connect(CAENRFIDPort.CAENRFID_RS232, "MOC1");
				System.Threading.Thread.Sleep(500);
				RfidReader.source = RfidReader.reader.GetSources()[0];
			}

			catch (CAENRFIDException e)
			{
				return;
			}

			InitializeComponent();

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
			configuration.Serialize(path);
		}

		private void MainFormClosing(object sender, CancelEventArgs e)
		{
			RfidReader.reader.Disconnect();
		}

		private void RepairForm_Click(object sender, EventArgs e)
		{
			var repairForm = new RepairForm();
			repairForm.Show();
		}

		private void OrderForm_Click(object sender, EventArgs e)
		{
			(sender as Button).Enabled = false;
			var response = RfidReader.web.GetRepairs();

			if (response.error != null)
			{
				MessageBox.Show(strings["repeatAttempt"]);
				(sender as Button).Enabled = true;
				return;
			}

			(sender as Button).Enabled = true;
			var form = new OrderForm(response.result);
			form.ShowDialog();
		}

		private void OrdersForm_Click(object sender, EventArgs e)
		{
			(sender as Button).Enabled = false;
			var response = RfidReader.web.GetOrders();

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
			var response = RfidReader.web.GetRepairs();

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