using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace personel_satis_tablo
{
    public partial class Xtra_prim_sorgu : DevExpress.XtraEditors.XtraForm
    {
        public Xtra_prim_sorgu()
        {
            InitializeComponent();
        }

        private void Xtra_prim_sorgu_Load(object sender, EventArgs e)
        {

        }

        public void hesapla()
        {

            if (txt_tutar.Text=="")
            {
                XtraMessageBox.Show("TUTAR ALANI BOŞ OLAMAZ LÜTFEN BİR SAYI GİRİNİZ.", "UYARI ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (chc_mgz_79.Checked && chc_pers_80.Checked)
            {
                XtraMessageBox.Show(" 0 TL ", "UYARI ", MessageBoxButtons.OK);
            }
            else if (chc_mgz_79.Checked && chc_pers_90.Checked)
            {
                XtraMessageBox.Show(" 0 TL ", "UYARI ", MessageBoxButtons.OK);
            }

            else if (chc_mgz_79.Checked && chc_pers_100.Checked)
            {



                double a, c, d;
                a = Convert.ToDouble(txt_tutar.Text);


                c = a / 1.08 / 100;
                d = c * 0.9 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_79.Checked && chc_pers_120.Checked)
            {


                double a, b, c, d;
                a = Convert.ToDouble(txt_tutar.Text);
                b = (a * 120) / 100;

                c = b / 1.08 / 100;
                d = c * 0.9 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_79.Checked && chc_pers_138.Checked)
            {

                double a, b, c, d;
                a = Convert.ToDouble(txt_tutar.Text);
                b = (a * 138) / 100;

                c = b / 1.08 / 100;
                d = c * 0.9 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }

            else if (chc_mgz_80.Checked && chc_pers_80.Checked)
            {
                double a, b, c, d;
                a = Convert.ToDouble(txt_tutar.Text);
                b = (a * 80) / 100;

                c = b / 1.08 / 100;
                d = c * 0.45 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));



            }
            else if (chc_mgz_80.Checked && chc_pers_90.Checked)
            {
                double a, b, c, d;
                a = Convert.ToDouble(txt_tutar.Text);
                b = (a * 90) / 100;

                c = b / 1.08 / 100;
                d = c * 0.7 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_80.Checked && chc_pers_100.Checked)
            {

                double a, c, d;
                a = Convert.ToDouble(txt_tutar.Text);


                c = a / 1.08 / 100;
                d = c * 0.9 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_80.Checked && chc_pers_120.Checked)
            {
                double a, b, c, d;
                a = Convert.ToDouble(txt_tutar.Text);
                b = (a * 120) / 100;

                c = b / 1.08 / 100;
                d = c * 0.9 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_80.Checked && chc_pers_138.Checked)
            {
                double a, b, c, d;
                a = Convert.ToDouble(txt_tutar.Text);
                b = (a * 138) / 100;

                c = b / 1.08 / 100;
                d = c * 1 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }

            else if (chc_mgz_90.Checked && chc_pers_80.Checked)
            {
                double a, b, c, d;
                a = Convert.ToDouble(txt_tutar.Text);
                b = (a * 80) / 100;

                c = b / 1.08 / 100;
                d = c * 0.45 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_90.Checked && chc_pers_90.Checked)
            {
                double a, b, c, d;
                a = Convert.ToDouble(txt_tutar.Text);
                b = (a * 90) / 100;

                c = b / 1.08 / 100;
                d = c * 0.8 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_90.Checked && chc_pers_100.Checked)
            {

                double a, c, d;
                a = Convert.ToDouble(txt_tutar.Text);


                c = a / 1.08 / 100;
                d = c * 1 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_90.Checked && chc_pers_120.Checked)
            {
                double a, b, c, d;
                a = Convert.ToDouble(txt_tutar.Text);
                b = (a * 120) / 100;

                c = b / 1.08 / 100;
                d = c * 1.2 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_90.Checked && chc_pers_138.Checked)
            {
                double a, b, c, d;
                a = Convert.ToDouble(txt_tutar.Text);
                b = (a * 138) / 100;

                c = b / 1.08 / 100;
                d = c * 1.4 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_100.Checked && chc_pers_80.Checked)
            {
                double a, b, c, d;
                a = Convert.ToDouble(txt_tutar.Text);
                b = (a * 80) / 100;

                c = b / 1.08 / 100;
                d = c * 0.5 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_100.Checked && chc_pers_90.Checked)
            {
                double a, b, c, d;
                a = Convert.ToDouble(txt_tutar.Text);
                b = (a * 90) / 100;

                c = b / 1.08 / 100;
                d = c * 0.9 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_100.Checked && chc_pers_100.Checked)
            {

                double a, c, d;
                a = Convert.ToDouble(txt_tutar.Text);


                c = a / 1.08 / 100;
                d = c * 1.25 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_100.Checked && chc_pers_120.Checked)
            {
                double a, b, c, d;
                a = Convert.ToDouble(txt_tutar.Text);
                b = (a * 120) / 100;

                c = b / 1.08 / 100;
                d = c * 1.5 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_100.Checked && chc_pers_138.Checked)
            {
                double a, b, c, d;
                a = Convert.ToDouble(txt_tutar.Text);
                b = (a * 138) / 100;

                c = b / 1.08 / 100;
                d = c * 1.8 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_120.Checked && chc_pers_80.Checked)
            {
                double a, b, c, d;
                a = Convert.ToDouble(txt_tutar.Text);
                b = (a * 80) / 100;

                c = b / 1.08 / 100;
                d = c * 0.5 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_120.Checked && chc_pers_90.Checked)
            {
                double a, b, c, d;
                a = Convert.ToDouble(txt_tutar.Text);
                b = (a * 90) / 100;

                c = b / 1.08 / 100;
                d = c * 1 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_120.Checked && chc_pers_100.Checked)
            {

                double a, c, d;
                a = Convert.ToDouble(txt_tutar.Text);


                c = a / 1.08 / 100;
                d = c * 1.3 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_120.Checked && chc_pers_120.Checked)
            {
                double a, b, c, d;
                a = Convert.ToDouble(txt_tutar.Text);
                b = (a * 120) / 100;

                c = b / 1.08 / 100;
                d = c * 1.7 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_120.Checked && chc_pers_138.Checked)
            {
                double a, b, c, d;
                a = Convert.ToDouble(txt_tutar.Text);
                b = (a * 138) / 100;

                c = b / 1.08 / 100;
                d = c * 2.2 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_138.Checked && chc_pers_80.Checked)
            {
                double a, b, c, d;
                a = Convert.ToDouble(txt_tutar.Text);
                b = (a * 80) / 100;

                c = b / 1.08 / 100;
                d = c * 0.5 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_138.Checked && chc_pers_90.Checked)
            {
                double a, b, c, d;
                a = Convert.ToDouble(txt_tutar.Text);
                b = (a * 90) / 100;

                c = b / 1.08 / 100;
                d = c * 1 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_138.Checked && chc_pers_100.Checked)
            {

                double a, c, d;
                a = Convert.ToDouble(txt_tutar.Text);


                c = a / 1.08 / 100;
                d = c * 1.35 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_138.Checked && chc_pers_120.Checked)
            {
                double a, b, c, d;
                a = Convert.ToDouble(txt_tutar.Text);
                b = (a * 120) / 100;

                c = b / 1.08 / 100;
                d = c * 1.85 * 1000;

                btn_tutar.Text = d.ToString();
                btn_tutar.Text = (string.Format("{0:0, TL}", d));
            }
            else if (chc_mgz_138.Checked && chc_pers_138.Checked)
            {
                double a, b, c, d;
                a = Convert.ToDouble(txt_tutar.Text);
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
            else if (chc_mgz_80.Checked)
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

        private void btn_hesap_Click(object sender, EventArgs e)
        {
           
                hesapla();
            

            
        }

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

        private void grup_pers1_Paint(object sender, PaintEventArgs e)
        {

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

        private void btn_hesap_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txt_tutar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                hesapla();
            } 
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