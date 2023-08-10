using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisVeUrunTakip.Classlar.Personel_Listesi_Classlar
{
    public class GuncelleButtonPersonelListesi
    {
        public TextEdit TXTPersonelID;
        public TextEdit TXTPersonelAd;
        public TextEdit TXTPersonelSoyad;
        public TextEdit TXTPersonelMail;
        public TextEdit TXTPersonelTel;
        public LookUpEdit lookUpEdit1;
        public GuncelleButtonPersonelListesi(TextEdit id, TextEdit ad, TextEdit soyad, TextEdit mail, TextEdit tel, LookUpEdit lookUpEdit)
        {
            TXTPersonelID = id;
            TXTPersonelAd = ad;
            TXTPersonelSoyad = soyad;
            TXTPersonelMail = mail;
            TXTPersonelTel = tel;
            lookUpEdit1 = lookUpEdit;
        }
        public void Guncelle()
        {
            DBTeknikServisEntities DB = new DBTeknikServisEntities();

            if (TXTPersonelAd.Text != "" && TXTPersonelSoyad.Text != "" && TXTPersonelMail.Text != "" && TXTPersonelTel.Text != "" && lookUpEdit1 != null) {

                int ID = int.Parse(TXTPersonelID.Text);

                var value = DB.TBLPersonel.Find(ID);

                value.AD = TXTPersonelAd.Text;
                value.SOYAD = TXTPersonelSoyad.Text;
                value.DEPARTMAN = byte.Parse(lookUpEdit1.EditValue.ToString());
                value.MAIL = TXTPersonelMail.Text;
                value.TELEFON = TXTPersonelTel.Text;


                DB.SaveChanges();

                MessageBox.Show("Personel başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
