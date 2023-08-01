using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisVeUrunTakip.Classlar.Kategori_Classlar
{
    public class SilButtonKategori
    {
        public TextEdit TXTKategoriID;

        public SilButtonKategori(TextEdit textKategoriID)
        {
            TXTKategoriID = textKategoriID;
        }

        public void Sil()
        {
            DBTeknikServisEntities DB = new DBTeknikServisEntities();
            int ID = int.Parse(TXTKategoriID.Text);  //Textboxtaki string olan ID değerini al ve integer'a dönüştür.

            var value = DB.TBLKategori.Find(ID); //Dönüştürdüğün ID değerinin, sana verilen tabloda konumunu bul.

            DB.TBLKategori.Remove(value);        //Konuma ait bütün bilgileri sil.

            DB.SaveChanges();

            MessageBox.Show("Kategori başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
