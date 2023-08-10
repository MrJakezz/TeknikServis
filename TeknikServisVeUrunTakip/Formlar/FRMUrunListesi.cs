using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeknikServisVeUrunTakip.Classlar;
using TeknikServisVeUrunTakip.Classlar.Ürün_Listesi_Classlar;

namespace TeknikServisVeUrunTakip.Formlar
{
    public partial class FRMUrunListesi : Form
    {
        public FRMUrunListesi()
        {
            InitializeComponent();
        }

        DBTeknikServisEntities DB = new DBTeknikServisEntities();

        private void FRMUrunListesi_Load(object sender, EventArgs e)
        {
            GosterFormUrunListesi showObj = new GosterFormUrunListesi(gridControl1);
            showObj.Goster();

            //LOOKUP EDIT KATEGORİ LİSTESİ

            KategoriSecUrunListesi categoryObj = new KategoriSecUrunListesi(lookUpEdit1);
            categoryObj.Kategori();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TXTID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TXTUrunAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            TXTMarka.Text = gridView1.GetFocusedRowCellValue("MARKA").ToString();
            TXTAlisFiyat.Text = gridView1.GetFocusedRowCellValue("ALISFIYAT").ToString();
            TXTSatisFiyat.Text = gridView1.GetFocusedRowCellValue("SATISFIYAT").ToString();
            TXTStok.Text = gridView1.GetFocusedRowCellValue("STOK").ToString();
        }


        private void BTNKaydetUrunListesi_Click(object sender, EventArgs e)
        {
            KaydetButtonUrunListesi saveObj = new KaydetButtonUrunListesi(TXTUrunAd, TXTMarka, TXTAlisFiyat, TXTSatisFiyat, TXTStok, lookUpEdit1);
            saveObj.Kaydet();
        }

        private void BTNGuncelleUrunListesi_Click(object sender, EventArgs e)
        {
            GuncelleButtonUrunListesi updateObj = new GuncelleButtonUrunListesi(TXTID, TXTUrunAd, TXTMarka, TXTStok, TXTAlisFiyat, TXTSatisFiyat, lookUpEdit1);
            updateObj.Guncelle();
        }

        private void BTNListeleUrunListesi_Click(object sender, EventArgs e)
        {
            ListeleButtonUrunListesi listObj = new ListeleButtonUrunListesi(gridControl1);
            listObj.Listele();
        }

        private void BTNSilUrunListesi_Click(object sender, EventArgs e)
        {
            SilButtonUrunListesi deleteObj = new SilButtonUrunListesi(TXTID);
            deleteObj.Sil();
        }
    }
}
