using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknikServisVeUrunTakip.Classlar.Personel_Listesi_Classlar
{
    public class DepartmanSecPersonelListesi
    {
        public LookUpEdit lookUpEdit1;

        public DepartmanSecPersonelListesi(LookUpEdit lookUpEdit)
        {
            lookUpEdit1 = lookUpEdit;
        }
        
        public void Departman()
        {
            DBTeknikServisEntities DB = new DBTeknikServisEntities();

            var values = from value in DB.TBLDepartman
                         select new
                         {
                             value.ID,
                             value.AD
                         };

            lookUpEdit1.Properties.DataSource = values.ToList();
        }
    }
}
