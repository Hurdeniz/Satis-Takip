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
    public partial class Xtra_tarih_degistir : DevExpress.XtraEditors.XtraForm
    {
        public Xtra_tarih_degistir()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=personel.accdb");
        DataGridView data = Xtra_ana_form.data;
        DataTable dt = new DataTable();

        private void Xtra_tarih_degistir_Load(object sender, EventArgs e)
        {

            DateTime a;

            lbl_tarih.Text = Xtra_ana_form.data.CurrentRow.Cells[0].Value.ToString();
            a = Convert.ToDateTime(lbl_tarih.Text);

            date_tarih.Text = a.ToString();
            date_tarih.Text = (string.Format("{0:dd.MM.yyyy}", a));
           
            txt_pers1.Text = Xtra_ana_form.data.CurrentRow.Cells[1].Value.ToString();
            txt_pers2.Text = Xtra_ana_form.data.CurrentRow.Cells[2].Value.ToString();
            txt_pers3.Text = Xtra_ana_form.data.CurrentRow.Cells[3].Value.ToString();
            txt_pers4.Text = Xtra_ana_form.data.CurrentRow.Cells[4].Value.ToString();
            txt_tdlt.Text = Xtra_ana_form.data.CurrentRow.Cells[5].Value.ToString();
            txt_iade.Text = Xtra_ana_form.data.CurrentRow.Cells[6].Value.ToString();
            txt_toplam.Text = Xtra_ana_form.data.CurrentRow.Cells[7].Value.ToString();

            lbl_pers1.Text = Xtra_ana_form.pers11;
            lbl_pers2.Text = Xtra_ana_form.pers22;
            lbl_pers3.Text = Xtra_ana_form.pers33;
            lbl_pers4.Text = Xtra_ana_form.pers44;

            control();

        }

        public void kaydet()
        {
            




                bag.Open();
                OleDbCommand kmt = new OleDbCommand("Update satis Set tarih=@tarih  Where pers1=@pers1", bag);        
                kmt.Parameters.Add("@tarih", OleDbType.Date).Value = date_tarih.Text;
                kmt.Parameters.Add("@pers1", OleDbType.Double).Value = txt_pers1.Text;

                kmt.Connection = bag;

                OleDbTransaction trans;
                trans = bag.BeginTransaction();
                kmt.Transaction = trans;


                try
                {
                    kmt.ExecuteNonQuery();
                    trans.Commit();
                    XtraMessageBox.Show("TARİH BİLGİSİ GÜNCELLENDİ  ", "GÜNCELLEME BAŞARILI  ", MessageBoxButtons.OK);
                }
                catch
                {
                    trans.Rollback();
                    XtraMessageBox.Show("TARİH BİLGİSİ GÜNCELLENMEDİ.LÜTFEN TARİH BİLGİSİNİ KONTROL EDİN DOĞRU BİLGİ GİRDİĞİNİZDEN EMİN OLUN", "GÜNCELLEME BAŞARISIZ ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    bag.Close();                   
                    this.Close();




                
            }
        }
        public void grid_doldur()
        {

             

            DateTime aybasi = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime aysonu = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);


            string sqltext = "SELECT  tarih,pers1,pers2,pers3,pers4,tadilat,iade,toplam FROM satis where tarih BETWEEN @tar1 and @tar2  Order By tarih ASC";
            OleDbDataAdapter satis = new OleDbDataAdapter(sqltext, bag);
            satis.SelectCommand.Parameters.AddWithValue("@tar1", aybasi);
            satis.SelectCommand.Parameters.AddWithValue("@tar2", aysonu);

            bag.Open();

            satis.Fill(dt);
            data.DataSource = dt;

            DataSet ds = new DataSet();


            satis.Fill(ds);








            data.DataSource = ds.Tables[0];     
            data.FirstDisplayedScrollingRowIndex = data.RowCount - 1;


            bag.Close();
        }
        public void control()
        {

            if (lbl_pers1.Text == "**" && lbl_pers2.Text == "**" && lbl_pers3.Text == "**" && lbl_pers4.Text == "**")
            {

                txt_pers1.Enabled = false;
                txt_pers2.Enabled = false;
                txt_pers3.Enabled = false;
                txt_pers4.Enabled = false;




            }
            else if (lbl_pers1.Text == "**" && lbl_pers2.Text == "**" && lbl_pers3.Text == "**")
            {
                txt_pers1.Enabled = false;
                txt_pers2.Enabled = false;
                txt_pers3.Enabled = false;
            }
            else if (lbl_pers1.Text == "**" && lbl_pers3.Text == "**" && lbl_pers4.Text == "**")
            {
                txt_pers1.Enabled = false;
                txt_pers3.Enabled = false;
                txt_pers4.Enabled = false;
            }
            else if (lbl_pers2.Text == "**" && lbl_pers3.Text == "**" && lbl_pers4.Text == "**")
            {
                txt_pers2.Enabled = false;
                txt_pers3.Enabled = false;
                txt_pers4.Enabled = false;
            }
            else if (lbl_pers1.Text == "**" && lbl_pers2.Text == "**" && lbl_pers4.Text == "**")
            {
                txt_pers1.Enabled = false;
                txt_pers2.Enabled = false;
                txt_pers4.Enabled = false;
            }

            else if (lbl_pers1.Text == "**" && lbl_pers4.Text == "**")
            {
                txt_pers1.Enabled = false;
                txt_pers4.Enabled = false;


            }
            else if (lbl_pers1.Text == "**" && lbl_pers3.Text == "**")
            {
                txt_pers1.Enabled = false;
                txt_pers3.Enabled = false;

            }
            else if (lbl_pers1.Text == "**" && lbl_pers2.Text == "**")
            {
                txt_pers1.Enabled = false;
                txt_pers2.Enabled = false;
            }
            else if (lbl_pers2.Text == "**" && lbl_pers4.Text == "**")
            {
                txt_pers2.Enabled = false;
                txt_pers4.Enabled = false;
            }
            else if (lbl_pers2.Text == "**" && lbl_pers3.Text == "**")
            {
                txt_pers2.Enabled = false;
                txt_pers3.Enabled = false;

            }
            else if (lbl_pers3.Text == "**" && lbl_pers4.Text == "**")
            {
                txt_pers3.Enabled = false;
                txt_pers4.Enabled = false;

            }
            else if (lbl_pers4.Text == "**")
            {

                txt_pers4.Enabled = false;

            }
            else if (lbl_pers3.Text == "**")
            {

                txt_pers3.Enabled = false;

            }
            else if (lbl_pers2.Text == "**")
            {

                txt_pers2.Enabled = false;

            }
            else if (lbl_pers1.Text == "**")
            {

                txt_pers1.Enabled = false;

            }
            else
            {
                txt_pers1.Enabled = true;
                txt_pers2.Enabled = true;
                txt_pers3.Enabled = true;
                txt_pers4.Enabled = true;

            }




        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            kaydet();
            grid_doldur();

            
        }
    }
}