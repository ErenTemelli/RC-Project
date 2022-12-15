using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RC_Project.Kullanicilar
{
    public partial class KullaniciEkle : Form
    {
        public KullaniciEkle()
        {
            InitializeComponent();
        }

        bool isUpdate = false;
        string UpdateEdilecekKullaniciAdi = "";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void bilgileriDoldur(string kullaniciAdi)
        {
            KullaniciModel kullanici = new KullaniciModel();
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=RCdb.db");
            SQLiteCommand sqCommand = (SQLiteCommand)m_dbConnection.CreateCommand();
            sqCommand.CommandText = "SELECT KullaniciAdi, KullaniciSifre, isOperator, AdSoyad, ToplamRC, SHA256, OlusturmaTarihi FROM Kullanicilar WHERE KullaniciAdi = @kAd";
            sqCommand.Parameters.AddWithValue("@kAd", kullaniciAdi); 
            m_dbConnection.Open();
            SQLiteDataReader sqReader = sqCommand.ExecuteReader();
                while (sqReader.Read())
                {
                        kullanici.KullaniciAdi = sqReader.GetString(0);
                        kullanici.isAccessGranted = true;
                        kullanici.KullaniciSifre = sqReader.GetString(1);
                        kullanici.AdSoyad = sqReader.GetString(3);
                        kullanici.ToplamRC = sqReader.GetDouble(4);
                        kullanici.SHA256 = sqReader.GetString(5);
                        kullanici.OlusturulmaTarihi = sqReader.GetDateTime(6);

                    if (sqReader.GetInt32(2) == 1)
                        {
                        kullanici.isOperator = true;
                        }
                }
                sqReader.Close();
                m_dbConnection.Close();

            textBox_AdSoyad.Text = kullanici.AdSoyad;
            textBox_Kadi.Text = kullanici.KullaniciAdi;
            UpdateEdilecekKullaniciAdi = kullanici.KullaniciAdi;
            textBox_SHA.Text = kullanici.SHA256;
            textBox_Sifre.Text = kullanici.KullaniciSifre;
            checkBoxOp.Checked = kullanici.isOperator;
            isUpdate = true;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if(isUpdate && !String.IsNullOrEmpty(UpdateEdilecekKullaniciAdi))
            {
                SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=RCdb.db");
                SQLiteCommand updateCommand = (SQLiteCommand)m_dbConnection.CreateCommand();
                updateCommand.CommandText = @"UPDATE Kullanicilar SET KullaniciAdi = @kullaniciadi, KullaniciSifre = @kullanicisifre , AdSoyad=@adsoyad,SHA256=@sha256,isOperator=@isOperator 
                 WHERE KullaniciAdi=@kAd";
                updateCommand.Parameters.AddWithValue("kullaniciadi", textBox_Kadi.Text);
                updateCommand.Parameters.AddWithValue("kullanicisifre", textBox_Sifre.Text);
                updateCommand.Parameters.AddWithValue("adsoyad", textBox_AdSoyad.Text);
                updateCommand.Parameters.AddWithValue("sha256", textBox_SHA.Text);
                updateCommand.Parameters.AddWithValue("isoperator", checkBoxOp.Checked ? 1 : 0);
                updateCommand.Parameters.AddWithValue("kAd", UpdateEdilecekKullaniciAdi);
                if (textBox_Kadi.Text == "" || textBox_Sifre.Text == "" || textBox_AdSoyad.Text == "" || textBox_SHA.Text == "")
                {
                    MessageBox.Show("Kullanici bilgilerinde boşluk olamaz!");
                    return;
                }
                m_dbConnection.Open();
                updateCommand.ExecuteNonQuery();
                m_dbConnection.Close();
                MessageBox.Show("Kullanici başarıyla düzenlendi.");
                this.Close();
            }
            else
            {
                SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=RCdb.db");
                SQLiteCommand insertCommand = (SQLiteCommand)m_dbConnection.CreateCommand();
                insertCommand.CommandText = @"INSERT INTO Kullanicilar (KullaniciAdi,KullaniciSifre,AdSoyad,ToplamRC,SHA256,isOperator,OlusturmaTarihi) 
                 VALUES (@kullaniciadi,@kullanicisifre,@adsoyad,@toplamrc,@sha256,@isoperator,@tarih)";
                insertCommand.Parameters.AddWithValue("kullaniciadi", textBox_Kadi.Text);
                insertCommand.Parameters.AddWithValue("kullanicisifre", textBox_Sifre.Text);
                insertCommand.Parameters.AddWithValue("adsoyad", textBox_AdSoyad.Text);
                insertCommand.Parameters.AddWithValue("toplamrc", 0);
                insertCommand.Parameters.AddWithValue("sha256", textBox_SHA.Text);
                insertCommand.Parameters.AddWithValue("isoperator", checkBoxOp.Checked ? 1 : 0);
                insertCommand.Parameters.AddWithValue("tarih", DateTime.Now);
                if (textBox_Kadi.Text == "" || textBox_Sifre.Text == "" || textBox_AdSoyad.Text == "" || textBox_SHA.Text == "")
                {
                    MessageBox.Show("Kullanici bilgilerinde boşluk olamaz!");
                    return;
                }
                m_dbConnection.Open();
                insertCommand.ExecuteNonQuery();
                m_dbConnection.Close();
                MessageBox.Show("Kullanici başarıyla eklendi.");
                this.Close();
            }        
        }

        private void textBox_Sifre_TextChanged(object sender, EventArgs e)
        {
            textBox_Sifre.PasswordChar = '*';
            
        }

        private void KullaniciEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
