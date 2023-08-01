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

namespace TeknikServisVeUrunTakip.Formlar
{
    public partial class FRMCariListesi : Form
    {
        public FRMCariListesi()
        {
            InitializeComponent();
        }

        private void FRMCariListesi_Load(object sender, EventArgs e)
        {
            GosterFormCariListesi showObj = new GosterFormCariListesi(gridControl1);
            showObj.Goster();
        }
    }
}
