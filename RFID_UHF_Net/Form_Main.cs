using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using com.caen.RFIDLibrary;
using com.abitech;
using com.abitech.rfid;
using System.IO;
using System.Reflection;

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
        private object isTubesBungleSending = false;

        public String m_strAppVersion = "1.0.0";
        public String m_strAppRelease = "2011-11-10";
        private CAENRFIDReader m_Reader;

        public bool m_bSoundEnable = true;
        public bool m_bTIDVisible = false;
        
        // Continuous Read
        public bool m_bTIDMode = false;
        public bool m_bOneRead = false;
        // 

        // memory Access
        MemoryBankType m_MemBank = MemoryBankType.EPC;
        int m_nStartAddr = 0;
        int m_nAccessLength = 12;
        //

        private bool m_bConnect = false;

        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            m_Reader = new CAENRFIDReader();

            try
            {
                //m_Reader.Disconnect();
                m_Reader.Connect(CAENRFIDPort.CAENRFID_RS232, "MOC1");

                System.Threading.Thread.Sleep(500);

                var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
                RfidReader.collector = new RfidTagsCollector(path + @"\rfid.db");
                RfidReader.web = new RfidWebClient(Configuration.Deserialize(path + @"\config.xml"));
                RfidReader.reader = m_Reader;
                RfidReader.source = m_Reader.GetSources()[0];

                UpdateInformation();

                m_bConnect = true;
            }
            catch (CAENRFIDException err)
            {
                //label_Information.Text = "Status: Connect Error\n" + err.Message;

                m_bConnect = false;
                return;
            }

        }

        private void UpdateInformation()
        {            
            CAENRFIDRFRegulations rf = m_Reader.GetRFRegulation();
            CAENRFIDProtocol protocol = m_Reader.GetProtocol();
            String strRfRegulation = "";
            String strProtocol = "";

            switch(rf)
            {
                case CAENRFIDRFRegulations.ETSI_302208:
                    strRfRegulation = "ETSI 302208";
                    break;
                case CAENRFIDRFRegulations.FCC_US:
                    strRfRegulation = "FCC US";
                    break;
                default:
                    break; 
            }

            switch(protocol)
            {
                case CAENRFIDProtocol.CAENRFID_EPC_C1G2:
                    strProtocol = "EPC Class1 Gen2";
                    break;
                default:
                    strProtocol = "No Protocol";
                    break;
            }



            String strInformation = "APP Version: " + m_strAppVersion + "\n" +
                                    "APP Release: " + m_strAppRelease + "\n" +
                                    "DLL Version: " + CAENRFIDReader.Version + "\n" +
                                    "Firmware: " + m_Reader.GetFirmwareRelease() + "\n" +
                                    "RF Regulation: " + strRfRegulation + "\n" +
                                    "Reader Protocol: " + strProtocol;

            //label_Information.Text = strInformation;

            if(m_Reader.GetFirmwareRelease() == "1.2.1")
            {
                m_bTIDVisible = false;
            }
            else
            {
                m_bTIDVisible = true;
            }
        }

        private void button_Continue_Click(object sender, EventArgs e)
        {
            Form_Continue formContinue = new Form_Continue(m_Reader);
            formContinue.m_bSoundEnable = m_bSoundEnable;

            formContinue.m_bOneRead = m_bOneRead;
            formContinue.m_bTIDMode = m_bTIDMode;
            formContinue.m_bTIDVisible = m_bTIDVisible;

            formContinue.ShowDialog();
            m_bOneRead = formContinue.m_bOneRead;
            m_bTIDMode = formContinue.m_bTIDMode;
        }

        private void button_Memory_Click(object sender, EventArgs e)
        {
            Form_Read formRead = new Form_Read(m_Reader);
            formRead.m_bSoundEnable = m_bSoundEnable;

            formRead.m_MemBank = m_MemBank;
            formRead.m_nStartAddr = m_nStartAddr;
            formRead.m_nAccessLength = m_nAccessLength;
            
            formRead.ShowDialog();
            
            m_MemBank = formRead.m_MemBank;
            m_nStartAddr = formRead.m_nStartAddr;
            m_nAccessLength = formRead.m_nAccessLength;

        }

        private void button_Setting_Click(object sender, EventArgs e)
        {
            Form_Setting formSetting = new Form_Setting(m_Reader);
            formSetting.m_bSoundEnable = m_bSoundEnable;

            formSetting.ShowDialog();

            m_bSoundEnable = formSetting.m_bSoundEnable;

            UpdateInformation();

        }

        private void Form_Main_Closing(object sender, CancelEventArgs e)
        {
            if(m_bConnect == true)
            {
                if (m_Reader != null) m_Reader.Disconnect();
            }

            RfidReader.collector.Close();
        }

        private void tracking_Click(object sender, EventArgs e)
        {
            var form = new TagsOperation();
            form.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void OrderList_Click(object sender, EventArgs e)
        {
            var form = new OrderList();
            form.ShowDialog();
        }

        private void MakeOrder_Click(object sender, EventArgs e)
        {
            var form = new NewOrder();
            form.ShowDialog();
        }


    }
}