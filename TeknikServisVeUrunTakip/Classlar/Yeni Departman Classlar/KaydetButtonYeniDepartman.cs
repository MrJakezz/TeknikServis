using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisVeUrunTakip.Classlar.Yeni_Departman_Classlar
{
    public class KaydetButtonYeniDepartman
    {
        public TextEdit txtDepartmanAd;
        public TextEdit txtAciklama;

        public KaydetButtonYeniDepartman(TextEdit departmanAd, TextEdit aciklama)
        {
            txtDepartmanAd = departmanAd;
            txtAciklama = aciklama;       
        }

        public void Kaydet()
        {
            DBTeknikServisEntities DB = new DBTeknikServisEntities();

            TBLDepartman product = new TBLDepartman();

            if (txtDepartmanAd.Text != "" && txtAciklama.Text != "")
            {
                product.AD = txtDepartmanAd.Text;
                product.ACIKLAMA = txtAciklama.Text;

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
