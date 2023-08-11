using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisVeUrunTakip.Classlar.Notlar_Classlar
{
    public class SilButtonNotlar
    {
        public TextEdit TXTNotID;

        public SilButtonNotlar(TextEdit notId)
        {
            TXTNotID = notId;
        }

        public void Sil()
        {
            DBTeknikServisEntities DB = new DBTeknikServisEntities();
            int ID = int.Parse(TXTNotID.Text);  //Textboxtaki string olan ID değerini al ve integer'a dönüştür.

            var value = DB.TBLNotlarim.Find(ID); //Dönüştürdüğün ID değerinin, sana verilen tabloda konumunu bul.

            DB.TBLNotlarim.Remove(value);        //Konuma ait bütün bilgileri sil.

            DB.SaveChanges();

            MessageBox.Show("Not başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
