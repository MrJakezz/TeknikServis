using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknikServisVeUrunTakip.LINQ_Sorgular
{
    public class PersonelListesiLINQ
    {
        public LabelControl LBLAdSoyad1;
        public LabelControl LBLDepartman1;
        public LabelControl LBLMail1;

        public LabelControl LBLAdSoyad2;
        public LabelControl LBLDepartman2;
        public LabelControl LBLMail2;

        public LabelControl LBLAdSoyad3;
        public LabelControl LBLDepartman3;
        public LabelControl LBLMail3;

        public LabelControl LBLAdSoyad4;
        public LabelControl LBLDepartman4;
        public LabelControl LBLMail4;



        public PersonelListesiLINQ(LabelControl adSoyad1, LabelControl departman1, LabelControl mail1, LabelControl adSoyad2, LabelControl departman2, LabelControl mail2, LabelControl adSoyad3, LabelControl departman3, LabelControl mail3, LabelControl adSoyad4, LabelControl departman4, LabelControl mail4)
        {
            LBLAdSoyad1 = adSoyad1;
            LBLDepartman1 = departman1;
            LBLMail1 = mail1;

            LBLAdSoyad2 = adSoyad2;
            LBLDepartman2 = departman2;
            LBLMail2 = mail2;

            LBLAdSoyad3 = adSoyad3;
            LBLDepartman3 = departman3;
            LBLMail3 = mail3;

            LBLAdSoyad4 = adSoyad4;
            LBLDepartman4 = departman4;
            LBLMail4 = mail4;
        }
        //
        //
        DBTeknikServisEntities DB = new DBTeknikServisEntities();
        //
        //
        public void AdVeSoyadlar()
        {
            string ad1, ad2, ad3, ad4;
            string soyad1, soyad2, soyad3, soyad4;

            ad1 = DB.TBLPersonel.First(x => x.ID == 1).AD;
            soyad1 = DB.TBLPersonel.First(x => x.ID == 1).SOYAD;
            LBLAdSoyad1.Text = ad1 + " " + soyad1;

            ad2 = DB.TBLPersonel.First(x => x.ID == 2).AD;
            soyad2 = DB.TBLPersonel.First(x => x.ID == 2).SOYAD;
            LBLAdSoyad2.Text = ad2 + " " + soyad2;

            ad3 = DB.TBLPersonel.First(x => x.ID == 3).AD;
            soyad3 = DB.TBLPersonel.First(x => x.ID == 3).SOYAD;
            LBLAdSoyad3.Text = ad3 + " " + soyad3;

            ad4 = DB.TBLPersonel.First(x => x.ID == 4).AD;
            soyad4 = DB.TBLPersonel.First(x => x.ID == 4).SOYAD;
            LBLAdSoyad4.Text = ad4 + " " + soyad4;
        }

        public void Departmanlar()
        {
            LBLDepartman1.Text = DB.TBLPersonel.First(x => x.ID == 1).TBLDepartman.AD;

            LBLDepartman2.Text = DB.TBLPersonel.First(x => x.ID == 2).TBLDepartman.AD;

            LBLDepartman3.Text = DB.TBLPersonel.First(x => x.ID == 3).TBLDepartman.AD;

            LBLDepartman4.Text = DB.TBLPersonel.First(x => x.ID == 4).TBLDepartman.AD;
        }

        public void Mailler()
        {
            LBLMail1.Text = DB.TBLPersonel.First(x => x.ID == 1).MAIL;

            LBLMail2.Text = DB.TBLPersonel.First(x => x.ID == 2).MAIL;

            LBLMail3.Text = DB.TBLPersonel.First(x => x.ID == 3).MAIL;

            LBLMail4.Text = DB.TBLPersonel.First(x => x.ID == 4).MAIL;
        }
    }
}
