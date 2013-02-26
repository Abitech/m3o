namespace RFID_UHF_Net.Forms
{
    partial class WaybillForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
		private System.ComponentModel.IContainer components = null;

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
			this.sendWaybillButton = new System.Windows.Forms.Button();
			this.readTagButton = new System.Windows.Forms.Button();
			this.epcLabel = new System.Windows.Forms.Label();
			this.tubesNumberTextBox = new System.Windows.Forms.TextBox();
			this.tubeStatusNew = new System.Windows.Forms.RadioButton();
			this.tubeStatusOld = new System.Windows.Forms.RadioButton();
			this.tubeStatusLabel = new System.Windows.Forms.Label();
			this.tubesNumberLabel = new System.Windows.Forms.Label();
			this.notificationLabel = new System.Windows.Forms.Label();
			this.waybillNumberLabel = new System.Windows.Forms.Label();
			this.waybillNumberTextBox = new System.Windows.Forms.TextBox();
			this.notification = new Microsoft.WindowsCE.Forms.Notification();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.SuspendLayout();
			// 
			// sendWaybillButton
			// 
			this.sendWaybillButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.sendWaybillButton.Location = new System.Drawing.Point(3, 245);
			this.sendWaybillButton.Name = "sendWaybillButton";
			this.sendWaybillButton.Size = new System.Drawing.Size(234, 20);
			this.sendWaybillButton.TabIndex = 5;
			this.sendWaybillButton.Text = "Жөнелту";
			this.sendWaybillButton.Click += new System.EventHandler(this.sendWaybill_Click);
			// 
			// readTagButton
			// 
			this.readTagButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.readTagButton.Location = new System.Drawing.Point(3, 46);
			this.readTagButton.Name = "readTagButton";
			this.readTagButton.Size = new System.Drawing.Size(234, 18);
			this.readTagButton.TabIndex = 0;
			this.readTagButton.Text = "Считать транспортную метку";
			this.readTagButton.Click += new System.EventHandler(this.ReadTag_Click);
			// 
			// epcLabel
			// 
			this.epcLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.epcLabel.Location = new System.Drawing.Point(4, 0);
			this.epcLabel.Name = "epcLabel";
			this.epcLabel.Size = new System.Drawing.Size(233, 43);
			this.epcLabel.Tag = "";
			this.epcLabel.Text = "Номер транспортного средства";
			this.epcLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// tubesNumberTextBox
			// 
			this.tubesNumberTextBox.Location = new System.Drawing.Point(112, 137);
			this.tubesNumberTextBox.Name = "tubesNumberTextBox";
			this.tubesNumberTextBox.Size = new System.Drawing.Size(100, 21);
			this.tubesNumberTextBox.TabIndex = 2;
			// 
			// tubeStatusNew
			// 
			this.tubeStatusNew.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.tubeStatusNew.Location = new System.Drawing.Point(5, 91);
			this.tubeStatusNew.Name = "tubeStatusNew";
			this.tubeStatusNew.Size = new System.Drawing.Size(100, 20);
			this.tubeStatusNew.TabIndex = 3;
			this.tubeStatusNew.Text = "Новые";
			// 
			// tubeStatusOld
			// 
			this.tubeStatusOld.Location = new System.Drawing.Point(6, 117);
			this.tubeStatusOld.Name = "tubeStatusOld";
			this.tubeStatusOld.Size = new System.Drawing.Size(100, 20);
			this.tubeStatusOld.TabIndex = 4;
			this.tubeStatusOld.Text = "Старые";
			// 
			// tubeStatusLabel
			// 
			this.tubeStatusLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.tubeStatusLabel.Location = new System.Drawing.Point(5, 68);
			this.tubeStatusLabel.Name = "tubeStatusLabel";
			this.tubeStatusLabel.Size = new System.Drawing.Size(100, 20);
			this.tubeStatusLabel.Text = "Тип труб";
			// 
			// tubesNumberLabel
			// 
			this.tubesNumberLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.tubesNumberLabel.Location = new System.Drawing.Point(111, 114);
			this.tubesNumberLabel.Name = "tubesNumberLabel";
			this.tubesNumberLabel.Size = new System.Drawing.Size(100, 20);
			this.tubesNumberLabel.Text = "Число НКТ";
			// 
			// notificationLabel
			// 
			this.notificationLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.notificationLabel.Location = new System.Drawing.Point(3, 174);
			this.notificationLabel.Name = "notificationLabel";
			this.notificationLabel.Size = new System.Drawing.Size(235, 71);
			this.notificationLabel.Tag = "";
			this.notificationLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// waybillNumberLabel
			// 
			this.waybillNumberLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.waybillNumberLabel.Location = new System.Drawing.Point(112, 67);
			this.waybillNumberLabel.Name = "waybillNumberLabel";
			this.waybillNumberLabel.Size = new System.Drawing.Size(100, 20);
			this.waybillNumberLabel.Text = "Номер ТТН";
			// 
			// waybillNumberTextBox
			// 
			this.waybillNumberTextBox.Location = new System.Drawing.Point(111, 90);
			this.waybillNumberTextBox.Name = "waybillNumberTextBox";
			this.waybillNumberTextBox.Size = new System.Drawing.Size(100, 21);
			this.waybillNumberTextBox.TabIndex = 1;
			// 
			// notification
			// 
			this.notification.Text = "notification1";
			// 
			// WaybillForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(240, 268);
			this.Controls.Add(this.waybillNumberTextBox);
			this.Controls.Add(this.waybillNumberLabel);
			this.Controls.Add(this.notificationLabel);
			this.Controls.Add(this.tubesNumberLabel);
			this.Controls.Add(this.tubeStatusLabel);
			this.Controls.Add(this.tubeStatusOld);
			this.Controls.Add(this.tubeStatusNew);
			this.Controls.Add(this.tubesNumberTextBox);
			this.Controls.Add(this.sendWaybillButton);
			this.Controls.Add(this.epcLabel);
			this.Controls.Add(this.readTagButton);
			this.Menu = this.mainMenu1;
			this.Name = "WaybillForm";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button readTagButton;
        private System.Windows.Forms.Label epcLabel;
        private System.Windows.Forms.TextBox tubesNumberTextBox;
        private System.Windows.Forms.RadioButton tubeStatusNew;
        private System.Windows.Forms.RadioButton tubeStatusOld;
        private System.Windows.Forms.Label tubeStatusLabel;
        private System.Windows.Forms.Label tubesNumberLabel;
        private System.Windows.Forms.Label notificationLabel;
        private System.Windows.Forms.Label waybillNumberLabel;
        private System.Windows.Forms.TextBox waybillNumberTextBox;
        private System.Windows.Forms.Button sendWaybillButton;
		private Microsoft.WindowsCE.Forms.Notification notification;
		private System.Windows.Forms.MainMenu mainMenu1;
    }
}