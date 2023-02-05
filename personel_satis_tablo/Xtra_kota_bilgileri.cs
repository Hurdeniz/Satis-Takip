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
    public partial class Xtra_kota_bilgileri : DevExpress.XtraEditors.XtraForm
    {
        public Xtra_kota_bilgileri()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=personel.accdb");

        private void Xtra_kota_bilgileri_Load(object sender, EventArgs e)
        {
            
            personel1();
            personel2();
            personel3();
            personel4();
            hedef_magaza();
            hedef_personel1();
            hedef_personel2();
            hedef_personel3();
            hedef_personel4();
        }
        public void hedef_magaza()
        {

            bag.Open();
            OleDbCommand kmt = new OleDbCommand("Select * from hedef where id=1", bag);
            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                txt_magaza_kota.Text = oku["magaza_kota"].ToString();
                



            }
            bag.Close();
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
        public void hedef_personel1()
        {

            bag.Open();
            OleDbCommand kmt = new OleDbCommand("Select * from hedef where id=1", bag);
            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                txt_pers1_kota.Text = oku["personel_1"].ToString();
                


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
        public void hedef_personel2()
        {

            bag.Open();
            OleDbCommand kmt = new OleDbCommand("Select * from hedef where id=1", bag);
            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                txt_pers2_kota.Text = oku["personel_2"].ToString();



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
        public void hedef_personel3()
        {

            bag.Open();
            OleDbCommand kmt = new OleDbCommand("Select * from hedef where id=1", bag);
            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                txt_pers3_kota.Text = oku["personel_3"].ToString();



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
        public void hedef_personel4()
        {

            bag.Open();
            OleDbCommand kmt = new OleDbCommand("Select * from hedef where id=1", bag);
            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                txt_pers4_kota.Text = oku["personel_4"].ToString();



            }
            bag.Close();
        }
    }
}