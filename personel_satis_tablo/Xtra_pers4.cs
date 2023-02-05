using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.OleDb;

namespace personel_satis_tablo
{
    public partial class Xtra_pers4 : DevExpress.XtraEditors.XtraForm
    {
        public Xtra_pers4()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=personel.accdb");

        private void Xtra_pers4_Load(object sender, EventArgs e)
        {
            btn_toplam.Text = Xtra_ana_form.pers4;


            adi();
            hedef();
            hedef_hesap();
            kalan();
            gunlukgereken();
            prim();
        }
        public void adi()
        {

            bag.Open();
            OleDbCommand kmt = new OleDbCommand("Select * from personel where ID=4", bag);
            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                drop_adi.Text = oku["adi"].ToString();
                drop_soyadi.Text = oku["soyadi"].ToString();
            }
            bag.Close();
        }

        public void hedef()
        {
            double a;

            bag.Open();
            OleDbCommand kmt = new OleDbCommand("Select * from hedef where id=1", bag);
            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {

                lbl_top.Text = oku["personel_4"].ToString();
                a = Convert.ToDouble(lbl_top.Text);

                btn_hdf_100.Text = a.ToString();
                btn_hdf_100.Text = (string.Format("{0:0,0 }", a));




            }
            bag.Close();
        }
        public void hedef_hesap()
        {
            double a, b, c, d, e;
            a = Convert.ToDouble(btn_hdf_100.Text);
            b = (a * 80) / 100;
            c = (a * 90) / 100;
            d = (a * 120) / 100;
            e = (a * 138) / 100;

            btn_hdf_80.Text = b.ToString();
            btn_hdf_80.Text = (string.Format("{0:0,0 }", b));
            btn_hdf_90.Text = c.ToString();
            btn_hdf_90.Text = (string.Format("{0:0,0 }", c));
            btn_hdf_120.Text = d.ToString();
            btn_hdf_120.Text = (string.Format("{0:0,0 }", d));
            btn_hdf_140.Text = e.ToString();
            btn_hdf_140.Text = (string.Format("{0:0,0 }", e));



        }
        public void kalan()
        {
            double a, b, c, d, e, f, g, h, ı, j, k;

            a = Convert.ToDouble(btn_toplam.Text);

            b = Convert.ToDouble(btn_hdf_80.Text);
            c = Convert.ToDouble(btn_hdf_90.Text);
            d = Convert.ToDouble(btn_hdf_100.Text);
            e = Convert.ToDouble(btn_hdf_120.Text);
            f = Convert.ToDouble(btn_hdf_140.Text);

            g = b - a;
            h = c - a;
            ı = d - a;
            j = e - a;
            k = f - a;


            btn_kln_80.Text = g.ToString();
            btn_kln_80.Text = (string.Format("{0:0,0 }", g));
            btn_kln_90.Text = h.ToString();
            btn_kln_90.Text = (string.Format("{0:0,0 }", h));
            btn_kln_100.Text = ı.ToString();
            btn_kln_100.Text = (string.Format("{0:0,0 }", ı));
            btn_kln_120.Text = j.ToString();
            btn_kln_120.Text = (string.Format("{0:0,0 }", j));
            btn_kln_140.Text = k.ToString();
            btn_kln_140.Text = (string.Format("{0:0,0 }", k));







        }
        public void gunlukgereken()
        {
            DateTime aysonu = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);

            double a, b, c, d, e, f, g, h, i, j, k, l, m;

            a = DateTime.Now.Day;
            b = Convert.ToInt32(aysonu.Day);

            c = Convert.ToDouble(btn_kln_80.Text);
            d = Convert.ToDouble(btn_kln_90.Text);
            e = Convert.ToDouble(btn_kln_100.Text);
            f = Convert.ToDouble(btn_kln_120.Text);
            g = Convert.ToDouble(btn_kln_140.Text);


            h = b - a;
            if (h == 0)
            {
                h = 1;
                i = c / h;
                j = d / h;
                k = e / h;
                l = f / h;
                m = g / h;


                btn_grkn_80.Text = i.ToString();
                btn_grkn_80.Text = (string.Format("{0:0,0 }", i));
                btn_grkn_90.Text = j.ToString();
                btn_grkn_90.Text = (string.Format("{0:0,0 }", j));
                btn_grkn_100.Text = k.ToString();
                btn_grkn_100.Text = (string.Format("{0:0,0 }", k));
                btn_grkn_120.Text = l.ToString();
                btn_grkn_120.Text = (string.Format("{0:0,0 }", l));
                btn_grkn_140.Text = m.ToString();
                btn_grkn_140.Text = (string.Format("{0:0,0 }", m));
            }
            else
            {
                i = c / h;
                j = d / h;
                k = e / h;
                l = f / h;
                m = g / h;


                btn_grkn_80.Text = i.ToString();
                btn_grkn_80.Text = (string.Format("{0:0,0 }", i));
                btn_grkn_90.Text = j.ToString();
                btn_grkn_90.Text = (string.Format("{0:0,0 }", j));
                btn_grkn_100.Text = k.ToString();
                btn_grkn_100.Text = (string.Format("{0:0,0 }", k));
                btn_grkn_120.Text = l.ToString();
                btn_grkn_120.Text = (string.Format("{0:0,0 }", l));
                btn_grkn_140.Text = m.ToString();
                btn_grkn_140.Text = (string.Format("{0:0,0 }", m));
            }




        }
        public void prim()
        {
            double x;
            double a, b, c, d, e, f;

            x = Convert.ToDouble(btn_toplam.Text);

            a = x / 1.08 / 100;

            b = a * 0.5 * 1000;//%80
            c = a * 0.9 * 1000;//%90
            d = a * 1.25 * 1000;//%100
            e = a * 1.5 * 1000;//%120
            f = a * 1.8 * 1000;//%138

            btn_prim_80.Text = b.ToString();
            btn_prim_80.Text = (string.Format("{0:0, TL}", b));

            btn_prim_90.Text = c.ToString();
            btn_prim_90.Text = (string.Format("{0:0, TL}", c));

            btn_prim_100.Text = d.ToString();
            btn_prim_100.Text = (string.Format("{0:0, TL}", d));

            btn_prim_120.Text = e.ToString();
            btn_prim_120.Text = (string.Format("{0:0, TL}", e));

            btn_prim_140.Text = f.ToString();
            btn_prim_140.Text = (string.Format("{0:0, TL}", f));


        }
    }
}