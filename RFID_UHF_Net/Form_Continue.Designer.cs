namespace RFID_UHF_Net
{
    partial class Form_Continue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.button_Continue = new System.Windows.Forms.Button();
            this.listView_Result = new System.Windows.Forms.ListView();
            this.columnHeader_ID = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_Count = new System.Windows.Forms.ColumnHeader();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_ReadWrite = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Tags_Count = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Save_File = new System.Windows.Forms.Button();
            this.checkBox_ReadOnce = new System.Windows.Forms.CheckBox();
            this.checkBox_TID = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button_Continue
            // 
            this.button_Continue.Location = new System.Drawing.Point(107, 217);
            this.button_Continue.Name = "button_Continue";
            this.button_Continue.Size = new System.Drawing.Size(62, 20);
            this.button_Continue.TabIndex = 2;
            this.button_Continue.Text = "Start";
            this.button_Continue.Click += new System.EventHandler(this.button_Continue_Click);
            // 
            // listView_Result
            // 
            this.listView_Result.Columns.Add(this.columnHeader_ID);
            this.listView_Result.Columns.Add(this.columnHeader_Count);
            this.listView_Result.FullRowSelect = true;
            this.listView_Result.Location = new System.Drawing.Point(3, 27);
            this.listView_Result.Name = "listView_Result";
            this.listView_Result.Size = new System.Drawing.Size(234, 152);
            this.listView_Result.TabIndex = 3;
            this.listView_Result.View = System.Windows.Forms.View.Details;
            this.listView_Result.ItemActivate += new System.EventHandler(this.listView_Result_Select);
            this.listView_Result.SelectedIndexChanged += new System.EventHandler(this.listView_Result_Select);
            // 
            // columnHeader_ID
            // 
            this.columnHeader_ID.Text = "ID";
            this.columnHeader_ID.Width = 60;
            // 
            // columnHeader_Count
            // 
            this.columnHeader_Count.Text = "Cnt";
            this.columnHeader_Count.Width = 60;
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(175, 217);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(62, 20);
            this.button_Clear.TabIndex = 5;
            this.button_Clear.Text = "Clear";
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_ReadWrite
            // 
            this.button_ReadWrite.Location = new System.Drawing.Point(175, 239);
            this.button_ReadWrite.Name = "button_ReadWrite";
            this.button_ReadWrite.Size = new System.Drawing.Size(62, 20);
            this.button_ReadWrite.TabIndex = 8;
            this.button_ReadWrite.Text = "R/W";
            this.button_ReadWrite.Click += new System.EventHandler(this.button_ReadWrite_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 24);
            this.label1.Text = "Continuous Read";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_Tags_Count
            // 
            this.label_Tags_Count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label_Tags_Count.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.label_Tags_Count.ForeColor = System.Drawing.SystemColors.Info;
            this.label_Tags_Count.Location = new System.Drawing.Point(3, 226);
            this.label_Tags_Count.Name = "label_Tags_Count";
            this.label_Tags_Count.Size = new System.Drawing.Size(92, 33);
            this.label_Tags_Count.Text = "0";
            this.label_Tags_Count.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(3, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.Text = "Tags Count";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_Save_File
            // 
            this.button_Save_File.Location = new System.Drawing.Point(107, 239);
            this.button_Save_File.Name = "button_Save_File";
            this.button_Save_File.Size = new System.Drawing.Size(62, 20);
            this.button_Save_File.TabIndex = 11;
            this.button_Save_File.Text = "Save File";
            this.button_Save_File.Click += new System.EventHandler(this.button_Save_File_Click);
            // 
            // checkBox_ReadOnce
            // 
            this.checkBox_ReadOnce.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.checkBox_ReadOnce.Location = new System.Drawing.Point(107, 193);
            this.checkBox_ReadOnce.Name = "checkBox_ReadOnce";
            this.checkBox_ReadOnce.Size = new System.Drawing.Size(62, 18);
            this.checkBox_ReadOnce.TabIndex = 12;
            this.checkBox_ReadOnce.Text = "Once";
            // 
            // checkBox_TID
            // 
            this.checkBox_TID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.checkBox_TID.Location = new System.Drawing.Point(175, 193);
            this.checkBox_TID.Name = "checkBox_TID";
            this.checkBox_TID.Size = new System.Drawing.Size(62, 18);
            this.checkBox_TID.TabIndex = 16;
            this.checkBox_TID.Text = "TID";
            // 
            // Form_Continue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.checkBox_TID);
            this.Controls.Add(this.checkBox_ReadOnce);
            this.Controls.Add(this.button_Save_File);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_Tags_Count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_ReadWrite);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.listView_Result);
            this.Controls.Add(this.button_Continue);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "Form_Continue";
            this.Text = "RFID_UHF";
            this.Load += new System.EventHandler(this.Form_Continue_Load);
            this.Closed += new System.EventHandler(this.Form_Continue_Closed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Continue;
        private System.Windows.Forms.ListView listView_Result;
        private System.Windows.Forms.ColumnHeader columnHeader_ID;
        private System.Windows.Forms.ColumnHeader columnHeader_Count;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_ReadWrite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Tags_Count;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Save_File;
        private System.Windows.Forms.CheckBox checkBox_ReadOnce;
        private System.Windows.Forms.CheckBox checkBox_TID;
    }
}

