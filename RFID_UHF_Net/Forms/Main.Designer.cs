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
			this.newOrderButton = new System.Windows.Forms.Button();
			this.orderListButton = new System.Windows.Forms.Button();
			this.languageSelectorKzRadioButton = new System.Windows.Forms.RadioButton();
			this.languageSelectorRuRadioButton = new System.Windows.Forms.RadioButton();
			this.testWaybillForm = new System.Windows.Forms.Button();
			this.teamNumberLabel = new System.Windows.Forms.Label();
			this.newRepairButton = new System.Windows.Forms.Button();
			this.newActButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// newOrderButton
			// 
			this.newOrderButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.newOrderButton.Location = new System.Drawing.Point(3, 66);
			this.newOrderButton.Name = "newOrderButton";
			this.newOrderButton.Size = new System.Drawing.Size(231, 22);
			this.newOrderButton.TabIndex = 2;
			this.newOrderButton.Text = "Новая заявка";
			this.newOrderButton.Click += new System.EventHandler(this.OrderForm_Click);
			// 
			// orderListButton
			// 
			this.orderListButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.orderListButton.Location = new System.Drawing.Point(3, 120);
			this.orderListButton.Name = "orderListButton";
			this.orderListButton.Size = new System.Drawing.Size(231, 20);
			this.orderListButton.TabIndex = 4;
			this.orderListButton.Text = "Список заявок";
			this.orderListButton.Click += new System.EventHandler(this.OrdersForm_Click);
			// 
			// languageSelectorKzRadioButton
			// 
			this.languageSelectorKzRadioButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.languageSelectorKzRadioButton.Location = new System.Drawing.Point(3, 213);
			this.languageSelectorKzRadioButton.Name = "languageSelectorKzRadioButton";
			this.languageSelectorKzRadioButton.Size = new System.Drawing.Size(100, 20);
			this.languageSelectorKzRadioButton.TabIndex = 9;
			this.languageSelectorKzRadioButton.Text = "Қазақ";
			this.languageSelectorKzRadioButton.Click += new System.EventHandler(this.LanguageSelectorKz_CheckedChanged);
			// 
			// languageSelectorRuRadioButton
			// 
			this.languageSelectorRuRadioButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.languageSelectorRuRadioButton.Location = new System.Drawing.Point(3, 239);
			this.languageSelectorRuRadioButton.Name = "languageSelectorRuRadioButton";
			this.languageSelectorRuRadioButton.Size = new System.Drawing.Size(100, 20);
			this.languageSelectorRuRadioButton.TabIndex = 10;
			this.languageSelectorRuRadioButton.Text = "Русский";
			this.languageSelectorRuRadioButton.Click += new System.EventHandler(this.LanguageSelectorRu_CheckedChanged);
			// 
			// testWaybillForm
			// 
			this.testWaybillForm.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.testWaybillForm.Location = new System.Drawing.Point(3, 147);
			this.testWaybillForm.Name = "testWaybillForm";
			this.testWaybillForm.Size = new System.Drawing.Size(231, 20);
			this.testWaybillForm.TabIndex = 5;
			this.testWaybillForm.Text = "ТТН";
			this.testWaybillForm.Click += new System.EventHandler(this.TestWaybillForm_Click);
			// 
			// teamNumberLabel
			// 
			this.teamNumberLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
			this.teamNumberLabel.Location = new System.Drawing.Point(0, 0);
			this.teamNumberLabel.Name = "teamNumberLabel";
			this.teamNumberLabel.Size = new System.Drawing.Size(240, 35);
			this.teamNumberLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// newRepairButton
			// 
			this.newRepairButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.newRepairButton.Location = new System.Drawing.Point(3, 38);
			this.newRepairButton.Name = "newRepairButton";
			this.newRepairButton.Size = new System.Drawing.Size(231, 22);
			this.newRepairButton.TabIndex = 1;
			this.newRepairButton.Text = "Новый ремонт";
			this.newRepairButton.Click += new System.EventHandler(this.RepairForm_Click);
			// 
			// newActButton
			// 
			this.newActButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.newActButton.Location = new System.Drawing.Point(3, 94);
			this.newActButton.Name = "newActButton";
			this.newActButton.Size = new System.Drawing.Size(231, 20);
			this.newActButton.TabIndex = 3;
			this.newActButton.Text = "Новый акт";
			this.newActButton.Click += new System.EventHandler(this.ActFormButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(240, 268);
			this.Controls.Add(this.newActButton);
			this.Controls.Add(this.newRepairButton);
			this.Controls.Add(this.teamNumberLabel);
			this.Controls.Add(this.testWaybillForm);
			this.Controls.Add(this.languageSelectorRuRadioButton);
			this.Controls.Add(this.languageSelectorKzRadioButton);
			this.Controls.Add(this.orderListButton);
			this.Controls.Add(this.newOrderButton);
			this.Menu = this.mainMenu1;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "АСКОУ НКТ";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.MainFormClosing);
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
    }
}