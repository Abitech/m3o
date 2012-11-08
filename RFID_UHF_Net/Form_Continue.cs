using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using com.caen.RFIDLibrary;
using System.Threading;

namespace RFID_UHF_Net
{
    public partial class Form_Continue : Form
    {
        // declare member
        private CAENRFIDReader m_Reader;
        private CAENRFIDLogicalSource m_Source;
        private CAENRFIDTag[] m_Tags = new CAENRFIDTag[260];
        private int m_TagIndex = 0;
        private int m_nSelectTagIndex = -1;

        private Boolean m_bContRead = false;

        public bool m_bSoundEnable = true;

        // Option
        public bool m_bTIDMode = false;
        public bool m_bOneRead = false;
        //
        
        // Flag
        public bool m_bReading = false;
        public bool m_bTIDVisible = false;

        public Thread ContReadThread = null;

        public const int RESULT_ID = 0;
        public const int RESULT_READ_COUNT = 1;      
        
        public Form_Continue(CAENRFIDReader reader)
        {

            InitializeComponent();

            button_Continue.Enabled = true;
            button_Clear.Enabled = false;
            button_ReadWrite.Enabled = false;
            button_Save_File.Enabled = true;
                        
            listView_Result.Columns[RESULT_ID].Width = (int)((listView_Result.Width) * 100 / 100);
            listView_Result.Columns[RESULT_READ_COUNT].Width = (int)((listView_Result.Width) * 15 / 100);

            m_Reader = reader;
            m_Source = m_Reader.GetSources()[0];

        }


        private delegate void ControlDelegate(string szString);
        private delegate void TagsDelegate(CAENRFIDTag[] Tags);

        public void UpdateCountResult(string szData)
        {
            if (this.label_Tags_Count.InvokeRequired)
            {
                ControlDelegate d = new ControlDelegate(UpdateCountResult);
                this.Invoke(d, new object[] { szData });
            }
            else
            {
                this.label_Tags_Count.Text = szData;
            }
        }



        public void UpdateListView_Read(CAENRFIDTag[] Tags)
        {
            m_bReading = true;
            if(this.listView_Result.InvokeRequired)
            {
                TagsDelegate d = new TagsDelegate(UpdateListView_Read);
                this.Invoke(d, new object[] {Tags});

            }
            else
            {
                int nTags;

                nTags = Tags.Length;

                if (nTags > 0)
                {
                    // Current Antenna fields
                    // label_Tags_Count.Text = nTags.ToString();
                    

                    for (int i = 0; i < nTags; i++)
                    {
                        String Current = getStringID(Tags[i]);
                        String Type = Tags[i].GetType().ToString();
                        Type = Type.Substring(9); // Remove "caenrfid_"
                        ListViewItem lvTag = new ListViewItem();

                        int nCount = listView_Result.Items.Count;

                        if (nCount > 0)
                        {
                            Boolean bFound = false;

                            for (int j = 0; j < nCount; j++)
                            {
                                String strID = listView_Result.Items[j].SubItems[RESULT_ID].Text;
                                if (strID == Current)
                                {
                                    bFound = true;
                                    int nNum = int.Parse(listView_Result.Items[j].SubItems[RESULT_READ_COUNT].Text) + 1;
                                    listView_Result.Items[j].SubItems[RESULT_READ_COUNT].Text = nNum.ToString();
                                }
                            }

                            if(bFound == false)
                            {
                                lvTag = new ListViewItem();

                                lvTag.Text = Current;
                                lvTag.SubItems.Add("1");

                                listView_Result.Items.Add(lvTag);

                                m_Tags[m_TagIndex++] = Tags[i];
                            }

                        }
                        else
                        {
                            lvTag = new ListViewItem();

                            lvTag.Text = Current;
                            lvTag.SubItems.Add("1");

                            listView_Result.Items.Add(lvTag);
                            m_Tags[m_TagIndex++] = Tags[i];

                        }

                        lvTag = null;

                    }

                    label_Tags_Count.Text = listView_Result.Items.Count.ToString();
                }
            }
            m_bReading = false;
        }


        private void ContinuousRead()
        {
            while(m_bContRead)
            {
                if (m_bReading)
                    continue;

                CAENRFIDTag[] Tags;

                try
                {
                    if (m_bTIDMode)
                    {
                        byte[] Mask = { 0xE2, 0x00, };
                        Tags = m_Source.InventoryTag(Mask, 0, 0, 0x10);
                    }
                    else
                    {
                        Tags = m_Source.InventoryTag();
                    }
                }
                catch 
                {
                    // UpdateResultLabel(err.getError());
                    return;
                }

                if (Tags != null)
                {
                    this.UpdateListView_Read(Tags);

                    if (m_bSoundEnable) SoundClass.PlaySound("\\Windows\\voicbeep.wav", 0, (int)(SoundClass.SND.SND_ASYNC | SoundClass.SND.SND_FILENAME));

                }
                else
                {
                    // UpdateResultLabel("Tags can not Found");

                }
            }

        }
        

        private void button_Continue_Click(object sender, EventArgs e)
        {
            m_bTIDMode = checkBox_TID.Checked;

            if(checkBox_ReadOnce.Checked)
            {
                CAENRFIDTag[] Tags;

                try
                {
                    if (m_bTIDMode)
                    {
                        byte[] Mask = { 0xE2, 0x00, };
                        Tags = m_Source.InventoryTag(Mask, 0, 0, 0x10);
                    }
                    else
                    {
                        Tags = m_Source.InventoryTag();
                    }
                }
                catch (CAENRFIDException err)
                {
                    MessageBox.Show(err.getError());
                    
                    return;
                }

                if (Tags != null)
                {
                    UpdateListView_Read(Tags);
                    if (m_bSoundEnable) SoundClass.PlaySound("\\Windows\\voicbeep.wav", 0, (int)(SoundClass.SND.SND_ASYNC | SoundClass.SND.SND_FILENAME));

                    button_ReadWrite.Enabled = true;
                }
                else
                {
                    //
                }

            }
            else
            {
                if (m_bContRead == true)
                {
                    m_bContRead = false;
                    button_Continue.Text = "Start";

                    button_Clear.Enabled = true;
                    checkBox_ReadOnce.Enabled = true;
                    checkBox_TID.Enabled = true;
                }
                else
                {
                    ContReadThread = new Thread(this.ContinuousRead);
                    ContReadThread.Start();

                    button_Continue.Text = "Stop";

                    m_bContRead = true;

                    button_ReadWrite.Enabled = false;
                    button_Clear.Enabled = false;
                    checkBox_ReadOnce.Enabled = false;
                    checkBox_TID.Enabled = false;
                }
            }    


        }

        private String getStringID(CAENRFIDTag Tag)
        {            
            String strID = "";
            String strResultID = "";

            if (m_bTIDMode)
            {
                strID = System.BitConverter.ToString(Tag.GetTID());
            }
            else
            {
                strID = System.BitConverter.ToString(Tag.GetId());
            }

            for (int i = 0; i < strID.Length; i++)
            {
                if (!strID.Substring(i, 1).Equals("-")) strResultID += strID.Substring(i, 1);
            }
            return strResultID;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            listView_Result.Items.Clear();
            m_Tags = new CAENRFIDTag[260];

            m_TagIndex = 0;
            label_Tags_Count.Text = m_TagIndex.ToString();
        }


        private void button_ReadWrite_Click(object sender, EventArgs e)
        {
            if (m_bContRead == true)
                return;

            Form_Read formRead = new Form_Read(m_Reader);


            formRead.SetCurrentTag(m_Tags[m_nSelectTagIndex]);

            formRead.Show();

        }

        private void listView_Result_Select(object sender, EventArgs e)
        {

            if (listView_Result.SelectedIndices.Count == 0 || m_bContRead == true)
            {
                button_ReadWrite.Enabled = false;
                return;
            }
            else
            {
                m_nSelectTagIndex = listView_Result.FocusedItem.Index;
                button_ReadWrite.Enabled = true;
            }

        }

        private void button_Save_File_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfDialog = new SaveFileDialog();
            sfDialog.Filter = "Log Files|*.log";           

            if (sfDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(sfDialog.FileName);
                foreach (ListViewItem lvItems in listView_Result.Items)
                {
                    file.WriteLine(lvItems.Text + "\t" + lvItems.SubItems[1].Text);
                }
                file.Close();
            }
        }

        private void Form_Continue_Load(object sender, EventArgs e)
        {
            checkBox_TID.Checked = m_bTIDMode;
            checkBox_ReadOnce.Checked = m_bOneRead;

            checkBox_TID.Visible = m_bTIDVisible;

        }
        private void Form_Continue_Closed(object sender, EventArgs e)
        {
            m_bTIDMode = checkBox_TID.Checked;
            m_bOneRead = checkBox_ReadOnce.Checked;
        }


    }
}