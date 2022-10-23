using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RC_Project
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }
        public KullaniciModel kullanici = new KullaniciModel();  

        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            
            string newPassword = Convert.ToString(txtNewPassword.Text);
            string oldPassword = Convert.ToString(txtOldPassword.Text);
            string newPasswordCheck = Convert.ToString(txtNewPassword2.Text);
            KullaniciModel passwordChangeSc = new KullaniciModel();
            
            bool chanceRequirements = false; 
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=RCdb.db");
            SQLiteCommand sqCommand = (SQLiteCommand)m_dbConnection.CreateCommand();
            sqCommand.CommandText = "SELECT KullaniciSifre, KullaniciAdi FROM Kullanicilar";
            m_dbConnection.Open();
            SQLiteDataReader sqReader = sqCommand.ExecuteReader();
            while (sqReader.Read())
            {
               
                if(oldPassword == sqReader.GetString(0))
                {
                    chanceRequirements = true;
                    passwordChangeSc.KullaniciAdi = sqReader.GetString(1);
                }
            }
            sqReader.Close();
            if (oldPassword == newPassword)
            {
                chanceRequirements = false;
                MessageBox.Show("Yeni şifreniz eskisi ile aynı olamaz.");
                return;
            }
            if (newPassword != newPasswordCheck)
            {
                chanceRequirements = false;
                MessageBox.Show("Girdiğiniz yeni şifreler birbiri ile uyuşmuyor.");
                return;
            }
            if (!chanceRequirements)
            {
                MessageBox.Show("Eski şifrenizi yanlış girdiniz.");
                return;
            }
            if(chanceRequirements)
            {
                SQLiteCommand updateCommand = (SQLiteCommand)m_dbConnection.CreateCommand();
                updateCommand.CommandText = "UPDATE Kullanicilar SET KullaniciSifre = @YeniSifre WHERE KullaniciAdi = @userKad";
                updateCommand.Parameters.AddWithValue("YeniSifre", (newPassword));
                updateCommand.Parameters.AddWithValue("userKad", passwordChangeSc.KullaniciAdi);
                kullanici.KullaniciSifre = newPassword;
                updateCommand.ExecuteNonQuery();

                MessageBox.Show("Şifreniz başarıyla değiştirildi.");
                 
            }


        }
    }
}
