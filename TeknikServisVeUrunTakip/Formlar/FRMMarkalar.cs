using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeknikServisVeUrunTakip.LINQ_Sorgular;

namespace TeknikServisVeUrunTakip.Formlar
{
    public partial class FRMMarkalar : Form
    {
        public FRMMarkalar()
        {
            InitializeComponent();
        }

        private void FRMMarkalar_Load(object sender, EventArgs e)
        {
            MarkaIstatistikleriLINQ brandStatistics = new MarkaIstatistikleriLINQ(gridControl1, chartControl1, chartControl2, lblToplamUrunKategori, lblToplamMarkaKategori, lblEnFazlaUrunMarkaKategori, lblYuksekFiyatKategori);

            brandStatistics.Markalar();
            brandStatistics.Chart();
            brandStatistics.ToplamUrun();
            brandStatistics.ToplamMarka();
            //brandStatistics.EnFazlaUrunMarkaKategori();
            brandStatistics.YuksekFiyat();
        }
    }
}
