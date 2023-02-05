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
    public partial class Xtra_satis_tablo : DevExpress.XtraEditors.XtraForm
    {
        public Xtra_satis_tablo()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=personel.accdb");

        private void Xtra_satis_tablo_Load(object sender, EventArgs e)
        {
            personel1();
            personel2();
            personel3();
            personel4();
            grid_doldur();
            isim();
            boyut();

        }
        public void grid_doldur()
        {

            string sqltext = "select * from satis ";
            OleDbDataAdapter personel = new OleDbDataAdapter(sqltext, bag);
            DataSet ds = new DataSet();
            bag.Open();
            personel.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
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
        public void personel1()
        {

            bag.Open();
            OleDbCommand kmt = new OleDbCommand("Select * from personel where ID=1", bag);
            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                lbl_pers1.Text = oku["adi"].ToString();
               

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
                

            }
            bag.Close();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {

            sil();

            
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
                cmd.Parameters.AddWithValue("@tarih", a);
                cmd.ExecuteNonQuery();
                bag.Close();
                grid_doldur();


            }

        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int satir = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                if (satir > -1)
                {
                    dataGridView1.Rows[satir].Selected = true;

                }
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sil();
        }
        
    }
}