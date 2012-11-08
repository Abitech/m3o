using com.abitech.rfid;
namespace RFID_UHF_Net
{
    partial class Form_NewOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.districtIdT = new System.Windows.Forms.TextBox();
            this.createNewOrder = new System.Windows.Forms.Button();
            this.tubesNumberT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.orderTypeT = new System.Windows.Forms.ComboBox();
            this.OrderDispatchingStatusT = new System.Windows.Forms.Label();
            this.tubesDiameterT = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(27, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "№ скважины";
            this.label1.ParentChanged += new System.EventHandler(this.label1_ParentChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(27, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.Text = "Диаметр, мм";
            this.label2.ParentChanged += new System.EventHandler(this.label2_ParentChanged);
            // 
            // districtIdT
            // 
            this.districtIdT.Location = new System.Drawing.Point(27, 76);
            this.districtIdT.Name = "districtIdT";
            this.districtIdT.Size = new System.Drawing.Size(100, 21);
            this.districtIdT.TabIndex = 2;
            this.districtIdT.TextChanged += new System.EventHandler(this.districtIdT_TextChanged);
            // 
            // createNewOrder
            // 
            this.createNewOrder.Location = new System.Drawing.Point(27, 197);
            this.createNewOrder.Name = "createNewOrder";
            this.createNewOrder.Size = new System.Drawing.Size(100, 20);
            this.createNewOrder.TabIndex = 4;
            this.createNewOrder.Text = "Отправить";
            this.createNewOrder.Click += new System.EventHandler(this.CreateNewOrder_Click);
            // 
            // tubesNumberT
            // 
            this.tubesNumberT.Location = new System.Drawing.Point(27, 170);
            this.tubesNumberT.Name = "tubesNumberT";
            this.tubesNumberT.Size = new System.Drawing.Size(100, 21);
            this.tubesNumberT.TabIndex = 7;
            this.tubesNumberT.TextChanged += new System.EventHandler(this.tubesNumberT_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(27, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.Text = "Количество труб, шт";
            this.label3.ParentChanged += new System.EventHandler(this.label3_ParentChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(27, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.Text = "Тип заявки";
            // 
            // orderTypeT
            // 
            this.orderTypeT.Location = new System.Drawing.Point(27, 28);
            this.orderTypeT.Name = "orderTypeT";
            this.orderTypeT.Size = new System.Drawing.Size(100, 22);
            this.orderTypeT.TabIndex = 15;
            this.orderTypeT.SelectedIndexChanged += new System.EventHandler(this.orderTypeT_SelectedIndexChanged);
            // 
            // OrderDispatchingStatusT
            // 
            this.OrderDispatchingStatusT.ForeColor = System.Drawing.SystemColors.MenuText;
            this.OrderDispatchingStatusT.Location = new System.Drawing.Point(27, 224);
            this.OrderDispatchingStatusT.Name = "OrderDispatchingStatusT";
            this.OrderDispatchingStatusT.Size = new System.Drawing.Size(210, 44);
            this.OrderDispatchingStatusT.Text = "label5";
            this.OrderDispatchingStatusT.Visible = false;
            // 
            // tubesDiameterT
            // 
            this.tubesDiameterT.Location = new System.Drawing.Point(27, 122);
            this.tubesDiameterT.Name = "tubesDiameterT";
            this.tubesDiameterT.Size = new System.Drawing.Size(100, 22);
            this.tubesDiameterT.TabIndex = 10;
            this.tubesDiameterT.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form_NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.OrderDispatchingStatusT);
            this.Controls.Add(this.orderTypeT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tubesDiameterT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tubesNumberT);
            this.Controls.Add(this.createNewOrder);
            this.Controls.Add(this.districtIdT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu1;
            this.Name = "Form_NewOrder";
            this.Text = "Новая заявка";
            this.Load += new System.EventHandler(this.NewOrder_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox districtIdT;
        private System.Windows.Forms.Button createNewOrder;
        private System.Windows.Forms.TextBox tubesNumberT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox orderTypeT;
        private System.Windows.Forms.Label OrderDispatchingStatusT;
        private System.Windows.Forms.ComboBox tubesDiameterT;
    }
}