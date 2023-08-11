using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisVeUrunTakip.Classlar.Notlar_Classlar
{
    public class GosterFormNotlar
    {
        public GridControl gridControl1;
        public GridControl gridControl2;

        public GosterFormNotlar(GridControl _gridControl1, GridControl _gridControl2)
        {
            gridControl1 = _gridControl1;
            gridControl2 = _gridControl2;
        }
        public void OkunmamisNotlariGoster()
        {
            DBTeknikServisEntities DB = new DBTeknikServisEntities();

            var values = from value in DB.TBLNotlarim
                         select new
                         {
                             value.ID,
                             value.BASLIK,
                             value.ICERIK,
                             value.DURUM
                         };

            gridControl1.DataSource = values.Where(x => x.DURUM == false).ToList();
        }
        public void OkunmusNotlariGoster()
        {
            DBTeknikServisEntities DB = new DBTeknikServisEntities();

            var values = from value in DB.TBLNotlarim
                         select new
                         {
                             value.ID,
                             value.BASLIK,
                             value.ICERIK,
                             value.DURUM
                         };

            gridControl2.DataSource = values.Where(x => x.DURUM == true).ToList();
        }
    }
}
