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
    public partial class Xtra_pers_bilgi : DevExpress.XtraEditors.XtraForm
    {
        public Xtra_pers_bilgi()
        {
            InitializeComponent();
        }

        public static DataGridView data;

        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=personel.accdb");


        private void Xtra_pers_bilgi_Load(object sender, EventArgs e)
        {
            grid_doldur();
            isim();
            boyut();

            data = dataGridView1;
        }
        public void grid_doldur()
        {

            string sqltext = "select * from personel ";
            OleDbDataAdapter personel = new OleDbDataAdapter(sqltext, bag);
            DataSet ds = new DataSet();
            bag.Open();
            personel.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            bag.Close();
        }
        public void isim()
        {
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "PERSONEL ADI";
            dataGridView1.Columns[2].HeaderText = "PERSONEL SOYADI";
            


        }
        public void boyut()
        {
            dataGridView1.Columns[0].Width = 35;
            dataGridView1.Columns[1].Width = 135;
            dataGridView1.Columns[2].Width = 145;
         
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            Xtra_personel_kayit kayit = new Xtra_personel_kayit(dataGridView1);
            kayit.Show();
            this.Close();
        }
    }
}