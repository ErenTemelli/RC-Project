using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace RC_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        bool SifreyiGoster = false;
        private void btn_login_Click(object sender, EventArgs e)
        {
            string p_KullaniciAdi = textBox_KAdi.Text;
            string p_Sifre = textBox_Sifre.Text;
            bool isOperator = false;
            bool isAccessGranted = false;

            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=RCdb.db");
            SQLiteCommand sqCommand = (SQLiteCommand)m_dbConnection.CreateCommand();
            sqCommand.CommandText = "SELECT KullaniciAdi, KullaniciSifre, isOperator, AdSoyad, ToplamRC, SHA256 FROM Kullanicilar";
            m_dbConnection.Open();
            SQLiteDataReader sqReader = sqCommand.ExecuteReader();
                while (sqReader.Read())
                {
                    if(p_KullaniciAdi == sqReader.GetString(0) && p_Sifre == sqReader.GetString(1))
                    {
                        isAccessGranted = true;
                        if(sqReader.GetInt32(2) == 1)
                        {
                            isOperator = true;
                        }
                    MessageBox.Show("Hoşgeldiniz, Sn. " + sqReader.GetString(3) + "\nYetki Seviyesi: " + isOperator);
                    this.Hide();
                    if(isOperator)
                    {
                        OperatorAnaEkran opEkran = new OperatorAnaEkran();
                        opEkran.SetKadTextForLabel(sqReader.GetString(3));
                        opEkran.SetTotalRcLabel(sqReader.GetDouble(4));
                        opEkran.SetKullaniciAdi(sqReader.GetString(0)); 
                        opEkran.SetSHALabel(sqReader.GetString(5));
                        opEkran.Show();
                    }
                    else
                    {
                        KullaniciAnaEkran kEkran = new KullaniciAnaEkran();
                        kEkran.Show();
                    }
                    }
                    else
                    {
                        MessageBox.Show("Oturum açmaya çalıştığınız bilgiler hatalı!");
                    }
                }
                sqReader.Close();
                m_dbConnection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox_Sifre_TextChanged(object sender, EventArgs e)
        {
            if(!SifreyiGoster)
            {
                textBox_Sifre.PasswordChar = '*';
            }
            else
            {
                textBox_Sifre.PasswordChar = '\0';
            }
        }

        private void btn_Goster_Click(object sender, EventArgs e)
        {
            SifreyiGoster = !SifreyiGoster;
            if (!SifreyiGoster)
            {
                textBox_Sifre.PasswordChar = '*';
            }
            else
            {
                textBox_Sifre.PasswordChar = '\0';
            }
        }
    }
}
