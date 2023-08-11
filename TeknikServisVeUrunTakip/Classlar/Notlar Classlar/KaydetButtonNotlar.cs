using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisVeUrunTakip.Classlar.Notlar_Classlar
{
    public class KaydetButtonNotlar
    {
        public TextEdit TXTBaslik;
        public TextEdit TXTIcerik;
        public CheckEdit checkEdit1;

        public KaydetButtonNotlar(TextEdit baslik, TextEdit icerik, CheckEdit checkEdit)
        {
            TXTBaslik = baslik;
            TXTIcerik = icerik;
            checkEdit1 = checkEdit;
        }

        public void Kaydet()
        {
            DBTeknikServisEntities DB = new DBTeknikServisEntities();

            TBLNotlarim product = new TBLNotlarim();

            if (TXTBaslik.Text != "" && TXTIcerik.Text != "")
            {

                if (checkEdit1.Checked != true) {

                    product.BASLIK = TXTBaslik.Text;
                    product.ICERIK = TXTIcerik.Text;
                    product.DURUM = false;

                    DB.TBLNotlarim.Add(product);
                    DB.SaveChanges();

                    MessageBox.Show("Not başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }

                else
                {
                    MessageBox.Show("Yeni oluşturulan not 'okundu' olarak işaretlenemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
