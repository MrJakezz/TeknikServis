using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknikServisVeUrunTakip.Classlar.Kategori_Classlar
{
    public class ListeleButtonKategori
    {
        public GridControl gridControl1;

        public ListeleButtonKategori(GridControl gridControl)
        {
            gridControl1 = gridControl;
        }

        public void Listele()
        {
            //Listeleme -ToList, Add, Remove-
            DBTeknikServisEntities DB = new DBTeknikServisEntities();

            var values = from value in DB.TBLKategori
                         select new
                         {
                             value.ID,
                             value.AD,
                         };

            gridControl1.DataSource = values.ToList();
        }
    }
}
