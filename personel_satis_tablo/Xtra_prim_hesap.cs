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
    public partial class Xtra_prim_hesap : DevExpress.XtraEditors.XtraForm
    {
        public Xtra_prim_hesap()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=personel.accdb");

        private void Xtra_prim_hesap_Load(object sender, EventArgs e)
        {
            personel1();
            personel2();
            personel3();
            personel4();

            control();
        }
        public void personel1()
        {

            bag.Open();
            OleDbCommand kmt = new OleDbCommand("Select * from personel where ID=1", bag);
            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                btn_pers1.Text = oku["adi"].ToString();
               

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
                btn_pers2.Text = oku["adi"].ToString();
                
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
                btn_pers3.Text = oku["adi"].ToString();
              

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
                btn_pers4.Text = oku["adi"].ToString();
               


            }
            bag.Close();
        }

        private void btn_pers1_Click(object sender, EventArgs e)
        {
            Xtra_pers1_prim pers1 = new Xtra_pers1_prim();
            pers1.Text = Convert.ToString(btn_pers1.Text);
            pers1.Show();
           
        }

        public void control()
        {

            if (btn_pers1.Text == "**" && btn_pers2.Text == "**" && btn_pers3.Text == "**" && btn_pers4.Text == "**")
            {


                btn_pers1.Enabled = false;
                btn_pers2.Enabled = false;
                btn_pers3.Enabled = false;
                btn_pers4.Enabled = false;



            }
            else if (btn_pers1.Text == "**" && btn_pers2.Text == "**" && btn_pers3.Text == "**")
            {
                btn_pers1.Enabled = false;
                btn_pers2.Enabled = false;
                btn_pers3.Enabled = false;
            }
            else if (btn_pers1.Text == "**" && btn_pers3.Text == "**" && btn_pers4.Text == "**")
            {
                btn_pers1.Enabled = false;
                btn_pers3.Enabled = false;
                btn_pers4.Enabled = false;
            }
            else if (btn_pers2.Text == "**" && btn_pers3.Text == "**" && btn_pers4.Text == "**")
            {
                btn_pers2.Enabled = false;
                btn_pers3.Enabled = false;
                btn_pers4.Enabled = false;
            }
            else if (btn_pers1.Text == "**" && btn_pers2.Text == "**" && btn_pers4.Text == "**")
            {
                btn_pers1.Enabled = false;
                btn_pers2.Enabled = false;
                btn_pers4.Enabled = false;
            }

            else if (btn_pers1.Text == "**" && btn_pers4.Text == "**")
            {
                btn_pers1.Enabled = false;
                btn_pers4.Enabled = false;


            }
            else if (btn_pers1.Text == "**" && btn_pers3.Text == "**")
            {
                btn_pers1.Enabled = false;
                btn_pers3.Enabled = false;

            }
            else if (btn_pers1.Text == "**" && btn_pers2.Text == "**")
            {
                btn_pers1.Enabled = false;
                btn_pers2.Enabled = false;
            }
            else if (btn_pers2.Text == "**" && btn_pers4.Text == "**")
            {
                btn_pers2.Enabled = false;
                btn_pers4.Enabled = false;
            }
            else if (btn_pers2.Text == "**" && btn_pers3.Text == "**")
            {
                btn_pers2.Enabled = false;
                btn_pers3.Enabled = false;

            }
            else if (btn_pers3.Text == "**" && btn_pers4.Text == "**")
            {
                btn_pers3.Enabled = false;
                btn_pers4.Enabled = false;

            }
            else if (btn_pers4.Text == "**")
            {

                btn_pers4.Enabled = false;

            }
            else if (btn_pers3.Text == "**")
            {

                btn_pers3.Enabled = false;

            }
            else if (btn_pers2.Text == "**")
            {

                btn_pers2.Enabled = false;

            }
            else if (btn_pers1.Text == "**")
            {

                btn_pers1.Enabled = false;

            }
            else
            {
                btn_pers1.Enabled = true;
                btn_pers2.Enabled = true;
                btn_pers3.Enabled = true;
                btn_pers4.Enabled = true;

            }
        
        
        
        
        }

        private void btn_pers2_Click(object sender, EventArgs e)
        {
            Xtra_pers2_prim pers2 = new Xtra_pers2_prim ();
            pers2.Text = Convert.ToString(btn_pers2.Text);
            pers2.Show();
        }

        private void btn_pers3_Click(object sender, EventArgs e)
        {
            Xtra_pers3_prim pers3 = new Xtra_pers3_prim();
            pers3.Text = Convert.ToString(btn_pers3.Text);
            pers3.Show();
        }

        private void btn_pers4_Click(object sender, EventArgs e)
        {
            Xtra_pers4_prim pers4 = new Xtra_pers4_prim();
            pers4.Text = Convert.ToString(btn_pers4.Text);
            pers4.Show();
        }
    }
}