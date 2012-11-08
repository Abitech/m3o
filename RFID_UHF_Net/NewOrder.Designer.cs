using com.abitech.rfid;
namespace RFID_UHF_Net
{
    partial class NewOrder
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
            this.tubeDiameterT = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "№ скважины";
            this.label1.ParentChanged += new System.EventHandler(this.label1_ParentChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(27, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.Text = "Диаметр, мм";
            this.label2.ParentChanged += new System.EventHandler(this.label2_ParentChanged);
            // 
            // districtIdT
            // 
            this.districtIdT.Location = new System.Drawing.Point(27, 41);
            this.districtIdT.Name = "districtIdT";
            this.districtIdT.Size = new System.Drawing.Size(100, 21);
            this.districtIdT.TabIndex = 2;
            this.districtIdT.TextChanged += new System.EventHandler(this.districtIdT_TextChanged);
            // 
            // createNewOrder
            // 
            this.createNewOrder.Location = new System.Drawing.Point(27, 162);
            this.createNewOrder.Name = "createNewOrder";
            this.createNewOrder.Size = new System.Drawing.Size(100, 20);
            this.createNewOrder.TabIndex = 4;
            this.createNewOrder.Text = "Отправить";
            this.createNewOrder.Click += new System.EventHandler(this.CreateNewOrder_Click);
            // 
            // tubesNumberT
            // 
            this.tubesNumberT.Location = new System.Drawing.Point(27, 135);
            this.tubesNumberT.Name = "tubesNumberT";
            this.tubesNumberT.Size = new System.Drawing.Size(100, 21);
            this.tubesNumberT.TabIndex = 7;
            this.tubesNumberT.TextChanged += new System.EventHandler(this.tubesNumberT_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(27, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.Text = "Количество труб, шт";
            this.label3.ParentChanged += new System.EventHandler(this.label3_ParentChanged);
            // 
            // tubeDiameterT
            //

            this.tubeDiameterT.Items.Add(new TubeDiameter() { id = 1, value = "60" });
            this.tubeDiameterT.Items.Add(new TubeDiameter() { id = 2, value = "73" });
            this.tubeDiameterT.Items.Add(new TubeDiameter() { id = 3, value = "73 выс" });
            this.tubeDiameterT.Items.Add(new TubeDiameter() { id = 4, value = "89" });
            this.tubeDiameterT.Location = new System.Drawing.Point(27, 87);
            this.tubeDiameterT.Name = "tubeDiameterT";
            this.tubeDiameterT.Size = new System.Drawing.Size(100, 22);
            this.tubeDiameterT.TabIndex = 10;
            this.tubeDiameterT.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.tubeDiameterT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tubesNumberT);
            this.Controls.Add(this.createNewOrder);
            this.Controls.Add(this.districtIdT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu1;
            this.Name = "NewOrder";
            this.Text = "Новая заявка";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox districtIdT;
        private System.Windows.Forms.Button createNewOrder;
        private System.Windows.Forms.TextBox tubesNumberT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tubeDiameterT;
    }
}