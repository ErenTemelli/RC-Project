using RC_Project.Kullanicilar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace RC_Project
{
    public partial class KullanıcıListele : Form
    {
        
        public KullanıcıListele()
        {
            InitializeComponent();
        }

        private void KullanıcıListele_Load(object sender, EventArgs e)
        {
       
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            KullaniciEkle kullaniciEkle = new KullaniciEkle();
            kullaniciEkle.Show();
        }
            
        public void KullanıcıListele_Activated(object sender, EventArgs e)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=RCdb.db");
            SQLiteCommand sqCommand = (SQLiteCommand)m_dbConnection.CreateCommand();
            sqCommand.CommandText = "SELECT KullaniciAdi, isOperator, AdSoyad, ToplamRC, SHA256, OlusturmaTarihi FROM Kullanicilar";
            m_dbConnection.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(sqCommand.CommandText, m_dbConnection);
            DataSet ds = new DataSet();
            da.Fill(ds, "Kullanicilar");
            dataGridKullanicilar.DataSource = ds.Tables[0].DefaultView;
            dataGridKullanicilar.Columns[4].Width = 175;
            dataGridKullanicilar.Columns[5].Width = 140;
        }

        public void bnt_sil_Click(object sender, EventArgs e)
        {

            if(dataGridKullanicilar.SelectedRows.Count > 0)
            {
                kayitSil(dataGridKullanicilar.SelectedCells[0].Value.ToString());
            }
            else
            {
                MessageBox.Show("Lutfen Silinecek Satiri Seciniz.");
            }
        }

        void kayitSil(string kAdi)
        {
            try
            {
                SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=RCdb.db");
                SQLiteCommand sqCommand = (SQLiteCommand)m_dbConnection.CreateCommand();
                sqCommand.CommandText = "DELETE FROM Kullanicilar WHERE KullaniciAdi=@kAdi";
                sqCommand.Parameters.AddWithValue("@kAdi", kAdi);
                m_dbConnection.Open();
                sqCommand.ExecuteNonQuery();
                m_dbConnection.Close();
                MessageBox.Show("Kullanıcı başarı ile silindi.");
            }
            catch
            {
                MessageBox.Show("İşlemi yaparken hata ile karşılaşıldı.");
            }
        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            if (dataGridKullanicilar.SelectedRows.Count > 0)
            {
                KullaniciEkle kullaniciEkle = new KullaniciEkle();
                kullaniciEkle.bilgileriDoldur(dataGridKullanicilar.SelectedCells[0].Value.ToString());
                kullaniciEkle.Show();
            }
            else
            {
                MessageBox.Show("Lutfen Düzenlenecek Satiri Seciniz.");
            }

        }
    }
}
