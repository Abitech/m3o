namespace com.abitech.rfid.Forms
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
			this.actTypeIdComboBox = new System.Windows.Forms.ComboBox();
			this.actTypeIdLabel = new System.Windows.Forms.Label();
			this.tubesNumberNewLabel = new System.Windows.Forms.Label();
			this.createActButton = new System.Windows.Forms.Button();
			this.notificationLabel = new System.Windows.Forms.Label();
			this.notification = new Microsoft.WindowsCE.Forms.Notification();
			this.tubesNumberOldTextBox = new System.Windows.Forms.TextBox();
			this.tubesNumberOldLabel = new System.Windows.Forms.Label();
			this.rodNumberNewLabel = new System.Windows.Forms.Label();
			this.rodNumberNewTextBox = new System.Windows.Forms.TextBox();
			this.rodNumberOldTextBox = new System.Windows.Forms.TextBox();
			this.rodNumberOldLabel = new System.Windows.Forms.Label();
			this.pumpTextLabel = new System.Windows.Forms.Label();
			this.pumpNewRadioButton = new System.Windows.Forms.RadioButton();
			this.pumpOldRadioButton = new System.Windows.Forms.RadioButton();
			this.tubesNumberNewTextBox = new System.Windows.Forms.TextBox();
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
			// actTypeIdComboBox
			// 
			this.actTypeIdComboBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.actTypeIdComboBox.Location = new System.Drawing.Point(123, 33);
			this.actTypeIdComboBox.Name = "actTypeIdComboBox";
			this.actTypeIdComboBox.Size = new System.Drawing.Size(113, 23);
			this.actTypeIdComboBox.TabIndex = 1;
			// 
			// actTypeIdLabel
			// 
			this.actTypeIdLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.actTypeIdLabel.Location = new System.Drawing.Point(4, 33);
			this.actTypeIdLabel.Name = "actTypeIdLabel";
			this.actTypeIdLabel.Size = new System.Drawing.Size(113, 20);
			this.actTypeIdLabel.Text = "Вид акта";
			// 
			// tubesNumberNewLabel
			// 
			this.tubesNumberNewLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.tubesNumberNewLabel.Location = new System.Drawing.Point(4, 59);
			this.tubesNumberNewLabel.Name = "tubesNumberNewLabel";
			this.tubesNumberNewLabel.Size = new System.Drawing.Size(147, 20);
			this.tubesNumberNewLabel.Text = "Новые НКТ";
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
			this.notificationLabel.Location = new System.Drawing.Point(3, 205);
			this.notificationLabel.Name = "notificationLabel";
			this.notificationLabel.Size = new System.Drawing.Size(234, 37);
			this.notificationLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// notification
			// 
			this.notification.Text = "";
			// 
			// tubesNumberOldTextBox
			// 
			this.tubesNumberOldTextBox.Location = new System.Drawing.Point(123, 82);
			this.tubesNumberOldTextBox.Name = "tubesNumberOldTextBox";
			this.tubesNumberOldTextBox.Size = new System.Drawing.Size(113, 21);
			this.tubesNumberOldTextBox.TabIndex = 8;
			this.tubesNumberOldTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// tubesNumberOldLabel
			// 
			this.tubesNumberOldLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.tubesNumberOldLabel.Location = new System.Drawing.Point(123, 59);
			this.tubesNumberOldLabel.Name = "tubesNumberOldLabel";
			this.tubesNumberOldLabel.Size = new System.Drawing.Size(117, 20);
			this.tubesNumberOldLabel.Text = "Б/у НКТ";
			// 
			// rodNumberNewLabel
			// 
			this.rodNumberNewLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.rodNumberNewLabel.Location = new System.Drawing.Point(4, 106);
			this.rodNumberNewLabel.Name = "rodNumberNewLabel";
			this.rodNumberNewLabel.Size = new System.Drawing.Size(147, 20);
			this.rodNumberNewLabel.Text = "Новые штанги";
			// 
			// rodNumberNewTextBox
			// 
			this.rodNumberNewTextBox.Location = new System.Drawing.Point(4, 129);
			this.rodNumberNewTextBox.Name = "rodNumberNewTextBox";
			this.rodNumberNewTextBox.Size = new System.Drawing.Size(113, 21);
			this.rodNumberNewTextBox.TabIndex = 11;
			// 
			// rodNumberOldTextBox
			// 
			this.rodNumberOldTextBox.Location = new System.Drawing.Point(123, 129);
			this.rodNumberOldTextBox.Name = "rodNumberOldTextBox";
			this.rodNumberOldTextBox.Size = new System.Drawing.Size(113, 21);
			this.rodNumberOldTextBox.TabIndex = 12;
			// 
			// rodNumberOldLabel
			// 
			this.rodNumberOldLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.rodNumberOldLabel.Location = new System.Drawing.Point(123, 106);
			this.rodNumberOldLabel.Name = "rodNumberOldLabel";
			this.rodNumberOldLabel.Size = new System.Drawing.Size(117, 20);
			this.rodNumberOldLabel.Text = "Б/у штанги";
			// 
			// pumpTextLabel
			// 
			this.pumpTextLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.pumpTextLabel.Location = new System.Drawing.Point(4, 157);
			this.pumpTextLabel.Name = "pumpTextLabel";
			this.pumpTextLabel.Size = new System.Drawing.Size(114, 20);
			this.pumpTextLabel.Text = "Насос";
			this.pumpTextLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// pumpNewRadioButton
			// 
			this.pumpNewRadioButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.pumpNewRadioButton.Location = new System.Drawing.Point(123, 156);
			this.pumpNewRadioButton.Name = "pumpNewRadioButton";
			this.pumpNewRadioButton.Size = new System.Drawing.Size(111, 20);
			this.pumpNewRadioButton.TabIndex = 15;
			this.pumpNewRadioButton.Text = "Новый";
			// 
			// pumpOldRadioButton
			// 
			this.pumpOldRadioButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.pumpOldRadioButton.Location = new System.Drawing.Point(123, 182);
			this.pumpOldRadioButton.Name = "pumpOldRadioButton";
			this.pumpOldRadioButton.Size = new System.Drawing.Size(113, 20);
			this.pumpOldRadioButton.TabIndex = 16;
			this.pumpOldRadioButton.Text = "Б/у";
			// 
			// tubesNumberNewTextBox
			// 
			this.tubesNumberNewTextBox.Location = new System.Drawing.Point(4, 82);
			this.tubesNumberNewTextBox.Name = "tubesNumberNewTextBox";
			this.tubesNumberNewTextBox.Size = new System.Drawing.Size(113, 21);
			this.tubesNumberNewTextBox.TabIndex = 2;
			this.tubesNumberNewTextBox.TextChanged += new System.EventHandler(this.tubesNumberNewTextBox_TextChanged);
			// 
			// ActForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(240, 268);
			this.Controls.Add(this.pumpOldRadioButton);
			this.Controls.Add(this.pumpNewRadioButton);
			this.Controls.Add(this.pumpTextLabel);
			this.Controls.Add(this.rodNumberOldLabel);
			this.Controls.Add(this.rodNumberOldTextBox);
			this.Controls.Add(this.rodNumberNewTextBox);
			this.Controls.Add(this.rodNumberNewLabel);
			this.Controls.Add(this.tubesNumberOldLabel);
			this.Controls.Add(this.tubesNumberOldTextBox);
			this.Controls.Add(this.notificationLabel);
			this.Controls.Add(this.createActButton);
			this.Controls.Add(this.tubesNumberNewLabel);
			this.Controls.Add(this.actTypeIdLabel);
			this.Controls.Add(this.actTypeIdComboBox);
			this.Controls.Add(this.tubesNumberNewTextBox);
			this.Controls.Add(this.repairsComboBox);
			this.Menu = this.mainMenu1;
			this.Name = "ActForm";

			this.LostFocus += new System.EventHandler(this.ActForm_LostFocus);
			this.Closing += new System.ComponentModel.CancelEventHandler(this.ActForm_Closing);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox repairsComboBox;
		private System.Windows.Forms.ComboBox actTypeIdComboBox;
		private System.Windows.Forms.Label actTypeIdLabel;
		private System.Windows.Forms.Label tubesNumberNewLabel;
		private System.Windows.Forms.Button createActButton;
		private System.Windows.Forms.Label notificationLabel;
		private Microsoft.WindowsCE.Forms.Notification notification;
		private System.Windows.Forms.TextBox tubesNumberOldTextBox;
		private System.Windows.Forms.Label tubesNumberOldLabel;
		private System.Windows.Forms.Label rodNumberNewLabel;
		private System.Windows.Forms.TextBox rodNumberNewTextBox;
		private System.Windows.Forms.TextBox rodNumberOldTextBox;
		private System.Windows.Forms.Label rodNumberOldLabel;
		private System.Windows.Forms.Label pumpTextLabel;
		private System.Windows.Forms.RadioButton pumpNewRadioButton;
		private System.Windows.Forms.RadioButton pumpOldRadioButton;
		private System.Windows.Forms.TextBox tubesNumberNewTextBox;
	}
}