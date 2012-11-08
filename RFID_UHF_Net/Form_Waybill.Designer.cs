namespace RFID_UHF_Net
{
    partial class Form_Waybill
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
            System.Windows.Forms.Button SendWaybill;
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.readTag = new System.Windows.Forms.Button();
            this.epcLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.oldTubesNumberT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newTubesNumberT = new System.Windows.Forms.TextBox();
            SendWaybill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SendWaybill
            // 
            SendWaybill.Location = new System.Drawing.Point(4, 203);
            SendWaybill.Name = "SendWaybill";
            SendWaybill.Size = new System.Drawing.Size(100, 20);
            SendWaybill.TabIndex = 13;
            SendWaybill.Text = "Отправить";
            SendWaybill.Click += new System.EventHandler(this.sendWaybill_Click);
            // 
            // readTag
            // 
            this.readTag.Location = new System.Drawing.Point(4, 38);
            this.readTag.Name = "readTag";
            this.readTag.Size = new System.Drawing.Size(233, 18);
            this.readTag.TabIndex = 0;
            this.readTag.Text = "Считать транспортную метку";
            this.readTag.Click += new System.EventHandler(this.button1_Click);
            // 
            // epcLabel
            // 
            this.epcLabel.Location = new System.Drawing.Point(4, 11);
            this.epcLabel.Name = "epcLabel";
            this.epcLabel.Size = new System.Drawing.Size(233, 24);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "Старых труб";
            // 
            // oldTubesNumberT
            // 
            this.oldTubesNumberT.Location = new System.Drawing.Point(4, 129);
            this.oldTubesNumberT.Name = "oldTubesNumberT";
            this.oldTubesNumberT.Size = new System.Drawing.Size(100, 21);
            this.oldTubesNumberT.TabIndex = 14;
            this.oldTubesNumberT.Text = "0";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "Новых труб";
            // 
            // newTubesNumberT
            // 
            this.newTubesNumberT.Location = new System.Drawing.Point(4, 82);
            this.newTubesNumberT.Name = "newTubesNumberT";
            this.newTubesNumberT.Size = new System.Drawing.Size(100, 21);
            this.newTubesNumberT.TabIndex = 19;
            this.newTubesNumberT.Text = "0";
            // 
            // Form_Waybill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.newTubesNumberT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.oldTubesNumberT);
            this.Controls.Add(SendWaybill);
            this.Controls.Add(this.epcLabel);
            this.Controls.Add(this.readTag);
            this.Menu = this.mainMenu1;
            this.Name = "Form_Waybill";
            this.Text = "Адресная метка";
            this.Load += new System.EventHandler(this.TagsOperation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button readTag;
        private System.Windows.Forms.Label epcLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox oldTubesNumberT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newTubesNumberT;
    }
}