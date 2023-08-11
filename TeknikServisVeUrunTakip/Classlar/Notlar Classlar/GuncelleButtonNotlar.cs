using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisVeUrunTakip.Classlar.Notlar_Classlar
{
    public class GuncelleButtonNotlar
    {
        public CheckEdit checkEdit1;
        public TextEdit TXTNotID;

        public GuncelleButtonNotlar(CheckEdit checkEdit, TextEdit notId)
        {
            checkEdit1 = checkEdit;
            TXTNotID = notId;
        }

        public void Guncelle()
        {
            DBTeknikServisEntities DB = new DBTeknikServisEntities();

            if (checkEdit1.Checked == true)
            {

                int ID = int.Parse(TXTNotID.Text);

                var value = DB.TBLNotlarim.Find(ID);

                value.DURUM = true;


                DB.SaveChanges();

                MessageBox.Show("Kategori başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                int ID = int.Parse(TXTNotID.Text);

                var value = DB.TBLNotlarim.Find(ID);

                value.DURUM = false;


                DB.SaveChanges();

                MessageBox.Show("Kategori başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
