using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisVeUrunTakip.Classlar.Yeni_Ürün_Classlar
{
    public class KaydetButtonYeniUrun
    {
        public TextEdit txtUrunAd;
        public TextEdit txtMarka;
        public TextEdit txtAlisFiyat;
        public TextEdit txtSatisFiyat;
        public TextEdit txtStok;
        public TextEdit txtKategori;

        public KaydetButtonYeniUrun(TextEdit urunAd, TextEdit marka, TextEdit alisFiyat, TextEdit satisFiyat, TextEdit stok, TextEdit kategori)
        {
            txtUrunAd = urunAd;
            txtMarka = marka;
            txtAlisFiyat = alisFiyat;
            txtSatisFiyat = satisFiyat;
            txtStok = stok;
            txtKategori = kategori;
        }

        public void Kaydet()
        {
            DBTeknikServisEntities DB = new DBTeknikServisEntities();

            TBLUrun product = new TBLUrun();

            product.AD = txtUrunAd.Text;
            product.MARKA = txtMarka.Text;
            product.ALISFIYAT = decimal.Parse(txtAlisFiyat.Text);
            product.SATISFIYAT = decimal.Parse(txtSatisFiyat.Text);
            product.KATEGORI = byte.Parse(txtKategori.Text);
            product.DURUM = false;
            product.STOK = short.Parse(txtStok.Text);

            DB.TBLUrun.Add(product);
            DB.SaveChanges();

            MessageBox.Show("Ürün başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
