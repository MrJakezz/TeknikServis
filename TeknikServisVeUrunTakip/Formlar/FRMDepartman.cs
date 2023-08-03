using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeknikServisVeUrunTakip.Classlar.Departman_Classlar;
using TeknikServisVeUrunTakip.LINQ_Sorgular;

namespace TeknikServisVeUrunTakip.Formlar
{
    public partial class FRMDepartman : Form
    {
        public FRMDepartman()
        {
            InitializeComponent();
        }

        private void FRMDepartman_Load(object sender, EventArgs e)
        {
            GosterFormDepartman showObj = new GosterFormDepartman(gridControl1);
            DepartmanLINQ statistics = new DepartmanLINQ(lblToplamDepartman, lblToplamPersonel, lblEnFazlaCalisanDepartman, lblEnAzCalisanDepartman);

            showObj.Goster();
            statistics.ToplamDepartman();
            statistics.ToplamPersonel();
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TXTDepartmanID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TXTDepartmanAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            TXTAciklama.Text = gridView1.GetFocusedRowCellValue("ACIKLAMA").ToString();
        }

        private void BTNKaydetDepartman_Click(object sender, EventArgs e)
        {
            KaydetButtonDepartman saveObj = new KaydetButtonDepartman(TXTDepartmanAd, TXTAciklama);
            saveObj.Kaydet();
        }

        private void BTNSilDepartman_Click(object sender, EventArgs e)
        {
            SilButtonDepartman deleteObj = new SilButtonDepartman(TXTDepartmanID);
            deleteObj.Sil();
        }

        private void BTNGuncelleDepartman_Click(object sender, EventArgs e)
        {
            GuncelleButtonDepartman updateObj = new GuncelleButtonDepartman(TXTDepartmanAd, TXTDepartmanID, TXTAciklama);
            updateObj.Guncelle();
        }

        private void BTNListeleDepartman_Click(object sender, EventArgs e)
        {
            ListeleButtonDepartman listObj = new ListeleButtonDepartman(gridControl1);
            listObj.Listele();
        }

    }
}
