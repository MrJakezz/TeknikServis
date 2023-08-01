using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeknikServisVeUrunTakip.Classlar.Kategori_Classlar;

namespace TeknikServisVeUrunTakip.Formlar
{
    public partial class FRMKategori : Form
    {
        public FRMKategori()
        {
            InitializeComponent();
        }

        private void FRMKategori_Load(object sender, EventArgs e)
        {
            GosterFormKategori showObj = new GosterFormKategori(gridControl1);
            showObj.Goster();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TXTKategoriID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TXTKategoriAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
        }

        private void BTNKaydetKategori_Click(object sender, EventArgs e)
        {
            KaydetButtonKategori saveObj = new KaydetButtonKategori(TXTKategoriAd);
            saveObj.Kaydet();
        }

        private void BTNSilKategori_Click(object sender, EventArgs e)
        {
            SilButtonKategori deleteObj = new SilButtonKategori(TXTKategoriID);
            deleteObj.Sil();
        }

        private void BTNGuncelleKategori_Click(object sender, EventArgs e)
        {
            GuncelleButtonKategori updateObj = new GuncelleButtonKategori(TXTKategoriAd, TXTKategoriID);
            updateObj.Guncelle();
        }

        private void BTNListeleKategori_Click(object sender, EventArgs e)
        {
            ListeleButtonKategori listObj = new ListeleButtonKategori(gridControl1);
            listObj.Listele();
        }
    }
}
