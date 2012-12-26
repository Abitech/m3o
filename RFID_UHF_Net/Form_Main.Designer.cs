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
            this.NewOrder = new System.Windows.Forms.Button();
            this.OrderList = new System.Windows.Forms.Button();
            this.LanguageSelectorKz = new System.Windows.Forms.RadioButton();
            this.LanguageSelectorRu = new System.Windows.Forms.RadioButton();
            this.OrderHistory = new System.Windows.Forms.Button();
            this.TestWaybillForm = new System.Windows.Forms.Button();
            this.TeamNumberT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewOrder
            // 
            this.NewOrder.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.NewOrder.Location = new System.Drawing.Point(0, 38);
            this.NewOrder.Name = "NewOrder";
            this.NewOrder.Size = new System.Drawing.Size(234, 22);
            this.NewOrder.TabIndex = 7;
            this.NewOrder.Text = "Жаңа тапсырыс";
            this.NewOrder.Click += new System.EventHandler(this.MakeOrder_Click);
            // 
            // OrderList
            // 
            this.OrderList.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.OrderList.Location = new System.Drawing.Point(0, 66);
            this.OrderList.Name = "OrderList";
            this.OrderList.Size = new System.Drawing.Size(234, 20);
            this.OrderList.TabIndex = 8;
            this.OrderList.Text = "Тапсырыстар тізімі";
            this.OrderList.Click += new System.EventHandler(this.OrderList_Click);
            // 
            // LanguageSelectorKz
            // 
            this.LanguageSelectorKz.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.LanguageSelectorKz.Location = new System.Drawing.Point(3, 213);
            this.LanguageSelectorKz.Name = "LanguageSelectorKz";
            this.LanguageSelectorKz.Size = new System.Drawing.Size(100, 20);
            this.LanguageSelectorKz.TabIndex = 9;
            this.LanguageSelectorKz.Text = "Қазақ";
            this.LanguageSelectorKz.Click += new System.EventHandler(this.LanguageSelectorKz_CheckedChanged);
            // 
            // LanguageSelectorRu
            // 
            this.LanguageSelectorRu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.LanguageSelectorRu.Location = new System.Drawing.Point(3, 239);
            this.LanguageSelectorRu.Name = "LanguageSelectorRu";
            this.LanguageSelectorRu.Size = new System.Drawing.Size(100, 20);
            this.LanguageSelectorRu.TabIndex = 10;
            this.LanguageSelectorRu.Text = "Русский";
            this.LanguageSelectorRu.Click += new System.EventHandler(this.LanguageSelectorRu_CheckedChanged);
            // 
            // OrderHistory
            // 
            this.OrderHistory.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.OrderHistory.Location = new System.Drawing.Point(0, 93);
            this.OrderHistory.Name = "OrderHistory";
            this.OrderHistory.Size = new System.Drawing.Size(234, 20);
            this.OrderHistory.TabIndex = 11;
            this.OrderHistory.Text = "Журнал заявок";
            // 
            // TestWaybillForm
            // 
            this.TestWaybillForm.Location = new System.Drawing.Point(1, 120);
            this.TestWaybillForm.Name = "TestWaybillForm";
            this.TestWaybillForm.Size = new System.Drawing.Size(233, 20);
            this.TestWaybillForm.TabIndex = 12;
            this.TestWaybillForm.Text = "ТТН";
            this.TestWaybillForm.Click += new System.EventHandler(this.TestWaybillForm_Click);
            // 
            // TeamNumberT
            // 
            this.TeamNumberT.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.TeamNumberT.Location = new System.Drawing.Point(0, 0);
            this.TeamNumberT.Name = "TeamNumberT";
            this.TeamNumberT.Size = new System.Drawing.Size(240, 35);
            this.TeamNumberT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.TeamNumberT);
            this.Controls.Add(this.TestWaybillForm);
            this.Controls.Add(this.OrderHistory);
            this.Controls.Add(this.LanguageSelectorRu);
            this.Controls.Add(this.LanguageSelectorKz);
            this.Controls.Add(this.OrderList);
            this.Controls.Add(this.NewOrder);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "Form_Main";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_Main_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewOrder;
        private System.Windows.Forms.Button OrderList;
        private System.Windows.Forms.RadioButton LanguageSelectorKz;
        private System.Windows.Forms.RadioButton LanguageSelectorRu;
        private System.Windows.Forms.Button OrderHistory;
        private System.Windows.Forms.Button TestWaybillForm;
        private System.Windows.Forms.Label TeamNumberT;
    }
}