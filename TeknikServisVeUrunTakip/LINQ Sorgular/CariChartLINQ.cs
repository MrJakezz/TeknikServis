using DevExpress.XtraCharts;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServisVeUrunTakip.SQL;

namespace TeknikServisVeUrunTakip.LINQ_Sorgular
{
    public class CariChartLINQ
    {

        public ChartControl chartControl1;
        public GridControl gridControl1;

        public CariChartLINQ(ChartControl chartControl, GridControl gridControl)
        {
            chartControl1 = chartControl;
            gridControl1 = gridControl;
        }
        //
        //
        DBTeknikServisEntities DB = new DBTeknikServisEntities();
        //
        //
        public void Iller()
        {
            gridControl1.DataSource = DB.TBLCari.OrderBy(x => x.IL).GroupBy(y => y.IL).Select(z => new
            {
                İl = z.Key,
                Toplam = z.Count()
            }).ToList();
        }
    }
}
