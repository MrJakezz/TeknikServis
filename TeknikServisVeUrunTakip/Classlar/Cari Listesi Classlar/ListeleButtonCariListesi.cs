using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknikServisVeUrunTakip.Classlar.Cari_Listesi_Classlar
{
    public class ListeleButtonCariListesi
    {
        public GridControl gridControl1;
        public ListeleButtonCariListesi(GridControl gridControl)
        {
            gridControl1 = gridControl;
        }

        public void Listele()
        {
            DBTeknikServisEntities DB = new DBTeknikServisEntities();

            var values = from value in DB.TBLCari
                         select new
                         {
                             value.ID,
                             value.AD,
                             value.SOYAD,
                             value.TELEFON,
                             value.MAIL,
                             value.IL,
                             value.ILCE,
                             value.BANKA,
                             value.VERGIDAIRESI,
                             value.VERGINO,
                             value.STATU,
                             value.ADRES
                         };

            gridControl1.DataSource = values.ToList();
        }
    }
}
