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
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            try
            {
                var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
                RfidReader.web = new RfidWebClient(Configuration.Deserialize(path + @"\config.xml"));
                RfidReader.reader = new CAENRFIDReader();
                RfidReader.reader.Connect(CAENRFIDPort.CAENRFID_RS232, "MOC1");
                System.Threading.Thread.Sleep(500);
                RfidReader.source = RfidReader.reader.GetSources()[0];                 
            }
            catch (CAENRFIDException err)
            {
                return;
            }
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
            form.ShowDialog();
        }

        private void MakeOrder_Click(object sender, EventArgs e)
        {
            var form = new Form_NewOrder();
            form.ShowDialog();
        }
    }
}