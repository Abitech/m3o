namespace RFID_UHF_Net
{
    partial class Form_Setting
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
            this.radioButton_ETSI_302208 = new System.Windows.Forms.RadioButton();
            this.radioButton_FCC_US = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton_Disable = new System.Windows.Forms.RadioButton();
            this.radioButton_Enable = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton_ETSI_302208
            // 
            this.radioButton_ETSI_302208.Location = new System.Drawing.Point(8, 12);
            this.radioButton_ETSI_302208.Name = "radioButton_ETSI_302208";
            this.radioButton_ETSI_302208.Size = new System.Drawing.Size(100, 23);
            this.radioButton_ETSI_302208.TabIndex = 0;
            this.radioButton_ETSI_302208.Text = "ETSI_302208";
            this.radioButton_ETSI_302208.CheckedChanged += new System.EventHandler(this.radioButton_ETSI_302208_CheckedChanged);
            // 
            // radioButton_FCC_US
            // 
            this.radioButton_FCC_US.Location = new System.Drawing.Point(8, 41);
            this.radioButton_FCC_US.Name = "radioButton_FCC_US";
            this.radioButton_FCC_US.Size = new System.Drawing.Size(100, 23);
            this.radioButton_FCC_US.TabIndex = 2;
            this.radioButton_FCC_US.Text = "FCC_US";
            this.radioButton_FCC_US.CheckedChanged += new System.EventHandler(this.radioButton_FCC_US_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.radioButton_FCC_US);
            this.panel1.Controls.Add(this.radioButton_ETSI_302208);
            this.panel1.Location = new System.Drawing.Point(6, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 80);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(5, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.Text = "SET RF Regulations";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(1, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 24);
            this.label2.Text = "Setting";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.Text = "Enable Sound";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.radioButton_Disable);
            this.panel2.Controls.Add(this.radioButton_Enable);
            this.panel2.Location = new System.Drawing.Point(7, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 31);
            // 
            // radioButton_Disable
            // 
            this.radioButton_Disable.Location = new System.Drawing.Point(97, 4);
            this.radioButton_Disable.Name = "radioButton_Disable";
            this.radioButton_Disable.Size = new System.Drawing.Size(100, 23);
            this.radioButton_Disable.TabIndex = 1;
            this.radioButton_Disable.Text = "Disable";
            // 
            // radioButton_Enable
            // 
            this.radioButton_Enable.Location = new System.Drawing.Point(8, 4);
            this.radioButton_Enable.Name = "radioButton_Enable";
            this.radioButton_Enable.Size = new System.Drawing.Size(83, 23);
            this.radioButton_Enable.TabIndex = 0;
            this.radioButton_Enable.Text = "Enable";
            // 
            // Form_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "Form_Setting";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Form_Setting_Load);
            this.Closed += new System.EventHandler(this.Form_RF_Closed);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_ETSI_302208;
        private System.Windows.Forms.RadioButton radioButton_FCC_US;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton_Disable;
        private System.Windows.Forms.RadioButton radioButton_Enable;
    }
}