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
    public partial class Xtra_guncelle : DevExpress.XtraEditors.XtraForm
    {
        public Xtra_guncelle()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=personel.accdb");
        DataGridView data = Xtra_ana_form.data;
        DataTable dt = new DataTable();
        private void Xtra_guncelle_Load(object sender, EventArgs e)
        {
            
           DateTime a;
           
            lbl_tarih.Text = Xtra_ana_form.data.CurrentRow.Cells[0].Value.ToString();
            a=Convert.ToDateTime(lbl_tarih.Text);

            dateEdit1.Text = a.ToString();
            dateEdit1.Text = (string.Format("{0:dd.MM.yyyy}", a));
           
            
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

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            kaydet();
            grid_doldur();
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
                double a, b, c, d, f, g, h;

                a = Convert.ToDouble(txt_pers1.Text);
                b = Convert.ToDouble(txt_pers2.Text);
                c = Convert.ToDouble(txt_pers3.Text);
                d = Convert.ToDouble(txt_pers4.Text);
                f = Convert.ToDouble(txt_tdlt.Text);
                g = Convert.ToDouble(txt_iade.Text);

                h = a + b + c + d + f - g;

                txt_toplam.Text = h.ToString();






                bag.Open();
                OleDbCommand kmt = new OleDbCommand("Update satis Set pers1 = @pers1 , pers2=@pers2 , pers3=@pers3 , pers4=@pers4 , tadilat=@tdlt , iade=@iade, toplam=@toplam Where tarih=@tarih", bag);
                kmt.Parameters.Add("@pers1", OleDbType.Double).Value = txt_pers1.Text;
                kmt.Parameters.Add("@pers2", OleDbType.Double).Value = txt_pers2.Text;
                kmt.Parameters.Add("@pers3", OleDbType.Double).Value = txt_pers3.Text;
                kmt.Parameters.Add("@pers4", OleDbType.Double).Value = txt_pers4.Text;
                kmt.Parameters.Add("@tdlt", OleDbType.Double).Value = txt_tdlt.Text;
                kmt.Parameters.Add("@iade", OleDbType.Double).Value = txt_iade.Text;
                kmt.Parameters.Add("@toplam", OleDbType.Double).Value = txt_toplam.Text;
                kmt.Parameters.Add("@tarih", OleDbType.Date).Value = dateEdit1.Text;
                kmt.Connection = bag;

                OleDbTransaction trans;
                trans = bag.BeginTransaction();
                kmt.Transaction = trans;


                try
                {
                    kmt.ExecuteNonQuery();
                    trans.Commit();
                    XtraMessageBox.Show("SATIŞ BİLGİLERİ GÜNCELLENDİ LÜTFEN PROGRAMI YENİDEN BAŞLATIN ", "GÜNCELLEME BAŞARILI  ", MessageBoxButtons.OK);
                }
                catch
                {
                    trans.Rollback();
                    XtraMessageBox.Show("SATIŞ GÜNCELEME YAPILAMAMIŞTIR.LÜTFEN ALANLARI KONTROL EDİN DOĞRU BİLGİ GİRDİĞİNİZDEN EMİN OLUN", "GÜNCELLEME BAŞARISIZ ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    bag.Close();
                    this.Close();




                }
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
    }
}