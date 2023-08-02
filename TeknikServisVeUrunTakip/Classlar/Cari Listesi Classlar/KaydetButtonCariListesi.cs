using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Filtering.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisVeUrunTakip.Classlar.Cari_Listesi_Classlar
{
    public class KaydetButtonCariListesi
    {
        public TextEdit TXTAd;
        public TextEdit TXTSoyad;
        public TextEdit TXTTelNo;
        public TextEdit TXTMail;
        public TextEdit TXTIl;
        public TextEdit TXTIlce;
        public TextEdit TXTBanka;
        public TextEdit TXTVergiDairesi;
        public TextEdit TXTVergiNo;
        public TextEdit TXTStatu;
        public TextEdit TXTAdres;

        public KaydetButtonCariListesi(TextEdit ad, TextEdit soyad, TextEdit telNo, TextEdit mail, TextEdit il, TextEdit ilce, TextEdit banka, TextEdit vergiDairesi, TextEdit vergiNo, TextEdit statu, TextEdit adres)
        {
            TXTAd = ad;
            TXTSoyad = soyad;
            TXTTelNo = telNo;
            TXTMail = mail;
            TXTIl = il;
            TXTIlce = ilce;
            TXTBanka = banka;
            TXTVergiDairesi = vergiDairesi;
            TXTVergiNo = vergiNo;
            TXTStatu = statu;
            TXTAdres = adres;
        }

        public void Kaydet()
        {
            DBTeknikServisEntities DB = new DBTeknikServisEntities();

            TBLCari product = new TBLCari();

            product.AD = TXTAd.Text;
            product.SOYAD = TXTSoyad.Text;
            product.TELEFON = TXTTelNo.Text;
            product.MAIL = TXTMail.Text;
            product.IL = TXTIl.Text;
            product.ILCE = TXTIlce.Text;
            product.BANKA = TXTBanka.Text;
            product.VERGIDAIRESI = TXTVergiDairesi.Text;
            product.VERGINO = TXTVergiNo.Text;
            product.STATU = TXTStatu.Text;
            product.ADRES = TXTAdres.Text;

            DB.TBLCari.Add(product);
            DB.SaveChanges();

            MessageBox.Show("Cari başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
