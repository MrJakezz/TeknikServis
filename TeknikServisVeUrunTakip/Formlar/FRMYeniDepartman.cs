using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeknikServisVeUrunTakip.Classlar.Yeni_Departman_Classlar;

namespace TeknikServisVeUrunTakip.Formlar
{
    public partial class FRMYeniDepartman : Form
    {
        public FRMYeniDepartman()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            KaydetButtonYeniDepartman saveObj = new KaydetButtonYeniDepartman(txtDepartmanAd, txtAciklama);
            saveObj.Kaydet();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
