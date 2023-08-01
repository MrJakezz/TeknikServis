using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeknikServisVeUrunTakip.Classlar.Yeni_Ürün_Classlar;

namespace TeknikServisVeUrunTakip.Formlar
{
    public partial class FRMYeniUrun : Form
    {
        public FRMYeniUrun()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            KaydetButtonYeniUrun saveObj = new KaydetButtonYeniUrun(txtUrunAd, txtMarka, txtAlisFiyat, txtSatisFiyat, txtStok, txtKategori);
            saveObj.Kaydet();
             
        }
    }
}
