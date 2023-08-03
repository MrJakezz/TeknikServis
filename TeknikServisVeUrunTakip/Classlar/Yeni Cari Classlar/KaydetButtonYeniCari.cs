using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisVeUrunTakip.Classlar.Yeni_Cari_Classlar
{
    public class KaydetButtonYeniCari
    {
        public TextEdit txtAd;
        public TextEdit txtSoyad;
        public TextEdit txtTel;
        public TextEdit txtMail;
        public TextEdit txtIl;
        public TextEdit txtIlce;
        public TextEdit txtBanka;
        public TextEdit txtVergiD;
        public TextEdit txtVergiNo;
        public TextEdit txtStatu;
        public TextEdit txtAdres;

        public KaydetButtonYeniCari(TextEdit ad, TextEdit soyad, TextEdit tel, TextEdit mail, TextEdit il, TextEdit ilce, TextEdit banka, TextEdit vergiDairesi, TextEdit vergiNumarasi, TextEdit statu, TextEdit adres)
        {
            txtAd = ad;
            txtSoyad = soyad;
            txtTel = tel;
            txtMail = mail;
            txtIl = il;
            txtIlce = ilce;
            txtBanka = banka;
            txtVergiD = vergiDairesi;
            txtVergiNo = vergiNumarasi;
            txtStatu = statu;
            txtAdres = adres;
        }

        public void Kaydet()
        {
            DBTeknikServisEntities DB = new DBTeknikServisEntities();

            TBLCari product = new TBLCari();

            if (txtAd.Text != "" && txtSoyad.Text != "" && txtTel.Text != "" && txtMail.Text != "" && txtIl.Text != "" && txtIlce.Text != "" && txtBanka.Text != "" && txtVergiD.Text != "" && txtVergiNo.Text != "" && txtStatu.Text != "" && txtAdres.Text != "")
            {
                product.AD = txtAd.Text;
                product.SOYAD = txtSoyad.Text;
                product.TELEFON = txtTel.Text;
                product.MAIL = txtMail.Text;
                product.IL = txtIl.Text;
                product.ILCE = txtIlce.Text;
                product.BANKA = txtBanka.Text;
                product.VERGIDAIRESI = txtVergiD.Text;
                product.VERGINO = txtVergiNo.Text;
                product.STATU = txtStatu.Text;
                product.ADRES = txtAdres.Text;

                DB.TBLCari.Add(product);
                DB.SaveChanges();

                MessageBox.Show("Cari başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
