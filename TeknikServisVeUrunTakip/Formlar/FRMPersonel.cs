using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeknikServisVeUrunTakip.Classlar.Departman_Classlar;
using TeknikServisVeUrunTakip.Classlar.Personel_Listesi_Classlar;
using TeknikServisVeUrunTakip.Classlar.Ürün_Listesi_Classlar;
using TeknikServisVeUrunTakip.LINQ_Sorgular;

namespace TeknikServisVeUrunTakip.Formlar
{
    public partial class FRMPersonel : Form
    {
        public FRMPersonel()
        {
            InitializeComponent();
        }

        private void FRMPersonel_Load(object sender, EventArgs e)
        {
            GosterFormPersonelListesi showObj = new GosterFormPersonelListesi(gridControl1);
            PersonelListesiLINQ statistics = new PersonelListesiLINQ(LBLAdSoyad1, LBLDepartman1, LBLMail1, LBLAdSoyad2, LBLDepartman2, LBLMail2, LBLAdSoyad3, LBLDepartman3, labelControl16, LBLAdSoyad4, LBLDepartman4, labelControl22);
            DepartmanSecPersonelListesi departmentObj = new DepartmanSecPersonelListesi(lookUpEdit1);

            showObj.Goster();
            statistics.AdVeSoyadlar();
            statistics.Departmanlar();
            statistics.Mailler();
            departmentObj.Departman();
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TXTPersonelID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TXTPersonelAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            TXTPersonelSoyad.Text = gridView1.GetFocusedRowCellValue("SOYAD").ToString();
            TXTPersonelMail.Text = gridView1.GetFocusedRowCellValue("MAIL").ToString();
            TXTPersonelTel.Text = gridView1.GetFocusedRowCellValue("TELEFON").ToString();
        }

        private void BTNKaydetPersonel_Click(object sender, EventArgs e)
        {
            KaydetButtonPersonelListesi saveObj = new KaydetButtonPersonelListesi(TXTPersonelID, TXTPersonelAd, TXTPersonelSoyad, TXTPersonelMail, TXTPersonelTel, lookUpEdit1);
            saveObj.Kaydet();
        }

        private void BTNSilPersonel_Click(object sender, EventArgs e)
        {
            SilButtonPersonelListesi deleteObj = new SilButtonPersonelListesi(TXTPersonelID);
            deleteObj.Sil();
        }

        private void BTNGuncellePersonel_Click(object sender, EventArgs e)
        {
            GuncelleButtonPersonelListesi updateObj = new GuncelleButtonPersonelListesi(TXTPersonelID, TXTPersonelAd, TXTPersonelSoyad, TXTPersonelMail, TXTPersonelTel, lookUpEdit1);
            updateObj.Guncelle();
        }

        private void BTNListelePersonel_Click(object sender, EventArgs e)
        {
            ListeleButtonPersonelListesi listObj = new ListeleButtonPersonelListesi(gridControl1);
            listObj.Listele();
        }

    }
}
