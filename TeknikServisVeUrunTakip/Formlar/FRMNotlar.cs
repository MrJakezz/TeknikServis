using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeknikServisVeUrunTakip.Classlar.Cari_Listesi_Classlar;
using TeknikServisVeUrunTakip.Classlar.Notlar_Classlar;

namespace TeknikServisVeUrunTakip.Formlar
{
    public partial class FRMNotlar : Form
    {
        public FRMNotlar()
        {
            InitializeComponent();
        }

        private void FRMNotlar_Load(object sender, EventArgs e)
        {
            GosterFormNotlar showObj = new GosterFormNotlar(gridControl1, gridControl2);

            showObj.OkunmamisNotlariGoster();
            showObj.OkunmusNotlariGoster();
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TXTNotID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TXTBaslik.Text = gridView1.GetFocusedRowCellValue("BASLIK").ToString();
            TXTIcerik.Text = gridView1.GetFocusedRowCellValue("ICERIK").ToString();
            checkEdit1.EditValue = false;
        }
        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TXTNotID.Text = gridView2.GetFocusedRowCellValue("ID").ToString();
            TXTBaslik.Text = gridView2.GetFocusedRowCellValue("BASLIK").ToString();
            TXTIcerik.Text = gridView2.GetFocusedRowCellValue("ICERIK").ToString();
            checkEdit1.EditValue = true;
            
        }

        private void BTNKaydetNotlar_Click(object sender, EventArgs e)
        {
            KaydetButtonNotlar saveObj = new KaydetButtonNotlar(TXTBaslik, TXTIcerik, checkEdit1);
            saveObj.Kaydet();
        }

        private void BTNSilNotlar_Click(object sender, EventArgs e)
        {
            SilButtonNotlar deleteObj = new SilButtonNotlar(TXTNotID);
            deleteObj.Sil();
        }

        private void BTNGuncelleNotlar_Click(object sender, EventArgs e)
        {
            GuncelleButtonNotlar updateObj = new GuncelleButtonNotlar(checkEdit1, TXTNotID);
            updateObj.Guncelle();
        }

        private void BTNListeleNotlar_Click(object sender, EventArgs e)
        {
            ListeleButtonNotlar listObj = new ListeleButtonNotlar(gridControl1, gridControl2);
            listObj.OkunmamisNotlariListele();
            listObj.OkunmusNotlariListele();
        }

    }
}
