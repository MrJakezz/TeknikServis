using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisVeUrunTakip.Classlar.Kategori_Classlar
{
    public class GuncelleButtonKategori
    {
        public TextEdit TXTKategoriAd;
        public TextEdit TXTKategoriID;

        public GuncelleButtonKategori(TextEdit kategoriAd, TextEdit kategoriId)
        {
            TXTKategoriAd = kategoriAd;
            TXTKategoriID = kategoriId;
        }

        public void Guncelle()
        {
            DBTeknikServisEntities DB = new DBTeknikServisEntities();

            int ID = int.Parse(TXTKategoriID.Text);

            var value = DB.TBLKategori.Find(ID);

            value.AD = TXTKategoriAd.Text;
            

            DB.SaveChanges();

            MessageBox.Show("Kategori başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
