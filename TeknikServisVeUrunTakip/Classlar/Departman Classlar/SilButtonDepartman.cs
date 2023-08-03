using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisVeUrunTakip.Classlar.Departman_Classlar
{
    public class SilButtonDepartman
    {
        public TextEdit TXTDepartmanID;

        public SilButtonDepartman(TextEdit departmanId)
        {
            TXTDepartmanID = departmanId;
        }

        public void Sil()
        {
            DBTeknikServisEntities DB = new DBTeknikServisEntities();
            int ID = int.Parse(TXTDepartmanID.Text);  //Textboxtaki string olan ID değerini al ve integer'a dönüştür.

            var value = DB.TBLDepartman.Find(ID); //Dönüştürdüğün ID değerinin, sana verilen tabloda konumunu bul.

            DB.TBLDepartman.Remove(value);        //Konuma ait bütün bilgileri sil.

            DB.SaveChanges();

            MessageBox.Show("Departman başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
