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
using TeknikServisVeUrunTakip.Classlar.Personel_Listesi_Classlar;
using TeknikServisVeUrunTakip.LINQ_Sorgular;

namespace TeknikServisVeUrunTakip.Formlar
{
    public partial class FRMPersonel : Form
    {
        public FRMPersonel()
        {
            InitializeComponent();
        }

        private void FRMPersonel_Load(object sender, EventArgs e)
        {
            GosterFormPersonelListesi showObj = new GosterFormPersonelListesi(gridControl1);
            PersonelListesiLINQ statistics = new PersonelListesiLINQ(LBLAdSoyad1, LBLDepartman1, LBLMail1, LBLAdSoyad2, LBLDepartman2, LBLMail2, LBLAdSoyad3, LBLDepartman3, labelControl16, LBLAdSoyad4, LBLDepartman4, labelControl22);

            showObj.Goster();
            statistics.AdVeSoyadlar();
            statistics.Departmanlar();
            statistics.Mailler();
        }
    }
}
