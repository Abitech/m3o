namespace RFID_UHF_Net
{
    partial class Form_Read
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_Result = new System.Windows.Forms.ListBox();
            this.textBox_Write = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_WriteLen = new System.Windows.Forms.Label();
            this.comboBox_BankType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_StartAddr = new System.Windows.Forms.TextBox();
            this.textBox_AccessLength = new System.Windows.Forms.TextBox();
            this.button_Read_Memory = new System.Windows.Forms.Button();
            this.button_Write_Memory = new System.Windows.Forms.Button();
            this.button_Clear_Result = new System.Windows.Forms.Button();
            this.textBox_Detail_Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 24);
            this.label1.Text = "Memory Access";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBox_Result
            // 
            this.listBox_Result.Location = new System.Drawing.Point(3, 27);
            this.listBox_Result.Name = "listBox_Result";
            this.listBox_Result.Size = new System.Drawing.Size(234, 100);
            this.listBox_Result.TabIndex = 12;
            this.listBox_Result.SelectedIndexChanged += new System.EventHandler(this.listBox_Result_SelectedIndexChanged);
            // 
            // textBox_Write
            // 
            this.textBox_Write.Location = new System.Drawing.Point(3, 155);
            this.textBox_Write.Name = "textBox_Write";
            this.textBox_Write.Size = new System.Drawing.Size(234, 21);
            this.textBox_Write.TabIndex = 13;
            this.textBox_Write.TextChanged += new System.EventHandler(this.textBox_Write_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.Text = "Write Data";
            // 
            // label_WriteLen
            // 
            this.label_WriteLen.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label_WriteLen.Location = new System.Drawing.Point(139, 136);
            this.label_WriteLen.Name = "label_WriteLen";
            this.label_WriteLen.Size = new System.Drawing.Size(98, 16);
            this.label_WriteLen.Text = "0 (0 Byte)";
            this.label_WriteLen.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBox_BankType
            // 
            this.comboBox_BankType.Location = new System.Drawing.Point(3, 198);
            this.comboBox_BankType.Name = "comboBox_BankType";
            this.comboBox_BankType.Size = new System.Drawing.Size(77, 22);
            this.comboBox_BankType.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.Text = "Mem Bank";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(3, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 18);
            this.label5.Text = "Start";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(47, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 18);
            this.label6.Text = "Byte";
            // 
            // textBox_StartAddr
            // 
            this.textBox_StartAddr.Location = new System.Drawing.Point(3, 244);
            this.textBox_StartAddr.Name = "textBox_StartAddr";
            this.textBox_StartAddr.Size = new System.Drawing.Size(34, 21);
            this.textBox_StartAddr.TabIndex = 24;
            this.textBox_StartAddr.Text = "textBox2";
            // 
            // textBox_AccessLength
            // 
            this.textBox_AccessLength.Location = new System.Drawing.Point(46, 244);
            this.textBox_AccessLength.Name = "textBox_AccessLength";
            this.textBox_AccessLength.Size = new System.Drawing.Size(34, 21);
            this.textBox_AccessLength.TabIndex = 25;
            this.textBox_AccessLength.Text = "textBox3";
            // 
            // button_Read_Memory
            // 
            this.button_Read_Memory.Location = new System.Drawing.Point(98, 182);
            this.button_Read_Memory.Name = "button_Read_Memory";
            this.button_Read_Memory.Size = new System.Drawing.Size(139, 23);
            this.button_Read_Memory.TabIndex = 26;
            this.button_Read_Memory.Text = "Read Memory";
            this.button_Read_Memory.Click += new System.EventHandler(this.button_Read_Memory_Click);
            // 
            // button_Write_Memory
            // 
            this.button_Write_Memory.Location = new System.Drawing.Point(98, 211);
            this.button_Write_Memory.Name = "button_Write_Memory";
            this.button_Write_Memory.Size = new System.Drawing.Size(139, 23);
            this.button_Write_Memory.TabIndex = 27;
            this.button_Write_Memory.Text = "Write Memory";
            this.button_Write_Memory.Click += new System.EventHandler(this.button_Write_Memory_Click);
            // 
            // button_Clear_Result
            // 
            this.button_Clear_Result.Location = new System.Drawing.Point(98, 240);
            this.button_Clear_Result.Name = "button_Clear_Result";
            this.button_Clear_Result.Size = new System.Drawing.Size(139, 23);
            this.button_Clear_Result.TabIndex = 28;
            this.button_Clear_Result.Text = "Clear";
            this.button_Clear_Result.Click += new System.EventHandler(this.button_Clear_Result_Click);
            // 
            // textBox_Detail_Result
            // 
            this.textBox_Detail_Result.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_Detail_Result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Detail_Result.Location = new System.Drawing.Point(159, 31);
            this.textBox_Detail_Result.Multiline = true;
            this.textBox_Detail_Result.Name = "textBox_Detail_Result";
            this.textBox_Detail_Result.ReadOnly = true;
            this.textBox_Detail_Result.Size = new System.Drawing.Size(73, 91);
            this.textBox_Detail_Result.TabIndex = 35;
            this.textBox_Detail_Result.GotFocus += new System.EventHandler(this.textBox_Detail_Result_GotFocus);
            // 
            // Form_Read
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.textBox_Detail_Result);
            this.Controls.Add(this.button_Clear_Result);
            this.Controls.Add(this.button_Write_Memory);
            this.Controls.Add(this.button_Read_Memory);
            this.Controls.Add(this.textBox_AccessLength);
            this.Controls.Add(this.textBox_StartAddr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_BankType);
            this.Controls.Add(this.label_WriteLen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Write);
            this.Controls.Add(this.listBox_Result);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu1;
            this.Name = "Form_Read";
            this.Text = "Form_Read";
            this.Load += new System.EventHandler(this.Form_Read_Load);
            this.Closed += new System.EventHandler(this.Form_Read_Closed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_Result;
        private System.Windows.Forms.TextBox textBox_Write;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_WriteLen;
        private System.Windows.Forms.ComboBox comboBox_BankType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_StartAddr;
        private System.Windows.Forms.TextBox textBox_AccessLength;
        private System.Windows.Forms.Button button_Read_Memory;
        private System.Windows.Forms.Button button_Write_Memory;
        private System.Windows.Forms.Button button_Clear_Result;
        private System.Windows.Forms.TextBox textBox_Detail_Result;
    }
}