using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeknikServisVeUrunTakip.Classlar.Yeni_Cari_Classlar;

namespace TeknikServisVeUrunTakip.Formlar
{
    public partial class FRMYeniCari : Form
    {
        public FRMYeniCari()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            KaydetButtonYeniCari saveObj = new KaydetButtonYeniCari(txtAd, txtSoyad, txtTel, txtMail, txtIl, txtIlce, txtBanka, txtVergiD, txtVergiNo, txtStatu, txtAdres);
            saveObj.Kaydet();
        }
    }
}
