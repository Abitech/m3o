namespace RFID_UHF_Net
{
    partial class TagsOperation
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
            this.readTag = new System.Windows.Forms.Button();
            this.epcLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tubesNumberT = new System.Windows.Forms.TextBox();
            this.acceptShipping = new System.Windows.Forms.Button();
            this.tubesLengthT = new System.Windows.Forms.TextBox();
            this.districtIdT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.declineOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // readTag
            // 
            this.readTag.Location = new System.Drawing.Point(4, 36);
            this.readTag.Name = "readTag";
            this.readTag.Size = new System.Drawing.Size(233, 20);
            this.readTag.TabIndex = 0;
            this.readTag.Text = "Считать транспортную метку";
            this.readTag.Click += new System.EventHandler(this.button1_Click);
            // 
            // epcLabel
            // 
            this.epcLabel.Location = new System.Drawing.Point(4, 13);
            this.epcLabel.Name = "epcLabel";
            this.epcLabel.Size = new System.Drawing.Size(233, 20);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "Количество труб";
            // 
            // tubesNumberT
            // 
            this.tubesNumberT.Location = new System.Drawing.Point(4, 176);
            this.tubesNumberT.Name = "tubesNumberT";
            this.tubesNumberT.Size = new System.Drawing.Size(100, 21);
            this.tubesNumberT.TabIndex = 14;
            // 
            // acceptShipping
            // 
            this.acceptShipping.Location = new System.Drawing.Point(4, 203);
            this.acceptShipping.Name = "acceptShipping";
            this.acceptShipping.Size = new System.Drawing.Size(100, 20);
            this.acceptShipping.TabIndex = 13;
            this.acceptShipping.Text = "Принять";
            this.acceptShipping.Click += new System.EventHandler(this.acceptShipping_Click);
            // 
            // tubesLengthT
            // 
            this.tubesLengthT.Location = new System.Drawing.Point(4, 129);
            this.tubesLengthT.Name = "tubesLengthT";
            this.tubesLengthT.Size = new System.Drawing.Size(100, 21);
            this.tubesLengthT.TabIndex = 12;
            // 
            // districtIdT
            // 
            this.districtIdT.Location = new System.Drawing.Point(4, 82);
            this.districtIdT.Name = "districtIdT";
            this.districtIdT.Size = new System.Drawing.Size(100, 21);
            this.districtIdT.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "Подвеска, м";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "№ скважины";
            // 
            // declineOrder
            // 
            this.declineOrder.Location = new System.Drawing.Point(110, 203);
            this.declineOrder.Name = "declineOrder";
            this.declineOrder.Size = new System.Drawing.Size(100, 20);
            this.declineOrder.TabIndex = 13;
            this.declineOrder.Text = "Отклонить";
            this.declineOrder.Click += new System.EventHandler(this.declineOrder_Click);
            // 
            // TagsOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tubesNumberT);
            this.Controls.Add(this.declineOrder);
            this.Controls.Add(this.acceptShipping);
            this.Controls.Add(this.tubesLengthT);
            this.Controls.Add(this.districtIdT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.epcLabel);
            this.Controls.Add(this.readTag);
            this.Menu = this.mainMenu1;
            this.Name = "TagsOperation";
            this.Text = "Адресная метка";
            this.Load += new System.EventHandler(this.TagsOperation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button readTag;
        private System.Windows.Forms.Label epcLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tubesNumberT;
        private System.Windows.Forms.Button acceptShipping;
        private System.Windows.Forms.TextBox tubesLengthT;
        private System.Windows.Forms.TextBox districtIdT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button declineOrder;
    }
}