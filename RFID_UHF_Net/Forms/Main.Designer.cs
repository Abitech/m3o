namespace RFID_UHF_Net.Forms
{
    partial class MainForm
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
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.newOrderButton = new System.Windows.Forms.Button();
			this.orderListButton = new System.Windows.Forms.Button();
			this.languageSelectorKzRadioButton = new System.Windows.Forms.RadioButton();
			this.languageSelectorRuRadioButton = new System.Windows.Forms.RadioButton();
			this.testWaybillForm = new System.Windows.Forms.Button();
			this.teamNumberLabel = new System.Windows.Forms.Label();
			this.newRepairButton = new System.Windows.Forms.Button();
			this.newActButton = new System.Windows.Forms.Button();
			this.notificationLabel = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.titleLabel = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.getDeviceListButton = new System.Windows.Forms.Button();
			this.deviceListComboBox = new System.Windows.Forms.ComboBox();
			this.requestDeviceDescriptionButton = new System.Windows.Forms.Button();
			this.requestNewDeviceKeyResultLabel = new System.Windows.Forms.Label();
			this.requestNewDeviceKeyResultButton = new System.Windows.Forms.Button();
			this.maintenanceLabel = new System.Windows.Forms.Label();
			this.readMasterCardResultButton = new System.Windows.Forms.Button();
			this.serverLocationUrlTextBox = new System.Windows.Forms.TextBox();
			this.getDeviceDescriptionTimer = new System.Windows.Forms.Timer();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.Add(this.menuItem1);
			// 
			// menuItem1
			// 
			this.menuItem1.Text = "Версия 1.5";
			// 
			// newOrderButton
			// 
			this.newOrderButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.newOrderButton.Location = new System.Drawing.Point(3, 81);
			this.newOrderButton.Name = "newOrderButton";
			this.newOrderButton.Size = new System.Drawing.Size(231, 22);
			this.newOrderButton.TabIndex = 2;
			this.newOrderButton.Text = "Новая заявка";
			this.newOrderButton.Click += new System.EventHandler(this.OrderForm_Click);
			// 
			// orderListButton
			// 
			this.orderListButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.orderListButton.Location = new System.Drawing.Point(3, 135);
			this.orderListButton.Name = "orderListButton";
			this.orderListButton.Size = new System.Drawing.Size(231, 20);
			this.orderListButton.TabIndex = 4;
			this.orderListButton.Text = "Список заявок";
			this.orderListButton.Click += new System.EventHandler(this.OrdersForm_Click);
			// 
			// languageSelectorKzRadioButton
			// 
			this.languageSelectorKzRadioButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.languageSelectorKzRadioButton.Location = new System.Drawing.Point(9, 188);
			this.languageSelectorKzRadioButton.Name = "languageSelectorKzRadioButton";
			this.languageSelectorKzRadioButton.Size = new System.Drawing.Size(77, 20);
			this.languageSelectorKzRadioButton.TabIndex = 9;
			this.languageSelectorKzRadioButton.Text = "Қазақ";
			this.languageSelectorKzRadioButton.Click += new System.EventHandler(this.LanguageSelectorKz_CheckedChanged);
			// 
			// languageSelectorRuRadioButton
			// 
			this.languageSelectorRuRadioButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.languageSelectorRuRadioButton.Location = new System.Drawing.Point(9, 214);
			this.languageSelectorRuRadioButton.Name = "languageSelectorRuRadioButton";
			this.languageSelectorRuRadioButton.Size = new System.Drawing.Size(77, 20);
			this.languageSelectorRuRadioButton.TabIndex = 10;
			this.languageSelectorRuRadioButton.Text = "Русский";
			this.languageSelectorRuRadioButton.Click += new System.EventHandler(this.LanguageSelectorRu_CheckedChanged);
			// 
			// testWaybillForm
			// 
			this.testWaybillForm.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.testWaybillForm.Location = new System.Drawing.Point(2, 161);
			this.testWaybillForm.Name = "testWaybillForm";
			this.testWaybillForm.Size = new System.Drawing.Size(231, 20);
			this.testWaybillForm.TabIndex = 5;
			this.testWaybillForm.Text = "ТТН";
			this.testWaybillForm.Click += new System.EventHandler(this.TestWaybillForm_Click);
			// 
			// teamNumberLabel
			// 
			this.teamNumberLabel.Location = new System.Drawing.Point(0, 0);
			this.teamNumberLabel.Name = "teamNumberLabel";
			this.teamNumberLabel.Size = new System.Drawing.Size(100, 20);
			// 
			// newRepairButton
			// 
			this.newRepairButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.newRepairButton.Location = new System.Drawing.Point(3, 53);
			this.newRepairButton.Name = "newRepairButton";
			this.newRepairButton.Size = new System.Drawing.Size(231, 22);
			this.newRepairButton.TabIndex = 1;
			this.newRepairButton.Text = "Новый ремонт";
			this.newRepairButton.Click += new System.EventHandler(this.RepairForm_Click);
			// 
			// newActButton
			// 
			this.newActButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.newActButton.Location = new System.Drawing.Point(2, 109);
			this.newActButton.Name = "newActButton";
			this.newActButton.Size = new System.Drawing.Size(231, 20);
			this.newActButton.TabIndex = 3;
			this.newActButton.Text = "Новый акт";
			this.newActButton.Click += new System.EventHandler(this.ActFormButton_Click);
			// 
			// notificationLabel
			// 
			this.notificationLabel.Location = new System.Drawing.Point(92, 188);
			this.notificationLabel.Name = "notificationLabel";
			this.notificationLabel.Size = new System.Drawing.Size(145, 54);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(240, 265);
			this.tabControl1.TabIndex = 11;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.titleLabel);
			this.tabPage1.Controls.Add(this.newRepairButton);
			this.tabPage1.Controls.Add(this.notificationLabel);
			this.tabPage1.Controls.Add(this.newOrderButton);
			this.tabPage1.Controls.Add(this.newActButton);
			this.tabPage1.Controls.Add(this.orderListButton);
			this.tabPage1.Controls.Add(this.languageSelectorKzRadioButton);
			this.tabPage1.Controls.Add(this.languageSelectorRuRadioButton);
			this.tabPage1.Controls.Add(this.testWaybillForm);
			this.tabPage1.Location = new System.Drawing.Point(0, 0);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(240, 242);
			// 
			// titleLabel
			// 
			this.titleLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.titleLabel.Location = new System.Drawing.Point(4, 4);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(229, 40);
			this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.getDeviceListButton);
			this.tabPage2.Controls.Add(this.deviceListComboBox);
			this.tabPage2.Controls.Add(this.requestDeviceDescriptionButton);
			this.tabPage2.Controls.Add(this.requestNewDeviceKeyResultLabel);
			this.tabPage2.Controls.Add(this.requestNewDeviceKeyResultButton);
			this.tabPage2.Controls.Add(this.maintenanceLabel);
			this.tabPage2.Controls.Add(this.readMasterCardResultButton);
			this.tabPage2.Controls.Add(this.serverLocationUrlTextBox);
			this.tabPage2.Location = new System.Drawing.Point(0, 0);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(240, 242);
			this.tabPage2.Text = "Обслуживание";
			// 
			// getDeviceListButton
			// 
			this.getDeviceListButton.Enabled = false;
			this.getDeviceListButton.Location = new System.Drawing.Point(4, 136);
			this.getDeviceListButton.Name = "getDeviceListButton";
			this.getDeviceListButton.Size = new System.Drawing.Size(231, 20);
			this.getDeviceListButton.TabIndex = 13;
			this.getDeviceListButton.Text = "Получить список бригад";
			this.getDeviceListButton.Click += new System.EventHandler(this.getDeviceListButton_Click);
			// 
			// deviceListComboBox
			// 
			this.deviceListComboBox.Location = new System.Drawing.Point(4, 108);
			this.deviceListComboBox.Name = "deviceListComboBox";
			this.deviceListComboBox.Size = new System.Drawing.Size(231, 22);
			this.deviceListComboBox.TabIndex = 12;
			// 
			// requestDeviceDescriptionButton
			// 
			this.requestDeviceDescriptionButton.Location = new System.Drawing.Point(4, 188);
			this.requestDeviceDescriptionButton.Name = "requestDeviceDescriptionButton";
			this.requestDeviceDescriptionButton.Size = new System.Drawing.Size(231, 20);
			this.requestDeviceDescriptionButton.TabIndex = 9;
			this.requestDeviceDescriptionButton.Text = "Обновить номер бригады";
			this.requestDeviceDescriptionButton.Click += new System.EventHandler(this.requestDeviceDescriptionButton_Click);
			// 
			// requestNewDeviceKeyResultLabel
			// 
			this.requestNewDeviceKeyResultLabel.Location = new System.Drawing.Point(3, 135);
			this.requestNewDeviceKeyResultLabel.Name = "requestNewDeviceKeyResultLabel";
			this.requestNewDeviceKeyResultLabel.Size = new System.Drawing.Size(231, 20);
			// 
			// requestNewDeviceKeyResultButton
			// 
			this.requestNewDeviceKeyResultButton.Enabled = false;
			this.requestNewDeviceKeyResultButton.Location = new System.Drawing.Point(4, 162);
			this.requestNewDeviceKeyResultButton.Name = "requestNewDeviceKeyResultButton";
			this.requestNewDeviceKeyResultButton.Size = new System.Drawing.Size(231, 20);
			this.requestNewDeviceKeyResultButton.TabIndex = 7;
			this.requestNewDeviceKeyResultButton.Text = "Запросить новый ключ";
			this.requestNewDeviceKeyResultButton.Click += new System.EventHandler(this.requestNewDeviceKeyResultButton_Click);
			// 
			// maintenanceLabel
			// 
			this.maintenanceLabel.Location = new System.Drawing.Point(4, 4);
			this.maintenanceLabel.Name = "maintenanceLabel";
			this.maintenanceLabel.Size = new System.Drawing.Size(233, 48);
			// 
			// readMasterCardResultButton
			// 
			this.readMasterCardResultButton.Location = new System.Drawing.Point(4, 55);
			this.readMasterCardResultButton.Name = "readMasterCardResultButton";
			this.readMasterCardResultButton.Size = new System.Drawing.Size(231, 20);
			this.readMasterCardResultButton.TabIndex = 5;
			this.readMasterCardResultButton.Text = "Считать мастер-карту";
			this.readMasterCardResultButton.Click += new System.EventHandler(this.ReadMasterCardResultButton_Click);
			// 
			// serverLocationUrlTextBox
			// 
			this.serverLocationUrlTextBox.Location = new System.Drawing.Point(4, 81);
			this.serverLocationUrlTextBox.Name = "serverLocationUrlTextBox";
			this.serverLocationUrlTextBox.Size = new System.Drawing.Size(231, 21);
			this.serverLocationUrlTextBox.TabIndex = 4;
			// 
			// getDeviceDescriptionTimer
			// 
			this.getDeviceDescriptionTimer.Interval = 500;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(240, 268);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.teamNumberLabel);
			this.Menu = this.mainMenu1;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "АСКОУ НКТ";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.MainFormClosing);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Button orderListButton;
        private System.Windows.Forms.RadioButton languageSelectorKzRadioButton;
        private System.Windows.Forms.RadioButton languageSelectorRuRadioButton;
        private System.Windows.Forms.Button testWaybillForm;
        private System.Windows.Forms.Label teamNumberLabel;
        private System.Windows.Forms.Button newRepairButton;
		private System.Windows.Forms.Button newActButton;
		private System.Windows.Forms.Label notificationLabel;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.TextBox serverLocationUrlTextBox;
		private System.Windows.Forms.Button readMasterCardResultButton;
		private System.Windows.Forms.Label maintenanceLabel;
		private System.Windows.Forms.Label requestNewDeviceKeyResultLabel;
		private System.Windows.Forms.Button requestNewDeviceKeyResultButton;
		private System.Windows.Forms.Button requestDeviceDescriptionButton;
		private System.Windows.Forms.ComboBox deviceListComboBox;
		private System.Windows.Forms.Button getDeviceListButton;
		private System.Windows.Forms.Timer getDeviceDescriptionTimer;
		private System.Windows.Forms.MenuItem menuItem1;
    }
}