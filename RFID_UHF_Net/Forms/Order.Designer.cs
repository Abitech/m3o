using com.abitech.rfid;
using System.Windows.Forms;

namespace RFID_UHF_Net.Forms
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
			this.createNewOrderButton = new System.Windows.Forms.Button();
			this.tubesNumberTextBox = new System.Windows.Forms.TextBox();
			this.tubesNumberLabel = new System.Windows.Forms.Label();
			this.orderTypeIdLabel = new System.Windows.Forms.Label();
			this.orderTypeIdComboBox = new System.Windows.Forms.ComboBox();
			this.approachIdLabel = new System.Windows.Forms.Label();
			this.orderReasonIdComboBox = new System.Windows.Forms.ComboBox();
			this.orderReasonIdLabel = new System.Windows.Forms.Label();
			this.approachIdComboBox = new System.Windows.Forms.ComboBox();
			this.dateExpectedLabel = new System.Windows.Forms.Label();
			this.notification = new Microsoft.WindowsCE.Forms.Notification();
			this.dateExpectedDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.repairsComboBox = new System.Windows.Forms.ComboBox();
			this.notificationLabel = new System.Windows.Forms.Label();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.SuspendLayout();
			// 
			// createNewOrderButton
			// 
			this.createNewOrderButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.createNewOrderButton.Location = new System.Drawing.Point(3, 245);
			this.createNewOrderButton.Name = "createNewOrderButton";
			this.createNewOrderButton.Size = new System.Drawing.Size(234, 20);
			this.createNewOrderButton.TabIndex = 7;
			this.createNewOrderButton.Text = "Отправить заявку";
			this.createNewOrderButton.Click += new System.EventHandler(this.CreateNewOrder_Click);
			// 
			// tubesNumberTextBox
			// 
			this.tubesNumberTextBox.Location = new System.Drawing.Point(3, 101);
			this.tubesNumberTextBox.Name = "tubesNumberTextBox";
			this.tubesNumberTextBox.Size = new System.Drawing.Size(100, 21);
			this.tubesNumberTextBox.TabIndex = 4;
			// 
			// tubesNumberLabel
			// 
			this.tubesNumberLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.tubesNumberLabel.Location = new System.Drawing.Point(5, 78);
			this.tubesNumberLabel.Name = "tubesNumberLabel";
			this.tubesNumberLabel.Size = new System.Drawing.Size(100, 20);
			this.tubesNumberLabel.Text = "Кол-во, шт";
			// 
			// orderTypeIdLabel
			// 
			this.orderTypeIdLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.orderTypeIdLabel.Location = new System.Drawing.Point(5, 30);
			this.orderTypeIdLabel.Name = "orderTypeIdLabel";
			this.orderTypeIdLabel.Size = new System.Drawing.Size(128, 20);
			this.orderTypeIdLabel.Text = "Тип заявки";
			// 
			// orderTypeIdComboBox
			// 
			this.orderTypeIdComboBox.BackColor = System.Drawing.Color.White;
			this.orderTypeIdComboBox.Location = new System.Drawing.Point(3, 53);
			this.orderTypeIdComboBox.Name = "orderTypeIdComboBox";
			this.orderTypeIdComboBox.Size = new System.Drawing.Size(100, 22);
			this.orderTypeIdComboBox.TabIndex = 2;
			// 
			// approachIdLabel
			// 
			this.approachIdLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.approachIdLabel.Location = new System.Drawing.Point(3, 125);
			this.approachIdLabel.Name = "approachIdLabel";
			this.approachIdLabel.Size = new System.Drawing.Size(130, 20);
			this.approachIdLabel.Text = "Подъезд";
			// 
			// orderReasonIdComboBox
			// 
			this.orderReasonIdComboBox.Location = new System.Drawing.Point(109, 53);
			this.orderReasonIdComboBox.Name = "orderReasonIdComboBox";
			this.orderReasonIdComboBox.Size = new System.Drawing.Size(128, 22);
			this.orderReasonIdComboBox.TabIndex = 3;
			// 
			// orderReasonIdLabel
			// 
			this.orderReasonIdLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.orderReasonIdLabel.Location = new System.Drawing.Point(111, 30);
			this.orderReasonIdLabel.Name = "orderReasonIdLabel";
			this.orderReasonIdLabel.Size = new System.Drawing.Size(126, 20);
			this.orderReasonIdLabel.Text = "Основание";
			// 
			// approachIdComboBox
			// 
			this.approachIdComboBox.Location = new System.Drawing.Point(3, 148);
			this.approachIdComboBox.Name = "approachIdComboBox";
			this.approachIdComboBox.Size = new System.Drawing.Size(234, 22);
			this.approachIdComboBox.TabIndex = 6;
			// 
			// dateExpectedLabel
			// 
			this.dateExpectedLabel.Location = new System.Drawing.Point(111, 78);
			this.dateExpectedLabel.Name = "dateExpectedLabel";
			this.dateExpectedLabel.Size = new System.Drawing.Size(126, 20);
			this.dateExpectedLabel.Text = "Плановое время";
			// 
			// notification
			// 
			this.notification.Text = "";
			// 
			// dateExpectedDateTimePicker
			// 
			this.dateExpectedDateTimePicker.CustomFormat = "yyyy";
			this.dateExpectedDateTimePicker.Location = new System.Drawing.Point(109, 100);
			this.dateExpectedDateTimePicker.Name = "dateExpectedDateTimePicker";
			this.dateExpectedDateTimePicker.Size = new System.Drawing.Size(128, 22);
			this.dateExpectedDateTimePicker.TabIndex = 5;
			// 
			// repairsComboBox
			// 
			this.repairsComboBox.Location = new System.Drawing.Point(3, 3);
			this.repairsComboBox.Name = "repairsComboBox";
			this.repairsComboBox.Size = new System.Drawing.Size(234, 22);
			this.repairsComboBox.TabIndex = 1;
			// 
			// notificationLabel
			// 
			this.notificationLabel.Location = new System.Drawing.Point(3, 177);
			this.notificationLabel.Name = "notificationLabel";
			this.notificationLabel.Size = new System.Drawing.Size(234, 65);
			this.notificationLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createNewOrderButton;
        private System.Windows.Forms.TextBox tubesNumberTextBox;
        private System.Windows.Forms.Label tubesNumberLabel;
        private System.Windows.Forms.Label orderTypeIdLabel;
        private System.Windows.Forms.ComboBox orderTypeIdComboBox;
        private System.Windows.Forms.Label approachIdLabel;
        private System.Windows.Forms.ComboBox orderReasonIdComboBox;
        private System.Windows.Forms.Label orderReasonIdLabel;
        private System.Windows.Forms.ComboBox approachIdComboBox;
        private System.Windows.Forms.Label dateExpectedLabel;
        private Microsoft.WindowsCE.Forms.Notification notification;
        private System.Windows.Forms.DateTimePicker dateExpectedDateTimePicker;
        private ComboBox repairsComboBox;
        private Label notificationLabel;
		private MainMenu mainMenu1;
    }
}