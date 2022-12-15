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


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
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
            if (textBox_Kadi.Text=="" || textBox_Sifre.Text=="" || textBox_AdSoyad.Text=="" || textBox_SHA.Text=="")
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

        private void textBox_Sifre_TextChanged(object sender, EventArgs e)
        {
            textBox_Sifre.PasswordChar = '*';
            
        }

        private void KullaniciEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
