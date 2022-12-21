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
using static System.Data.Entity.Infrastructure.Design.Executor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace RC_Project.Urunler
{
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }

        bool isUpdate = false;
        string UpdateEdilecekNesneAdi = "";
        UrunModel urun = new UrunModel();

        public void urunBilgiDoldur(string NesneAdi)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=RCdb.db");
            SQLiteCommand sqCommand = (SQLiteCommand)m_dbConnection.CreateCommand();
            sqCommand.CommandText = "SELECT NesneAdi, KarbonPoint, GeriDonusumTip FROM Nesneler WHERE NesneAdi = @nAd";
            sqCommand.Parameters.AddWithValue("@nAd", NesneAdi);
            m_dbConnection.Open();
            SQLiteDataReader sqReader = sqCommand.ExecuteReader();
            while (sqReader.Read())
            {
                urun.NesneAdi = sqReader.GetString(0);
                urun.KarbonPoint = sqReader.GetString(1);
                urun.GeriDonusumTip = sqReader.GetInt32(2);
                  
            }
            sqReader.Close();
            m_dbConnection.Close();

            textBox_NAdi.Text = urun.NesneAdi;
            textBox_CPoint.Text = urun.KarbonPoint;
            UpdateEdilecekNesneAdi = urun.NesneAdi;
            isUpdate = true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if(isUpdate && !String.IsNullOrEmpty(UpdateEdilecekNesneAdi))
            {
                SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=RCdb.db");
                SQLiteCommand updateCommand = (SQLiteCommand)m_dbConnection.CreateCommand();
                updateCommand.CommandText = @"UPDATE Nesneler SET NesneAdi = @nesneadi, KarbonPoint = @karbonpoint , GeriDonusumTip=@geridonusumtip 
                 WHERE NesneAdi=@NAd";
                updateCommand.Parameters.AddWithValue("NAd", UpdateEdilecekNesneAdi);
                updateCommand.Parameters.AddWithValue("NesneAdi", textBox_NAdi.Text);
                updateCommand.Parameters.AddWithValue("KarbonPoint", textBox_CPoint.Text);
                updateCommand.Parameters.AddWithValue("GeriDonusumTip", comboBoxGeriDonusum.SelectedValue);      
                if (textBox_NAdi.Text == "" || textBox_CPoint.Text == "")
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
                insertCommand.CommandText = @"INSERT INTO Nesneler (NesneAdi,KarbonPoint,GeriDonusumTip,OlusturmaTarihi) 
                 VALUES (@nesneadi,@karbonpuani,@geridonusumtipi,@tarih)";
                insertCommand.Parameters.AddWithValue("nesneadi", textBox_NAdi.Text);
                insertCommand.Parameters.AddWithValue("karbonpuani", textBox_CPoint.Text);
                insertCommand.Parameters.AddWithValue("geridonusumtipi",comboBoxGeriDonusum.SelectedValue);
                insertCommand.Parameters.AddWithValue("tarih", DateTime.Now);
                if (textBox_NAdi.Text == "" || textBox_CPoint.Text == "" || comboBoxGeriDonusum.SelectedValue == null)
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
            
        }

        private void UrunEkle_Load(object sender, EventArgs e)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=RCdb.db");
            SQLiteCommand sqCommand = (SQLiteCommand)m_dbConnection.CreateCommand();
            sqCommand.CommandText = "SELECT * FROM GeriDonusumTipleri";
            m_dbConnection.Open();
            SQLiteDataReader sqReader = sqCommand.ExecuteReader();
            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            while (sqReader.Read())
            {
                comboSource.Add(sqReader.GetInt32(0), sqReader.GetString(1));
            }
            comboBoxGeriDonusum.DataSource = new BindingSource(comboSource, null);
            comboBoxGeriDonusum.DisplayMember = "Value";
            comboBoxGeriDonusum.ValueMember = "Key";
            sqReader.Close();
            m_dbConnection.Close();
            comboBoxGeriDonusum.SelectedValue = urun.GeriDonusumTip;

        }

        
    }

     
}
