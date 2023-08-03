using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisVeUrunTakip.Classlar.Departman_Classlar
{
    public class KaydetButtonDepartman
    {
        public TextEdit TXTDepartmanAd;
        public RichTextBox TXTAciklama;

        public KaydetButtonDepartman(TextEdit departmanAd, RichTextBox aciklama)
        {
            TXTDepartmanAd = departmanAd;
            TXTAciklama = aciklama;
        }

        public void Kaydet()
        {
            DBTeknikServisEntities DB = new DBTeknikServisEntities();

            TBLDepartman product = new TBLDepartman();

            if (TXTDepartmanAd.Text != "" && TXTAciklama.Text != "")
            {
                product.AD = TXTDepartmanAd.Text;
                product.ACIKLAMA = TXTAciklama.Text;

                DB.TBLDepartman.Add(product);
                DB.SaveChanges();

                MessageBox.Show("Departman başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
