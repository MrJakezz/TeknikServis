﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisVeUrunTakip.Classlar
{
    public class KaydetButton
    {
        public TextEdit TXTUrunAd;
        public TextEdit TXTMarka;
        public TextEdit TXTAlisFiyat;
        public TextEdit TXTSatisFiyat;
        public TextEdit TXTStok;
        public LookUpEdit lookUpEdit1;

        public KaydetButton(TextEdit urunAd, TextEdit marka, TextEdit alisFiyat, TextEdit satisFiyat, TextEdit stok, LookUpEdit lookUpEdit)
        {
            TXTUrunAd = urunAd;
            TXTMarka = marka;
            TXTAlisFiyat = alisFiyat;
            TXTSatisFiyat = satisFiyat;
            TXTStok = stok;
            lookUpEdit1 = lookUpEdit;
        }

        public void Kaydet()
        {
            DBTeknikServisEntities DB = new DBTeknikServisEntities();

            TBLUrun product = new TBLUrun();

            product.AD = TXTUrunAd.Text;
            product.MARKA = TXTMarka.Text;
            product.ALISFIYAT = decimal.Parse(TXTAlisFiyat.Text);
            product.SATISFIYAT = decimal.Parse(TXTSatisFiyat.Text);
            product.KATEGORI = byte.Parse(lookUpEdit1.EditValue.ToString());
            product.DURUM = false;
            product.STOK = short.Parse(TXTStok.Text);

            DB.TBLUrun.Add(product);
            DB.SaveChanges();

            MessageBox.Show("Ürün başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
