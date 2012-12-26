using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using com.abitech.rfid;
using com.caen.RFIDLibrary;

namespace RFID_UHF_Net
{
    public enum MemoryBankType
    {
        Other = -1,
        Reserved = 0,
        EPC = 1,
        TID = 2,
        USER = 3
    };

    public partial class Form_Main : Form
    {
        private Configuration configuration;
        private string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase) + @"\config.xml";

        public Form_Main()
        {
            try
            {
                configuration = Configuration.Deserialize(path);

                Resources.Init();
                Resources.strings.SetLanguage(configuration.Language);

                RfidReader.web = new RfidWebClient(configuration);
                RfidReader.reader = new CAENRFIDReader();
                RfidReader.reader.Connect(CAENRFIDPort.CAENRFID_RS232, "MOC1");
                System.Threading.Thread.Sleep(500);
                RfidReader.source = RfidReader.reader.GetSources()[0];
            }

            catch (CAENRFIDException err)
            {
                return;
            }

            InitializeComponent();

            if (configuration.Language == "ru")
                LanguageSelectorRu.Checked = true;
            else if (configuration.Language == "kz")
                LanguageSelectorKz.Checked = true;

            var strings = Resources.strings;

            NewOrder.Text = strings["NewOrder"];
            OrderList.Text = strings["OrderList"];
            OrderHistory.Text = strings["OrderHistory"];
            TeamNumberT.Text = configuration.Location + " " + strings["Team"] + configuration.Team;


            #if !DEBUG

            OrderHistory.Visible = false;
            OrderHistory.Enabled = false;
            TestWaybillForm.Visible = false;
            TestWaybillForm.Enabled = false;

            #endif

            
        }

        private void ReInit(string language)
        {
            Resources.strings.SetLanguage(language);
            var strings = Resources.strings;

            NewOrder.Text = strings["NewOrder"];
            OrderList.Text = strings["OrderList"];
            OrderHistory.Text = strings["OrderHistory"];

            configuration.Language = language;
            configuration.Serialize(path);
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
        }

        private void Form_Main_Closing(object sender, CancelEventArgs e)
        {
            RfidReader.reader.Disconnect();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void OrderList_Click(object sender, EventArgs e)
        {
            var form = new Form_OrderList();

            #if DEBUG
            form.Sync();
            form.ShowDialog();

            #else
            if (form.Sync() == false)
            {
                form.Close();
            }
            else
            {
                form.ShowDialog();
            }
            #endif
        }

        private void MakeOrder_Click(object sender, EventArgs e)
        {
            var form = new Form_NewOrder();
            form.ShowDialog();
        }

        private void LanguageSelectorKz_CheckedChanged(object sender, EventArgs e)
        {
            ReInit("kz");
        }

        private void LanguageSelectorRu_CheckedChanged(object sender, EventArgs e)
        {
            ReInit("ru");
        }

        private void TestWaybillForm_Click(object sender, EventArgs e)
        {
            var waybillForm = new Form_Waybill(new ListViewItem { Tag = new TubesOrder() });
            waybillForm.Show();
        }
    }
}