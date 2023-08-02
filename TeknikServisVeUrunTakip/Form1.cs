using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisVeUrunTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnUrunListesiFormu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FRMUrunListesi fr = new Formlar.FRMUrunListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnYeniUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FRMYeniUrun fr = new Formlar.FRMYeniUrun();
            
            fr.Show();
        }

        private void BtnKategoriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FRMKategori fr = new Formlar.FRMKategori();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnYeniKategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FRMYeniKategori fr = new Formlar.FRMYeniKategori();
            
            fr.Show();
        }

        private void BtnIstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FRMIstatistik fr = new Formlar.FRMIstatistik();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnMarkaIstatistikleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FRMMarkalar fr = new Formlar.FRMMarkalar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnCariListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FRMCariListesi fr = new Formlar.FRMCariListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnCariIstatistigi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FRMCariChart fr = new Formlar.FRMCariChart();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnYeniCari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FRMYeniCari fr = new Formlar.FRMYeniCari();
            
            fr.Show();
        }
    }
}
