using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TeknikServisVeUrunTakip.LINQ_Sorgular
{
    public class UrunIstatistikleriLINQ
    {
        #region Constructor ve Tanımlamalar
        public LabelControl lblToplamUrun;
        public LabelControl lblToplamKategori;
        public LabelControl lblToplamStok;
        public LabelControl lblYuksekFiyat;
        public LabelControl lblKritikSeviye;
        public LabelControl lblEnFazlaStok;
        public LabelControl lblEnFazlaUrunKategori;
        public LabelControl lblEnAzStok;
        public LabelControl lblDusukFiyat;
        public LabelControl lblBugunSatilanUrun;
        public LabelControl lblToplamMarka;
        public LabelControl lblEnFazlaUrunuOlanMarka;
        public LabelControl lblArizali;
        public LabelControl lblTamir;
        public LabelControl lblBugunArizaliUrun;

        public UrunIstatistikleriLINQ (LabelControl toplamUrun, LabelControl toplamKategori, LabelControl toplamStok, LabelControl yuksekFiyat, LabelControl kritikSeviye, LabelControl enFazlaStok, LabelControl enFazlaUrunKategori, LabelControl enAzStok, LabelControl dusukFiyat, LabelControl bugunSatilanUrun, LabelControl toplamMarka, LabelControl enFazlaUrunuOlanMarka, LabelControl arizali, LabelControl tamir, LabelControl bugunArizaliUrun)
        {
            lblToplamUrun = toplamUrun;
            lblToplamKategori = toplamKategori;
            lblToplamStok = toplamStok;
            lblYuksekFiyat = yuksekFiyat;
            lblKritikSeviye = kritikSeviye;
            lblEnFazlaStok = enFazlaStok;
            lblEnFazlaUrunKategori = enFazlaUrunKategori;
            lblEnAzStok = enAzStok;
            lblDusukFiyat = dusukFiyat;
            lblBugunSatilanUrun = bugunSatilanUrun;
            lblToplamMarka = toplamMarka;
            lblEnFazlaUrunuOlanMarka = enFazlaUrunuOlanMarka;
            lblArizali = arizali;
            lblTamir = tamir;
            lblBugunArizaliUrun = bugunArizaliUrun;
        }
        //
        //
        DBTeknikServisEntities DB = new DBTeknikServisEntities();
        //
        //
        #endregion
        #region Metotlar
        public void ToplamUrun()
        {
            lblToplamUrun.Text = DB.TBLUrun.Count().ToString();
        }

        public void ToplamKategori()
        {
            lblToplamKategori.Text = DB.TBLKategori.Count().ToString();
        }

        public void ToplamStok()
        {
            lblToplamStok.Text = DB.TBLUrun.Sum (product => product.STOK).ToString();
        }

        public void EnYuksekFiyatliUrun()
        {
            lblYuksekFiyat.Text = (from product in DB.TBLUrun
                                   orderby product.SATISFIYAT descending
                                   select product.AD).FirstOrDefault();
        }

        public void KritikSeviye()
        {
            lblKritikSeviye.Text = "10";
        }
        public void EnFazlaStokluUrun()
        {
            lblEnFazlaStok.Text = (from product in DB.TBLUrun
                                   orderby product.STOK descending
                                   select product.AD).FirstOrDefault();
        }

        public void EnFazlaUrunKategori()
        {

        }

        public void EnAzStok()
        {
            lblEnAzStok.Text = (from product in DB.TBLUrun
                                orderby product.STOK ascending
                                select product.AD).FirstOrDefault();
        }

        public void DusukFiyat()
        {
            lblDusukFiyat.Text = (from product in DB.TBLUrun
                                   orderby product.SATISFIYAT ascending
                                   select product.AD).FirstOrDefault();
        }

        public void BugunSatilanUrun()
        {

        }

        public void ToplamMarka()
        {
            lblToplamMarka.Text = (from product in DB.TBLUrun
                              select product.MARKA).Distinct().Count().ToString();
        }

        public void EnFazlaUrunuOlanMarka()
        {

        }

        public void Arizali()
        {

        }

        public void Tamir()
        {

        }

        public void BugunArizaliUrun()
        {

        }
        #endregion
    }
}
