namespace RFID_UHF_Net
{
    partial class Form_Waybill
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
            this.SendWaybill = new System.Windows.Forms.Button();
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.ReadTag = new System.Windows.Forms.Button();
            this.EpcLabel = new System.Windows.Forms.Label();
            this.TubesNumber = new System.Windows.Forms.TextBox();
            this.TubeStatusNew = new System.Windows.Forms.RadioButton();
            this.TubeStatusOld = new System.Windows.Forms.RadioButton();
            this.TubeStatusT = new System.Windows.Forms.Label();
            this.TubesNumberT = new System.Windows.Forms.Label();
            this.WaybillDispatchingStatus = new System.Windows.Forms.Label();
            this.WaybillNumberT = new System.Windows.Forms.Label();
            this.WaybillNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SendWaybill
            // 
            this.SendWaybill.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.SendWaybill.Location = new System.Drawing.Point(4, 235);
            this.SendWaybill.Name = "SendWaybill";
            this.SendWaybill.Size = new System.Drawing.Size(233, 20);
            this.SendWaybill.TabIndex = 13;
            this.SendWaybill.Text = "Жөнелту";
            this.SendWaybill.Click += new System.EventHandler(this.sendWaybill_Click);
            // 
            // ReadTag
            // 
            this.ReadTag.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.ReadTag.Location = new System.Drawing.Point(4, 46);
            this.ReadTag.Name = "ReadTag";
            this.ReadTag.Size = new System.Drawing.Size(233, 18);
            this.ReadTag.TabIndex = 0;
            this.ReadTag.Text = "Транспорттық белгіні есептеу";
            this.ReadTag.Click += new System.EventHandler(this.ReadTag_Click);
            // 
            // EpcLabel
            // 
            this.EpcLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.EpcLabel.Location = new System.Drawing.Point(4, 0);
            this.EpcLabel.Name = "EpcLabel";
            this.EpcLabel.Size = new System.Drawing.Size(233, 43);
            this.EpcLabel.Tag = "";
            this.EpcLabel.Text = "Номер транспортного средства";
            this.EpcLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EpcLabel.ParentChanged += new System.EventHandler(this.epcLabel_ParentChanged);
            // 
            // TubesNumber
            // 
            this.TubesNumber.Location = new System.Drawing.Point(112, 137);
            this.TubesNumber.Name = "TubesNumber";
            this.TubesNumber.Size = new System.Drawing.Size(100, 21);
            this.TubesNumber.TabIndex = 14;
            // 
            // TubeStatusNew
            // 
            this.TubeStatusNew.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.TubeStatusNew.Location = new System.Drawing.Point(5, 91);
            this.TubeStatusNew.Name = "TubeStatusNew";
            this.TubeStatusNew.Size = new System.Drawing.Size(100, 20);
            this.TubeStatusNew.TabIndex = 23;
            this.TubeStatusNew.Text = "Жаңа";
            this.TubeStatusNew.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // TubeStatusOld
            // 
            this.TubeStatusOld.Location = new System.Drawing.Point(6, 117);
            this.TubeStatusOld.Name = "TubeStatusOld";
            this.TubeStatusOld.Size = new System.Drawing.Size(100, 20);
            this.TubeStatusOld.TabIndex = 24;
            this.TubeStatusOld.Text = "Ескі";
            this.TubeStatusOld.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // TubeStatusT
            // 
            this.TubeStatusT.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.TubeStatusT.Location = new System.Drawing.Point(5, 68);
            this.TubeStatusT.Name = "TubeStatusT";
            this.TubeStatusT.Size = new System.Drawing.Size(100, 20);
            this.TubeStatusT.Text = "НКҚ күйі";
            // 
            // TubesNumberT
            // 
            this.TubesNumberT.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.TubesNumberT.Location = new System.Drawing.Point(111, 114);
            this.TubesNumberT.Name = "TubesNumberT";
            this.TubesNumberT.Size = new System.Drawing.Size(100, 20);
            this.TubesNumberT.Text = "НКҚ саны";
            // 
            // WaybillDispatchingStatus
            // 
            this.WaybillDispatchingStatus.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
            this.WaybillDispatchingStatus.Location = new System.Drawing.Point(4, 161);
            this.WaybillDispatchingStatus.Name = "WaybillDispatchingStatus";
            this.WaybillDispatchingStatus.Size = new System.Drawing.Size(233, 71);
            this.WaybillDispatchingStatus.Tag = "";
            this.WaybillDispatchingStatus.Text = "Статус отправки накладной и сообщения о  некорректно заполненных полях";
            this.WaybillDispatchingStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WaybillNumberT
            // 
            this.WaybillNumberT.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.WaybillNumberT.Location = new System.Drawing.Point(112, 67);
            this.WaybillNumberT.Name = "WaybillNumberT";
            this.WaybillNumberT.Size = new System.Drawing.Size(100, 20);
            this.WaybillNumberT.Text = "ТТЖ №";
            // 
            // WaybillNumber
            // 
            this.WaybillNumber.Location = new System.Drawing.Point(111, 90);
            this.WaybillNumber.Name = "WaybillNumber";
            this.WaybillNumber.Size = new System.Drawing.Size(100, 21);
            this.WaybillNumber.TabIndex = 27;
            this.WaybillNumber.TextChanged += new System.EventHandler(this.wayBillNumberT_TextChanged);
            // 
            // Form_Waybill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.WaybillNumber);
            this.Controls.Add(this.WaybillNumberT);
            this.Controls.Add(this.WaybillDispatchingStatus);
            this.Controls.Add(this.TubesNumberT);
            this.Controls.Add(this.TubeStatusT);
            this.Controls.Add(this.TubeStatusOld);
            this.Controls.Add(this.TubeStatusNew);
            this.Controls.Add(this.TubesNumber);
            this.Controls.Add(this.SendWaybill);
            this.Controls.Add(this.EpcLabel);
            this.Controls.Add(this.ReadTag);
            this.Menu = this.mainMenu1;
            this.Name = "Form_Waybill";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReadTag;
        private System.Windows.Forms.Label EpcLabel;
        private System.Windows.Forms.TextBox TubesNumber;
        private System.Windows.Forms.RadioButton TubeStatusNew;
        private System.Windows.Forms.RadioButton TubeStatusOld;
        private System.Windows.Forms.Label TubeStatusT;
        private System.Windows.Forms.Label TubesNumberT;
        private System.Windows.Forms.Label WaybillDispatchingStatus;
        private System.Windows.Forms.Label WaybillNumberT;
        private System.Windows.Forms.TextBox WaybillNumber;
        private System.Windows.Forms.Button SendWaybill;
    }
}