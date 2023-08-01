using DevExpress.Utils.VisualEffects;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.UI;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknikServisVeUrunTakip.LINQ_Sorgular
{
    public class MarkaIstatistikleriLINQ
    {
        public GridControl gridControl1;
        public ChartControl chartControl1;
        public ChartControl chartControl2;
        public LabelControl lblToplamUrunKategori;
        public LabelControl lblToplamMarkaKategori;
        public LabelControl lblEnFazlaUrunMarkaKategori;
        public LabelControl lblYuksekFiyatKategori;

        public MarkaIstatistikleriLINQ(GridControl gridControl, ChartControl chartControl, ChartControl chartControlBar, LabelControl toplamUrunKategori, LabelControl toplamMarkaKategori, LabelControl enFazlaUrunMarkaKategori, LabelControl yuksekFiyatKategori)
        {
            gridControl1 = gridControl;
            chartControl1 = chartControl;
            chartControl2 = chartControlBar;
            lblToplamUrunKategori = toplamUrunKategori;
            lblToplamMarkaKategori = toplamMarkaKategori;
            lblEnFazlaUrunMarkaKategori = enFazlaUrunMarkaKategori;
            lblYuksekFiyatKategori = yuksekFiyatKategori;

        }
        //
        //
        DBTeknikServisEntities DB = new DBTeknikServisEntities();
        //
        //
        public void Markalar()
        {
            var values = DB.TBLUrun.OrderBy(x => x.MARKA).GroupBy(y => y.MARKA).Select(z => new
            {
                Marka = z.Key,
                Toplam = z.Count()
            });

            gridControl1.DataSource = values.ToList();
        }

        public void Chart()
        {
            chartControl1.Series["Series 1"].Points.AddPoint("Samsung", 2);
            chartControl1.Series["Series 1"].Points.AddPoint("Arçelik", 1);
            chartControl1.Series["Series 1"].Points.AddPoint("IPhone", 1);
            chartControl1.Series["Series 1"].Points.AddPoint("Logitech", 1);
            chartControl1.Series["Series 1"].Points.AddPoint("Monster", 1);
            chartControl1.Series["Series 1"].Points.AddPoint("Tefal", 1);

            chartControl2.Series["Kategoriler"].Points.AddPoint("Telefon", 2);
            chartControl2.Series["Kategoriler"].Points.AddPoint("Bilgisayar", 1);
            chartControl2.Series["Kategoriler"].Points.AddPoint("TV", 1);
            chartControl2.Series["Kategoriler"].Points.AddPoint("Beyaz Eşya", 1);
            chartControl2.Series["Kategoriler"].Points.AddPoint("Küçük Ev Aleti", 1);
            chartControl2.Series["Kategoriler"].Points.AddPoint("Ses Sistemleri", 1);

        }

        public void ToplamUrun()
        {
            lblToplamUrunKategori.Text = DB.TBLUrun.Count().ToString();
        }

        public void ToplamMarka()
        {
            lblToplamMarkaKategori.Text = (from x in DB.TBLUrun
                                           select x.MARKA).Distinct().Count().ToString();
        }

        public void EnFazlaUrunMarkaKategori()
        {

        }

        public void YuksekFiyat()
        {
            lblYuksekFiyatKategori.Text = (from x in DB.TBLUrun
                                           orderby x.SATISFIYAT descending
                                           select x.MARKA).FirstOrDefault();
        }
    }
}
