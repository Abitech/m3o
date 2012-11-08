namespace RFID_UHF_Net
{
    partial class Form_OrderList
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
            this.orderLog = new System.Windows.Forms.ListView();
            this.districtId = new System.Windows.Forms.ColumnHeader();
            this.tubesDiameter = new System.Windows.Forms.ColumnHeader();
            this.tubesNumber = new System.Windows.Forms.ColumnHeader();
            this.orderStatus = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orderLog
            // 
            this.orderLog.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.orderLog.Columns.Add(this.districtId);
            this.orderLog.Columns.Add(this.tubesDiameter);
            this.orderLog.Columns.Add(this.tubesNumber);
            this.orderLog.Columns.Add(this.orderStatus);
            this.orderLog.FullRowSelect = true;
            this.orderLog.Location = new System.Drawing.Point(0, 0);
            this.orderLog.Name = "orderLog";
            this.orderLog.Size = new System.Drawing.Size(240, 198);
            this.orderLog.TabIndex = 0;
            this.orderLog.View = System.Windows.Forms.View.Details;
            this.orderLog.ItemActivate += new System.EventHandler(this.orderLog_ItemActivated);
            this.orderLog.SelectedIndexChanged += new System.EventHandler(this.orderLog_SelectedIndexChanged);
            // 
            // districtId
            // 
            this.districtId.Text = "№";
            this.districtId.Width = 38;
            // 
            // tubesDiameter
            // 
            this.tubesDiameter.Text = "Диаметр, мм";
            this.tubesDiameter.Width = 60;
            // 
            // tubesNumber
            // 
            this.tubesNumber.Text = "Кол-во";
            this.tubesNumber.Width = 77;
            // 
            // orderStatus
            // 
            this.orderStatus.Text = "Статус";
            this.orderStatus.Width = 62;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "Закрыть заявку";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 20);
            this.button2.TabIndex = 2;
            this.button2.Text = "Отменить";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(4, 204);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(236, 26);
            this.button3.TabIndex = 3;
            this.button3.Text = "Прикрепить накладную";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form_OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.orderLog);
            this.Menu = this.mainMenu1;
            this.Name = "Form_OrderList";
            this.Text = "Список заявок";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView orderLog;
        private System.Windows.Forms.ColumnHeader districtId;
        private System.Windows.Forms.ColumnHeader tubesDiameter;
        private System.Windows.Forms.ColumnHeader tubesNumber;
        private System.Windows.Forms.ColumnHeader orderStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}