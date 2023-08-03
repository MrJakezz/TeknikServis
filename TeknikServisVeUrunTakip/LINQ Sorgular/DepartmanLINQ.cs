using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknikServisVeUrunTakip.LINQ_Sorgular
{
    public class DepartmanLINQ
    {
        public LabelControl lblToplamDepartman;
        public LabelControl lblToplamPersonel;
        public LabelControl lblEnFazlaCalisanDepartman;
        public LabelControl lblEnAzCalisanDepartman;

        public DepartmanLINQ(LabelControl toplamDepartman, LabelControl toplamPersonel, LabelControl enFazlaCalisanDepartman, LabelControl enAzCalisanDepartman)
        {
            lblToplamDepartman = toplamDepartman;
            lblToplamPersonel = toplamPersonel;
            lblEnFazlaCalisanDepartman = enFazlaCalisanDepartman;
            lblEnAzCalisanDepartman = enAzCalisanDepartman;
        }

        //
        //
        DBTeknikServisEntities DB = new DBTeknikServisEntities();
        //
        //
        public void ToplamDepartman()
        {
            lblToplamDepartman.Text = DB.TBLDepartman.Count().ToString();
        }

        public void ToplamPersonel()
        {
            lblToplamPersonel.Text = DB.TBLPersonel.Count().ToString();
        }

        public void EnFazlaCalisan()
        {
            
        }

        public void EnAzCalisan()
        {

        }
    }
}
