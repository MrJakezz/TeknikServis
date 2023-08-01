namespace TeknikServisVeUrunTakip.Formlar
{
    partial class FRMUrunListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMUrunListesi));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.TXTID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.BTNListeleUrunListesi = new DevExpress.XtraEditors.SimpleButton();
            this.BTNGuncelleUrunListesi = new DevExpress.XtraEditors.SimpleButton();
            this.BTNSilUrunListesi = new DevExpress.XtraEditors.SimpleButton();
            this.BTNKaydetUrunListesi = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.TXTStok = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TXTSatisFiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TXTAlisFiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TXTMarka = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TXTUrunAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TXTID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTStok.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTSatisFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTAlisFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTMarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTUrunAd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1009, 550);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.TXTID);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.BTNListeleUrunListesi);
            this.groupControl1.Controls.Add(this.BTNGuncelleUrunListesi);
            this.groupControl1.Controls.Add(this.BTNSilUrunListesi);
            this.groupControl1.Controls.Add(this.BTNKaydetUrunListesi);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.lookUpEdit1);
            this.groupControl1.Controls.Add(this.TXTStok);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.TXTSatisFiyat);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.TXTAlisFiyat);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.TXTMarka);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.TXTUrunAd);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1015, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(350, 550);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Ürün İşlemleri";
            // 
            // TXTID
            // 
            this.TXTID.Enabled = false;
            this.TXTID.Location = new System.Drawing.Point(77, 34);
            this.TXTID.Name = "TXTID";
            this.TXTID.Size = new System.Drawing.Size(218, 20);
            this.TXTID.TabIndex = 20;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(34, 37);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(37, 13);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "Ürün ID";
            // 
            // BTNListeleUrunListesi
            // 
            this.BTNListeleUrunListesi.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.BTNListeleUrunListesi.Appearance.Options.UseFont = true;
            this.BTNListeleUrunListesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTNListeleUrunListesi.ImageOptions.Image")));
            this.BTNListeleUrunListesi.Location = new System.Drawing.Point(123, 369);
            this.BTNListeleUrunListesi.Name = "BTNListeleUrunListesi";
            this.BTNListeleUrunListesi.Size = new System.Drawing.Size(125, 45);
            this.BTNListeleUrunListesi.TabIndex = 18;
            this.BTNListeleUrunListesi.Text = "LİSTELE";
            this.BTNListeleUrunListesi.Click += new System.EventHandler(this.BTNListeleUrunListesi_Click);
            // 
            // BTNGuncelleUrunListesi
            // 
            this.BTNGuncelleUrunListesi.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.BTNGuncelleUrunListesi.Appearance.Options.UseFont = true;
            this.BTNGuncelleUrunListesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTNGuncelleUrunListesi.ImageOptions.Image")));
            this.BTNGuncelleUrunListesi.Location = new System.Drawing.Point(123, 318);
            this.BTNGuncelleUrunListesi.Name = "BTNGuncelleUrunListesi";
            this.BTNGuncelleUrunListesi.Size = new System.Drawing.Size(125, 45);
            this.BTNGuncelleUrunListesi.TabIndex = 17;
            this.BTNGuncelleUrunListesi.Text = "GÜNCELLE";
            this.BTNGuncelleUrunListesi.Click += new System.EventHandler(this.BTNGuncelleUrunListesi_Click);
            // 
            // BTNSilUrunListesi
            // 
            this.BTNSilUrunListesi.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.BTNSilUrunListesi.Appearance.Options.UseFont = true;
            this.BTNSilUrunListesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTNSilUrunListesi.ImageOptions.Image")));
            this.BTNSilUrunListesi.Location = new System.Drawing.Point(123, 267);
            this.BTNSilUrunListesi.Name = "BTNSilUrunListesi";
            this.BTNSilUrunListesi.Size = new System.Drawing.Size(125, 45);
            this.BTNSilUrunListesi.TabIndex = 16;
            this.BTNSilUrunListesi.Text = "SİL";
            this.BTNSilUrunListesi.Click += new System.EventHandler(this.BTNSilUrunListesi_Click);
            // 
            // BTNKaydetUrunListesi
            // 
            this.BTNKaydetUrunListesi.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.BTNKaydetUrunListesi.Appearance.Options.UseFont = true;
            this.BTNKaydetUrunListesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTNKaydetUrunListesi.ImageOptions.Image")));
            this.BTNKaydetUrunListesi.Location = new System.Drawing.Point(123, 216);
            this.BTNKaydetUrunListesi.Name = "BTNKaydetUrunListesi";
            this.BTNKaydetUrunListesi.Size = new System.Drawing.Size(125, 45);
            this.BTNKaydetUrunListesi.TabIndex = 15;
            this.BTNKaydetUrunListesi.Text = "KAYDET";
            this.BTNKaydetUrunListesi.Click += new System.EventHandler(this.BTNKaydetUrunListesi_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(31, 193);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(40, 13);
            this.labelControl6.TabIndex = 14;
            this.labelControl6.Text = "Kategori";
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(77, 190);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.DisplayMember = "AD";
            this.lookUpEdit1.Properties.NullText = "Kategori seçiniz";
            this.lookUpEdit1.Properties.ValueMember = "ID";
            this.lookUpEdit1.Size = new System.Drawing.Size(218, 20);
            this.lookUpEdit1.TabIndex = 13;
            // 
            // TXTStok
            // 
            this.TXTStok.Location = new System.Drawing.Point(77, 164);
            this.TXTStok.Name = "TXTStok";
            this.TXTStok.Size = new System.Drawing.Size(218, 20);
            this.TXTStok.TabIndex = 12;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(50, 167);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(21, 13);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Stok";
            // 
            // TXTSatisFiyat
            // 
            this.TXTSatisFiyat.Location = new System.Drawing.Point(77, 138);
            this.TXTSatisFiyat.Name = "TXTSatisFiyat";
            this.TXTSatisFiyat.Size = new System.Drawing.Size(218, 20);
            this.TXTSatisFiyat.TabIndex = 10;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(19, 141);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(52, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Satış Fiyatı";
            // 
            // TXTAlisFiyat
            // 
            this.TXTAlisFiyat.Location = new System.Drawing.Point(77, 112);
            this.TXTAlisFiyat.Name = "TXTAlisFiyat";
            this.TXTAlisFiyat.Size = new System.Drawing.Size(218, 20);
            this.TXTAlisFiyat.TabIndex = 8;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(26, 115);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Alış Fiyatı";
            // 
            // TXTMarka
            // 
            this.TXTMarka.Location = new System.Drawing.Point(77, 86);
            this.TXTMarka.Name = "TXTMarka";
            this.TXTMarka.Size = new System.Drawing.Size(218, 20);
            this.TXTMarka.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(42, 89);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Marka";
            // 
            // TXTUrunAd
            // 
            this.TXTUrunAd.Location = new System.Drawing.Point(77, 60);
            this.TXTUrunAd.Name = "TXTUrunAd";
            this.TXTUrunAd.Size = new System.Drawing.Size(218, 20);
            this.TXTUrunAd.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 63);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Ürün Adı";
            // 
            // FRMUrunListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 541);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FRMUrunListesi";
            this.Text = "FRMUrunListesi";
            this.Load += new System.EventHandler(this.FRMUrunListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TXTID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTStok.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTSatisFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTAlisFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTMarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTUrunAd.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit TXTSatisFiyat;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TXTAlisFiyat;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TXTMarka;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TXTUrunAd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TXTStok;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.SimpleButton BTNKaydetUrunListesi;
        private DevExpress.XtraEditors.SimpleButton BTNGuncelleUrunListesi;
        private DevExpress.XtraEditors.SimpleButton BTNSilUrunListesi;
        private DevExpress.XtraEditors.SimpleButton BTNListeleUrunListesi;
        private DevExpress.XtraEditors.TextEdit TXTID;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}