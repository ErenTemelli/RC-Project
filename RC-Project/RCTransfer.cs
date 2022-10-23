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
    public partial class RCTransfer : Form
    {
        public RCTransfer()
        {
            InitializeComponent();
        }
        public KullaniciModel kullanici = new KullaniciModel();

        private void RCTransfer_Load(object sender, EventArgs e)
        {

        }

        private void btn_Transfer_Click(object sender, EventArgs e)
        {
            txtMiktar.Text = txtMiktar.Text.Replace(',', '.');
            double TransferEdileekCoin = Convert.ToDouble(txtMiktar.Text);
            bool userFind = false;
            KullaniciModel transferKullanici = new KullaniciModel();
            if (TransferEdileekCoin > kullanici.ToplamRC)
            {
                MessageBox.Show("Bakiyeniz bu işlem için yetersizdir.");
                return;
            }
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=RCdb.db");
            SQLiteCommand sqCommand = (SQLiteCommand)m_dbConnection.CreateCommand();
            sqCommand.CommandText = "SELECT SHA256, KullaniciAdi, ToplamRC FROM Kullanicilar";
            m_dbConnection.Open();
            SQLiteDataReader sqReader = sqCommand.ExecuteReader();
            while (sqReader.Read())
            {
                if (txtSHA.Text == sqReader.GetString(0))
                {
                    userFind = true;
                    transferKullanici.KullaniciAdi = sqReader.GetString(1);
                    transferKullanici.SHA256 = sqReader.GetString(0);
                    transferKullanici.ToplamRC = sqReader.GetDouble(2);
                }
            }
            sqReader.Close();
            if(!userFind)
            {
                MessageBox.Show("Böyle bir SHA-256 adresine sahip sisteme kayıtlı kullanıcı bulunamadı.");
                return;
            }

            if(userFind)
            {
                SQLiteCommand updateCommand = (SQLiteCommand)m_dbConnection.CreateCommand();
                updateCommand.CommandText = "UPDATE Kullanicilar SET ToplamRC = @YeniRC WHERE KullaniciAdi = @transferKad";
                updateCommand.Parameters.AddWithValue("YeniRC", (transferKullanici.ToplamRC + TransferEdileekCoin));
                updateCommand.Parameters.AddWithValue("transferKad", transferKullanici.KullaniciAdi);
                updateCommand.ExecuteNonQuery();

                SQLiteCommand updateCommand2 = (SQLiteCommand)m_dbConnection.CreateCommand();
                updateCommand2.CommandText = "UPDATE Kullanicilar SET ToplamRC = @YeniRC WHERE KullaniciAdi = @transferKad";
                updateCommand2.Parameters.AddWithValue("YeniRC", (kullanici.ToplamRC - TransferEdileekCoin));
                updateCommand2.Parameters.AddWithValue("transferKad", kullanici.KullaniciAdi);
                kullanici.ToplamRC = kullanici.ToplamRC - TransferEdileekCoin;
                updateCommand2.ExecuteNonQuery();

                MessageBox.Show("Transfer başarıyla tamamlandı.");
            }

        }
    }
}
