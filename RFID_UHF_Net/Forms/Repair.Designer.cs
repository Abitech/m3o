namespace com.abitech.rfid.Forms
{
    partial class RepairForm
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
			this.ogpwLabel = new System.Windows.Forms.Label();
			this.ogpwTextBox = new System.Windows.Forms.TextBox();
			this.cjpTextBox = new System.Windows.Forms.TextBox();
			this.cjpLabel = new System.Windows.Forms.Label();
			this.oilwellNumberTextBox = new System.Windows.Forms.TextBox();
			this.oilwellNumberLabel = new System.Windows.Forms.Label();
			this.tubeDiameterIdComboBox = new System.Windows.Forms.ComboBox();
			this.tubeDiameterIdLabel = new System.Windows.Forms.Label();
			this.notification = new Microsoft.WindowsCE.Forms.Notification();
			this.createRepairButton = new System.Windows.Forms.Button();
			this.notificationLabel = new System.Windows.Forms.Label();
			this.rodDiameterIdLabel = new System.Windows.Forms.Label();
			this.rodDiameterIdComboBox = new System.Windows.Forms.ComboBox();
			this.pumpIdLabel = new System.Windows.Forms.Label();
			this.pumpIdComboBox = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// ogpwLabel
			// 
			this.ogpwLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.ogpwLabel.Location = new System.Drawing.Point(3, 10);
			this.ogpwLabel.Name = "ogpwLabel";
			this.ogpwLabel.Size = new System.Drawing.Size(100, 20);
			this.ogpwLabel.Text = "ЦДНГ";
			// 
			// ogpwTextBox
			// 
			this.ogpwTextBox.Location = new System.Drawing.Point(3, 33);
			this.ogpwTextBox.Name = "ogpwTextBox";
			this.ogpwTextBox.Size = new System.Drawing.Size(100, 21);
			this.ogpwTextBox.TabIndex = 1;
			// 
			// cjpTextBox
			// 
			this.cjpTextBox.Location = new System.Drawing.Point(3, 80);
			this.cjpTextBox.Name = "cjpTextBox";
			this.cjpTextBox.Size = new System.Drawing.Size(100, 21);
			this.cjpTextBox.TabIndex = 2;
			// 
			// cjpLabel
			// 
			this.cjpLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.cjpLabel.Location = new System.Drawing.Point(3, 57);
			this.cjpLabel.Name = "cjpLabel";
			this.cjpLabel.Size = new System.Drawing.Size(100, 20);
			this.cjpLabel.Text = "ГУ/ПС";
			// 
			// oilwellNumberTextBox
			// 
			this.oilwellNumberTextBox.Location = new System.Drawing.Point(3, 127);
			this.oilwellNumberTextBox.Name = "oilwellNumberTextBox";
			this.oilwellNumberTextBox.Size = new System.Drawing.Size(100, 21);
			this.oilwellNumberTextBox.TabIndex = 3;
			// 
			// oilwellNumberLabel
			// 
			this.oilwellNumberLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.oilwellNumberLabel.Location = new System.Drawing.Point(3, 104);
			this.oilwellNumberLabel.Name = "oilwellNumberLabel";
			this.oilwellNumberLabel.Size = new System.Drawing.Size(100, 20);
			this.oilwellNumberLabel.Text = "Скважина №";
			// 
			// tubeDiameterIdComboBox
			// 
			this.tubeDiameterIdComboBox.Location = new System.Drawing.Point(110, 33);
			this.tubeDiameterIdComboBox.Name = "tubeDiameterIdComboBox";
			this.tubeDiameterIdComboBox.Size = new System.Drawing.Size(100, 22);
			this.tubeDiameterIdComboBox.TabIndex = 4;
			// 
			// tubeDiameterIdLabel
			// 
			this.tubeDiameterIdLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.tubeDiameterIdLabel.Location = new System.Drawing.Point(109, 10);
			this.tubeDiameterIdLabel.Name = "tubeDiameterIdLabel";
			this.tubeDiameterIdLabel.Size = new System.Drawing.Size(128, 20);
			this.tubeDiameterIdLabel.Text = "Диаметр НКТ, мм";
			// 
			// notification
			// 
			this.notification.Text = "";
			// 
			// createRepairButton
			// 
			this.createRepairButton.Location = new System.Drawing.Point(3, 245);
			this.createRepairButton.Name = "createRepairButton";
			this.createRepairButton.Size = new System.Drawing.Size(234, 20);
			this.createRepairButton.TabIndex = 5;
			this.createRepairButton.Text = "Создать";
			this.createRepairButton.Click += new System.EventHandler(this.createRepairButton_Click);
			// 
			// notificationLabel
			// 
			this.notificationLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.notificationLabel.Location = new System.Drawing.Point(4, 203);
			this.notificationLabel.Name = "notificationLabel";
			this.notificationLabel.Size = new System.Drawing.Size(233, 39);
			this.notificationLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// rodDiameterIdLabel
			// 
			this.rodDiameterIdLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.rodDiameterIdLabel.Location = new System.Drawing.Point(110, 57);
			this.rodDiameterIdLabel.Name = "rodDiameterIdLabel";
			this.rodDiameterIdLabel.Size = new System.Drawing.Size(130, 20);
			this.rodDiameterIdLabel.Text = "Диаметр штанг, мм";
			// 
			// rodDiameterIdComboBox
			// 
			this.rodDiameterIdComboBox.Location = new System.Drawing.Point(109, 80);
			this.rodDiameterIdComboBox.Name = "rodDiameterIdComboBox";
			this.rodDiameterIdComboBox.Size = new System.Drawing.Size(99, 22);
			this.rodDiameterIdComboBox.TabIndex = 12;
			// 
			// pumpIdLabel
			// 
			this.pumpIdLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.pumpIdLabel.Location = new System.Drawing.Point(109, 104);
			this.pumpIdLabel.Name = "pumpIdLabel";
			this.pumpIdLabel.Size = new System.Drawing.Size(127, 20);
			this.pumpIdLabel.Text = "Тип насоса";
			// 
			// pumpIdComboBox
			// 
			this.pumpIdComboBox.Location = new System.Drawing.Point(110, 127);
			this.pumpIdComboBox.Name = "pumpIdComboBox";
			this.pumpIdComboBox.Size = new System.Drawing.Size(100, 22);
			this.pumpIdComboBox.TabIndex = 14;
			// 
			// RepairForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(240, 268);
			this.Controls.Add(this.pumpIdComboBox);
			this.Controls.Add(this.pumpIdLabel);
			this.Controls.Add(this.rodDiameterIdComboBox);
			this.Controls.Add(this.rodDiameterIdLabel);
			this.Controls.Add(this.notificationLabel);
			this.Controls.Add(this.createRepairButton);
			this.Controls.Add(this.tubeDiameterIdComboBox);
			this.Controls.Add(this.tubeDiameterIdLabel);
			this.Controls.Add(this.ogpwLabel);
			this.Controls.Add(this.ogpwTextBox);
			this.Controls.Add(this.cjpTextBox);
			this.Controls.Add(this.cjpLabel);
			this.Controls.Add(this.oilwellNumberTextBox);
			this.Controls.Add(this.oilwellNumberLabel);
			this.Menu = this.mainMenu1;
			this.Name = "RepairForm";
			this.Text = "NewRepair";
			this.Load += new System.EventHandler(this.RepairForm_Load);
			this.LostFocus += new System.EventHandler(this.RepairForm_LostFocus);
			this.Closing += new System.ComponentModel.CancelEventHandler(this.RepairForm_Closing);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ogpwLabel;
        private System.Windows.Forms.TextBox ogpwTextBox;
        private System.Windows.Forms.TextBox cjpTextBox;
        private System.Windows.Forms.Label cjpLabel;
        private System.Windows.Forms.TextBox oilwellNumberTextBox;
        private System.Windows.Forms.Label oilwellNumberLabel;
        private System.Windows.Forms.ComboBox tubeDiameterIdComboBox;
        private System.Windows.Forms.Label tubeDiameterIdLabel;
        private Microsoft.WindowsCE.Forms.Notification notification;
        private System.Windows.Forms.Button createRepairButton;
		private System.Windows.Forms.Label notificationLabel;
		private System.Windows.Forms.Label rodDiameterIdLabel;
		private System.Windows.Forms.ComboBox rodDiameterIdComboBox;
		private System.Windows.Forms.Label pumpIdLabel;
		private System.Windows.Forms.ComboBox pumpIdComboBox;
    }
}