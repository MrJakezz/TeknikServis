using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknikServisVeUrunTakip.Classlar.Personel_Listesi_Classlar
{
    public class GosterFormPersonelListesi
    {
        public GridControl gridControl1;

        public GosterFormPersonelListesi(GridControl gridControl)
        {
            gridControl1 = gridControl;
        }

        public void Goster()
        {
            DBTeknikServisEntities DB = new DBTeknikServisEntities();

            var values = from value in DB.TBLPersonel
                         select new
                         {
                             value.ID,
                             value.AD,
                             value.SOYAD,
                             value.MAIL,
                             value.TELEFON
                         };

            gridControl1.DataSource = values.ToList();
        }
    }
}
