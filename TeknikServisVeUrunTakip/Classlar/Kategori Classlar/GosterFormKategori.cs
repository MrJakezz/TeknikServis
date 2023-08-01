using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknikServisVeUrunTakip.Classlar.Kategori_Classlar
{
    public class GosterFormKategori
    {
        public GridControl gridControl1;
        public GosterFormKategori(GridControl gridControl)
        {
            gridControl1 = gridControl;
        }
        public void Goster()
        {
            DBTeknikServisEntities DB = new DBTeknikServisEntities();

            var values = from value in DB.TBLKategori
                         select new
                         {
                             value.ID,
                             value.AD
                         };

            gridControl1.DataSource = values.ToList();
        }
    }
}
