using com.abitech.rfid;
using System.Windows.Forms;

namespace com.abitech.rfid.Forms
{
    partial class OrderForm
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
			this.notification = new Microsoft.WindowsCE.Forms.Notification();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.notificationLabel = new System.Windows.Forms.Label();
			this.repairsComboBox = new System.Windows.Forms.ComboBox();
			this.dateExpectedDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.dateExpectedLabel = new System.Windows.Forms.Label();
			this.approachIdComboBox = new System.Windows.Forms.ComboBox();
			this.orderReasonIdLabel = new System.Windows.Forms.Label();
			this.orderReasonIdComboBox = new System.Windows.Forms.ComboBox();
			this.approachIdLabel = new System.Windows.Forms.Label();
			this.orderTypeIdComboBox = new System.Windows.Forms.ComboBox();
			this.orderTypeIdLabel = new System.Windows.Forms.Label();
			this.tubesNumberLabel = new System.Windows.Forms.Label();
			this.tubesNumberTextBox = new System.Windows.Forms.TextBox();
			this.createNewOrderButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// notification
			// 
			this.notification.Text = "";
			// 
			// notificationLabel
			// 
			this.notificationLabel.Location = new System.Drawing.Point(3, 173);
			this.notificationLabel.Name = "notificationLabel";
			this.notificationLabel.Size = new System.Drawing.Size(234, 46);
			this.notificationLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// repairsComboBox
			// 
			this.repairsComboBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.repairsComboBox.Location = new System.Drawing.Point(3, 3);
			this.repairsComboBox.Name = "repairsComboBox";
			this.repairsComboBox.Size = new System.Drawing.Size(234, 23);
			this.repairsComboBox.TabIndex = 23;
			// 
			// dateExpectedDateTimePicker
			// 
			this.dateExpectedDateTimePicker.CustomFormat = "yyyy";
			this.dateExpectedDateTimePicker.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.dateExpectedDateTimePicker.Location = new System.Drawing.Point(3, 97);
			this.dateExpectedDateTimePicker.Name = "dateExpectedDateTimePicker";
			this.dateExpectedDateTimePicker.Size = new System.Drawing.Size(128, 23);
			this.dateExpectedDateTimePicker.TabIndex = 27;
			// 
			// dateExpectedLabel
			// 
			this.dateExpectedLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.dateExpectedLabel.Location = new System.Drawing.Point(3, 75);
			this.dateExpectedLabel.Name = "dateExpectedLabel";
			this.dateExpectedLabel.Size = new System.Drawing.Size(130, 20);
			this.dateExpectedLabel.Text = "Жоспарланған уақыт";
			// 
			// approachIdComboBox
			// 
			this.approachIdComboBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.approachIdComboBox.Location = new System.Drawing.Point(3, 147);
			this.approachIdComboBox.Name = "approachIdComboBox";
			this.approachIdComboBox.Size = new System.Drawing.Size(234, 23);
			this.approachIdComboBox.TabIndex = 28;
			// 
			// orderReasonIdLabel
			// 
			this.orderReasonIdLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.orderReasonIdLabel.Location = new System.Drawing.Point(131, 26);
			this.orderReasonIdLabel.Name = "orderReasonIdLabel";
			this.orderReasonIdLabel.Size = new System.Drawing.Size(106, 20);
			this.orderReasonIdLabel.Text = "Основание";
			// 
			// orderReasonIdComboBox
			// 
			this.orderReasonIdComboBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.orderReasonIdComboBox.Location = new System.Drawing.Point(137, 49);
			this.orderReasonIdComboBox.Name = "orderReasonIdComboBox";
			this.orderReasonIdComboBox.Size = new System.Drawing.Size(100, 23);
			this.orderReasonIdComboBox.TabIndex = 25;
			// 
			// approachIdLabel
			// 
			this.approachIdLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.approachIdLabel.Location = new System.Drawing.Point(3, 124);
			this.approachIdLabel.Name = "approachIdLabel";
			this.approachIdLabel.Size = new System.Drawing.Size(128, 20);
			this.approachIdLabel.Text = "Подъезд";
			// 
			// orderTypeIdComboBox
			// 
			this.orderTypeIdComboBox.BackColor = System.Drawing.Color.White;
			this.orderTypeIdComboBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.orderTypeIdComboBox.Location = new System.Drawing.Point(3, 49);
			this.orderTypeIdComboBox.Name = "orderTypeIdComboBox";
			this.orderTypeIdComboBox.Size = new System.Drawing.Size(128, 23);
			this.orderTypeIdComboBox.TabIndex = 24;
			// 
			// orderTypeIdLabel
			// 
			this.orderTypeIdLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.orderTypeIdLabel.Location = new System.Drawing.Point(3, 26);
			this.orderTypeIdLabel.Name = "orderTypeIdLabel";
			this.orderTypeIdLabel.Size = new System.Drawing.Size(128, 20);
			this.orderTypeIdLabel.Text = "Тип заявки";
			// 
			// tubesNumberLabel
			// 
			this.tubesNumberLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.tubesNumberLabel.Location = new System.Drawing.Point(137, 75);
			this.tubesNumberLabel.Name = "tubesNumberLabel";
			this.tubesNumberLabel.Size = new System.Drawing.Size(100, 20);
			this.tubesNumberLabel.Text = "Кол-во, шт";
			// 
			// tubesNumberTextBox
			// 
			this.tubesNumberTextBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.tubesNumberTextBox.Location = new System.Drawing.Point(137, 98);
			this.tubesNumberTextBox.Name = "tubesNumberTextBox";
			this.tubesNumberTextBox.Size = new System.Drawing.Size(100, 22);
			this.tubesNumberTextBox.TabIndex = 26;
			// 
			// createNewOrderButton
			// 
			this.createNewOrderButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.createNewOrderButton.Location = new System.Drawing.Point(3, 245);
			this.createNewOrderButton.Name = "createNewOrderButton";
			this.createNewOrderButton.Size = new System.Drawing.Size(234, 20);
			this.createNewOrderButton.TabIndex = 32;
			this.createNewOrderButton.Text = "Отправить заявку";
			this.createNewOrderButton.Click += new System.EventHandler(this.CreateNewOrder_Click);
			// 
			// OrderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(240, 268);
			this.Controls.Add(this.notificationLabel);
			this.Controls.Add(this.repairsComboBox);
			this.Controls.Add(this.dateExpectedDateTimePicker);
			this.Controls.Add(this.dateExpectedLabel);
			this.Controls.Add(this.approachIdComboBox);
			this.Controls.Add(this.orderReasonIdLabel);
			this.Controls.Add(this.orderReasonIdComboBox);
			this.Controls.Add(this.approachIdLabel);
			this.Controls.Add(this.orderTypeIdComboBox);
			this.Controls.Add(this.orderTypeIdLabel);
			this.Controls.Add(this.tubesNumberLabel);
			this.Controls.Add(this.tubesNumberTextBox);
			this.Controls.Add(this.createNewOrderButton);
			this.Menu = this.mainMenu1;
			this.Name = "OrderForm";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.OrderForm_Closing);
			this.ResumeLayout(false);

        }

        #endregion

		private Microsoft.WindowsCE.Forms.Notification notification;
		private MainMenu mainMenu1;
		private Label notificationLabel;
		private ComboBox repairsComboBox;
		private DateTimePicker dateExpectedDateTimePicker;
		private Label dateExpectedLabel;
		private ComboBox approachIdComboBox;
		private Label orderReasonIdLabel;
		private ComboBox orderReasonIdComboBox;
		private Label approachIdLabel;
		private ComboBox orderTypeIdComboBox;
		private Label orderTypeIdLabel;
		private Label tubesNumberLabel;
		private TextBox tubesNumberTextBox;
		private Button createNewOrderButton;
    }
}