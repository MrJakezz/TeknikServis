using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisVeUrunTakip.Classlar.Departman_Classlar
{
    public class GuncelleButtonDepartman
    {
        public TextEdit TXTDepartmanAd;
        public TextEdit TXTDepartmanID;
        public RichTextBox TXTAciklama;

        public GuncelleButtonDepartman(TextEdit departmanAd, TextEdit departmanId, RichTextBox aciklama)
        {
            TXTDepartmanAd = departmanAd;
            TXTDepartmanID = departmanId;
            TXTAciklama = aciklama;
        }

        public void Guncelle()
        {
            DBTeknikServisEntities DB = new DBTeknikServisEntities();

            int ID = int.Parse(TXTDepartmanID.Text);

            var value = DB.TBLDepartman.Find(ID);

            value.AD = TXTDepartmanAd.Text;
            value.ACIKLAMA = TXTAciklama.Text;

            DB.SaveChanges();

            MessageBox.Show("Departman başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
