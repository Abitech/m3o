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
            this.MakeOrder = new System.Windows.Forms.Button();
            this.OrderList = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.OrderList);
            this.Controls.Add(this.MakeOrder);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "Form_Main";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_Main_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MakeOrder;
        private System.Windows.Forms.Button OrderList;
    }
}