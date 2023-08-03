using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisVeUrunTakip.Classlar.Yeni_KategoriClasslar
{
    public class KaydetButtonYeniKategori
    {
        public TextEdit txtKategoriAd;

        public KaydetButtonYeniKategori(TextEdit kategoriAd)
        {
            txtKategoriAd = kategoriAd;
        }

        public void Kaydet()
        {
            DBTeknikServisEntities DB = new DBTeknikServisEntities();

            TBLKategori product = new TBLKategori();

            if (txtKategoriAd.Text != "")
            {
                product.AD = txtKategoriAd.Text;

                DB.TBLKategori.Add(product);
                DB.SaveChanges();

                MessageBox.Show("Kategori başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
