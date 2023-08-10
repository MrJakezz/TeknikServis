using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisVeUrunTakip.Classlar.Personel_Listesi_Classlar
{
    public class KaydetButtonPersonelListesi
    {
        public TextEdit TXTPersonelID;
        public TextEdit TXTPersonelAd;
        public TextEdit TXTPersonelSoyad;
        public TextEdit TXTPersonelMail;
        public TextEdit TXTPersonelTel;
        public LookUpEdit lookUpEdit1;

        public KaydetButtonPersonelListesi(TextEdit id, TextEdit ad, TextEdit soyad, TextEdit mail, TextEdit tel, LookUpEdit lookUpEdit)
        {
            TXTPersonelID = id;
            TXTPersonelAd = ad;
            TXTPersonelSoyad = soyad;
            TXTPersonelMail = mail;
            TXTPersonelTel = tel;
            lookUpEdit1 = lookUpEdit;
        }

        public void Kaydet()
        {
            DBTeknikServisEntities DB = new DBTeknikServisEntities();

            TBLPersonel product = new TBLPersonel();

            if (TXTPersonelAd.Text != "" && TXTPersonelSoyad.Text != "" && TXTPersonelMail.Text != "" && TXTPersonelTel.Text != "" && lookUpEdit1 != null)
            {
                product.AD = TXTPersonelAd.Text;
                product.SOYAD = TXTPersonelSoyad.Text;
                product.MAIL = TXTPersonelMail.Text;
                product.TELEFON = TXTPersonelTel.Text;
                product.DEPARTMAN = byte.Parse(lookUpEdit1.EditValue.ToString());

                DB.TBLPersonel.Add(product);
                DB.SaveChanges();

                MessageBox.Show("Personel başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
