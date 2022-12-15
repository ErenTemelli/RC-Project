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
            insertCommand.Parameters.AddWithValue("geridonusumtipi", textBox_RType.Text);
            insertCommand.Parameters.AddWithValue("tarih", DateTime.Now);
            if (textBox_NAdi.Text == "" || textBox_CPoint.Text == "" || textBox_RType.Text == "")
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
}
