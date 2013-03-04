namespace RFID_UHF_Net.Forms
{
	partial class ActForm
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
			this.repairsComboBox = new System.Windows.Forms.ComboBox();
			this.tubesNumberTextBox = new System.Windows.Forms.TextBox();
			this.actTypeIdComboBox = new System.Windows.Forms.ComboBox();
			this.actTypeIdLabel = new System.Windows.Forms.Label();
			this.tubesNumberLabel = new System.Windows.Forms.Label();
			this.createActButton = new System.Windows.Forms.Button();
			this.notificationLabel = new System.Windows.Forms.Label();
			this.notification = new Microsoft.WindowsCE.Forms.Notification();
			this.SuspendLayout();
			// 
			// repairsComboBox
			// 
			this.repairsComboBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.repairsComboBox.Location = new System.Drawing.Point(3, 4);
			this.repairsComboBox.Name = "repairsComboBox";
			this.repairsComboBox.Size = new System.Drawing.Size(234, 23);
			this.repairsComboBox.TabIndex = 0;
			// 
			// tubesNumberTextBox
			// 
			this.tubesNumberTextBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.tubesNumberTextBox.Location = new System.Drawing.Point(4, 104);
			this.tubesNumberTextBox.Name = "tubesNumberTextBox";
			this.tubesNumberTextBox.Size = new System.Drawing.Size(127, 22);
			this.tubesNumberTextBox.TabIndex = 2;
			// 
			// actTypeIdComboBox
			// 
			this.actTypeIdComboBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.actTypeIdComboBox.Location = new System.Drawing.Point(4, 56);
			this.actTypeIdComboBox.Name = "actTypeIdComboBox";
			this.actTypeIdComboBox.Size = new System.Drawing.Size(127, 23);
			this.actTypeIdComboBox.TabIndex = 1;
			// 
			// actTypeIdLabel
			// 
			this.actTypeIdLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.actTypeIdLabel.Location = new System.Drawing.Point(4, 33);
			this.actTypeIdLabel.Name = "actTypeIdLabel";
			this.actTypeIdLabel.Size = new System.Drawing.Size(127, 20);
			this.actTypeIdLabel.Text = "Вид акта";
			// 
			// tubesNumberLabel
			// 
			this.tubesNumberLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.tubesNumberLabel.Location = new System.Drawing.Point(4, 81);
			this.tubesNumberLabel.Name = "tubesNumberLabel";
			this.tubesNumberLabel.Size = new System.Drawing.Size(127, 20);
			this.tubesNumberLabel.Text = "Количество НКТ";
			// 
			// createActButton
			// 
			this.createActButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.createActButton.Location = new System.Drawing.Point(3, 245);
			this.createActButton.Name = "createActButton";
			this.createActButton.Size = new System.Drawing.Size(234, 20);
			this.createActButton.TabIndex = 5;
			this.createActButton.Text = "Отправить акт";
			this.createActButton.Click += new System.EventHandler(this.createActButton_Click);
			// 
			// notificationLabel
			// 
			this.notificationLabel.Location = new System.Drawing.Point(3, 177);
			this.notificationLabel.Name = "notificationLabel";
			this.notificationLabel.Size = new System.Drawing.Size(234, 65);
			this.notificationLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// notification
			// 
			this.notification.Text = "";
			// 
			// ActForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(240, 268);
			this.Controls.Add(this.notificationLabel);
			this.Controls.Add(this.createActButton);
			this.Controls.Add(this.tubesNumberLabel);
			this.Controls.Add(this.actTypeIdLabel);
			this.Controls.Add(this.actTypeIdComboBox);
			this.Controls.Add(this.tubesNumberTextBox);
			this.Controls.Add(this.repairsComboBox);
			this.Menu = this.mainMenu1;
			this.Name = "ActForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox repairsComboBox;
		private System.Windows.Forms.TextBox tubesNumberTextBox;
		private System.Windows.Forms.ComboBox actTypeIdComboBox;
		private System.Windows.Forms.Label actTypeIdLabel;
		private System.Windows.Forms.Label tubesNumberLabel;
		private System.Windows.Forms.Button createActButton;
		private System.Windows.Forms.Label notificationLabel;
		private Microsoft.WindowsCE.Forms.Notification notification;
	}
}