using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisVeUrunTakip.Classlar.Cari_Listesi_Classlar
{
    public class GuncelleButtonCariListesi
    {
        public TextEdit TXTCariID;
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
        public GuncelleButtonCariListesi(TextEdit id, TextEdit ad, TextEdit soyad, TextEdit telNo, TextEdit mail, TextEdit il, TextEdit ilce, TextEdit banka, TextEdit vergiDairesi, TextEdit vergiNo, TextEdit statu, TextEdit adres)
        {
            TXTCariID = id;
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
        public void Guncelle()
        {
            DBTeknikServisEntities DB = new DBTeknikServisEntities();

            int ID = int.Parse(TXTCariID.Text);

            var value = DB.TBLCari.Find(ID);

            value.AD = TXTAd.Text;
            value.SOYAD = TXTSoyad.Text;
            value.TELEFON = TXTTelNo.Text;
            value.MAIL = TXTMail.Text;
            value.IL = TXTIl.Text;
            value.ILCE = TXTIlce.Text;
            value.BANKA = TXTBanka.Text;
            value.VERGIDAIRESI = TXTVergiDairesi.Text;
            value.VERGINO = TXTVergiNo.Text;
            value.STATU = TXTStatu.Text;
            value.ADRES = TXTAdres.Text;


            DB.SaveChanges();

            MessageBox.Show("Cari başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
