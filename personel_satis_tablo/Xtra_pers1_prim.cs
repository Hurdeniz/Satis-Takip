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
    public partial class Xtra_pers1_prim : DevExpress.XtraEditors.XtraForm
    {
        public Xtra_pers1_prim()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=personel.accdb");


        private void chc_mgz_80_CheckedChanged(object sender, EventArgs e)
        {

            if (chc_mgz_80.Checked)
            {
                chc_mgz_79.Enabled = false;
                chc_mgz_90.Enabled = false;
                chc_mgz_100.Enabled = false;
                chc_mgz_120.Enabled = false;
                chc_mgz_138.Enabled = false;
            }
            else
            {
                chc_mgz_79.Enabled = true;
                chc_mgz_90.Enabled = true;
                chc_mgz_100.Enabled = true;
                chc_mgz_120.Enabled = true;
                chc_mgz_138.Enabled = true;
            }
        }

        private void chc_mgz_90_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_mgz_90.Checked)
            {
                chc_mgz_79.Enabled = false;
                chc_mgz_80.Enabled = false;
                chc_mgz_100.Enabled = false;
                chc_mgz_120.Enabled = false;
                chc_mgz_138.Enabled = false;
            }
            else
            {
                chc_mgz_79.Enabled = true;
                chc_mgz_80.Enabled = true;
                chc_mgz_100.Enabled = true;
                chc_mgz_120.Enabled = true;
                chc_mgz_138.Enabled = true;
            }
        }

        private void chc_mgz_100_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_mgz_100.Checked)
            {
                chc_mgz_79.Enabled = false;
                chc_mgz_80.Enabled = false;
                chc_mgz_90.Enabled = false;
                chc_mgz_120.Enabled = false;
                chc_mgz_138.Enabled = false;
            }
            else
            {
                chc_mgz_79.Enabled = true;
                chc_mgz_80.Enabled = true;
                chc_mgz_90.Enabled = true;
                chc_mgz_120.Enabled = true;
                chc_mgz_138.Enabled = true;
            }
        }

        private void chc_mgz_120_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_mgz_120.Checked)
            {
                chc_mgz_79.Enabled = false;
                chc_mgz_80.Enabled = false;
                chc_mgz_90.Enabled = false;
                chc_mgz_100.Enabled = false;
                chc_mgz_138.Enabled = false;
            }
            else
            {
                chc_mgz_79.Enabled = true;
                chc_mgz_80.Enabled = true;
                chc_mgz_90.Enabled = true;
                chc_mgz_100.Enabled = true;
                chc_mgz_138.Enabled = true;
            }
        }

        private void chc_mgz_138_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_mgz_138.Checked)
            {
                chc_mgz_79.Enabled = false;
                chc_mgz_80.Enabled = false;
                chc_mgz_90.Enabled = false;
                chc_mgz_100.Enabled = false;
                chc_mgz_120.Enabled = false;
            }
            else
            {
                chc_mgz_79.Enabled = true;
                chc_mgz_80.Enabled = true;
                chc_mgz_90.Enabled = true;
                chc_mgz_100.Enabled = true;
                chc_mgz_120.Enabled = true;
            }
        }

        private void Xtra_pers1_prim_Load(object sender, EventArgs e)
        {
            txt_satis.Text = Xtra_ana_form.pers1;
            personel1();
            hedef();
            
        }

        public void hesapla()
        {

            if (chc_mgz_79.Checked && chc_pers_100.Checked)
            {
               

               
                double a, c, d;
                a = Convert.ToDouble(txt_kota.Text);
                

                c = a / 1.08 / 100;
                d = c * 0.9 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_79.Checked && chc_pers_80.Checked)
            {
                XtraMessageBox.Show(" 0 TL ", "UYARI ", MessageBoxButtons.OK);
            }
            else if (chc_mgz_79.Checked && chc_pers_90.Checked)
            {
                XtraMessageBox.Show(" 0 TL ", "UYARI ", MessageBoxButtons.OK);
            }
            else if (chc_mgz_79.Checked && chc_pers_120.Checked)
            {

               
                double a,b, c, d;
                a = Convert.ToDouble(txt_kota.Text);
                b = (a * 120) / 100;

                c = b / 1.08 / 100;
                d = c * 0.9 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_79.Checked && chc_pers_138.Checked)
            {

                double a, b, c, d;
                a = Convert.ToDouble(txt_kota.Text);
                b = (a * 138) / 100;

                c = b / 1.08 / 100;
                d = c * 0.9 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }

            else if (chc_mgz_80.Checked && chc_pers_80.Checked)
            {
                double a, b, c, d;
                a = Convert.ToDouble(txt_kota.Text);
                b = (a * 80) /100;

                c = b / 1.08 / 100;
                d = c * 0.45 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
                


            }
            else if (chc_mgz_80.Checked && chc_pers_90.Checked)
            {
                double a, b, c, d;
                a = Convert.ToDouble(txt_kota.Text);
                b = (a * 90) / 100;

                c = b / 1.08 / 100;
                d = c * 0.7 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_80.Checked && chc_pers_100.Checked)
            {
               
                double a,c, d;
                a = Convert.ToDouble(txt_kota.Text);
                

                c = a / 1.08 / 100;
                d = c * 0.9 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_80.Checked && chc_pers_120.Checked)
            {
                double a, b, c, d;
                a = Convert.ToDouble(txt_kota.Text);
                b = (a * 120) / 100;

                c = b / 1.08 / 100;
                d = c * 0.9 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_80.Checked && chc_pers_138.Checked)
            {
                double a, b, c, d;
                a = Convert.ToDouble(txt_kota.Text);
                b = (a * 138) / 100;

                c = b / 1.08 / 100;
                d = c * 1 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }

            else if (chc_mgz_90.Checked && chc_pers_80.Checked)
            {
                double a, b, c, d;
                a = Convert.ToDouble(txt_kota.Text);
                b = (a * 80) / 100;

                c = b / 1.08 / 100;
                d = c * 0.45 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_90.Checked && chc_pers_90.Checked)
            {
                double a, b, c, d;
                a = Convert.ToDouble(txt_kota.Text);
                b =(a * 90) / 100;

                c = b / 1.08 / 100;
                d = c * 0.8 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_90.Checked && chc_pers_100.Checked)
            {
               
                double a, c, d;
                a = Convert.ToDouble(txt_kota.Text);
               

                c = a / 1.08 / 100;
                d = c * 1 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_90.Checked && chc_pers_120.Checked)
            {
                double a, b, c, d;
                a = Convert.ToDouble(txt_kota.Text);
                b = (a * 120) / 100;

                c = b / 1.08 / 100;
                d = c * 1.2 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_90.Checked && chc_pers_138.Checked)
            {
                double a, b, c, d;
                a = Convert.ToDouble(txt_kota.Text);
                b = (a * 138) / 100;

                c = b / 1.08 / 100;
                d = c * 1.4 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_100.Checked && chc_pers_80.Checked)
            {
                double a, b, c, d;
                a = Convert.ToDouble(txt_kota.Text);
                b = (a * 80) / 100;

                c = b / 1.08 / 100;
                d = c * 0.5 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_100.Checked && chc_pers_90.Checked)
            {
                double a, b, c, d;
                a = Convert.ToDouble(txt_kota.Text);
                b = (a * 90) / 100;

                c = b / 1.08 / 100;
                d = c * 0.9 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_100.Checked && chc_pers_100.Checked)
            {
              
                double a, c, d;
                a = Convert.ToDouble(txt_kota.Text);
                

                c = a / 1.08 / 100;
                d = c * 1.25 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_100.Checked && chc_pers_120.Checked)
            {
                double a, b, c, d;
                a = Convert.ToDouble(txt_kota.Text);
                b = (a * 120) / 100;

                c = b / 1.08 / 100;
                d = c * 1.5 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_100.Checked && chc_pers_138.Checked)
            {
                double a, b, c, d;
                a = Convert.ToDouble(txt_kota.Text);
                b = (a * 138) / 100; 

                c = b / 1.08 / 100;
                d = c * 1.8 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_120.Checked && chc_pers_80.Checked)
            {
                double a, b, c, d;
                a = Convert.ToDouble(txt_kota.Text);
                b = (a * 80) / 100;

                c = b / 1.08 / 100;
                d = c * 0.5 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_120.Checked && chc_pers_90.Checked)
            {
                double a, b, c, d;
                a = Convert.ToDouble(txt_kota.Text);
                b = (a * 90) / 100;

                c = b / 1.08 / 100;
                d = c * 1 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_120.Checked && chc_pers_100.Checked)
            {
                
                double a, c, d;
                a = Convert.ToDouble(txt_kota.Text);
                

                c = a / 1.08 / 100;
                d = c * 1.3 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_120.Checked && chc_pers_120.Checked)
            {
                double a, b, c, d;
                a = Convert.ToDouble(txt_kota.Text);
                b = (a * 120) / 100;

                c = b / 1.08 / 100;
                d = c * 1.7 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_120.Checked && chc_pers_138.Checked)
            {
                double a, b, c, d;
                a = Convert.ToDouble(txt_kota.Text);
                b = (a * 138) / 100;

                c = b / 1.08 / 100;
                d = c * 2.2 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_138.Checked && chc_pers_80.Checked)
            {
                double a, b, c, d;
                a = Convert.ToDouble(txt_kota.Text);
                b = (a * 80) / 100;

                c = b / 1.08 / 100;
                d = c * 0.5 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_138.Checked && chc_pers_90.Checked)
            {
                double a, b, c, d;
                a = Convert.ToDouble(txt_kota.Text);
                b = (a * 90) / 100;

                c = b / 1.08 / 100;
                d = c * 1 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_138.Checked && chc_pers_100.Checked)
            {
                
                double a,c, d;
                a = Convert.ToDouble(txt_kota.Text);
               

                c = a / 1.08 / 100;
                d = c * 1.35 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_138.Checked && chc_pers_120.Checked)
            {
                double a, b, c, d;
                a = Convert.ToDouble(txt_kota.Text);
                b = (a * 120) / 100;

                c = b / 1.08 / 100;
                d = c * 1.85 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_138.Checked && chc_pers_138.Checked)
            {
                double a, b, c, d;
                a = Convert.ToDouble(txt_kota.Text);
                b = (a * 138) / 100;

                c = b / 1.08 / 100;
                d = c * 2.4 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_79.Checked)
            {
                XtraMessageBox.Show("LÜTFEN PERSONEL YÜZDESİNİ SEÇİNİZ.", "UYARI ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (chc_mgz_80.Checked )
            {
                XtraMessageBox.Show("LÜTFEN PERSONEL YÜZDESİNİ SEÇİNİZ.", "UYARI ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (chc_mgz_90.Checked)
            {
                XtraMessageBox.Show("LÜTFEN PERSONEL YÜZDESİNİ SEÇİNİZ.", "UYARI ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (chc_mgz_100.Checked)
            {
                XtraMessageBox.Show("LÜTFEN PERSONEL YÜZDESİNİ SEÇİNİZ.", "UYARI ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (chc_mgz_120.Checked)
            {
                XtraMessageBox.Show("LÜTFEN PERSONEL YÜZDESİNİ SEÇİNİZ.", "UYARI ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (chc_mgz_138.Checked)
            {
                XtraMessageBox.Show("LÜTFEN PERSONEL YÜZDESİNİ SEÇİNİZ.", "UYARI ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (chc_pers_80.Checked)
            {
                XtraMessageBox.Show("LÜTFEN MAĞAZA YÜZDESİNİ SEÇİNİZ.", "UYARI ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (chc_pers_90.Checked)
            {
                XtraMessageBox.Show("LÜTFEN MAĞAZA YÜZDESİNİ SEÇİNİZ.", "UYARI ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (chc_pers_100.Checked)
            {
                XtraMessageBox.Show("LÜTFEN MAĞAZA YÜZDESİNİ SEÇİNİZ.", "UYARI ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (chc_pers_120.Checked)
            {
                XtraMessageBox.Show("LÜTFEN MAĞAZA YÜZDESİNİ SEÇİNİZ.", "UYARI ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (chc_pers_138.Checked)
            {
                XtraMessageBox.Show("LÜTFEN MAĞAZA YÜZDESİNİ SEÇİNİZ.", "UYARI ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                XtraMessageBox.Show("LÜTFEN MAĞAZA VE SATIŞ DANIŞMASI YÜZDESİ SEÇİNİZ ", "UYARI ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           
        
        
        
        
        
        
        }
        public void personel1()
        {

            bag.Open();
            OleDbCommand kmt = new OleDbCommand("Select * from personel where ID=1", bag);
            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                grup_pers1.Text = oku["adi"].ToString();
               
            }
            bag.Close();
        }
        public void hedef()
        {
            double d;

            bag.Open();
            OleDbCommand kmt = new OleDbCommand("Select * from hedef where id=1", bag);
            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                
                d =Convert.ToDouble( oku["personel_1"].ToString());
                txt_kota.Text = d.ToString();
                txt_kota.Text = (string.Format("{0:0,0 }", d));
                

            }
            bag.Close();


            double a, b, c;

            a = Convert.ToDouble(txt_kota.Text);
            b = Convert.ToDouble(txt_satis.Text);
            c = a - b;
            txt_kalan.Text = c.ToString();
            txt_kalan.Text = (string.Format("{0:0,0 }", c));
        }

        private void chc_pers_80_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_pers_80.Checked)
            {
                chc_pers_90.Enabled = false;
                chc_pers_100.Enabled = false;
                chc_pers_120.Enabled = false;
                chc_pers_138.Enabled = false;
            }
            else
            {
                chc_pers_90.Enabled = true;
                chc_pers_100.Enabled = true;
                chc_pers_120.Enabled = true;
                chc_pers_138.Enabled = true;
            }
        }

        private void chc_pers_90_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_pers_90.Checked)
            {
                chc_pers_80.Enabled = false;
                chc_pers_100.Enabled = false;
                chc_pers_120.Enabled = false;
                chc_pers_138.Enabled = false;
            }
            else
            {
                chc_pers_80.Enabled = true;
                chc_pers_100.Enabled = true;
                chc_pers_120.Enabled = true;
                chc_pers_138.Enabled = true;
            }
        }

        private void chc_pers_100_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_pers_100.Checked)
            {
                chc_pers_80.Enabled = false;
                chc_pers_90.Enabled = false;
                chc_pers_120.Enabled = false;
                chc_pers_138.Enabled = false;
            }
            else
            {
                chc_pers_80.Enabled = true;
                chc_pers_90.Enabled = true;
                chc_pers_120.Enabled = true;
                chc_pers_138.Enabled = true;
            }
        }

        private void chc_pers_120_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_pers_120.Checked)
            {
                chc_pers_80.Enabled = false;
                chc_pers_90.Enabled = false;
                chc_pers_100.Enabled = false;
                chc_pers_138.Enabled = false;
            }
            else
            {
                chc_pers_80.Enabled = true;
                chc_pers_90.Enabled = true;
                chc_pers_100.Enabled = true;
                chc_pers_138.Enabled = true;
            }
        }

        private void chc_pers_138_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_pers_138.Checked)
            {
                chc_pers_80.Enabled = false;
                chc_pers_90.Enabled = false;
                chc_pers_100.Enabled = false;
                chc_pers_120.Enabled = false;
            }
            else
            {
                chc_pers_80.Enabled = true;
                chc_pers_90.Enabled = true;
                chc_pers_100.Enabled = true;
                chc_pers_120.Enabled = true;
            }
        }

        private void btn_hesap_Click(object sender, EventArgs e)
        {
            hesapla();
        }

        private void chc_mgz_79_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_mgz_79.Checked)
            {
                chc_mgz_80.Enabled = false;
                chc_mgz_90.Enabled = false;
                chc_mgz_100.Enabled = false;
                chc_mgz_120.Enabled = false;
                chc_mgz_138.Enabled = false;
                chc_pers_80.Visible = false;
                chc_pers_90.Visible = false;
            }
            else
            {
                chc_mgz_80.Enabled = true;
                chc_mgz_90.Enabled = true;
                chc_mgz_100.Enabled = true;
                chc_mgz_120.Enabled = true;
                chc_mgz_138.Enabled = true;

                chc_pers_80.Visible = true;
                chc_pers_90.Visible = true;
            }



        }
    }
}