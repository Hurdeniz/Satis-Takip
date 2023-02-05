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
    public partial class Xtra_gecen_yil : DevExpress.XtraEditors.XtraForm
    {
        public Xtra_gecen_yil()
        {
            InitializeComponent();
          
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=personel.accdb");
       
        private void Xtra_gecen_yil_Load(object sender, EventArgs e)
        {
            tarih();
           
        }

        

        public void tarih()
        {
            DateTime ay1 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddYears(-1);
            DateTime ay2 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddDays(1).AddYears(-1); ;
            DateTime ay3 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddDays(2).AddYears(-1); ;
            DateTime ay4 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddDays(3).AddYears(-1); ;
            DateTime ay5 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddDays(4).AddYears(-1); ;
            DateTime ay6 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddDays(5).AddYears(-1); ;
            DateTime ay7 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddDays(6).AddYears(-1); ;
            DateTime ay8 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddDays(7).AddYears(-1); ;
            DateTime ay9 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddDays(8).AddYears(-1); ;
            DateTime ay10 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddDays(9).AddYears(-1); ;
            DateTime ay11 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddDays(10).AddYears(-1); ;
            DateTime ay12 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddDays(11).AddYears(-1); ;
            DateTime ay13 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddDays(12).AddYears(-1); ;
            DateTime ay14 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddDays(13).AddYears(-1); ;
            DateTime ay15 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddDays(14).AddYears(-1); ;
            DateTime ay16 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddDays(15).AddYears(-1); ;
            DateTime ay17 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddDays(16).AddYears(-1); ;
            DateTime ay18 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddDays(17).AddYears(-1); ;
            DateTime ay19 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddDays(18).AddYears(-1); ;
            DateTime ay20 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddDays(19).AddYears(-1); ;
            DateTime ay21 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddDays(20).AddYears(-1); ;
            DateTime ay22 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddDays(21).AddYears(-1); ;
            DateTime ay23 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddDays(22).AddYears(-1); ;
            DateTime ay24 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddDays(23).AddYears(-1); ;
            DateTime ay25 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddDays(24).AddYears(-1); ;
            DateTime ay26 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddDays(25).AddYears(-1); ;
            DateTime ay27 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddDays(26).AddYears(-1); ;
            DateTime ay28 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddDays(27).AddYears(-1); ;
            DateTime ay29 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddDays(28).AddYears(-1); ;
            DateTime ay30 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddDays(29).AddYears(-1); ;
            DateTime ay31 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddDays(30).AddYears(-1); ;


            txt_tarih1.Text = ay1.ToString();
            txt_tarih1.Text = (string.Format("{0:dd.MM.yyyy}", ay1));

            txt_tarih2.Text = ay2.ToString();
            txt_tarih2.Text = (string.Format("{0:dd.MM.yyyy}", ay2));

            txt_tarih3.Text = ay3.ToString();
            txt_tarih3.Text = (string.Format("{0:dd.MM.yyyy}", ay3));

            txt_tarih4.Text = ay4.ToString();
            txt_tarih4.Text = (string.Format("{0:dd.MM.yyyy}", ay4));

            txt_tarih5.Text = ay5.ToString();
            txt_tarih5.Text = (string.Format("{0:dd.MM.yyyy}", ay5));

            txt_tarih6.Text = ay6.ToString();
            txt_tarih6.Text = (string.Format("{0:dd.MM.yyyy}", ay6));

            txt_tarih7.Text = ay7.ToString();
            txt_tarih7.Text = (string.Format("{0:dd.MM.yyyy}", ay7));

            txt_tarih8.Text = ay8.ToString();
            txt_tarih8.Text = (string.Format("{0:dd.MM.yyyy}", ay8));

            txt_tarih9.Text = ay9.ToString();
            txt_tarih9.Text = (string.Format("{0:dd.MM.yyyy}", ay9));

            txt_tarih10.Text = ay10.ToString();
            txt_tarih10.Text = (string.Format("{0:dd.MM.yyyy}", ay10));

            txt_tarih11.Text = ay11.ToString();
            txt_tarih11.Text = (string.Format("{0:dd.MM.yyyy}", ay11));

            txt_tarih12.Text = ay12.ToString();
            txt_tarih12.Text = (string.Format("{0:dd.MM.yyyy}", ay12));

            txt_tarih13.Text = ay13.ToString();
            txt_tarih13.Text = (string.Format("{0:dd.MM.yyyy}", ay13));

            txt_tarih14.Text = ay14.ToString();
            txt_tarih14.Text = (string.Format("{0:dd.MM.yyyy}", ay14));

            txt_tarih15.Text = ay15.ToString();
            txt_tarih15.Text = (string.Format("{0:dd.MM.yyyy}", ay15));

            txt_tarih16.Text = ay16.ToString();
            txt_tarih16.Text = (string.Format("{0:dd.MM.yyyy}", ay16));

            txt_tarih17.Text = ay17.ToString();
            txt_tarih17.Text = (string.Format("{0:dd.MM.yyyy}", ay17));

            txt_tarih18.Text = ay18.ToString();
            txt_tarih18.Text = (string.Format("{0:dd.MM.yyyy}", ay18));

            txt_tarih19.Text = ay19.ToString();
            txt_tarih19.Text = (string.Format("{0:dd.MM.yyyy}", ay19));

            txt_tarih20.Text = ay20.ToString();
            txt_tarih20.Text = (string.Format("{0:dd.MM.yyyy}", ay20));

            txt_tarih21.Text = ay21.ToString();
            txt_tarih21.Text = (string.Format("{0:dd.MM.yyyy}", ay21));

            txt_tarih22.Text = ay22.ToString();
            txt_tarih22.Text = (string.Format("{0:dd.MM.yyyy}", ay22));

            txt_tarih23.Text = ay23.ToString();
            txt_tarih23.Text = (string.Format("{0:dd.MM.yyyy}", ay23));

            txt_tarih24.Text = ay24.ToString();
            txt_tarih24.Text = (string.Format("{0:dd.MM.yyyy}", ay24));

            txt_tarih25.Text = ay25.ToString();
            txt_tarih25.Text = (string.Format("{0:dd.MM.yyyy}", ay25));

            txt_tarih26.Text = ay26.ToString();
            txt_tarih26.Text = (string.Format("{0:dd.MM.yyyy}", ay26));

            txt_tarih27.Text = ay27.ToString();
            txt_tarih27.Text = (string.Format("{0:dd.MM.yyyy}", ay27));

            txt_tarih28.Text = ay28.ToString();
            txt_tarih28.Text = (string.Format("{0:dd.MM.yyyy}", ay28));

            txt_tarih29.Text = ay29.ToString();
            txt_tarih29.Text = (string.Format("{0:dd.MM.yyyy}", ay29));

            txt_tarih30.Text = ay30.ToString();
            txt_tarih30.Text = (string.Format("{0:dd.MM.yyyy}", ay30));

            txt_tarih31.Text = ay31.ToString();
            txt_tarih31.Text = (string.Format("{0:dd.MM.yyyy}", ay31));











            
           
        
        
        
        
        }

        public void kaydet1()
        {
            bag.Open();
            OleDbCommand kmt = new OleDbCommand("Update gecen_sene Set tarih = @tarih,tutar=@tutar Where id=@id", bag);
       
            kmt.Parameters.Add("@tarih", OleDbType.Date).Value = txt_tarih1.Text;
            kmt.Parameters.Add("@tutar", OleDbType.Double).Value = txt_tutar1.Text;
            kmt.Parameters.Add("@id", OleDbType.Integer).Value = txt_id1.Text;




            kmt.Connection = bag;

            OleDbTransaction trans;
            trans = bag.BeginTransaction();
            kmt.Transaction = trans;


            try
            {
                kmt.ExecuteNonQuery();
                trans.Commit();
                
            }
            catch
            {
                trans.Rollback();
                

                XtraMessageBox.Show("AYIN 1.GÜNÜ TARİHLİ KAYIT YAPILAMAMIŞTIR LÜTFEN ALANI KONTROL EDİN ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                bag.Close();


            }
        




        
        
        }
        public void kaydet2()
        {

            bag.Open();
            OleDbCommand kmt = new OleDbCommand("Update gecen_sene Set tarih = @tarih,tutar=@tutar Where id=@id", bag);
       
            kmt.Parameters.Add("@tarih", OleDbType.Date).Value = txt_tarih2.Text;
            kmt.Parameters.Add("@tutar", OleDbType.Double).Value = txt_tutar2.Text;
            kmt.Parameters.Add("@id", OleDbType.Integer).Value = txt_id2.Text;




            kmt.Connection = bag;

            OleDbTransaction trans;
            trans = bag.BeginTransaction();
            kmt.Transaction = trans;


            try
            {
                kmt.ExecuteNonQuery();
                trans.Commit();

            }
            catch
            {
                trans.Rollback();
                XtraMessageBox.Show("AYIN 2.GÜNÜ TARİHLİ KAYIT YAPILAMAMIŞTIR LÜTFEN ALANI KONTROL EDİN ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                bag.Close();


            }







        }
        public void kaydet3()
        {

            bag.Open();
            OleDbCommand kmt = new OleDbCommand("Update gecen_sene Set tarih = @tarih,tutar=@tutar Where id=@id", bag);

            kmt.Parameters.Add("@tarih", OleDbType.Date).Value = txt_tarih3.Text;
            kmt.Parameters.Add("@tutar", OleDbType.Double).Value = txt_tutar3.Text;
            kmt.Parameters.Add("@id", OleDbType.Integer).Value = txt_id3.Text;




            kmt.Connection = bag;

            OleDbTransaction trans;
            trans = bag.BeginTransaction();
            kmt.Transaction = trans;


            try
            {
                kmt.ExecuteNonQuery();
                trans.Commit();

            }
            catch
            {
                trans.Rollback();
                XtraMessageBox.Show("AYIN 3.GÜNÜ TARİHLİ KAYIT YAPILAMAMIŞTIR LÜTFEN ALANI KONTROL EDİN ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bag.Close();


            }







        }
        public void kaydet4()
        {

            bag.Open();
            OleDbCommand kmt = new OleDbCommand("Update gecen_sene Set tarih = @tarih,tutar=@tutar Where id=@id", bag);

            kmt.Parameters.Add("@tarih", OleDbType.Date).Value = txt_tarih4.Text;
            kmt.Parameters.Add("@tutar", OleDbType.Double).Value = txt_tutar4.Text;
            kmt.Parameters.Add("@id", OleDbType.Integer).Value = txt_id4.Text;




            kmt.Connection = bag;

            OleDbTransaction trans;
            trans = bag.BeginTransaction();
            kmt.Transaction = trans;


            try
            {
                kmt.ExecuteNonQuery();
                trans.Commit();

            }
            catch
            {
                trans.Rollback();
                XtraMessageBox.Show("AYIN 4.GÜNÜ TARİHLİ KAYIT YAPILAMAMIŞTIR LÜTFEN ALANI KONTROL EDİN ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bag.Close();


            }







        }
        public void kaydet5()
        {

            bag.Open();
            OleDbCommand kmt = new OleDbCommand("Update gecen_sene Set tarih = @tarih,tutar=@tutar Where id=@id", bag);

            kmt.Parameters.Add("@tarih", OleDbType.Date).Value = txt_tarih5.Text;
            kmt.Parameters.Add("@tutar", OleDbType.Double).Value = txt_tutar5.Text;
            kmt.Parameters.Add("@id", OleDbType.Integer).Value = txt_id5.Text;




            kmt.Connection = bag;

            OleDbTransaction trans;
            trans = bag.BeginTransaction();
            kmt.Transaction = trans;


            try
            {
                kmt.ExecuteNonQuery();
                trans.Commit();

            }
            catch
            {
                trans.Rollback();
                XtraMessageBox.Show("AYIN 5.GÜNÜ TARİHLİ KAYIT YAPILAMAMIŞTIR LÜTFEN ALANI KONTROL EDİN ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bag.Close();


            }







        }
        public void kaydet6()
        {

            bag.Open();
            OleDbCommand kmt = new OleDbCommand("Update gecen_sene Set tarih = @tarih,tutar=@tutar Where id=@id", bag);

            kmt.Parameters.Add("@tarih", OleDbType.Date).Value = txt_tarih6.Text;
            kmt.Parameters.Add("@tutar", OleDbType.Double).Value = txt_tutar6.Text;
            kmt.Parameters.Add("@id", OleDbType.Integer).Value = txt_id6.Text;




            kmt.Connection = bag;

            OleDbTransaction trans;
            trans = bag.BeginTransaction();
            kmt.Transaction = trans;


            try
            {
                kmt.ExecuteNonQuery();
                trans.Commit();

            }
            catch
            {
                trans.Rollback();
                XtraMessageBox.Show("AYIN 6.GÜNÜ TARİHLİ KAYIT YAPILAMAMIŞTIR LÜTFEN ALANI KONTROL EDİN ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bag.Close();


            }







        }
        public void kaydet7()
        {

            bag.Open();
            OleDbCommand kmt = new OleDbCommand("Update gecen_sene Set tarih = @tarih,tutar=@tutar Where id=@id", bag);

            kmt.Parameters.Add("@tarih", OleDbType.Date).Value = txt_tarih7.Text;
            kmt.Parameters.Add("@tutar", OleDbType.Double).Value = txt_tutar7.Text;
            kmt.Parameters.Add("@id", OleDbType.Integer).Value = txt_id7.Text;




            kmt.Connection = bag;

            OleDbTransaction trans;
            trans = bag.BeginTransaction();
            kmt.Transaction = trans;


            try
            {
                kmt.ExecuteNonQuery();
                trans.Commit();

            }
            catch
            {
                trans.Rollback();
                XtraMessageBox.Show("AYIN 7.GÜNÜ TARİHLİ KAYIT YAPILAMAMIŞTIR LÜTFEN ALANI KONTROL EDİN ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bag.Close();


            }







        }
        public void kaydet8()
        {

            bag.Open();
            OleDbCommand kmt = new OleDbCommand("Update gecen_sene Set tarih = @tarih,tutar=@tutar Where id=@id", bag);

            kmt.Parameters.Add("@tarih", OleDbType.Date).Value = txt_tarih8.Text;
            kmt.Parameters.Add("@tutar", OleDbType.Double).Value = txt_tutar8.Text;
            kmt.Parameters.Add("@id", OleDbType.Integer).Value = txt_id8.Text;




            kmt.Connection = bag;

            OleDbTransaction trans;
            trans = bag.BeginTransaction();
            kmt.Transaction = trans;


            try
            {
                kmt.ExecuteNonQuery();
                trans.Commit();

            }
            catch
            {
                trans.Rollback();
                XtraMessageBox.Show("AYIN 8.GÜNÜ TARİHLİ KAYIT YAPILAMAMIŞTIR LÜTFEN ALANI KONTROL EDİN ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bag.Close();


            }







        }
        public void kaydet9()
        {

            bag.Open();
            OleDbCommand kmt = new OleDbCommand("Update gecen_sene Set tarih = @tarih,tutar=@tutar Where id=@id", bag);

            kmt.Parameters.Add("@tarih", OleDbType.Date).Value = txt_tarih9.Text;
            kmt.Parameters.Add("@tutar", OleDbType.Double).Value = txt_tutar9.Text;
            kmt.Parameters.Add("@id", OleDbType.Integer).Value = txt_id9.Text;




            kmt.Connection = bag;

            OleDbTransaction trans;
            trans = bag.BeginTransaction();
            kmt.Transaction = trans;


            try
            {
                kmt.ExecuteNonQuery();
                trans.Commit();

            }
            catch
            {
                trans.Rollback();
                XtraMessageBox.Show("AYIN 9.GÜNÜ TARİHLİ KAYIT YAPILAMAMIŞTIR LÜTFEN ALANI KONTROL EDİN ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bag.Close();


            }







        }
        public void kaydet10()
        {

            bag.Open();
            OleDbCommand kmt = new OleDbCommand("Update gecen_sene Set tarih = @tarih,tutar=@tutar Where id=@id", bag);

            kmt.Parameters.Add("@tarih", OleDbType.Date).Value = txt_tarih10.Text;
            kmt.Parameters.Add("@tutar", OleDbType.Double).Value = txt_tutar10.Text;
            kmt.Parameters.Add("@id", OleDbType.Integer).Value = txt_id10.Text;




            kmt.Connection = bag;

            OleDbTransaction trans;
            trans = bag.BeginTransaction();
            kmt.Transaction = trans;


            try
            {
                kmt.ExecuteNonQuery();
                trans.Commit();
                 XtraMessageBox.Show("ARAMA BİLGİSİ EKLENMİŞTİR  ", "BİLGİ EKLENDİ", MessageBoxButtons.OK);
            
            }
            catch
            {
                trans.Rollback();
                XtraMessageBox.Show("AYIN 10.GÜNÜ TARİHLİ KAYIT YAPILAMAMIŞTIR LÜTFEN ALANI KONTROL EDİN ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bag.Close();


            }







        }
             

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
           
            
            
        }

        private void btn_kaydet_Click_1(object sender, EventArgs e)
        {
       
           
            
        }

 

           
        


        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_kaydet_Click_2(object sender, EventArgs e)
        {
            kaydet1();
            kaydet2();
            kaydet3();
            kaydet4();
            kaydet5();
            kaydet6();
            kaydet7();
            kaydet8();
            kaydet9();
            kaydet10();
          

           
        }
       
       
          
    }
}