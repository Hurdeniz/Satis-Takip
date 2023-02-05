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
    public partial class Xtra_kota_giris : DevExpress.XtraEditors.XtraForm
    {
        public Xtra_kota_giris()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=personel.accdb");

        private void Xtra_kota_giris_Load(object sender, EventArgs e)
        {
            DateTime aysonu = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);
            
            personel1();
            personel2();
            personel3();
            personel4();
            control();


        }
        public void control()
        {

            if (lbl_pers1_adi.Text == "**" && lbl_pers2_adi.Text == "**" && lbl_pers3_adi.Text == "**" && lbl_pers4_adi.Text == "**")
            {

                txt_pers1_kota.Enabled=false;
                txt_pers2_kota.Enabled = false;
                txt_pers3_kota.Enabled = false;
                txt_pers4_kota.Enabled = false;
                



            }
            else if (lbl_pers1_adi.Text == "**" && lbl_pers2_adi.Text == "**" && lbl_pers3_adi.Text == "**")
            {
                txt_pers1_kota.Enabled = false;
                txt_pers2_kota.Enabled = false;
                txt_pers3_kota.Enabled = false;
            }
            else if (lbl_pers1_adi.Text == "**" && lbl_pers3_adi.Text == "**" && lbl_pers4_adi.Text == "**")
            {
                txt_pers1_kota.Enabled = false;
                txt_pers3_kota.Enabled = false;
                txt_pers4_kota.Enabled = false;
            }
            else if (lbl_pers2_adi.Text == "**" && lbl_pers3_adi.Text == "**" && lbl_pers4_adi.Text == "**")
            {
                txt_pers2_kota.Enabled = false;
                txt_pers3_kota.Enabled = false;
                txt_pers4_kota.Enabled = false;
            }
            else if (lbl_pers1_adi.Text == "**" && lbl_pers2_adi.Text == "**" && lbl_pers4_adi.Text == "**")
            {
                txt_pers1_kota.Enabled = false;
                txt_pers2_kota.Enabled = false;
                txt_pers4_kota.Enabled = false;
            }

            else if (lbl_pers1_adi.Text == "**" && lbl_pers4_adi.Text == "**")
            {
                txt_pers1_kota.Enabled = false;
                txt_pers4_kota.Enabled = false;


            }
            else if (lbl_pers1_adi.Text == "**" && lbl_pers3_adi.Text == "**")
            {
                txt_pers1_kota.Enabled = false;
                txt_pers3_kota.Enabled = false;

            }
            else if (lbl_pers1_adi.Text == "**" && lbl_pers2_adi.Text == "**")
            {
                txt_pers1_kota.Enabled = false;
                txt_pers2_kota.Enabled = false;
            }
            else if (lbl_pers2_adi.Text == "**" && lbl_pers4_adi.Text == "**")
            {
                txt_pers2_kota.Enabled = false;
                txt_pers4_kota.Enabled = false;
            }
            else if (lbl_pers2_adi.Text == "**" && lbl_pers3_adi.Text == "**")
            {
                txt_pers2_kota.Enabled = false;
                txt_pers3_kota.Enabled = false;

            }
            else if (lbl_pers3_adi.Text == "**" && lbl_pers4_adi.Text == "**")
            {
                txt_pers3_kota.Enabled = false;
                txt_pers4_kota.Enabled = false;

            }
            else if (lbl_pers4_adi.Text == "**")
            {

                txt_pers4_kota.Enabled = false;

            }
            else if (lbl_pers3_adi.Text == "**")
            {

                txt_pers3_kota.Enabled = false;

            }
            else if (lbl_pers2_adi.Text == "**")
            {

                txt_pers2_kota.Enabled = false;

            }
            else if (lbl_pers1_adi.Text == "**")
            {

                txt_pers1_kota.Enabled = false;

            }
            else
            {
                txt_pers1_kota.Enabled = true;
                txt_pers2_kota.Enabled = true;
                txt_pers3_kota.Enabled = true;
                txt_pers4_kota.Enabled = true;

            }




        }


        public void personel1()
        {

            bag.Open();
            OleDbCommand kmt = new OleDbCommand("Select * from personel where ID=1", bag);
            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                lbl_pers1_adi.Text = oku["adi"].ToString();
                lbl_pers1_soyadi.Text = oku["soyadi"].ToString();


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
                lbl_pers2_adi.Text = oku["adi"].ToString();
                lbl_pers2_soyadi.Text = oku["soyadi"].ToString();


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
                lbl_pers3_adi.Text = oku["adi"].ToString();
                lbl_pers3_soyadi.Text = oku["soyadi"].ToString();


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
                lbl_pers4_adi.Text = oku["adi"].ToString();
                lbl_pers4_soyadi.Text = oku["soyadi"].ToString();


            }
            bag.Close();
        }
        public void kaydet()
        {

            if (txt_magaza_kota.Text==""  )
            {
                XtraMessageBox.Show("LÜTFEN MAĞAZA KOTASINI GİRİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ( txt_magaza_kota.Text=="0" )
            {
                XtraMessageBox.Show("MAĞAZA KOTASI 0 OLAMAZ LÜTFEN MAĞAZA KOTASINI GİRİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_pers1_kota.Text == "")
            {
                XtraMessageBox.Show("LÜTFEN PERSONEL %100 KOTASI GİRİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_pers2_kota.Text == "" )
            {
                XtraMessageBox.Show("LÜTFEN PERSONEL %100 KOTASI GİRİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_pers3_kota.Text == "" )
            {
                XtraMessageBox.Show("LÜTFEN PERSONEL %100 KOTASI GİRİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_pers4_kota.Text == "" )
            {
                XtraMessageBox.Show("LÜTFEN PERSONEL %100 KOTASI GİRİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {



                bag.Open();
                OleDbCommand kmt = new OleDbCommand("Update hedef Set magaza_kota = @magaza_kota , personel_1=@pers1 , personel_2=@pers2 , personel_3=@pers3 , personel_4=@pers4 Where id=@id", bag);
                kmt.Parameters.Add("@magaza_kota", OleDbType.VarChar).Value = txt_magaza_kota.Text;
                kmt.Parameters.Add("@pers1", OleDbType.VarChar).Value = txt_pers1_kota.Text;
                kmt.Parameters.Add("@pers2", OleDbType.VarChar).Value = txt_pers2_kota.Text;
                kmt.Parameters.Add("@pers3", OleDbType.VarChar).Value = txt_pers3_kota.Text;
                kmt.Parameters.Add("@pers4", OleDbType.VarChar).Value = txt_pers4_kota.Text;
                kmt.Parameters.Add("@id", OleDbType.Integer).Value = txt_id.Text;
                kmt.Connection = bag;

                OleDbTransaction trans;
                trans = bag.BeginTransaction();
                kmt.Transaction = trans;


                try
                {
                    kmt.ExecuteNonQuery();
                    trans.Commit();
                    XtraMessageBox.Show("KOTA BİLGİLERİ GÜNCELLENDİ ", "GÜNCELLEME BAŞARILI  ", MessageBoxButtons.OK);
                }
                catch
                {
                    trans.Rollback();
                    XtraMessageBox.Show("KOTA GÜNCELEME YAPILAMAMIŞTIR.LÜTFEN ALANLARI KONTROL EDİN DOĞRU BİLGİ GİRDİĞİNİZDEN EMİN OLUN", "GÜNCELLEME BAŞARISIZ ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    bag.Close();

                    txt_magaza_kota.Text = "0";
                    txt_pers1_kota.Text = "0";
                    txt_pers2_kota.Text = "0";
                    txt_pers3_kota.Text = "0";
                    txt_pers4_kota.Text = "0";
                    
                }


            }

        }


        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            kaydet();
        }

        private void txt_magaza_kota_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            } 
        }

        private void txt_pers1_kota_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            } 
        }

        private void txt_pers2_kota_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            } 
        }

        private void txt_pers3_kota_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            } 
        }

        private void txt_pers4_kota_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            } 
        }
    }
}