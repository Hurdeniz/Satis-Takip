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
    public partial class Xtra_personel_kayit : DevExpress.XtraEditors.XtraForm
    {
        public Xtra_personel_kayit(DataGridView dataax)
        {
            InitializeComponent();
            dt = dataax;
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=personel.accdb");
        DataGridView dt = new DataGridView();


        private void Xtra_personel_kayit_Load(object sender, EventArgs e)
        {
            txt_id.Text = dt.CurrentRow.Cells[0].Value.ToString();
            txt_adi.Text = dt.CurrentRow.Cells[1].Value.ToString();
            txt_soyadi.Text = dt.CurrentRow.Cells[2].Value.ToString();

            
        }

        public void kaydet()
        {

            if (txt_adi.Text == "")
            {
                XtraMessageBox.Show("LÜTFEN PERSONEL ADINI GİRİNİZ ALANLARI BOŞ BIRAKMAYINIZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_soyadi.Text == "")
            {
                XtraMessageBox.Show("LÜTFEN PERSONEL SOYADINI GİRİNİZ ALANLARI BOŞ BIRAKMAYINIZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

           

            bag.Open();
            OleDbCommand kmt = new OleDbCommand("Update personel Set adi = @adi , soyadi=@soyadi Where ID=@id", bag);
            kmt.Parameters.Add("@adi", OleDbType.VarChar).Value = txt_adi.Text;
            kmt.Parameters.Add("@soyadi", OleDbType.VarChar).Value = txt_soyadi.Text;
            kmt.Parameters.Add("@id", OleDbType.Integer).Value = txt_id.Text;
            kmt.Connection = bag;

            OleDbTransaction trans;
            trans = bag.BeginTransaction();
            kmt.Transaction = trans;


            try
            {
                kmt.ExecuteNonQuery();
                trans.Commit();
                XtraMessageBox.Show("PERSONEL GÜCELLEMESİ YAPILMIŞTIR ","GÜNCELLEME BAŞARILI  ",  MessageBoxButtons.OK);
            }
            catch
            {
                trans.Rollback();
                XtraMessageBox.Show( "PERSONEL GÜNCELLEME İŞLEMİ YAPILAMAMIŞTIR.LÜTFEN ALANLARI KONTROL EDİN DOĞRU BİLGİ GİRDİĞİNİZDEN EMİN OLUN", "GÜNCELLEME BAŞARISIZ " ,MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                bag.Close();
                grid_doldur();
                
                Xtra_ana_form ana = new Xtra_ana_form();
                ana.Show();
                this.Close();

            }


            }

        }


        public void grid_doldur()
        {

            bag.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from personel", bag);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dt.DataSource = ds.Tables[0];
            bag.Close();


        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            kaydet();
            
        }

        private void txt_adi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            } 
        }

        private void txt_soyadi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                kaydet();
            } 
        }
    }
}