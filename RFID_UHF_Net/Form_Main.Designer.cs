namespace RFID_UHF_Net
{
    partial class Form_Main
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
            this.button_Continue = new System.Windows.Forms.Button();
            this.button_Memory = new System.Windows.Forms.Button();
            this.button_Setting = new System.Windows.Forms.Button();
            this.MakeOrder = new System.Windows.Forms.Button();
            this.OrderList = new System.Windows.Forms.Button();
            this.tracking = new System.Windows.Forms.Button();
            this.networkTimer = new System.Windows.Forms.Timer();
            this.SuspendLayout();
            // 
            // button_Continue
            // 
            this.button_Continue.Location = new System.Drawing.Point(3, 143);
            this.button_Continue.Name = "button_Continue";
            this.button_Continue.Size = new System.Drawing.Size(234, 25);
            this.button_Continue.TabIndex = 2;
            this.button_Continue.Text = "Continuous Read";
            this.button_Continue.Click += new System.EventHandler(this.button_Continue_Click);
            // 
            // button_Memory
            // 
            this.button_Memory.Location = new System.Drawing.Point(3, 168);
            this.button_Memory.Name = "button_Memory";
            this.button_Memory.Size = new System.Drawing.Size(234, 25);
            this.button_Memory.TabIndex = 3;
            this.button_Memory.Text = "Read/Write";
            this.button_Memory.Click += new System.EventHandler(this.button_Memory_Click);
            // 
            // button_Setting
            // 
            this.button_Setting.Location = new System.Drawing.Point(3, 193);
            this.button_Setting.Name = "button_Setting";
            this.button_Setting.Size = new System.Drawing.Size(234, 25);
            this.button_Setting.TabIndex = 4;
            this.button_Setting.Text = "Setting";
            this.button_Setting.Click += new System.EventHandler(this.button_Setting_Click);
            // 
            // MakeOrder
            // 
            this.MakeOrder.Location = new System.Drawing.Point(3, 3);
            this.MakeOrder.Name = "MakeOrder";
            this.MakeOrder.Size = new System.Drawing.Size(234, 22);
            this.MakeOrder.TabIndex = 7;
            this.MakeOrder.Text = "Новая заявка";
            this.MakeOrder.Click += new System.EventHandler(this.MakeOrder_Click);
            // 
            // OrderList
            // 
            this.OrderList.Location = new System.Drawing.Point(3, 31);
            this.OrderList.Name = "OrderList";
            this.OrderList.Size = new System.Drawing.Size(234, 20);
            this.OrderList.TabIndex = 8;
            this.OrderList.Text = "Список заявок";
            this.OrderList.Click += new System.EventHandler(this.OrderList_Click);
            // 
            // tracking
            // 
            this.tracking.Location = new System.Drawing.Point(4, 58);
            this.tracking.Name = "tracking";
            this.tracking.Size = new System.Drawing.Size(233, 20);
            this.tracking.TabIndex = 9;
            this.tracking.Text = "Закрытие заявки";
            this.tracking.Click += new System.EventHandler(this.tracking_Click);
            // 
            // networkTimer
            // 
            this.networkTimer.Interval = 60000;
            this.networkTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.tracking);
            this.Controls.Add(this.OrderList);
            this.Controls.Add(this.MakeOrder);
            this.Controls.Add(this.button_Setting);
            this.Controls.Add(this.button_Memory);
            this.Controls.Add(this.button_Continue);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "Form_Main";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_Main_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Continue;
        private System.Windows.Forms.Button button_Memory;
        private System.Windows.Forms.Button button_Setting;
        private System.Windows.Forms.Button MakeOrder;
        private System.Windows.Forms.Button OrderList;
        private System.Windows.Forms.Button tracking;
        private System.Windows.Forms.Timer networkTimer;
    }
}