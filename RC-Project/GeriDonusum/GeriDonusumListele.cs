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

namespace RC_Project.GeriDonusum
{
    public partial class GeriDonusumListele : Form
    {
        public GeriDonusumListele()
        {
            InitializeComponent();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            GeriDonusumEkle geriDonusumEkle = new GeriDonusumEkle();
            geriDonusumEkle.Show();
        }

        public void GeriDonusumListele_Activated(object sender, EventArgs e)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=RCdb.db");
            SQLiteCommand sqCommand = (SQLiteCommand)m_dbConnection.CreateCommand();
            sqCommand.CommandText = "SELECT GeriDonusumTipi FROM GeriDonusumTipleri";
            m_dbConnection.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(sqCommand.CommandText, m_dbConnection);
            DataSet ds = new DataSet();
            da.Fill(ds, "GeriDonusumTipleri");
            dataGridGeriDonusum.DataSource = ds.Tables[0].DefaultView;
            
        }
        void kayitSil(string GDTipi)
        {
            try
            {
                SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=RCdb.db");
                SQLiteCommand sqCommand = (SQLiteCommand)m_dbConnection.CreateCommand();
                sqCommand.CommandText = "DELETE FROM GeriDonusumTipleri WHERE GeriDonusumTipi=@GDTipi";
                sqCommand.Parameters.AddWithValue("@GDTipi", GDTipi);             
                m_dbConnection.Open();
                sqCommand.ExecuteNonQuery();
                m_dbConnection.Close();
                MessageBox.Show("Geri Donusum Tipi başarı ile silindi.");
            }
            catch
            {
                MessageBox.Show("İşlemi yaparken hata ile karşılaşıldı.");
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (dataGridGeriDonusum.SelectedRows.Count >= 0)
            {
                kayitSil(dataGridGeriDonusum.SelectedCells[0].Value.ToString());
            }
            else
            {
                MessageBox.Show("Lutfen Silinecek Satiri Seciniz.");
            }
        }
    }
}
