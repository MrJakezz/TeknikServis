using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisVeUrunTakip.Classlar.Cari_Listesi_Classlar
{
    public class SilButtonCariListesi
    {
        public TextEdit TXTCariID;

        public SilButtonCariListesi(TextEdit id)
        {
            TXTCariID = id;
        }

        public void Sil()
        {
            DBTeknikServisEntities DB = new DBTeknikServisEntities();
            int ID = int.Parse(TXTCariID.Text);  //Textboxtaki string olan ID değerini al ve integer'a dönüştür.

            var value = DB.TBLCari.Find(ID); //Dönüştürdüğün ID değerinin, sana verilen tabloda konumunu bul.

            DB.TBLCari.Remove(value);        //Konuma ait bütün bilgileri sil.

            DB.SaveChanges();

            MessageBox.Show("Cari başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
