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

namespace RC_Project.Urunler
{
    public partial class UrunListele1 : Form
    {
        public UrunListele1()
        {
            InitializeComponent();
        }

        public void UrunListele1_Activated(object sender, EventArgs e)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=RCdb.db");
            SQLiteCommand sqCommand = (SQLiteCommand)m_dbConnection.CreateCommand();
            sqCommand.CommandText = "SELECT NesneAdi, KarbonPoint, GeriDonusumTip, OlusturmaTarihi FROM Nesneler";
            m_dbConnection.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(sqCommand.CommandText, m_dbConnection);
            DataSet ds = new DataSet();
            da.Fill(ds, "Nesneler");
            dataGridUrunler.DataSource = ds.Tables[0].DefaultView;
            dataGridUrunler.Columns[3].Width = 160;

        }

        private void UrunListele1_Load(object sender, EventArgs e)
        {
            /*SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=RCdb.db");
            SQLiteCommand sqCommand = (SQLiteCommand)m_dbConnection.CreateCommand();
            sqCommand.CommandText = "SELECT NesneAdi, KarbonPoint, GeriDonusumTip, OlusturmaTarihi FROM Nesneler";
            m_dbConnection.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(sqCommand.CommandText, m_dbConnection);
            DataSet ds = new DataSet();
            da.Fill(ds, "Nesneler");
            dataGridUrunler.DataSource = ds.Tables[0].DefaultView;
            // dataGridUrunler.Columns[4].Width = 175;
            // dataGridUrunler.Columns[5].Width = 140;*/
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            UrunEkle urunEkle = new UrunEkle();
            urunEkle.Show();
        }
    }
}
