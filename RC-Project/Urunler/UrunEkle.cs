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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace RC_Project.Urunler
{
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }
     
        

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=RCdb.db");
            SQLiteCommand insertCommand = (SQLiteCommand)m_dbConnection.CreateCommand();
            insertCommand.CommandText = @"INSERT INTO Nesneler (NesneAdi,KarbonPoint,GeriDonusumTip,OlusturmaTarihi) 
                 VALUES (@nesneadi,@karbonpuani,@geridonusumtipi,@tarih)";
            insertCommand.Parameters.AddWithValue("nesneadi", textBox_NAdi.Text);
            insertCommand.Parameters.AddWithValue("karbonpuani", textBox_CPoint.Text);
            insertCommand.Parameters.AddWithValue("geridonusumtipi", getGeriDonusum(comboBoxGeriDonusum.SelectedItem.ToString()));
            insertCommand.Parameters.AddWithValue("tarih", DateTime.Now);
            if (textBox_NAdi.Text == "" || textBox_CPoint.Text == "" || comboBoxGeriDonusum.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Eklenecek nesne bilgilerinde boşluk olamaz!");
                return;
            }
            m_dbConnection.Open();
            insertCommand.ExecuteNonQuery();
            m_dbConnection.Close();
            MessageBox.Show("Nesne başarıyla eklendi.");
            this.Close();
        }

        private void UrunEkle_Load(object sender, EventArgs e)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=RCdb.db");
            SQLiteCommand sqCommand = (SQLiteCommand)m_dbConnection.CreateCommand();
            sqCommand.CommandText = "SELECT * FROM GeriDonusumTipleri";
            m_dbConnection.Open();
            SQLiteDataReader sqReader = sqCommand.ExecuteReader();
            while (sqReader.Read())
            {
                comboBoxGeriDonusum.Items.Add(sqReader.GetString(1));
            }
            sqReader.Close();
            m_dbConnection.Close();
        }

        public int getGeriDonusum(string GeriDonusumAdi)
        {
            int ret = 0;
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=RCdb.db");
            SQLiteCommand sqCommand = (SQLiteCommand)m_dbConnection.CreateCommand();
            sqCommand.CommandText = "SELECT RecID FROM GeriDonusumTipleri WHERE GeriDonusumTipi=@GT";
            sqCommand.Parameters.AddWithValue("GT", GeriDonusumAdi);
            m_dbConnection.Open();
            SQLiteDataReader sqReader = sqCommand.ExecuteReader();
            while (sqReader.Read())
            {
                ret = sqReader.GetInt32(0);
            }
            sqReader.Close();
            m_dbConnection.Close();
            return ret;
        }
    }

     
}
