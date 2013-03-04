namespace RFID_UHF_Net.Forms
{
	partial class OrdersForm
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
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.ordersListView = new System.Windows.Forms.ListView();
			this.oilwellNumberColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.orderType = new System.Windows.Forms.ColumnHeader();
			this.tubeDiameterColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.orderedTubesAmountColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.shippedTubesAmountColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.cancelOrderButton = new System.Windows.Forms.Button();
			this.attachWaybillButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ordersListView
			// 
			this.ordersListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.ordersListView.Columns.Add(this.oilwellNumberColumnHeader);
			this.ordersListView.Columns.Add(this.orderType);
			this.ordersListView.Columns.Add(this.tubeDiameterColumnHeader);
			this.ordersListView.Columns.Add(this.orderedTubesAmountColumnHeader);
			this.ordersListView.Columns.Add(this.shippedTubesAmountColumnHeader);
			this.ordersListView.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.ordersListView.FullRowSelect = true;
			listViewItem1.Text = "00-00-0000";
			listViewItem1.SubItems.Add("Доставка НКТ");
			listViewItem1.SubItems.Add("73 выс");
			listViewItem1.SubItems.Add("100");
			listViewItem1.SubItems.Add("100");
			this.ordersListView.Items.Add(listViewItem1);
			this.ordersListView.Location = new System.Drawing.Point(0, 0);
			this.ordersListView.Name = "ordersListView";
			this.ordersListView.Size = new System.Drawing.Size(240, 207);
			this.ordersListView.TabIndex = 0;
			this.ordersListView.View = System.Windows.Forms.View.Details;
			// 
			// oilwellNumberColumnHeader
			// 
			this.oilwellNumberColumnHeader.Text = "Скважина";
			this.oilwellNumberColumnHeader.Width = 90;
			// 
			// orderType
			// 
			this.orderType.Text = "Тип заявки";
			this.orderType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.orderType.Width = 95;
			// 
			// tubeDiameterColumnHeader
			// 
			this.tubeDiameterColumnHeader.Text = "ø";
			this.tubeDiameterColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tubeDiameterColumnHeader.Width = 54;
			// 
			// orderedTubesAmountColumnHeader
			// 
			this.orderedTubesAmountColumnHeader.Text = "Тапсырыс бойынша";
			this.orderedTubesAmountColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.orderedTubesAmountColumnHeader.Width = 77;
			// 
			// shippedTubesAmountColumnHeader
			// 
			this.shippedTubesAmountColumnHeader.Text = "Қабылданған саны";
			this.shippedTubesAmountColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.shippedTubesAmountColumnHeader.Width = 98;
			// 
			// cancelOrderButton
			// 
			this.cancelOrderButton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.cancelOrderButton.Location = new System.Drawing.Point(135, 245);
			this.cancelOrderButton.Name = "cancelOrderButton";
			this.cancelOrderButton.Size = new System.Drawing.Size(102, 20);
			this.cancelOrderButton.TabIndex = 2;
			this.cancelOrderButton.Text = "Отменить заявку";
			this.cancelOrderButton.Click += new System.EventHandler(this.decline_Order_Click);
			// 
			// attachWaybillButton
			// 
			this.attachWaybillButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.attachWaybillButton.Location = new System.Drawing.Point(3, 213);
			this.attachWaybillButton.Name = "attachWaybillButton";
			this.attachWaybillButton.Size = new System.Drawing.Size(234, 26);
			this.attachWaybillButton.TabIndex = 3;
			this.attachWaybillButton.Text = "Прикрепить ТТН";
			this.attachWaybillButton.Click += new System.EventHandler(this.attach_Waybill_Click);
			// 
			// OrdersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(240, 268);
			this.Controls.Add(this.attachWaybillButton);
			this.Controls.Add(this.cancelOrderButton);
			this.Controls.Add(this.ordersListView);
			this.Menu = this.mainMenu1;
			this.Name = "OrdersForm";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ordersListView;
        private System.Windows.Forms.ColumnHeader oilwellNumberColumnHeader;
        private System.Windows.Forms.ColumnHeader tubeDiameterColumnHeader;
		private System.Windows.Forms.ColumnHeader orderedTubesAmountColumnHeader;
        private System.Windows.Forms.Button cancelOrderButton;
        private System.Windows.Forms.Button attachWaybillButton;
        private System.Windows.Forms.ColumnHeader shippedTubesAmountColumnHeader;
        private System.Windows.Forms.ColumnHeader orderType;
    }
}