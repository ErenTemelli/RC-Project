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
    public partial class RCSorgula : Form
    {
        public RCSorgula()
        {
            InitializeComponent();
        }

        private void btn_Sorgula_Click(object sender, EventArgs e)
        {
            double ret = 0;
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=RCdb.db");
            SQLiteCommand sqCommand = (SQLiteCommand)m_dbConnection.CreateCommand();
            sqCommand.CommandText = "SELECT ToplamRC FROM Kullanicilar WHERE SHA256=@SHA256";
            sqCommand.Parameters.AddWithValue("SHA256", textBox_SHA256.Text);
            m_dbConnection.Open();
            SQLiteDataReader sqReader = sqCommand.ExecuteReader();
            while (sqReader.Read())
            {
                ret = sqReader.GetDouble(0);
            }
            sqReader.Close();
            m_dbConnection.Close();
            MessageBox.Show(textBox_SHA256.Text + " numaralı SHA-256 adresine ait kullanıcının kullanılabilir toplam Recycle Coin miktarı : " + ret);
            this.Close();
        }
    }
}
