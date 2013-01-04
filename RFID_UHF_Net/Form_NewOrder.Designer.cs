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
            this.DistrictIdT = new System.Windows.Forms.Label();
            this.TubesDiameterT = new System.Windows.Forms.Label();
            this.DistrictId = new System.Windows.Forms.TextBox();
            this.CreateNewOrder = new System.Windows.Forms.Button();
            this.TubesNumber = new System.Windows.Forms.TextBox();
            this.TubesNumberT = new System.Windows.Forms.Label();
            this.OrderTypeT = new System.Windows.Forms.Label();
            this.OrderType = new System.Windows.Forms.ComboBox();
            this.OrderDispatchingStatusT = new System.Windows.Forms.Label();
            this.TubesDiameter = new System.Windows.Forms.ComboBox();
            this.GroupUnitT = new System.Windows.Forms.Label();
            this.GroupUnit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DistrictIdT
            // 
            this.DistrictIdT.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.DistrictIdT.Location = new System.Drawing.Point(137, 54);
            this.DistrictIdT.Name = "DistrictIdT";
            this.DistrictIdT.Size = new System.Drawing.Size(100, 20);
            this.DistrictIdT.Text = "Скважина №";
            this.DistrictIdT.ParentChanged += new System.EventHandler(this.label1_ParentChanged);
            // 
            // TubesDiameterT
            // 
            this.TubesDiameterT.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.TubesDiameterT.Location = new System.Drawing.Point(3, 102);
            this.TubesDiameterT.Name = "TubesDiameterT";
            this.TubesDiameterT.Size = new System.Drawing.Size(100, 20);
            this.TubesDiameterT.Text = "Диаметр, мм";
            this.TubesDiameterT.ParentChanged += new System.EventHandler(this.label2_ParentChanged);
            // 
            // DistrictId
            // 
            this.DistrictId.Location = new System.Drawing.Point(137, 78);
            this.DistrictId.Name = "DistrictId";
            this.DistrictId.Size = new System.Drawing.Size(100, 21);
            this.DistrictId.TabIndex = 2;
            this.DistrictId.TextChanged += new System.EventHandler(this.districtIdT_TextChanged);
            // 
            // CreateNewOrder
            // 
            this.CreateNewOrder.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.CreateNewOrder.Location = new System.Drawing.Point(0, 169);
            this.CreateNewOrder.Name = "CreateNewOrder";
            this.CreateNewOrder.Size = new System.Drawing.Size(237, 20);
            this.CreateNewOrder.TabIndex = 4;
            this.CreateNewOrder.Text = "Отправить заявку";
            this.CreateNewOrder.Click += new System.EventHandler(this.CreateNewOrder_Click);
            // 
            // TubesNumber
            // 
            this.TubesNumber.Location = new System.Drawing.Point(137, 125);
            this.TubesNumber.Name = "TubesNumber";
            this.TubesNumber.Size = new System.Drawing.Size(100, 21);
            this.TubesNumber.TabIndex = 7;
            this.TubesNumber.TextChanged += new System.EventHandler(this.tubesNumberT_TextChanged);
            // 
            // TubesNumberT
            // 
            this.TubesNumberT.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.TubesNumberT.Location = new System.Drawing.Point(137, 102);
            this.TubesNumberT.Name = "TubesNumberT";
            this.TubesNumberT.Size = new System.Drawing.Size(100, 20);
            this.TubesNumberT.Text = "Кол-во, шт";
            this.TubesNumberT.ParentChanged += new System.EventHandler(this.label3_ParentChanged);
            // 
            // OrderTypeT
            // 
            this.OrderTypeT.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.OrderTypeT.Location = new System.Drawing.Point(3, 4);
            this.OrderTypeT.Name = "OrderTypeT";
            this.OrderTypeT.Size = new System.Drawing.Size(128, 20);
            this.OrderTypeT.Text = "Тип заявки";
            this.OrderTypeT.ParentChanged += new System.EventHandler(this.label4_ParentChanged);
            // 
            // OrderType
            // 
            this.OrderType.Location = new System.Drawing.Point(137, 4);
            this.OrderType.Name = "OrderType";
            this.OrderType.Size = new System.Drawing.Size(100, 22);
            this.OrderType.TabIndex = 15;
            this.OrderType.SelectedIndexChanged += new System.EventHandler(this.orderTypeT_SelectedIndexChanged);
            // 
            // OrderDispatchingStatusT
            // 
            this.OrderDispatchingStatusT.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.OrderDispatchingStatusT.ForeColor = System.Drawing.SystemColors.MenuText;
            this.OrderDispatchingStatusT.Location = new System.Drawing.Point(0, 192);
            this.OrderDispatchingStatusT.Name = "OrderDispatchingStatusT";
            this.OrderDispatchingStatusT.Size = new System.Drawing.Size(237, 76);
            this.OrderDispatchingStatusT.Text = "Состояние отправки заявки и сообщения об некорректно заполненных полях";
            // 
            // TubesDiameter
            // 
            this.TubesDiameter.Location = new System.Drawing.Point(3, 125);
            this.TubesDiameter.Name = "TubesDiameter";
            this.TubesDiameter.Size = new System.Drawing.Size(100, 22);
            this.TubesDiameter.TabIndex = 10;
            this.TubesDiameter.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // GroupUnitT
            // 
            this.GroupUnitT.Location = new System.Drawing.Point(3, 54);
            this.GroupUnitT.Name = "GroupUnitT";
            this.GroupUnitT.Size = new System.Drawing.Size(100, 20);
            this.GroupUnitT.Text = "ГУ";
            // 
            // GroupUnit
            // 
            this.GroupUnit.Location = new System.Drawing.Point(3, 77);
            this.GroupUnit.Name = "GroupUnit";
            this.GroupUnit.Size = new System.Drawing.Size(100, 21);
            this.GroupUnit.TabIndex = 21;
            // 
            // Form_NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.GroupUnit);
            this.Controls.Add(this.GroupUnitT);
            this.Controls.Add(this.OrderDispatchingStatusT);
            this.Controls.Add(this.OrderType);
            this.Controls.Add(this.OrderTypeT);
            this.Controls.Add(this.TubesDiameter);
            this.Controls.Add(this.TubesNumberT);
            this.Controls.Add(this.TubesNumber);
            this.Controls.Add(this.CreateNewOrder);
            this.Controls.Add(this.DistrictId);
            this.Controls.Add(this.TubesDiameterT);
            this.Controls.Add(this.DistrictIdT);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.Menu = this.mainMenu1;
            this.Name = "Form_NewOrder";
            this.Load += new System.EventHandler(this.NewOrder_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DistrictIdT;
        private System.Windows.Forms.Label TubesDiameterT;
        private System.Windows.Forms.TextBox DistrictId;
        private System.Windows.Forms.Button CreateNewOrder;
        private System.Windows.Forms.TextBox TubesNumber;
        private System.Windows.Forms.Label TubesNumberT;
        private System.Windows.Forms.Label OrderTypeT;
        private System.Windows.Forms.ComboBox OrderType;
        private System.Windows.Forms.Label OrderDispatchingStatusT;
        private System.Windows.Forms.ComboBox TubesDiameter;
        private System.Windows.Forms.Label GroupUnitT;
        private System.Windows.Forms.TextBox GroupUnit;
    }
}