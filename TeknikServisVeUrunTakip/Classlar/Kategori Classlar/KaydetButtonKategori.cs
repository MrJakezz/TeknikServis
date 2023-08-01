using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisVeUrunTakip.Classlar.Kategori_Classlar
{
    public class KaydetButtonKategori
    {
        public TextEdit TXTKategoriAd;

        public KaydetButtonKategori(TextEdit kategoriAd)
        {
            TXTKategoriAd = kategoriAd;
        }

        public void Kaydet()
        {
            DBTeknikServisEntities DB = new DBTeknikServisEntities();

            TBLKategori product = new TBLKategori();

            product.AD = TXTKategoriAd.Text;

            DB.TBLKategori.Add(product);
            DB.SaveChanges();

            MessageBox.Show("Kategori başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
