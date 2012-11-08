using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using com.caen.RFIDLibrary;

namespace RFID_UHF_Net
{
    public partial class Form_Setting : Form
    {
        private CAENRFIDReader m_Reader;
        public bool m_bSoundEnable = true;

        public Form_Setting(CAENRFIDReader reader)
        {
            m_Reader = reader;
            InitializeComponent();

            CAENRFIDRFRegulations rf = reader.GetRFRegulation();

            switch(rf)
            {
                case CAENRFIDRFRegulations.ETSI_302208:
                    radioButton_ETSI_302208.Checked = true;
                    radioButton_FCC_US.Checked = false;
                    break;
                case CAENRFIDRFRegulations.FCC_US:
                    radioButton_ETSI_302208.Checked = false;
                    radioButton_FCC_US.Checked = true;
                    break;
                default:
                    break; 
            }
        }

        private void Form_Setting_Load(object sender, EventArgs e)
        {
            if (m_bSoundEnable)
            {
                radioButton_Enable.Checked = true;
                radioButton_Disable.Checked = false;
            }
            else
            {
                radioButton_Enable.Checked = false;
                radioButton_Disable.Checked = true;
            }

        }

        private void radioButton_ETSI_302208_CheckedChanged(object sender, EventArgs e)
        {
            SetRfRegulations(CAENRFIDRFRegulations.ETSI_302208);
        }

        
        private void radioButton_FCC_US_CheckedChanged(object sender, EventArgs e)
        {
            SetRfRegulations(CAENRFIDRFRegulations.FCC_US);
        }


        private void SetRfRegulations(CAENRFIDRFRegulations rfType)
        {
            try
            {
                m_Reader.SetRFRegulation(rfType);
            }
            catch (CAENRFIDException er)
            {
                MessageBox.Show(er.Message);
                return;
            }

        }

        private void Form_RF_Closed(object sender, EventArgs e)
        {
            m_bSoundEnable = radioButton_Enable.Checked;

            Close();
        }

    }
}