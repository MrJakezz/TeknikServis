using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknikServisVeUrunTakip.Classlar.Departman_Classlar
{
    public class ListeleButtonDepartman
    {
        public GridControl gridControl1;

        public ListeleButtonDepartman(GridControl gridControl)
        {
            gridControl1 = gridControl;
        }

        public void Listele()
        {
            //Listeleme -ToList, Add, Remove-
            DBTeknikServisEntities DB = new DBTeknikServisEntities();

            var values = from value in DB.TBLDepartman
                         select new
                         {
                             value.ID,
                             value.AD,
                             value.ACIKLAMA
                         };

            gridControl1.DataSource = values.ToList();
        }
    }
}
