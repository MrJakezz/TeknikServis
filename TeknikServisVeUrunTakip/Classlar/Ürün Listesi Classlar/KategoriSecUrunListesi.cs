using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknikServisVeUrunTakip.Classlar.Ürün_Listesi_Classlar
{
    public class KategoriSecUrunListesi
    {
        public LookUpEdit lookUpEdit1;

        public KategoriSecUrunListesi(LookUpEdit lookUpEdit)
        {
            lookUpEdit1 = lookUpEdit;
        }

        public void Kategori()
        {
            DBTeknikServisEntities DB = new DBTeknikServisEntities();

            var values = from value in DB.TBLKategori
                         select new
                         {
                             value.ID,
                             value.AD
                         };

            lookUpEdit1.Properties.DataSource = values.ToList();
        }
    }
}
