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
    public partial class FRMIstatistik : Form
    {
        public FRMIstatistik()
        {
            InitializeComponent();
        }

        private void FRMIstatistik_Load(object sender, EventArgs e)
        {
            UrunIstatistikleriLINQ statistics = new UrunIstatistikleriLINQ (lblToplamUrun, lblToplamKategori, lblToplamStok, lblYuksekFiyat, lblKritikSeviye, lblEnFazlaStok, lblEnFazlaUrunKategori, lblEnAzStok, lblDusukFiyat, lblBugunSatilanUrun, lblToplamMarka, lblEnFazlaUrunuOlanMarka, lblArizali, lblTamir, lblBugunArizaliUrun);

            statistics.ToplamUrun();
            statistics.ToplamKategori();
            statistics.ToplamStok();
            statistics.EnYuksekFiyatliUrun();
            statistics.KritikSeviye();
            statistics.EnFazlaStokluUrun();
            //statistics.EnFazlaUrunKategori();
            statistics.EnAzStok();
            statistics.DusukFiyat();
            //statistics.BugunSatilanUrun();
            statistics.ToplamMarka();
            //statistics.EnFazlaUrunuOlanMarka();
            //statistics.Arizali();
            //statistics.Tamir();
            //statistics.BugunArizaliUrun();
        }
    }
}
