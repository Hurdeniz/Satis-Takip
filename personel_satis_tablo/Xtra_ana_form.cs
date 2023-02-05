using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.OleDb;
using excel = Microsoft.Office.Interop.Excel;


namespace personel_satis_tablo
{
    public partial class Xtra_ana_form : DevExpress.XtraEditors.XtraForm
    {
        public Xtra_ana_form()
        {
            InitializeComponent();
        }

        public static string pers1, pers2, pers3,pers4,magaza;
        public static string pers11, pers22, pers33, pers44;
        public static DataGridView data;
        public static string tarih;

       

        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=personel.accdb");
        DataTable dt = new DataTable();
        private void Xtra_ana_form_Load(object sender, EventArgs e)
        {

            
            
           


                DateTime aysonu = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);



                lbl_ay_sonu.Text = Convert.ToString(aysonu.Day);




                ay();

                personel1();
                personel2();
                personel3();
                personel4();


                grid_doldur();
                isim();
                boyut();

                data_toplama();
                hedef();
                gunlukgereken();

                personel_hedef();

               

                iade();
                kalan();

                prim();
     
        

             
              

                personel1_gunluk_gereken();
                personel2_gunluk_gereken();
                personel3_gunluk_gereken();
                personel4_gunluk_gereken();


                pers1 = btn_kln_pers1.Text;
                pers2 = btn_kln_pers2.Text;
                pers3 = btn_kln_pers3.Text;
                pers4 = btn_kln_pers4.Text;
                data = dataGridView1;
                pers11 = lbl_pers1.Text;
                pers22 = lbl_pers2.Text;
                pers33 = lbl_pers3.Text;
                pers44 = lbl_pers4.Text;

                tarih = date_tarih.Text;
                magaza = btn_mgz_tplm.Text;
               
           
                




            }
       


        public void grid_doldur()
        {
            int i = 0;
            DateTime a,b;
          

            DateTime aybasi = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);           
            DateTime aysonu = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);


            string sqltext = "SELECT  tarih,pers1,pers2,pers3,pers4,tadilat,iade,toplam FROM satis where tarih BETWEEN @tar1 and @tar2 Order By tarih ASC";
            OleDbDataAdapter satis = new OleDbDataAdapter(sqltext, bag);
            satis.SelectCommand.Parameters.AddWithValue("@tar1", aybasi);
            satis.SelectCommand.Parameters.AddWithValue("@tar2", aysonu);
            bag.Open();
            satis.Fill(dt);
            dataGridView1.DataSource = dt;

            DataSet ds = new DataSet();
            satis.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
          

            i = ds.Tables[0].Rows.Count - 1; // tablodaki en son veri
            if (i == -1)
            {
                date_tarih.Text = DateTime.Now.ToShortDateString();
            }
            else
            {
                lbl_tarihhh.Text = ds.Tables[0].Rows[i]["tarih"].ToString();

                a = Convert.ToDateTime(lbl_tarihhh.Text);
                b = a.AddDays(1);
                date_tarih.Text = b.ToString();
                date_tarih.Text = (string.Format("{0:dd.MM.yyyy}", b));

                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
                
            }


            
            bag.Close();
        }
        public void isim()
        {
            dataGridView1.Columns[0].HeaderText = "TARİH";
            dataGridView1.Columns[1].HeaderText = Convert.ToString(lbl_pers1.Text);
            dataGridView1.Columns[2].HeaderText = Convert.ToString(lbl_pers2.Text);
            dataGridView1.Columns[3].HeaderText = Convert.ToString(lbl_pers3.Text);
            dataGridView1.Columns[4].HeaderText = Convert.ToString(lbl_pers4.Text);
            dataGridView1.Columns[5].HeaderText = "TADİLAT";
            dataGridView1.Columns[6].HeaderText = "İADE";
            dataGridView1.Columns[7].HeaderText = "TOPLAM";


        }
        public void boyut()
        {
            dataGridView1.Columns[0].Width = 95;
            dataGridView1.Columns[1].Width = 90;
            dataGridView1.Columns[2].Width = 90;
            dataGridView1.Columns[3].Width = 90;
            dataGridView1.Columns[4].Width = 90;
            dataGridView1.Columns[5].Width = 70;
            dataGridView1.Columns[6].Width = 73;
            dataGridView1.Columns[7].Width = 80;
        }
        public void ay()
        {
            

            DateTime dt = DateTime.Today;
            int ay = dt.Month;
            lbl_ay.Text = Convert.ToString(ay);



            if (ay == 1)
            {
                lbl_ay.Text = "OCAK PERSONEL SATIŞ TABLOSU";
            }
            else if (ay == 2)
            {
                lbl_ay.Text = "ŞUBAT PERSONEL SATIŞ TABLOSU";
            }
            else if (ay == 3)
            {
                lbl_ay.Text = "MART PERSONEL SATIŞ TABLOSU";
            }
            else if (ay == 4)
            {
                lbl_ay.Text = "NİSAN PERSONEL SATIŞ TABLOSU";
            }
            else if (ay == 5)
            {
                lbl_ay.Text = "MAYIS PERSONEL SATIŞ TABLOSU";
            }
            else if (ay == 6)
            {
                lbl_ay.Text = "HAZİRAN PERSONEL SATIŞ TABLOSU";
            }
            else if (ay == 7)
            {
                lbl_ay.Text = "TEMMUZ PERSONEL SATIŞ TABLOSU";
            }
            else if (ay == 8)
            {
                lbl_ay.Text = "AĞUSTOS PERSONEL SATIŞ TABLOSU";
            }
            else if (ay == 9)
            {
                lbl_ay.Text = "EYLÜL PERSONEL SATIŞ TABLOSU";
            }
            else if (ay == 10)
            {
                lbl_ay.Text = "EKİM PERSONEL SATIŞ TABLOSU";
            }
            else if (ay == 11)
            {
                lbl_ay.Text = "KASIM PERSONEL SATIŞ TABLOSU";
            }
            else if (ay == 12)
            {
                lbl_ay.Text = "ARALIK PERSONEL SATIŞ TABLOSU";
            }







        }
        public void personel1()
        {

            bag.Open();
            OleDbCommand kmt = new OleDbCommand("Select * from personel where ID=1", bag);
            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                lbl_pers1.Text = oku["adi"].ToString();
                lbl_gnlk_pers11.Text = oku["adi"].ToString();
                
            }
            bag.Close();
        }
        public void personel2()
        {

            bag.Open();
            OleDbCommand kmt = new OleDbCommand("Select * from personel where ID=2", bag);
            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                lbl_pers2.Text = oku["adi"].ToString();
                lbl_gnlk_pers22.Text = oku["adi"].ToString();

            }
            bag.Close();
        }
        public void personel3()
        {

            bag.Open();
            OleDbCommand kmt = new OleDbCommand("Select * from personel where ID=3", bag);
            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                lbl_pers3.Text = oku["adi"].ToString();
                lbl_gnlk_pers33.Text = oku["adi"].ToString();
                

            }
            bag.Close();
        }
        public void personel4()
        {

            bag.Open();
            OleDbCommand kmt = new OleDbCommand("Select * from personel where ID=4", bag);
            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                lbl_pers4.Text = oku["adi"].ToString();
                lbl_gnlk_pers44.Text = oku["adi"].ToString();


            }
            bag.Close();
        }
        public void data_toplama()
        {


            double a = 0;
            double b = 0;
            double c = 0;
            
            double e = 0;
            double f = 0;
            double g = 0;
            double j = 0;
            
            


            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {


                a += Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
                b += Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
                c += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                e += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                f += Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                g += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                j += Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value);


                

               

                
                btn_mgz_tplm.Text = j.ToString();
                btn_mgz_tplm.Text = (string.Format("{0:N}", j));
                btn_tpl_pers1.Text = a.ToString();
                btn_tpl_pers1.Text = (string.Format("{0:0,0 }", a));
                btn_tpl_pers2.Text = b.ToString();
                btn_tpl_pers2.Text = (string.Format("{0:0,0 }", b));
                btn_tpl_pers3.Text = c.ToString();
                btn_tpl_pers3.Text = (string.Format("{0:0,0 }", c));
                btn_tpl_pers4.Text = e.ToString();
                btn_tpl_pers4.Text = (string.Format("{0:0,0 }", e));
                btn_tpl_tdlt.Text = f.ToString();
                btn_tpl_tdlt.Text = (string.Format("{0:0,0 }", f));
                btn_iade.Text = g.ToString();
                btn_iade.Text = (string.Format("{0:0,0 }", g));



            }


        }
        public void hedef()
        {
            double a, b, c, d, e, f, g;

            bag.Open();
            OleDbCommand kmt = new OleDbCommand("Select * from hedef where id=1", bag);
            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                btn_mgz_kln.Text = oku["magaza_kota"].ToString();


                g = DateTime.Now.Day;


                a = Convert.ToDouble(btn_mgz_kln.Text);
                b = Convert.ToDouble(btn_mgz_tplm.Text);
                d = Convert.ToDouble(lbl_ay_sonu.Text);

                c = a - b;

                btn_mgz_kln.Text = c.ToString();
                btn_mgz_kln.Text = (string.Format("{0:N}", c));
               

                e = b / d;
                btn_mgz_ort.Text = e.ToString();
                btn_mgz_ort.Text = (string.Format("{0:0,0 TL}", e));

                if (g==d)
                {
                    btn_mgz_kpns.Text = b.ToString();
                    btn_mgz_kpns.Text = (string.Format("{0:0,0 TL}", b));
                }

                else
                {
                    f = b / g * d;
                    btn_mgz_kpns.Text = f.ToString();
                    btn_mgz_kpns.Text = (string.Format("{0:0,0 TL}", f));
                }
                

            }
            bag.Close();




        }
        public void gunlukgereken()
        {

           double a, b, c, d, e;

            d = DateTime.Now.Day;

            a = Convert.ToDouble(btn_mgz_kln.Text);
            b = Convert.ToDouble(lbl_ay_sonu.Text);


            e = b - d;
            if (e==0)
            {
                e = 1;
                c = a / e;

                btn_mgz_gnl_gereken.Text = c.ToString();
                btn_mgz_gnl_gereken.Text = (string.Format("{0:0,0 TL}", c));

            }
            else
            {
                c = a / e;

                btn_mgz_gnl_gereken.Text = Convert.ToString(c);
                btn_mgz_gnl_gereken.Text = (string.Format("{0:0,0 TL}", c));
            }

            




        }
        public void personel_hedef()
        {
            if (lbl_pers1.Text == "**" && lbl_pers2.Text == "**" && lbl_pers3.Text == "**" && lbl_pers4.Text == "**")
            {
                lbl_hdf_pers1.Text = "0";
                lbl_hdf_pers2.Text = "0";
                lbl_hdf_pers3.Text = "0";
                lbl_hdf_pers4.Text = "0";

                lbl_pers1.Enabled = false;
                lbl_pers2.Enabled = false;
                lbl_pers3.Enabled = false;
                lbl_pers4.Enabled = false;

                txt_pers1.Enabled = false;
                txt_pers2.Enabled = false;
                txt_pers3.Enabled = false;
                txt_pers4.Enabled = false;
    
            }
            else if (lbl_pers1.Text == "**" && lbl_pers2.Text == "**" && lbl_pers3.Text == "**")
            {
                lbl_hdf_pers1.Text = "0";
                lbl_hdf_pers2.Text = "0";
                lbl_hdf_pers3.Text = "0";

                lbl_pers1.Enabled = false;
                lbl_pers2.Enabled = false;
                lbl_pers3.Enabled = false;
                

                txt_pers1.Enabled = false;
                txt_pers2.Enabled = false;
                txt_pers3.Enabled = false;
                




                bag.Open();
                OleDbCommand kmt = new OleDbCommand("Select * from hedef where id=1", bag);
                OleDbDataReader oku = kmt.ExecuteReader();
                while (oku.Read())
                {
                   
                    lbl_hdf_pers4.Text = oku["personel_4"].ToString();



                }
                bag.Close();
            }
            else if (lbl_pers1.Text == "**" && lbl_pers3.Text == "**" && lbl_pers4.Text == "**")
            {
                 lbl_hdf_pers1.Text = "0";
                lbl_hdf_pers3.Text = "0";
                lbl_hdf_pers4.Text = "0";

                lbl_pers1.Enabled = false;              
                lbl_pers3.Enabled = false;
                lbl_pers4.Enabled = false;

                txt_pers1.Enabled = false;              
                txt_pers3.Enabled = false;
                txt_pers4.Enabled = false;





                bag.Open();
                OleDbCommand kmt = new OleDbCommand("Select * from hedef where id=1", bag);
                OleDbDataReader oku = kmt.ExecuteReader();
                while (oku.Read())
                {
                   
                    lbl_hdf_pers2.Text = oku["personel_2"].ToString();



                }
                bag.Close();
            }
            else if (lbl_pers2.Text == "**" && lbl_pers3.Text == "**" && lbl_pers4.Text == "**")
            {
                lbl_hdf_pers2.Text = "0";
                lbl_hdf_pers3.Text = "0";
                lbl_hdf_pers4.Text = "0";

              
                lbl_pers2.Enabled = false;
                lbl_pers3.Enabled = false;
                lbl_pers4.Enabled = false;

               
                txt_pers2.Enabled = false;
                txt_pers3.Enabled = false;
                txt_pers4.Enabled = false;

                bag.Open();
                OleDbCommand kmt = new OleDbCommand("Select * from hedef where id=1", bag);
                OleDbDataReader oku = kmt.ExecuteReader();
                while (oku.Read())
                {

                    lbl_hdf_pers1.Text = oku["personel_1"].ToString();



                }
                bag.Close();
            }
            else if (lbl_pers1.Text == "**" && lbl_pers2.Text == "**" && lbl_pers4.Text == "**")
            {
                lbl_hdf_pers1.Text = "0";
                lbl_hdf_pers2.Text = "0";
                lbl_hdf_pers4.Text = "0";

                lbl_pers1.Enabled = false;
                lbl_pers2.Enabled = false;
                lbl_pers4.Enabled = false;

                txt_pers1.Enabled = false;
                txt_pers2.Enabled = false;
                txt_pers4.Enabled = false;

                bag.Open();
                OleDbCommand kmt = new OleDbCommand("Select * from hedef where id=1", bag);
                OleDbDataReader oku = kmt.ExecuteReader();
                while (oku.Read())
                {

                    lbl_hdf_pers3.Text = oku["personel_3"].ToString();



                }
                bag.Close();
            }

            else if (lbl_pers1.Text == "**" && lbl_pers4.Text == "**")
            {
                lbl_hdf_pers1.Text = "0";
                lbl_hdf_pers4.Text = "0";

                lbl_pers1.Enabled = false;
                lbl_pers4.Enabled = false;

                txt_pers1.Enabled = false;
                txt_pers4.Enabled = false;

                bag.Open();
                OleDbCommand kmt = new OleDbCommand("Select * from hedef where id=1", bag);
                OleDbDataReader oku = kmt.ExecuteReader();
                while (oku.Read())
                {

                    lbl_hdf_pers2.Text = oku["personel_2"].ToString();
                    lbl_hdf_pers3.Text = oku["personel_3"].ToString();



                }
                bag.Close();
                
            }
            else if (lbl_pers1.Text == "**" && lbl_pers3.Text == "**")
            {
                lbl_hdf_pers1.Text = "0";
                lbl_hdf_pers3.Text = "0";

                lbl_pers1.Enabled = false;
                lbl_pers3.Enabled = false;

                txt_pers1.Enabled = false;
                txt_pers3.Enabled = false;


                bag.Open();
                OleDbCommand kmt = new OleDbCommand("Select * from hedef where id=1", bag);
                OleDbDataReader oku = kmt.ExecuteReader();
                while (oku.Read())
                {

                    lbl_hdf_pers2.Text = oku["personel_2"].ToString();
                    lbl_hdf_pers4.Text = oku["personel_4"].ToString();



                }
                bag.Close();

            }
            else if (lbl_pers1.Text == "**" && lbl_pers2.Text == "**")
            {
                lbl_hdf_pers1.Text = "0";
                lbl_hdf_pers2.Text = "0";

                lbl_pers1.Enabled = false;
                lbl_pers2.Enabled = false;

                txt_pers1.Enabled = false;
                txt_pers2.Enabled = false;


                bag.Open();
                OleDbCommand kmt = new OleDbCommand("Select * from hedef where id=1", bag);
                OleDbDataReader oku = kmt.ExecuteReader();
                while (oku.Read())
                {

                    lbl_hdf_pers3.Text = oku["personel_3"].ToString();
                    lbl_hdf_pers4.Text = oku["personel_4"].ToString();



                }
                bag.Close();

            }
            else if (lbl_pers2.Text == "**" && lbl_pers4.Text == "**")
            {
                lbl_hdf_pers2.Text = "0";
                lbl_hdf_pers4.Text = "0";

                lbl_pers2.Enabled = false;
                lbl_pers4.Enabled = false;

                txt_pers2.Enabled = false;
                txt_pers4.Enabled = false;

                bag.Open();
                OleDbCommand kmt = new OleDbCommand("Select * from hedef where id=1", bag);
                OleDbDataReader oku = kmt.ExecuteReader();
                while (oku.Read())
                {

                    lbl_hdf_pers1.Text = oku["personel_1"].ToString();
                    lbl_hdf_pers3.Text = oku["personel_3"].ToString();



                }
                bag.Close();

            }
            else if (lbl_pers2.Text == "**" && lbl_pers3.Text == "**")
            {
                lbl_hdf_pers2.Text = "0";
                lbl_hdf_pers3.Text = "0";

                lbl_pers2.Enabled = false;
                lbl_pers3.Enabled = false;

                txt_pers2.Enabled = false;
                txt_pers3.Enabled = false;

                bag.Open();
                OleDbCommand kmt = new OleDbCommand("Select * from hedef where id=1", bag);
                OleDbDataReader oku = kmt.ExecuteReader();
                while (oku.Read())
                {

                    lbl_hdf_pers1.Text = oku["personel_1"].ToString();
                    lbl_hdf_pers4.Text = oku["personel_4"].ToString();



                }
                bag.Close();

            }
            else if (lbl_pers3.Text == "**" && lbl_pers4.Text == "**")
            {
                lbl_hdf_pers3.Text = "0";
                lbl_hdf_pers4.Text = "0";

                lbl_pers3.Enabled = false;
                lbl_pers4.Enabled = false;

                txt_pers3.Enabled = false;
                txt_pers4.Enabled = false;

                bag.Open();
                OleDbCommand kmt = new OleDbCommand("Select * from hedef where id=1", bag);
                OleDbDataReader oku = kmt.ExecuteReader();
                while (oku.Read())
                {

                    lbl_hdf_pers1.Text = oku["personel_1"].ToString();
                    lbl_hdf_pers2.Text = oku["personel_2"].ToString();



                }
                bag.Close();

            }
            else if (lbl_pers4.Text == "**" )
            {
                
                lbl_hdf_pers4.Text = "0";

                lbl_pers4.Enabled = false;

                txt_pers4.Enabled = false;

                bag.Open();
                OleDbCommand kmt = new OleDbCommand("Select * from hedef where id=1", bag);
                OleDbDataReader oku = kmt.ExecuteReader();
                while (oku.Read())
                {
                    lbl_hdf_pers1.Text = oku["personel_1"].ToString();
                    lbl_hdf_pers2.Text = oku["personel_2"].ToString();
                    lbl_hdf_pers3.Text = oku["personel_3"].ToString();



                }
                bag.Close();

            }
            else if (lbl_pers3.Text == "**")
            {

                lbl_hdf_pers3.Text = "0";

                lbl_pers3.Enabled = false;

                txt_pers3.Enabled = false;
     

                bag.Open();
                OleDbCommand kmt = new OleDbCommand("Select * from hedef where id=1", bag);
                OleDbDataReader oku = kmt.ExecuteReader();
                while (oku.Read())
                {
                    lbl_hdf_pers1.Text = oku["personel_1"].ToString();
                    lbl_hdf_pers2.Text = oku["personel_2"].ToString();
                    lbl_hdf_pers4.Text = oku["personel_4"].ToString();



                }
                bag.Close();

            }
            else if (lbl_pers2.Text == "**")
            {

                lbl_hdf_pers2.Text = "0";

                lbl_pers2.Enabled = false;

                txt_pers2.Enabled = false;


                bag.Open();
                OleDbCommand kmt = new OleDbCommand("Select * from hedef where id=1", bag);
                OleDbDataReader oku = kmt.ExecuteReader();
                while (oku.Read())
                {
                    lbl_hdf_pers1.Text = oku["personel_1"].ToString();
                    lbl_hdf_pers3.Text = oku["personel_3"].ToString();
                    lbl_hdf_pers4.Text = oku["personel_4"].ToString();



                }
                bag.Close();

            }
            else if (lbl_pers1.Text == "**")
            {

                lbl_hdf_pers1.Text = "0";

                lbl_pers1.Enabled = false;

                txt_pers1.Enabled = false;


                bag.Open();
                OleDbCommand kmt = new OleDbCommand("Select * from hedef where id=1", bag);
                OleDbDataReader oku = kmt.ExecuteReader();
                while (oku.Read())
                {
                    
                    lbl_hdf_pers2.Text = oku["personel_2"].ToString();
                    lbl_hdf_pers3.Text = oku["personel_3"].ToString();
                    lbl_hdf_pers4.Text = oku["personel_4"].ToString();



                }
                bag.Close();

            }
            else
            {
                bag.Open();
                OleDbCommand kmt = new OleDbCommand("Select * from hedef where id=1", bag);
                OleDbDataReader oku = kmt.ExecuteReader();
                while (oku.Read())
                {
                    lbl_hdf_pers1.Text = oku["personel_1"].ToString();
                    lbl_hdf_pers2.Text = oku["personel_2"].ToString();
                    lbl_hdf_pers3.Text = oku["personel_3"].ToString();
                    lbl_hdf_pers4.Text = oku["personel_4"].ToString();



                }
                bag.Close();

            }
        }
             
       
        public void kalan()
        {
            double a, b, c, d, e, f, g, h, ı,j;

            a = Convert.ToDouble(btn_tpl_pers1.Text);
            b = Convert.ToDouble(btn_tpl_pers2.Text);
            c = Convert.ToDouble(btn_tpl_pers3.Text);
            d = Convert.ToDouble(btn_tpl_pers4.Text);

            if (lbl_pers1.Text == "**" && lbl_pers2.Text == "**" && lbl_pers3.Text == "**" && lbl_pers4.Text == "**")
            {



                f = 0;
                g = 0;
                h = 0;
                ı = 0;

                btn_kln_pers1.Text = f.ToString();
                btn_kln_pers2.Text = g.ToString();
                btn_kln_pers3.Text = h.ToString();
                btn_kln_pers4.Text = ı.ToString();

                
            }
            else if (lbl_pers1.Text == "**"  && lbl_pers3.Text == "**" && lbl_pers4.Text == "**")
            {

                e = Convert.ToDouble(btn_iade_pers2.Text);

                
                g = b - e;
                
                btn_kln_pers2.Text = g.ToString();
                btn_kln_pers2.Text = (string.Format("{0:0,0 }", g));
               
            }
            else if (lbl_pers1.Text == "**" && lbl_pers2.Text == "**" && lbl_pers3.Text == "**")
            {

                e = Convert.ToDouble(btn_iade_pers4.Text);



                g = d - e;

                btn_kln_pers4.Text = g.ToString();
                btn_kln_pers4.Text = (string.Format("{0:0,0 }", g));

            }
            else if (lbl_pers1.Text == "**" && lbl_pers2.Text == "**" && lbl_pers4.Text == "**")
            {

                e = Convert.ToDouble(btn_iade_pers3.Text);


                g = c - e;

                btn_kln_pers3.Text = g.ToString();
                btn_kln_pers3.Text = (string.Format("{0:0,0 }", g));

            }
            else if (lbl_pers2.Text == "**" && lbl_pers3.Text == "**" && lbl_pers4.Text == "**")
            {

                e = Convert.ToDouble(btn_iade_pers1.Text);


                g = a - e;

                btn_kln_pers1.Text = g.ToString();
                btn_kln_pers1.Text = (string.Format("{0:0,0 }", g));

            }
            else if (lbl_pers1.Text == "**" && lbl_pers4.Text == "**")
            {

                e = Convert.ToDouble(btn_iade_pers2.Text);
                f = Convert.ToDouble(btn_iade_pers3.Text);

                g = b - e;
                h = c - f;

                btn_kln_pers2.Text = g.ToString();
                btn_kln_pers2.Text = (string.Format("{0:0,0 }", g));
                btn_kln_pers3.Text = h.ToString();
                btn_kln_pers3.Text = (string.Format("{0:0,0 }", h));

            }
            else if (lbl_pers1.Text == "**" && lbl_pers3.Text == "**")
            {

                e = Convert.ToDouble(btn_iade_pers2.Text);
                f = Convert.ToDouble(btn_iade_pers4.Text);

                g = b - e;
                h = d - f;

                btn_kln_pers2.Text = g.ToString();
                btn_kln_pers2.Text = (string.Format("{0:0,0 }", g));
                btn_kln_pers4.Text = h.ToString();
                btn_kln_pers4.Text = (string.Format("{0:0,0 }", h));

            }
            else if (lbl_pers1.Text == "**" && lbl_pers2.Text == "**")
            {

                e = Convert.ToDouble(btn_iade_pers3.Text);
                f = Convert.ToDouble(btn_iade_pers4.Text);

                g = c - e;
                h = d - f;

                btn_kln_pers3.Text = g.ToString();
                btn_kln_pers3.Text = (string.Format("{0:0,0 }", g));
                btn_kln_pers4.Text = h.ToString();
                btn_kln_pers4.Text = (string.Format("{0:0,0 }", h));

            }
            else if (lbl_pers3.Text == "**" && lbl_pers4.Text == "**")
            {

                e = Convert.ToDouble(btn_iade_pers1.Text);
                f = Convert.ToDouble(btn_iade_pers2.Text);

                g = a - e;
                h = b - f;

                btn_kln_pers1.Text = g.ToString();
                btn_kln_pers1.Text = (string.Format("{0:0,0 }", g));
                btn_kln_pers2.Text = h.ToString();
                btn_kln_pers2.Text = (string.Format("{0:0,0 }", h));

            }
            else if (lbl_pers2.Text == "**" && lbl_pers3.Text == "**")
            {

                e = Convert.ToDouble(btn_iade_pers1.Text);
                f = Convert.ToDouble(btn_iade_pers4.Text);

                g = a - e;
                h = d - f;

                btn_kln_pers1.Text = g.ToString();
                btn_kln_pers1.Text = (string.Format("{0:0,0 }", g));
                btn_kln_pers4.Text = h.ToString();
                btn_kln_pers4.Text = (string.Format("{0:0,0 }", h));

            }
            else if (lbl_pers2.Text == "**" && lbl_pers4.Text == "**")
            {

                e = Convert.ToDouble(btn_iade_pers1.Text);
                f = Convert.ToDouble(btn_iade_pers3.Text);

                g = a - e;
                h = c - f;

                btn_kln_pers1.Text = g.ToString();
                btn_kln_pers1.Text = (string.Format("{0:0,0 }", g));
                btn_kln_pers3.Text = h.ToString();
                btn_kln_pers3.Text = (string.Format("{0:0,0 }", h));

            }
            else if (lbl_pers4.Text == "**")
            {

                e = Convert.ToDouble(btn_iade_pers1.Text);
                f = Convert.ToDouble(btn_iade_pers2.Text);
                ı = Convert.ToDouble(btn_iade_pers3.Text);

                g = a - e;
                h = b - f;
                j = c - ı;
                    
                btn_kln_pers1.Text = g.ToString();
                btn_kln_pers1.Text = (string.Format("{0:0,0 }", g));
                btn_kln_pers2.Text = h.ToString();
                btn_kln_pers2.Text = (string.Format("{0:0,0 }", h));
                btn_kln_pers3.Text = j.ToString();
                btn_kln_pers3.Text = (string.Format("{0:0,0 }", j));

           

            }
            else if (lbl_pers3.Text == "**")
            {

                e = Convert.ToDouble(btn_iade_pers1.Text);
                f = Convert.ToDouble(btn_iade_pers2.Text);
                ı = Convert.ToDouble(btn_iade_pers4.Text);

                g = a - e;
                h = b - f;
                j = d - ı;

                btn_kln_pers1.Text = g.ToString();
                btn_kln_pers1.Text = (string.Format("{0:0,0 }", g));
                btn_kln_pers2.Text = h.ToString();
                btn_kln_pers2.Text = (string.Format("{0:0,0 }", h));
                btn_kln_pers4.Text = j.ToString();
                btn_kln_pers4.Text = (string.Format("{0:0,0 }", j));

            }
            else if (lbl_pers2.Text == "**")
            {

                e = Convert.ToDouble(btn_iade_pers1.Text);
                f = Convert.ToDouble(btn_iade_pers3.Text);
                ı = Convert.ToDouble(btn_iade_pers4.Text);

                g = a - e;
                h = c - f;
                j = d - ı;

                btn_kln_pers1.Text = g.ToString();
                btn_kln_pers1.Text = (string.Format("{0:0,0 }", g));
                btn_kln_pers3.Text = h.ToString();
                btn_kln_pers3.Text = (string.Format("{0:0,0 }", h));
                btn_kln_pers4.Text = j.ToString();
                btn_kln_pers4.Text = (string.Format("{0:0,0 }", j));

            }
            else if (lbl_pers1.Text == "**")
            {

                e = Convert.ToDouble(btn_iade_pers2.Text);
                f = Convert.ToDouble(btn_iade_pers3.Text);
                ı = Convert.ToDouble(btn_iade_pers4.Text);

                g = b - e;
                h = c - f;
                j = d - ı;

                btn_kln_pers2.Text = g.ToString();
                btn_kln_pers2.Text = (string.Format("{0:0,0 }", g));
                btn_kln_pers3.Text = h.ToString();
                btn_kln_pers3.Text = (string.Format("{0:0,0 }", h));
                btn_kln_pers4.Text = j.ToString();
                btn_kln_pers4.Text = (string.Format("{0:0,0 }", j));

            }
            else
            {
                e = Convert.ToDouble(btn_iade_pers1.Text);

                f = a - e;
                g = b - e;
                h = c - e;
                ı = d - e;

                btn_kln_pers1.Text = f.ToString();
                btn_kln_pers1.Text = (string.Format("{0:0,0 }", f));

                btn_kln_pers2.Text = g.ToString();
                btn_kln_pers2.Text = (string.Format("{0:0,0 }", g));
                btn_kln_pers3.Text = h.ToString();
                btn_kln_pers3.Text = (string.Format("{0:0,0 }", h));
                btn_kln_pers4.Text = ı.ToString();
                btn_kln_pers4.Text = (string.Format("{0:0,0 }", ı));
            }
                                           
      
        }
        public void iade()
        {
            if (lbl_pers1.Text == "**" && lbl_pers2.Text == "**" && lbl_pers3.Text == "**" && lbl_pers4.Text == "**")
            {
                double b;


                b = 0;

                btn_iade_pers1.Text = b.ToString();
                
                btn_iade_pers2.Text = b.ToString();
                
                btn_iade_pers3.Text = b.ToString();
               
                btn_iade_pers4.Text = b.ToString();
                


            }
           else if (lbl_pers1.Text == "**"  && lbl_pers3.Text == "**" && lbl_pers4.Text == "**")
            {
                double a, b;

                a = Convert.ToDouble(btn_iade.Text);
                b = a / 1;             
                btn_iade_pers2.Text = b.ToString();
                btn_iade_pers2.Text = (string.Format("{0:0,0 }", b));
               


            }
            else if (lbl_pers1.Text == "**" && lbl_pers2.Text == "**" && lbl_pers3.Text == "**")
            {
                double a, b;

                a = Convert.ToDouble(btn_iade.Text);
                b = a / 1;
                btn_iade_pers4.Text = b.ToString();
                btn_iade_pers4.Text = (string.Format("{0:0,0 }", b));



            }
            else if (lbl_pers1.Text == "**" && lbl_pers2.Text == "**" && lbl_pers4.Text == "**")
            {
               double a, b;

               a = Convert.ToDouble(btn_iade.Text);
                b = a / 1;
                btn_iade_pers3.Text = b.ToString();
                btn_iade_pers3.Text = (string.Format("{0:0,0 }", b));



            }
            else if (lbl_pers2.Text == "**" && lbl_pers3.Text == "**" && lbl_pers4.Text == "**")
            {
                double a, b;

                a = Convert.ToDouble(btn_iade.Text);
                b = a / 1;
                btn_iade_pers1.Text = b.ToString();
                btn_iade_pers1.Text = (string.Format("{0:0,0 }", b));



            }
            else if (lbl_pers1.Text == "**"  && lbl_pers4.Text == "**")
            {
                double a, b;

                a = Convert.ToDouble(btn_iade.Text);
                b = a / 2;
                btn_iade_pers2.Text = b.ToString();
                btn_iade_pers2.Text = (string.Format("{0:0,0 }", b));
                btn_iade_pers3.Text = b.ToString();
                btn_iade_pers3.Text = (string.Format("{0:0,0 }", b));

            }
            else if (lbl_pers1.Text == "**" && lbl_pers3.Text == "**")
            {
               double a, b;

               a = Convert.ToDouble(btn_iade.Text);
                b = a / 2;
                btn_iade_pers2.Text = b.ToString();
                btn_iade_pers2.Text = (string.Format("{0:0,0 }", b));
                btn_iade_pers4.Text = b.ToString();
                btn_iade_pers4.Text = (string.Format("{0:0,0 }", b));

            }
            else if (lbl_pers1.Text == "**" && lbl_pers2.Text == "**")
            {
                double a, b;

                a = Convert.ToDouble(btn_iade.Text);
                b = a / 2;
                btn_iade_pers3.Text = b.ToString();
                btn_iade_pers3.Text = (string.Format("{0:0,0 }", b));
                btn_iade_pers4.Text = b.ToString();
                btn_iade_pers4.Text = (string.Format("{0:0,0 }", b));

            }
            else if (lbl_pers3.Text == "**" && lbl_pers4.Text == "**")
            {
                double a, b;

                a = Convert.ToDouble(btn_iade.Text);
                b = a / 2;
                btn_iade_pers1.Text = b.ToString();
                btn_iade_pers1.Text = (string.Format("{0:0,0 }", b));
                btn_iade_pers2.Text = b.ToString();
                btn_iade_pers2.Text = (string.Format("{0:0,0 }", b));

            }
            else if (lbl_pers3.Text == "**" && lbl_pers2.Text == "**")
            {
                double a, b;

                a = Convert.ToDouble(btn_iade.Text);
                b = a / 2;
                btn_iade_pers1.Text = b.ToString();
                btn_iade_pers1.Text = (string.Format("{0:0,0 }", b));
                btn_iade_pers4.Text = b.ToString();
                btn_iade_pers4.Text = (string.Format("{0:0,0 }", b));

            }
            else if (lbl_pers2.Text == "**" && lbl_pers4.Text == "**")
            {
                double a, b;

                a = Convert.ToDouble(btn_iade.Text);
                b = a / 2;
                btn_iade_pers1.Text = b.ToString();
                btn_iade_pers1.Text = (string.Format("{0:0,0 }", b));
                btn_iade_pers3.Text = b.ToString();
                btn_iade_pers3.Text = (string.Format("{0:0,0 }", b));

            }
            else if (lbl_pers4.Text == "**" )
            {
               double a, b;

               a = Convert.ToDouble(btn_iade.Text);
                b = a / 3;
                btn_iade_pers1.Text = b.ToString();
                btn_iade_pers1.Text = (string.Format("{0:0,0 }", b));
                btn_iade_pers2.Text = b.ToString();
                btn_iade_pers2.Text = (string.Format("{0:0,0 }", b));
                btn_iade_pers3.Text = b.ToString();
                btn_iade_pers3.Text = (string.Format("{0:0,0 }", b));

            }
            else if (lbl_pers3.Text == "**")
            {
               double a, b;

               a = Convert.ToDouble(btn_iade.Text);
                b = a / 3;
                btn_iade_pers1.Text = b.ToString();
                btn_iade_pers1.Text = (string.Format("{0:0,0 }", b));
                btn_iade_pers2.Text = b.ToString();
                btn_iade_pers2.Text = (string.Format("{0:0,0 }", b));
                btn_iade_pers4.Text = b.ToString();
                btn_iade_pers4.Text = (string.Format("{0:0,0 }", b));

            }
            else if (lbl_pers2.Text == "**")
            {
               double a, b;

               a = Convert.ToDouble(btn_iade.Text);
                b = a / 3;
                btn_iade_pers1.Text = b.ToString();
                btn_iade_pers1.Text = (string.Format("{0:0,0 }", b));
                btn_iade_pers3.Text = b.ToString();
                btn_iade_pers3.Text = (string.Format("{0:0,0 }", b));
                btn_iade_pers4.Text = b.ToString();
                btn_iade_pers4.Text = (string.Format("{0:0,0 }", b));

            }
            else if (lbl_pers1.Text == "**")
            {
               double a, b;

               a = Convert.ToDouble(btn_iade.Text);
                b = a / 3;
                btn_iade_pers2.Text = b.ToString();
                btn_iade_pers2.Text = (string.Format("{0:0,0 }", b));
                btn_iade_pers3.Text = b.ToString();
                btn_iade_pers3.Text = (string.Format("{0:0,0 }", b));
                btn_iade_pers4.Text = b.ToString();
                btn_iade_pers4.Text = (string.Format("{0:0,0 }", b));

            }
            else
            {
                    
                double a, b;

                a = Convert.ToDouble(btn_iade.Text);
                b = a / 4;

                btn_iade_pers1.Text = b.ToString();
                btn_iade_pers1.Text = (string.Format("{0:0,0 }", b));
                btn_iade_pers2.Text = b.ToString();
                btn_iade_pers2.Text = (string.Format("{0:0,0 }", b));
                btn_iade_pers3.Text = b.ToString();
                btn_iade_pers3.Text = (string.Format("{0:0,0 }", b));
                btn_iade_pers4.Text = b.ToString();
                btn_iade_pers4.Text = (string.Format("{0:0,0 }", b));

            
            }



           

             



        
        
        
        
        }
        public void prim()
        {


            double a, b, c, d;
            double e, f, g, h, ı, j, k, l;

            a = Convert.ToDouble(btn_kln_pers1.Text);
            b = Convert.ToDouble(btn_kln_pers2.Text);
            c = Convert.ToDouble(btn_kln_pers3.Text);
            d = Convert.ToDouble(btn_kln_pers4.Text);

            e = a / 1.08 / 100;
            f = e * 1.25 * 1000;
           
                btn_prim_pers1.Text = f.ToString();
                btn_prim_pers1.Text = (string.Format("{0:0, TL}", f)); // personel1
            
         
            

            g = b / 1.08 / 100;
            h = g * 1.25 * 1000;
           
                btn_prim_pers2.Text = h.ToString();
                btn_prim_pers2.Text = (string.Format("{0:0, TL}", h)); // personel2
                
            
            

            ı = c / 1.08 / 100;
            j = ı * 1.25 * 1000;
            btn_prim_pers3.Text = j.ToString();
            btn_prim_pers3.Text = (string.Format("{0:0, TL}", j)); // personel3

            k = d / 1.08 / 100;
            l = k * 1.25 * 1000;
            btn_prim_pers4.Text = l.ToString();
            btn_prim_pers4.Text = (string.Format("{0:0, TL}", l)); // personel4


        
        
        }

        public void personel1_gunluk_gereken()
        {
            DateTime aysonu = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);

            double a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, r, s,t;


            a = Convert.ToDouble(lbl_hdf_pers1.Text);
            b = (a / 100) * 80;
            c = (a / 100) * 90;
            d = (a / 100) * 120;
            e = (a / 100) * 138;
                               

            f = DateTime.Now.Day;
            g = Convert.ToDouble(aysonu.Day);

            h = Convert.ToDouble(btn_kln_pers1.Text);

           
            
            
            
            
            
            
            
            
            
           
            i = b - h;
            j = c - h;
            k = a - h;
            l = d - h;
            m = e - h;

            n = g - f;

            if (n==0)
            {
                n = 1;
                o = i / n;
                p = j / n;
                r = k / n;
                s = l / n;
                t = m / n;
                btn_gnlk_grkn_pers1_80.Text = o.ToString();
                btn_gnlk_grkn_pers1_80.Text = (string.Format("{0:0,0 TL}", o));
                btn_gnlk_grkn_pers1_90.Text = p.ToString();
                btn_gnlk_grkn_pers1_90.Text = (string.Format("{0:0,0 TL}", p));
                btn_gnlk_grkn_pers1_100.Text = r.ToString();
                btn_gnlk_grkn_pers1_100.Text = (string.Format("{0:0,0 TL}", r));
                btn_gnlk_grkn_pers1_120.Text = s.ToString();
                btn_gnlk_grkn_pers1_120.Text = (string.Format("{0:0,0 TL}", s));
                btn_gnlk_grkn_pers1_140.Text = t.ToString();
                btn_gnlk_grkn_pers1_140.Text = (string.Format("{0:0,0 TL}", t));
            }

            else
            {
                o = i / n;
                p = j / n;
                r = k / n;
                s = l / n;
                t = m / n;

                btn_gnlk_grkn_pers1_80.Text = o.ToString();
                btn_gnlk_grkn_pers1_80.Text = (string.Format("{0:0,0 TL}", o));
                btn_gnlk_grkn_pers1_90.Text = p.ToString();
                btn_gnlk_grkn_pers1_90.Text = (string.Format("{0:0,0 TL}", p));
                btn_gnlk_grkn_pers1_100.Text = r.ToString();
                btn_gnlk_grkn_pers1_100.Text = (string.Format("{0:0,0 TL}", r));
                btn_gnlk_grkn_pers1_120.Text = s.ToString();
                btn_gnlk_grkn_pers1_120.Text = (string.Format("{0:0,0 TL}", s));
                btn_gnlk_grkn_pers1_140.Text = t.ToString();
                btn_gnlk_grkn_pers1_140.Text = (string.Format("{0:0,0 TL}", t));
            }

           


            

       
        
        
        }
        public void personel2_gunluk_gereken()
        {
            DateTime aysonu = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);

           double a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, r, s, t;


           a = Convert.ToDouble(lbl_hdf_pers2.Text);
            b = (a / 100) * 80;
            c = (a / 100) * 90;
            d = (a / 100) * 120;
            e = (a / 100) * 138;


            f = DateTime.Now.Day;
            g = Convert.ToDouble(aysonu.Day);

            h = Convert.ToDouble(btn_kln_pers2.Text);
            i = b - h;
            j = c - h;
            k = a - h;
            l = d - h;
            m = e - h;

            n = g - f;

            if (n == 0)
            {
                n = 1;
                o = i / n;
                p = j / n;
                r = k / n;
                s = l / n;
                t = m / n;
                btn_gnlk_grkn_pers2_80.Text = o.ToString();
                btn_gnlk_grkn_pers2_80.Text = (string.Format("{0:0,0 TL }", o));
                btn_gnlk_grkn_pers2_90.Text = p.ToString();
                btn_gnlk_grkn_pers2_90.Text = (string.Format("{0:0,0 TL}", p));
                btn_gnlk_grkn_pers2_100.Text = r.ToString();
                btn_gnlk_grkn_pers2_100.Text = (string.Format("{0:0,0 TL}", r));
                btn_gnlk_grkn_pers2_120.Text = s.ToString();
                btn_gnlk_grkn_pers2_120.Text = (string.Format("{0:0,0 TL}", s));
                btn_gnlk_grkn_pers2_140.Text = t.ToString();
                btn_gnlk_grkn_pers2_140.Text = (string.Format("{0:0,0 TL}", t));
            }

            else
            {
                o = i / n;
                p = j / n;
                r = k / n;
                s = l / n;
                t = m / n;

                btn_gnlk_grkn_pers2_80.Text = o.ToString();
                btn_gnlk_grkn_pers2_80.Text = (string.Format("{0:0,0 TL}", o));
                btn_gnlk_grkn_pers2_90.Text = p.ToString();
                btn_gnlk_grkn_pers2_90.Text = (string.Format("{0:0,0 TL }", p));
                btn_gnlk_grkn_pers2_100.Text = r.ToString();
                btn_gnlk_grkn_pers2_100.Text = (string.Format("{0:0,0 TL}", r));
                btn_gnlk_grkn_pers2_120.Text = s.ToString();
                btn_gnlk_grkn_pers2_120.Text = (string.Format("{0:0,0 TL }", s));
                btn_gnlk_grkn_pers2_140.Text = t.ToString();
                btn_gnlk_grkn_pers2_140.Text = (string.Format("{0:0,0 TL}", t));
            }







        }
        public void personel3_gunluk_gereken()
        {
            DateTime aysonu = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);

           double a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, r, s, t;


           a = Convert.ToDouble(lbl_hdf_pers3.Text);
            b = (a / 100) * 80;
            c = (a / 100) * 90;
            d = (a / 100) * 120;
            e = (a / 100) * 138;


            f = DateTime.Now.Day;
            g = Convert.ToDouble(aysonu.Day);

            h = Convert.ToDouble(btn_kln_pers3.Text);
            i = b - h;
            j = c - h;
            k = a - h;
            l = d - h;
            m = e - h;

            n = g - f;

            if (n == 0)
            {
                n = 1;
                o = i / n;
                p = j / n;
                r = k / n;
                s = l / n;
                t = m / n;


                btn_gnlk_grkn_pers3_80.Text = o.ToString();
                btn_gnlk_grkn_pers3_80.Text = (string.Format("{0:0,0 TL}", o));
                btn_gnlk_grkn_pers3_90.Text = p.ToString();
                btn_gnlk_grkn_pers3_90.Text = (string.Format("{0:0,0 TL}", p));
                btn_gnlk_grkn_pers3_100.Text = r.ToString();
                btn_gnlk_grkn_pers3_100.Text = (string.Format("{0:0,0 TL}", r));
                btn_gnlk_grkn_pers3_120.Text = s.ToString();
                btn_gnlk_grkn_pers3_120.Text = (string.Format("{0:0,0 TL}", s));
                btn_gnlk_grkn_pers3_140.Text = t.ToString();
                btn_gnlk_grkn_pers3_140.Text = (string.Format("{0:0,0 TL}", t));
            }

            else
            {
                o = i / n;
                p = j / n;
                r = k / n;
                s = l / n;
                t = m / n;

                btn_gnlk_grkn_pers3_80.Text = o.ToString();
                btn_gnlk_grkn_pers3_80.Text = (string.Format("{0:0,0 TL}", o));
                btn_gnlk_grkn_pers3_90.Text = p.ToString();
                btn_gnlk_grkn_pers3_90.Text = (string.Format("{0:0,0 TL}", p));
                btn_gnlk_grkn_pers3_100.Text = r.ToString();
                btn_gnlk_grkn_pers3_100.Text = (string.Format("{0:0,0 TL}", r));
                btn_gnlk_grkn_pers3_120.Text = s.ToString();
                btn_gnlk_grkn_pers3_120.Text = (string.Format("{0:0,0 TL}", s));
                btn_gnlk_grkn_pers3_140.Text = t.ToString();
                btn_gnlk_grkn_pers3_140.Text = (string.Format("{0:0,0 TL}", t));

            }

        }
        public void personel4_gunluk_gereken()
        {
            DateTime aysonu = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);

            double a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, r, s, t;


            a = Convert.ToDouble(lbl_hdf_pers4.Text);
            b = (a / 100) * 80;
            c = (a / 100) * 90;
            d = (a / 100) * 120;
            e = (a / 100) * 138;


            f = DateTime.Now.Day;
            g = Convert.ToDouble(aysonu.Day);

            h = Convert.ToDouble(btn_kln_pers4.Text);
            i = b - h;
            j = c - h;
            k = a - h;
            l = d - h;
            m = e - h;

            n = g - f;

            if (n == 0)
            {
                n = 1;
                o = i / n;
                p = j / n;
                r = k / n;
                s = l / n;
                t = m / n;

                btn_gnlk_grkn_pers4_80.Text = o.ToString();
                btn_gnlk_grkn_pers4_80.Text = (string.Format("{0:0,0 TL}", o));
                btn_gnlk_grkn_pers4_90.Text = p.ToString();
                btn_gnlk_grkn_pers4_90.Text = (string.Format("{0:0,0 TL}", p));
                btn_gnlk_grkn_pers4_100.Text = r.ToString();
                btn_gnlk_grkn_pers4_100.Text = (string.Format("{0:0,0 TL}", r));
                btn_gnlk_grkn_pers4_120.Text = s.ToString();
                btn_gnlk_grkn_pers4_120.Text = (string.Format("{0:0,0 TL}", s));
                btn_gnlk_grkn_pers4_140.Text = t.ToString();
                btn_gnlk_grkn_pers4_140.Text = (string.Format("{0:0,0 TL}", t));
            }

            else
            {
                o = i / n;
                p = j / n;
                r = k / n;
                s = l / n;
                t = m / n;

                btn_gnlk_grkn_pers4_80.Text = o.ToString();
                btn_gnlk_grkn_pers4_80.Text = (string.Format("{0:0,0 TL}", o));
                btn_gnlk_grkn_pers4_90.Text = p.ToString();
                btn_gnlk_grkn_pers4_90.Text = (string.Format("{0:0,0 TL}", p));
                btn_gnlk_grkn_pers4_100.Text = r.ToString();
                btn_gnlk_grkn_pers4_100.Text = (string.Format("{0:0,0 TL}", r));
                btn_gnlk_grkn_pers4_120.Text = s.ToString();
                btn_gnlk_grkn_pers4_120.Text = (string.Format("{0:0,0 TL}", s));
                btn_gnlk_grkn_pers4_140.Text = t.ToString();
                btn_gnlk_grkn_pers4_140.Text = (string.Format("{0:0,0 TL}", t));
                btn_gnlk_grkn_pers4_140.Text = Convert.ToString(t);
                btn_gnlk_grkn_pers4_140.Text = (string.Format("{0:0,0 TL}", t));
            }







        }

        public void kaydet()
        {
            if (txt_pers1.Text=="")
            {
                XtraMessageBox.Show("PERSONEL TUTAR ALANLARI BOŞ OLAMAZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txt_pers2.Text == "")
            {
                XtraMessageBox.Show("PERSONEL TUTAR ALANLARI BOŞ OLAMAZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_pers3.Text == "")
            {
                XtraMessageBox.Show("PERSONEL TUTAR ALANLARI BOŞ OLAMAZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_pers4.Text == "")
            {
                XtraMessageBox.Show("PERSONEL TUTAR ALANLARI BOŞ OLAMAZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double a, b, c, d, f, g,h;

                a = Convert.ToDouble(txt_pers1.Text);
                b = Convert.ToDouble(txt_pers2.Text);
                c = Convert.ToDouble(txt_pers3.Text);
                d = Convert.ToDouble(txt_pers4.Text);
                f = Convert.ToDouble(txt_tdlt.Text);
                g = Convert.ToDouble(txt_iade.Text);

            h = a + b + c + d + f - g;

            txt_but_top.Text = Convert.ToString(h);

                bag.Open();
                OleDbCommand kmt = new OleDbCommand("insert into satis(tarih,pers1,pers2,pers3,pers4,tadilat,iade,toplam) values ('" + date_tarih.Text + "','" + txt_pers1.Text + "','" + txt_pers2.Text + "','" + txt_pers3.Text + "','" + txt_pers4.Text + "','"+txt_tdlt.Text+"','"+txt_iade.Text+"','"+ txt_but_top.Text +"')", bag);


                OleDbTransaction trans;
                trans = bag.BeginTransaction();
                kmt.Transaction = trans;


                try
                {
                    kmt.ExecuteNonQuery();
                    trans.Commit();
                    XtraMessageBox.Show("KAYIT İŞLEMİNİZ YAPILMIŞTIR. ", "BAŞARILI", MessageBoxButtons.OK);

                }
                catch
                {

                    trans.Rollback();
                    XtraMessageBox.Show("KAYIT İŞLEMİNİZ YAPILMAMIŞTIR LÜTFEN ALANLARI KONTROL EDİNİZ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    bag.Close();
                    txt_pers1.Text = "0";
                    txt_pers2.Text = "0";
                    txt_pers3.Text = "0";
                    txt_pers4.Text = "0";
                    txt_tdlt.Text = "0";
                    txt_iade.Text = "0";
                    txt_but_top.Text = "";


                }

                grid_doldur();



            }
        }
   

        private void lbl_pers1_Click(object sender, EventArgs e)
        {
            Xtra_pers1 pers1 = new Xtra_pers1();
            pers1.Text = Convert.ToString(lbl_pers1.Text+ " DETAY");
            pers1.Show();
            
        }

        private void lbl_pers2_Click(object sender, EventArgs e)
        {
            Xtra_pers2 pers2 = new Xtra_pers2();
            pers2.Text = Convert.ToString(lbl_pers2.Text + " DETAY");
            pers2.Show();
        }

        private void lbl_pers3_Click(object sender, EventArgs e)
        {
            Xtra_pers3 pers3 = new Xtra_pers3();
            pers3.Text = Convert.ToString(lbl_pers3.Text + " DETAY");
            pers3.Show();
        }

        private void lbl_pers4_Click(object sender, EventArgs e)
        {
            Xtra_pers4 pers4 = new Xtra_pers4();
            pers4.Text = Convert.ToString(lbl_pers4.Text + " DETAY");
            pers4.Show();
        }

        private void labelControl12_Click(object sender, EventArgs e)
        {

        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            kaydet();
            data_toplama();
            hedef();
            gunlukgereken();

            personel_hedef();



            iade();
            kalan();

            prim();






            personel1_gunluk_gereken();
            personel2_gunluk_gereken();
            personel3_gunluk_gereken();
            personel4_gunluk_gereken();

            pers1 = btn_kln_pers1.Text;
            pers2 = btn_kln_pers2.Text;
            pers3 = btn_kln_pers3.Text;
            pers4 = btn_kln_pers4.Text;
          

        }

        private void bar_btn_kota_giris_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Xtra_kota_bilgileri kota_bilgi = new Xtra_kota_bilgileri();
            kota_bilgi.Show();
        }

        private void panelControl7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Xtra_pers_bilgi pers_bilgi = new Xtra_pers_bilgi();
            pers_bilgi.Owner = this;
            pers_bilgi.Show();
            this.Hide();
        }

        private void barStaticItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barStaticItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barDockControlTop_Click(object sender, EventArgs e)
        {

        }

        private void barDockControlBottom_Click(object sender, EventArgs e)
        {

        }

        private void barDockControlLeft_Click(object sender, EventArgs e)
        {

        }

        private void barDockControlRight_Click(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_mgz_kln_Click(object sender, EventArgs e)
        {

        }

        private void btn_mgz_tplm_Click(object sender, EventArgs e)
        {

        }

        private void labelControl17_Click(object sender, EventArgs e)
        {

        }

        private void labelControl16_Click(object sender, EventArgs e)
        {

        }

        private void panelControl6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_but_top_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lbl_hdf_pers4_Click(object sender, EventArgs e)
        {

        }

        private void lbl_hdf_pers3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_hdf_pers2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_hdf_pers1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ay_sonu_Click(object sender, EventArgs e)
        {

        }

        private void panelControl5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_gnlk_pers4_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void btn_gnlk_grkn_pers4_80_Click(object sender, EventArgs e)
        {

        }

        private void btn_gnlk_grkn_pers4_140_Click(object sender, EventArgs e)
        {

        }

        private void btn_gnlk_grkn_pers4_120_Click(object sender, EventArgs e)
        {

        }

        private void btn_gnlk_grkn_pers4_100_Click(object sender, EventArgs e)
        {

        }

        private void btn_gnlk_grkn_pers4_90_Click(object sender, EventArgs e)
        {

        }

        private void lbl_gnlk_pers2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_gnlk_pers1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_gnlk_pers3_Click(object sender, EventArgs e)
        {

        }

        private void labelControl30_Click(object sender, EventArgs e)
        {

        }

        private void labelControl31_Click(object sender, EventArgs e)
        {

        }

        private void btn_gnlk_grkn_pers1_80_Click(object sender, EventArgs e)
        {

        }

        private void btn_gnlk_grkn_pers2_80_Click(object sender, EventArgs e)
        {

        }

        private void btn_gnlk_grkn_pers3_80_Click(object sender, EventArgs e)
        {

        }

        private void labelControl26_Click(object sender, EventArgs e)
        {

        }

        private void labelControl25_Click(object sender, EventArgs e)
        {

        }

        private void labelControl24_Click(object sender, EventArgs e)
        {

        }

        private void labelControl23_Click(object sender, EventArgs e)
        {

        }

        private void labelControl22_Click(object sender, EventArgs e)
        {

        }

        private void btn_gnlk_grkn_pers1_140_Click(object sender, EventArgs e)
        {

        }

        private void btn_gnlk_grkn_pers2_140_Click(object sender, EventArgs e)
        {

        }

        private void btn_gnlk_grkn_pers3_140_Click(object sender, EventArgs e)
        {

        }

        private void btn_gnlk_grkn_pers1_120_Click(object sender, EventArgs e)
        {

        }

        private void btn_gnlk_grkn_pers2_120_Click(object sender, EventArgs e)
        {

        }

        private void btn_gnlk_grkn_pers3_120_Click(object sender, EventArgs e)
        {

        }

        private void btn_gnlk_grkn_pers1_100_Click(object sender, EventArgs e)
        {

        }

        private void btn_gnlk_grkn_pers2_100_Click(object sender, EventArgs e)
        {

        }

        private void btn_gnlk_grkn_pers3_100_Click(object sender, EventArgs e)
        {

        }

        private void btn_gnlk_grkn_pers1_90_Click(object sender, EventArgs e)
        {

        }

        private void btn_gnlk_grkn_pers2_90_Click(object sender, EventArgs e)
        {

        }

        private void btn_gnlk_grkn_pers3_90_Click(object sender, EventArgs e)
        {

        }

        private void labelControl21_Click(object sender, EventArgs e)
        {

        }

        private void btn_iade_Click(object sender, EventArgs e)
        {

        }

        private void btn_iade_tdlt_Click(object sender, EventArgs e)
        {

        }

        private void btn_iade_pers4_Click(object sender, EventArgs e)
        {

        }

        private void btn_iade_pers3_Click(object sender, EventArgs e)
        {

        }

        private void btn_iade_pers2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl13_Click(object sender, EventArgs e)
        {

        }

        private void btn_iade_pers1_Click(object sender, EventArgs e)
        {

        }

        private void txt_pers4_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_prim_pers4_Click(object sender, EventArgs e)
        {

        }

        private void btn_kln_pers4_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void btn_tpl_pers4_Click(object sender, EventArgs e)
        {

        }

        private void txt_pers3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_pers2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_pers1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_prim_iade_Click(object sender, EventArgs e)
        {

        }

        private void btn_prim_tdlt_Click(object sender, EventArgs e)
        {

        }

        private void btn_prim_pers3_Click(object sender, EventArgs e)
        {

        }

        private void btn_prim_pers2_Click(object sender, EventArgs e)
        {

        }

        private void btn_prim_pers1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl15_Click(object sender, EventArgs e)
        {

        }

        private void labelControl14_Click(object sender, EventArgs e)
        {

        }

        private void btn_kln_iade_Click(object sender, EventArgs e)
        {

        }

        private void btn_kln_tdlt_Click(object sender, EventArgs e)
        {

        }

        private void btn_kln_pers3_Click(object sender, EventArgs e)
        {

        }

        private void btn_kln_pers2_Click(object sender, EventArgs e)
        {

        }

        private void btn_kln_pers1_Click(object sender, EventArgs e)
        {

        }

        private void btn_tpl_iade_Click(object sender, EventArgs e)
        {

        }

        private void btn_tpl_tdlt_Click(object sender, EventArgs e)
        {

        }

        private void txt_iade_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_tdlt_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl8_Click(object sender, EventArgs e)
        {

        }

        private void labelControl11_Click(object sender, EventArgs e)
        {

        }

        private void labelControl9_Click(object sender, EventArgs e)
        {

        }

        private void labelControl10_Click(object sender, EventArgs e)
        {

        }

        private void btn_tpl_pers1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_iade_Click(object sender, EventArgs e)
        {

        }

        private void btn_tpl_pers2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_tadilat_Click(object sender, EventArgs e)
        {

        }

        private void btn_tpl_pers3_Click(object sender, EventArgs e)
        {

        }

        private void btn_mgz_kpns_Click(object sender, EventArgs e)
        {

        }

        private void btn_mgz_gnl_gereken_Click(object sender, EventArgs e)
        {

        }

        private void btn_mgz_ort_Click(object sender, EventArgs e)
        {

        }

        private void labelControl20_Click(object sender, EventArgs e)
        {

        }

        private void labelControl19_Click(object sender, EventArgs e)
        {

        }

        private void labelControl18_Click(object sender, EventArgs e)
        {

        }

        private void panelControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_ay_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void bar_btn_prim_sorgu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void btn_gecen_yil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void bar_btn_satis_tablo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Xtra_satis_tablo tablo = new Xtra_satis_tablo();
            tablo.Show();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sil();
            data_toplama();
            hedef();
            gunlukgereken();

            personel_hedef();



            iade();
            kalan();

            prim();






            personel1_gunluk_gereken();
            personel2_gunluk_gereken();
            personel3_gunluk_gereken();
            personel4_gunluk_gereken();

            pers1 = btn_kln_pers1.Text;
            pers2 = btn_kln_pers2.Text;
            pers3 = btn_kln_pers3.Text;
            pers4 = btn_kln_pers4.Text;
          
        }

         public void sil()
        {
            string a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DialogResult cevap;
            cevap = MessageBox.Show("Kayıdı Silmek İstediğinizden Emin Misiniz ? ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {

                bag.Open();
                OleDbCommand cmd = new OleDbCommand("delete from satis where tarih=@tarih ", bag);
                cmd.Parameters.AddWithValue("@tarih" , a);
                cmd.ExecuteNonQuery();
                bag.Close();
                grid_doldur();


            }
        
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Right)
            {
                int satir = dataGridView1.HitTest(e.X , e.Y).RowIndex;
                if (satir >-1)
                {
                    dataGridView1.Rows[satir].Selected=true;
                    dataGridView1.CurrentCell = dataGridView1.Rows[satir].Cells[0];
                    
                }
            }
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Xtra_guncelle guncel = new Xtra_guncelle();
            guncel.Show();
        }

        private void tarihDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Xtra_tarih_degistir tarih = new Xtra_tarih_degistir();
            tarih.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Xtra_kota_giris kota_giris = new Xtra_kota_giris();
            kota_giris.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Xtra_kota_bilgileri kota_bilgi = new Xtra_kota_bilgileri();
            kota_bilgi.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Xtra_gecen_yil gecen = new Xtra_gecen_yil();
            gecen.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Xtra_prim_hesap hesap = new Xtra_prim_hesap();
            hesap.Show();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Xtra_prim_sorgu sorgu = new Xtra_prim_sorgu();
            sorgu.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Xtra_magaza_detay magaza = new Xtra_magaza_detay();
            magaza.Show();
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int sutun = 1;
            int satır = 2;

            excel.Application excelapp = new excel.Application();
            excelapp.Workbooks.Add("satis.xls");
            excelapp.Visible = true;
            excelapp.Worksheets[1].activate();



            excelapp.Cells[satır , sutun  ].value = lbl_ay.Text;
            

           


            int sutunn = 1;
            int satırr = 3;

            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                excelapp.Cells[satırr, sutunn + j].value = dataGridView1.Columns[j].HeaderText;

            }
            int sutunnn = 1;
            int satırrr = 4;
            satır++;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    excelapp.Cells[satırrr + i, sutunnn + j].value = dataGridView1[j, i].Value;

                }
            }
            int top = 2;
            int toop = 42;
            excelapp.Cells[top , toop].value = btn_mgz_tplm.Text;
        }


    }
}