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

namespace RC_Project
{
    public partial class GeriDonusumEkle : Form
    {
        public GeriDonusumEkle()
        {
            InitializeComponent();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=RCdb.db");
            SQLiteCommand insertCommand = (SQLiteCommand)m_dbConnection.CreateCommand();
            insertCommand.CommandText = @"INSERT INTO GeriDonusumTipleri (GeriDonusumTipi) 
                 VALUES (@geridonusumtipi)";
            insertCommand.Parameters.AddWithValue("geridonusumtipi", textbox_geriDonusum.Text);
            if (textbox_geriDonusum.Text == "")
            {
                MessageBox.Show("Kaydetmek istediğiniz geri dönüşüm türü boş olamaz!");
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
