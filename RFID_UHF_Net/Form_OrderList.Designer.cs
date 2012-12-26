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
            this.DistrictId = new System.Windows.Forms.ColumnHeader();
            this.TubesDiameter = new System.Windows.Forms.ColumnHeader();
            this.OrderedTubesAmount = new System.Windows.Forms.ColumnHeader();
            this.ShippedTubesAmount = new System.Windows.Forms.ColumnHeader();
            this.CloseOrder = new System.Windows.Forms.Button();
            this.CancelOrder = new System.Windows.Forms.Button();
            this.AttachWaybill = new System.Windows.Forms.Button();
            this.orderType = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // orderLog
            // 
            this.orderLog.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.orderLog.Columns.Add(this.DistrictId);
            this.orderLog.Columns.Add(this.orderType);
            this.orderLog.Columns.Add(this.TubesDiameter);
            this.orderLog.Columns.Add(this.OrderedTubesAmount);
            this.orderLog.Columns.Add(this.ShippedTubesAmount);
            this.orderLog.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.orderLog.FullRowSelect = true;
            this.orderLog.Location = new System.Drawing.Point(0, 0);
            this.orderLog.Name = "orderLog";
            this.orderLog.Size = new System.Drawing.Size(240, 198);
            this.orderLog.TabIndex = 0;
            this.orderLog.View = System.Windows.Forms.View.Details;
            this.orderLog.ItemActivate += new System.EventHandler(this.orderLog_ItemActivated);
            this.orderLog.SelectedIndexChanged += new System.EventHandler(this.orderLog_SelectedIndexChanged);
            // 
            // DistrictId
            // 
            this.DistrictId.Text = "Ұңғыма нөмірі";
            this.DistrictId.Width = 56;
            // 
            // TubesDiameter
            // 
            this.TubesDiameter.Text = "Диаметр, мм";
            this.TubesDiameter.Width = 66;
            // 
            // OrderedTubesAmount
            // 
            this.OrderedTubesAmount.Text = "Тапсырыс бойынша";
            this.OrderedTubesAmount.Width = 77;
            // 
            // ShippedTubesAmount
            // 
            this.ShippedTubesAmount.Text = "Қабылданған саны";
            this.ShippedTubesAmount.Width = 98;
            // 
            // CloseOrder
            // 
            this.CloseOrder.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.CloseOrder.Location = new System.Drawing.Point(4, 236);
            this.CloseOrder.Name = "CloseOrder";
            this.CloseOrder.Size = new System.Drawing.Size(125, 20);
            this.CloseOrder.TabIndex = 1;
            this.CloseOrder.Text = "Тапсырысты жабу";
            this.CloseOrder.Click += new System.EventHandler(this.complete_Order_Click);
            // 
            // CancelOrder
            // 
            this.CancelOrder.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.CancelOrder.Location = new System.Drawing.Point(135, 236);
            this.CancelOrder.Name = "CancelOrder";
            this.CancelOrder.Size = new System.Drawing.Size(102, 20);
            this.CancelOrder.TabIndex = 2;
            this.CancelOrder.Text = "Отменить заявку";
            this.CancelOrder.Click += new System.EventHandler(this.decline_Order_Click);
            // 
            // AttachWaybill
            // 
            this.AttachWaybill.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.AttachWaybill.Location = new System.Drawing.Point(4, 204);
            this.AttachWaybill.Name = "AttachWaybill";
            this.AttachWaybill.Size = new System.Drawing.Size(236, 26);
            this.AttachWaybill.TabIndex = 3;
            this.AttachWaybill.Text = "Жүкқұжатты тіркеу";
            this.AttachWaybill.Click += new System.EventHandler(this.attach_Waybill_Click);
            // 
            // orderType
            // 
            this.orderType.Text = "Тип заявки";
            this.orderType.Width = 60;
            // 
            // Form_OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.AttachWaybill);
            this.Controls.Add(this.CancelOrder);
            this.Controls.Add(this.CloseOrder);
            this.Controls.Add(this.orderLog);
            this.Menu = this.mainMenu1;
            this.Name = "Form_OrderList";
            this.Text = "Тапсырыстар тізімі";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView orderLog;
        private System.Windows.Forms.ColumnHeader DistrictId;
        private System.Windows.Forms.ColumnHeader TubesDiameter;
        private System.Windows.Forms.ColumnHeader OrderedTubesAmount;
        private System.Windows.Forms.Button CloseOrder;
        private System.Windows.Forms.Button CancelOrder;
        private System.Windows.Forms.Button AttachWaybill;
        private System.Windows.Forms.ColumnHeader ShippedTubesAmount;
        private System.Windows.Forms.ColumnHeader orderType;
    }
}