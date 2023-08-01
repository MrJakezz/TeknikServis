using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeknikServisVeUrunTakip.Classlar.Yeni_KategoriClasslar;

namespace TeknikServisVeUrunTakip.Formlar
{
    public partial class FRMYeniKategori : Form
    {
        public FRMYeniKategori()
        {
            InitializeComponent();
        }

        private void BtnSaveKategori_Click(object sender, EventArgs e)
        {
            KaydetButtonYeniKategori saveObj = new KaydetButtonYeniKategori(txtKategoriAd);
            saveObj.Kaydet();
        }

        private void BtnCancelKategori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
