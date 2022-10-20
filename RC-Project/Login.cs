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
            KullaniciModel userCredentials = new KullaniciModel();
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=RCdb.db");
            SQLiteCommand sqCommand = (SQLiteCommand)m_dbConnection.CreateCommand();
            sqCommand.CommandText = "SELECT KullaniciAdi, KullaniciSifre, isOperator, AdSoyad, ToplamRC, SHA256, OlusturmaTarihi FROM Kullanicilar";
            m_dbConnection.Open();
            SQLiteDataReader sqReader = sqCommand.ExecuteReader();
                while (sqReader.Read())
                {
                    if (p_KullaniciAdi == sqReader.GetString(0) && p_Sifre == sqReader.GetString(1))
                    {
                        userCredentials.KullaniciAdi = sqReader.GetString(0);
                        userCredentials.isAccessGranted = true;
                        userCredentials.AdSoyad = sqReader.GetString(3);
                        userCredentials.ToplamRC = sqReader.GetDouble(4);
                        userCredentials.SHA256 = sqReader.GetString(5);
                        userCredentials.OlusturulmaTarihi = sqReader.GetDateTime(6);

                    if (sqReader.GetInt32(2) == 1)
                        {
                            userCredentials.isOperator = true;
                        }
                    }
                }
                sqReader.Close();
                m_dbConnection.Close();
            if(userCredentials.isAccessGranted)
            {
                MessageBox.Show("Hoşgeldiniz, Sn. " + userCredentials.AdSoyad + "\nYetki Seviyesi: " + userCredentials.isOperator);
                this.Hide();
            }

            if (userCredentials.isOperator && userCredentials.isAccessGranted)
            {
                OperatorAnaEkran opEkran = new OperatorAnaEkran();
                opEkran.SetKadTextForLabel(userCredentials.AdSoyad);
                opEkran.SetTotalRcLabel(userCredentials.ToplamRC);
                opEkran.SetKullaniciAdi(userCredentials.KullaniciAdi);
                opEkran.SetSHALabel(userCredentials.SHA256);
                opEkran.SetOlusturmaTarihi(userCredentials.OlusturulmaTarihi.ToString());
                opEkran.Show();
            }
            else if (userCredentials.isAccessGranted && !userCredentials.isOperator)
            {
                KullaniciAnaEkran kEkran = new KullaniciAnaEkran();

                kEkran.kullanici = userCredentials;
                kEkran.Show();
            }
            else
            {
                MessageBox.Show("Oturum açmaya çalıştığınız bilgiler hatalı!");
                this.Show();
            }
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
