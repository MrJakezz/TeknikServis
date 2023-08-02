using DevExpress.Utils.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeknikServisVeUrunTakip.Classlar.Cari_Listesi_Classlar;

namespace TeknikServisVeUrunTakip.Formlar
{
    public partial class FRMCariListesi : Form
    {
        public FRMCariListesi()
        {
            InitializeComponent();
        }

        private void FRMCariListesi_Load(object sender, EventArgs e)
        {
            GosterFormCariListesi showObj = new GosterFormCariListesi(gridControl1);
            showObj.Goster();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TXTCariID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TXTAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            TXTSoyad.Text = gridView1.GetFocusedRowCellValue("SOYAD").ToString();
            TXTTelNo.Text = gridView1.GetFocusedRowCellValue("TELEFON").ToString();
            TXTMail.Text = gridView1.GetFocusedRowCellValue("MAIL").ToString();
            TXTIl.Text = gridView1.GetFocusedRowCellValue("IL").ToString();
            TXTIlce.Text = gridView1.GetFocusedRowCellValue("ILCE").ToString();
            TXTBanka.Text = gridView1.GetFocusedRowCellValue("BANKA").ToString();
            TXTVergiDairesi.Text = gridView1.GetFocusedRowCellValue("VERGIDAIRESI").ToString();
            TXTVergiNo.Text = gridView1.GetFocusedRowCellValue("VERGINO").ToString();
            TXTStatu.Text = gridView1.GetFocusedRowCellValue("STATU").ToString();
            TXTAdres.Text = gridView1.GetFocusedRowCellValue("ADRES").ToString();
        }

        private void BTNKaydetCariListesi_Click(object sender, EventArgs e)
        {
            KaydetButtonCariListesi saveObj = new KaydetButtonCariListesi(TXTAd, TXTSoyad, TXTTelNo, TXTMail, TXTIl, TXTIlce, TXTBanka, TXTVergiDairesi, TXTVergiNo, TXTStatu, TXTAdres);
            saveObj.Kaydet();
        }

        private void BTNSilCariListesi_Click(object sender, EventArgs e)
        {
            SilButtonCariListesi deleteObj = new SilButtonCariListesi(TXTCariID);
            deleteObj.Sil();
        }

        private void BTNGuncelleCariListesi_Click(object sender, EventArgs e)
        {
            GuncelleButtonCariListesi updateObj = new GuncelleButtonCariListesi(TXTCariID, TXTAd, TXTSoyad, TXTTelNo, TXTMail, TXTIl, TXTIlce, TXTBanka, TXTVergiDairesi, TXTVergiNo, TXTStatu, TXTAdres);
            updateObj.Guncelle();
        }

        private void BTNListeleCariListesi_Click(object sender, EventArgs e)
        {
            ListeleButtonCariListesi listObj = new ListeleButtonCariListesi(gridControl1);
            listObj.Listele();
        }
    }
}
