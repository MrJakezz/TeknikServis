using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisVeUrunTakip.Classlar
{
    public class GuncelleButtonUrunListesi
    {
        public TextEdit TXTUrunAd;
        public TextEdit TXTID;
        public TextEdit TXTMarka;
        public TextEdit TXTStok;
        public TextEdit TXTAlisFiyat;
        public TextEdit TXTSatisFiyat;
        public LookUpEdit lookUpEdit1;
        public GuncelleButtonUrunListesi(TextEdit id, TextEdit urunAd, TextEdit marka, TextEdit stok, TextEdit alisFiyat, TextEdit satisFiyat, LookUpEdit lookUpEdit)
        {
            TXTID = id;
            TXTUrunAd = urunAd;
            TXTMarka = marka;
            TXTStok = stok;
            TXTAlisFiyat = alisFiyat;
            TXTSatisFiyat = satisFiyat;
            lookUpEdit1 = lookUpEdit;
        }
        public void Guncelle()
        {
            DBTeknikServisEntities DB = new DBTeknikServisEntities();

            if (TXTUrunAd.Text != "" && TXTMarka.Text != "" && TXTAlisFiyat.Text != "" && TXTSatisFiyat.Text != "" && TXTStok.Text != "" && lookUpEdit1 != null) {

                int ID = int.Parse(TXTID.Text);

                var value = DB.TBLUrun.Find(ID);

                value.AD = TXTUrunAd.Text;
                value.MARKA = TXTMarka.Text;
                value.STOK = short.Parse(TXTStok.Text);
                value.KATEGORI = byte.Parse(lookUpEdit1.EditValue.ToString());
                value.ALISFIYAT = decimal.Parse(TXTAlisFiyat.Text);
                value.SATISFIYAT = decimal.Parse(TXTSatisFiyat.Text);


                DB.SaveChanges();

                MessageBox.Show("Ürün başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
