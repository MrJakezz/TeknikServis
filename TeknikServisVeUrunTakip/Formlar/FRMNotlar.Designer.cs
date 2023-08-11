namespace TeknikServisVeUrunTakip.Formlar
{
    partial class FRMNotlar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMNotlar));
            this.TXTIcerik = new DevExpress.XtraEditors.TextEdit();
            this.TXTNotID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.BTNListeleNotlar = new DevExpress.XtraEditors.SimpleButton();
            this.BTNGuncelleNotlar = new DevExpress.XtraEditors.SimpleButton();
            this.BTNSilNotlar = new DevExpress.XtraEditors.SimpleButton();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.BTNKaydetNotlar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TXTBaslik = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.TXTIcerik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTNotID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTBaslik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTIcerik
            // 
            this.TXTIcerik.Location = new System.Drawing.Point(80, 113);
            this.TXTIcerik.Name = "TXTIcerik";
            this.TXTIcerik.Size = new System.Drawing.Size(218, 20);
            this.TXTIcerik.TabIndex = 21;
            // 
            // TXTNotID
            // 
            this.TXTNotID.Enabled = false;
            this.TXTNotID.Location = new System.Drawing.Point(80, 61);
            this.TXTNotID.Name = "TXTNotID";
            this.TXTNotID.Size = new System.Drawing.Size(218, 20);
            this.TXTNotID.TabIndex = 20;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(43, 64);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(31, 13);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "Not ID";
            // 
            // BTNListeleNotlar
            // 
            this.BTNListeleNotlar.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.BTNListeleNotlar.Appearance.Options.UseFont = true;
            this.BTNListeleNotlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTNListelePersonel.ImageOptions.Image")));
            this.BTNListeleNotlar.Location = new System.Drawing.Point(127, 320);
            this.BTNListeleNotlar.Name = "BTNListeleNotlar";
            this.BTNListeleNotlar.Size = new System.Drawing.Size(125, 45);
            this.BTNListeleNotlar.TabIndex = 18;
            this.BTNListeleNotlar.Text = "LİSTELE";
            this.BTNListeleNotlar.Click += new System.EventHandler(this.BTNListeleNotlar_Click);
            // 
            // BTNGuncelleNotlar
            // 
            this.BTNGuncelleNotlar.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.BTNGuncelleNotlar.Appearance.Options.UseFont = true;
            this.BTNGuncelleNotlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTNGuncellePersonel.ImageOptions.Image")));
            this.BTNGuncelleNotlar.Location = new System.Drawing.Point(127, 269);
            this.BTNGuncelleNotlar.Name = "BTNGuncelleNotlar";
            this.BTNGuncelleNotlar.Size = new System.Drawing.Size(125, 45);
            this.BTNGuncelleNotlar.TabIndex = 17;
            this.BTNGuncelleNotlar.Text = "GÜNCELLE";
            this.BTNGuncelleNotlar.Click += new System.EventHandler(this.BTNGuncelleNotlar_Click);
            // 
            // BTNSilNotlar
            // 
            this.BTNSilNotlar.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.BTNSilNotlar.Appearance.Options.UseFont = true;
            this.BTNSilNotlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTNSilPersonel.ImageOptions.Image")));
            this.BTNSilNotlar.Location = new System.Drawing.Point(127, 218);
            this.BTNSilNotlar.Name = "BTNSilNotlar";
            this.BTNSilNotlar.Size = new System.Drawing.Size(125, 45);
            this.BTNSilNotlar.TabIndex = 16;
            this.BTNSilNotlar.Text = "SİL";
            this.BTNSilNotlar.Click += new System.EventHandler(this.BTNSilNotlar_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 29);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1002, 246);
            this.gridControl1.TabIndex = 20;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // BTNKaydetNotlar
            // 
            this.BTNKaydetNotlar.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.BTNKaydetNotlar.Appearance.Options.UseFont = true;
            this.BTNKaydetNotlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTNKaydetPersonel.ImageOptions.Image")));
            this.BTNKaydetNotlar.Location = new System.Drawing.Point(127, 167);
            this.BTNKaydetNotlar.Name = "BTNKaydetNotlar";
            this.BTNKaydetNotlar.Size = new System.Drawing.Size(125, 45);
            this.BTNKaydetNotlar.TabIndex = 15;
            this.BTNKaydetNotlar.Text = "KAYDET";
            this.BTNKaydetNotlar.Click += new System.EventHandler(this.BTNKaydetNotlar_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(48, 116);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "İçerik";
            // 
            // TXTBaslik
            // 
            this.TXTBaslik.Location = new System.Drawing.Point(80, 87);
            this.TXTBaslik.Name = "TXTBaslik";
            this.TXTBaslik.Size = new System.Drawing.Size(218, 20);
            this.TXTBaslik.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(48, 90);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Başlık";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.checkEdit1);
            this.groupControl1.Controls.Add(this.TXTIcerik);
            this.groupControl1.Controls.Add(this.TXTNotID);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.BTNListeleNotlar);
            this.groupControl1.Controls.Add(this.BTNGuncelleNotlar);
            this.groupControl1.Controls.Add(this.BTNSilNotlar);
            this.groupControl1.Controls.Add(this.BTNKaydetNotlar);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.TXTBaslik);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1008, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(357, 550);
            this.groupControl1.TabIndex = 21;
            this.groupControl1.Text = "Not İşlemleri";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(43, 142);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(31, 13);
            this.labelControl5.TabIndex = 23;
            this.labelControl5.Text = "Durum";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(80, 139);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Okundu Olarak İşaretle";
            this.checkEdit1.Size = new System.Drawing.Size(136, 20);
            this.checkEdit1.TabIndex = 22;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(21, 5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(144, 19);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "Okunmamış Notlar";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(21, 280);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(126, 19);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "Okunmuş Notlar";
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(0, 305);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1002, 246);
            this.gridControl2.TabIndex = 23;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            // 
            // FRMNotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 541);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FRMNotlar";
            this.Text = "FRMNotlar";
            this.Load += new System.EventHandler(this.FRMNotlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TXTIcerik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTNotID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTBaslik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit TXTIcerik;
        private DevExpress.XtraEditors.TextEdit TXTNotID;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton BTNListeleNotlar;
        private DevExpress.XtraEditors.SimpleButton BTNGuncelleNotlar;
        private DevExpress.XtraEditors.SimpleButton BTNSilNotlar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton BTNKaydetNotlar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TXTBaslik;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}