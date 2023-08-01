using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknikServisVeUrunTakip.Classlar
{
    public class GosterForm
    {
        public GridControl gridControl1;

        public GosterForm(GridControl gridControl)
        {
            gridControl1 = gridControl;
        }

        public void Goster()
        {
            //Listeleme -ToList, Add, Remove-
            DBTeknikServisEntities DB = new DBTeknikServisEntities();

            var values = from value in DB.TBLUrun
                         select new
                         {
                             value.ID,
                             value.AD,
                             value.MARKA,
                             value.STOK,
                             value.ALISFIYAT,
                             value.SATISFIYAT,
                             KATEGORI = value.TBLKategori.AD
                         };

            gridControl1.DataSource = values.ToList();
        }
    }
}
