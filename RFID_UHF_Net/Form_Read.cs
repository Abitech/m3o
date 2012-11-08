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
    public partial class Form_Read : Form
    {

        private CAENRFIDReader m_reader;
        private CAENRFIDTag m_CurrentTag = null;
        private CAENRFIDLogicalSource m_SourceOne;

        public bool m_bSoundEnable = true;

        // Option
        public MemoryBankType m_MemBank = MemoryBankType.EPC;
        public int m_nStartAddr = 0;
        public int m_nAccessLength = 12;
        //


        public Form_Read(CAENRFIDReader reader)
        {
            InitializeComponent();

            m_reader = reader;
            m_SourceOne = reader.GetSources()[0];

        }


        private void Form_Read_Load(object sender, EventArgs e)
        {
            comboBox_BankType.Items.Insert(0, "Reserved");
            comboBox_BankType.Items.Insert(1, "EPC");
            comboBox_BankType.Items.Insert(2, "TID");
            comboBox_BankType.Items.Insert(3, "USER");

            comboBox_BankType.SelectedIndex = (int)m_MemBank;

            textBox_Write.Text = "";
            textBox_StartAddr.Text = m_nStartAddr.ToString();
            textBox_AccessLength.Text = m_nAccessLength.ToString();
            textBox_Detail_Result.Visible = false;

            if(m_CurrentTag != null)
            {
                button_Read_Memory_Click(sender, e);
            }

        }


        private bool ReadTag(CAENRFIDTag tag, MemoryBankType MemType, int nStartAddr, int nLength, StringBuilder strOutResult)
        {
            String toStamp = "";
            byte[] data = new byte[50];

            try
            {  
                String s;
                data = m_SourceOne.ReadTagData_EPC_C1G2(tag, (short)MemType, (short)nStartAddr, (short)nLength);
                s = System.BitConverter.ToString(data);
                for (int j = 0; j < s.Length; j++)
                {
                    if (!s.Substring(j, 1).Equals("-")) toStamp += s.Substring(j, 1);
                }

                strOutResult.Append(toStamp);
            }
            catch
            {
                return false;
            }

            return true;
        }


        private bool WriteTag(CAENRFIDTag tag, MemoryBankType MemType, int nStartAddr, int nLength, String strWriteData)
        {
            byte[] data = new byte[nLength];

            for (int i = 0; i < strWriteData.Length; i += 2)
                data[(int)(i / 2)] = System.Byte.Parse(strWriteData.Substring(i, 2), System.Globalization.NumberStyles.HexNumber);

            try
            {
                m_SourceOne.WriteTagData_EPC_C1G2(tag, (short)MemType, (short)nStartAddr, (short)nLength, data);
                return true;
            }
            catch 
            {
                return false;
            }
        }
        
        private bool GetSelectedTag(out CAENRFIDTag tag)
        {
            try
            {
                CAENRFIDTag[] tags;
                tags = m_SourceOne.InventoryTag();

                if (tags != null)
                {
                    tag = tags[0];
                    return true;
                }
                else
                {
                    tag = null;
                    return false;
                }
            }
            catch
            {
                tag = null;
                return false;
            
            }
        }

        public void SetCurrentTag(CAENRFIDTag tag)
        {
            m_CurrentTag = tag;                        
        }

        private MemoryBankType GetBankType()
        {
            int nType = comboBox_BankType.SelectedIndex;

            MemoryBankType memtype = MemoryBankType.EPC;

            switch(nType)
            {
                case 0:
                    memtype =  MemoryBankType.Reserved;
                    break;
                case 1:
                    memtype = MemoryBankType.EPC;
                    break;
                case 2:
                    memtype = MemoryBankType.TID; 
                    break;
                case 3:
                    memtype = MemoryBankType.USER;
                    break;
            }

            return memtype;

        }

        private void button_Read_Memory_Click(object sender, EventArgs e)
        {
            CAENRFIDTag tag = null;
            if(m_CurrentTag == null)
            {
                if(!GetSelectedTag(out tag))
                {
                    listBox_Result.Items.Add("No tags in the field");
                    return;
                }
            }
            else
            {
                tag = m_CurrentTag;
            }
            
            int nStartAddr = int.Parse(textBox_StartAddr.Text);
            int nLength = int.Parse(textBox_AccessLength.Text);
            StringBuilder strResult = new StringBuilder(nLength*2);

            if(ReadTag(tag, GetBankType(), nStartAddr, nLength, strResult))
            {
                listBox_Result.Items.Insert(0, strResult.ToString());

                if(m_bSoundEnable)  SoundClass.PlaySound("\\Windows\\voicbeep.wav", 0, (int)(SoundClass.SND.SND_ASYNC | SoundClass.SND.SND_FILENAME));
            }
            else
            {
                listBox_Result.Items.Insert(0, "Read Failed!");
            }
            textBox_Detail_Result.Visible = false;

        }

        private void button_Write_Memory_Click(object sender, EventArgs e)
        {

            CAENRFIDTag tag = null;
            if (m_CurrentTag == null)
            {
                if (!GetSelectedTag(out tag))
                {
                    listBox_Result.Items.Add("No tags in the field");
                    return;
                }
            }
            else
            {
                tag = m_CurrentTag;
            }

            int nStartAddr = int.Parse(textBox_StartAddr.Text);
            int nLength = int.Parse(textBox_AccessLength.Text);
            StringBuilder strResult = new StringBuilder(nLength * 2);

            if(WriteTag(tag, GetBankType(), nStartAddr, nLength, textBox_Write.Text))
            {
                listBox_Result.Items.Insert(0, "Write Success!");

                if (m_bSoundEnable) SoundClass.PlaySound("\\Windows\\voicbeep.wav", 0, (int)(SoundClass.SND.SND_ASYNC | SoundClass.SND.SND_FILENAME));
            }
            else
            {
                listBox_Result.Items.Insert(0, "Write Failed!");
            }

            textBox_Detail_Result.Visible = false;

        }

        private void button_Clear_Result_Click(object sender, EventArgs e)
        {
            textBox_Detail_Result.Visible = false;
            listBox_Result.Items.Clear();
            textBox_Write.Text = "";
        }

        private void textBox_Write_TextChanged(object sender, EventArgs e)
        {
            int nTextLength = textBox_Write.Text.Length;
            label_WriteLen.Text = nTextLength.ToString() + " (" + (nTextLength/2).ToString() + " Bytes)";
        }

        private void listBox_Result_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_Detail_Result.Visible = true;
            textBox_Detail_Result.Text = listBox_Result.Text;

            textBox_Write.Text = listBox_Result.Text;
        }

        private void textBox_Detail_Result_GotFocus(object sender, EventArgs e)
        {
            textBox_Detail_Result.Visible = false;
        }

        private void Form_Read_Closed(object sender, EventArgs e)
        {
            m_MemBank = (MemoryBankType)comboBox_BankType.SelectedIndex;

            m_nStartAddr = int.Parse(textBox_StartAddr.Text);
            m_nAccessLength = int.Parse(textBox_AccessLength.Text);
        }



    }
}