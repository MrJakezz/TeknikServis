using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisVeUrunTakip.Classlar
{
    public class SilButton
    {
        public TextEdit TXTID;

        public SilButton(TextEdit textID)
        {
            TXTID = textID;
        }

        public void Sil()
        {
            DBTeknikServisEntities DB = new DBTeknikServisEntities();
            int ID = int.Parse(TXTID.Text);  //Textboxtaki string olan ID değerini al ve integer'a dönüştür.

            var value = DB.TBLUrun.Find(ID); //Dönüştürdüğün ID değerinin, sana verilen tabloda konumunu bul.

            DB.TBLUrun.Remove(value);        //Konuma ait bütün bilgileri sil.

            DB.SaveChanges();

            MessageBox.Show("Ürün başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
