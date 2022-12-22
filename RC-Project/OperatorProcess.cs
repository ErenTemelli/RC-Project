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
    public partial class OperatorProcess : Form
    {
        public OperatorProcess()
        {
            InitializeComponent();
        }

        double totalRC = 0;
        int totalKP = 0;
        private void OperatorProcess_Load(object sender, EventArgs e)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=RCdb.db");
            SQLiteCommand sqCommand = (SQLiteCommand)m_dbConnection.CreateCommand();
            sqCommand.CommandText = "SELECT RecID, AdSoyad FROM Kullanicilar";
            m_dbConnection.Open();
            SQLiteDataReader sqReader = sqCommand.ExecuteReader();
            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            while (sqReader.Read())
            {
                comboSource.Add(sqReader.GetInt32(0), sqReader.GetString(1));
            }
            comboBoxKullanicilar.DataSource = new BindingSource(comboSource, null);
            comboBoxKullanicilar.DisplayMember = "Value";
            comboBoxKullanicilar.ValueMember = "Key";
            sqReader.Close();
            m_dbConnection.Close();
            sqCommand.CommandText = "SELECT KarbonPoint, NesneAdi FROM Nesneler";
            m_dbConnection.Open();
            SQLiteDataReader sqReader2 = sqCommand.ExecuteReader();
            Dictionary<string, string> comboSource2 = new Dictionary<string, string>();
            while (sqReader2.Read())
            {
                comboSource2.Add(sqReader2.GetString(1), sqReader2.GetString(0));
            }
            urunAdi.DataSource = new BindingSource(comboSource2, null);
            urunAdi.DisplayMember = "Key";
            urunAdi.ValueMember = "Value";
            sqReader2.Close();
            m_dbConnection.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 1)
                {
                    if (Convert.ToInt32(dataGridView1[0, e.RowIndex].Value) != 0 || dataGridView1[0, e.RowIndex].Value != null)
                    {
                        dataGridView1[2, e.RowIndex].Value = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value) * Convert.ToInt32(dataGridView1[1, e.RowIndex].Value);
                    }
                    else
                    {
                        MessageBox.Show("Lütfen ürün seçimi yapınız..");
                    }
                }
                else if (e.ColumnIndex == 0)
                {
                    if (Convert.ToInt32(dataGridView1[1, e.RowIndex].Value) != 0 || dataGridView1[1, e.RowIndex].Value != null)
                    {
                        dataGridView1[2, e.RowIndex].Value = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value) * Convert.ToInt32(dataGridView1[1, e.RowIndex].Value);
                    }
                }

                if (dataGridView1[2, e.RowIndex].Value != null || Convert.ToInt32(dataGridView1[2, e.RowIndex].Value) != 0)
                {
                    totalKP = 0;
                    totalRC = 0;
                    for (int x = 0; x < dataGridView1.Rows.Count; x++)
                    {
                        totalKP += Convert.ToInt32(dataGridView1.Rows[x].Cells["totalCarbon"].Value);
                    }
                    lbl_totalKP.Text = totalKP.ToString("N0");
                    totalRC = Convert.ToDouble(Convert.ToDouble(totalKP) / 100000000);
                    lbl_totalRC.Text = totalRC.ToString("N10");
                }
            }
            catch
            {

            }
        }

        private void btn_Tamamla_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("İşlem tamamlanıp, " + comboBoxKullanicilar.SelectedItem.ToString() +  " adlı kullanıcıya " + totalRC + " tutarında RC transfer edilecektir. İşlemi onaylıyor musunuz?",
                "İşlemi Tamamla", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result1 == DialogResult.Yes)
            {
                double eskiRCMiktari = 0;

                //Eski RC Miktari tespit ediliyor.
                SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=RCdb.db");
                SQLiteCommand sqCommand = (SQLiteCommand)m_dbConnection.CreateCommand();
                sqCommand.CommandText = "SELECT ToplamRC FROM Kullanicilar WHERE RecID=@RecID";
                sqCommand.Parameters.AddWithValue("RecID", comboBoxKullanicilar.SelectedValue);
                m_dbConnection.Open();
                SQLiteDataReader sqReader = sqCommand.ExecuteReader();
                while (sqReader.Read())
                {
                    eskiRCMiktari = sqReader.GetDouble(0);
                }

                //Yeni RC Miktarı kullanıcıya atanıyor.
                SQLiteCommand sqCommand2 = (SQLiteCommand)m_dbConnection.CreateCommand();
                sqCommand2.CommandText = "UPDATE Kullanicilar SET ToplamRC = @YeniRC WHERE RecID=@RecID";
                sqCommand2.Parameters.AddWithValue("RecID", comboBoxKullanicilar.SelectedValue);
                sqCommand2.Parameters.AddWithValue("YeniRC", eskiRCMiktari + totalRC);
                sqCommand2.ExecuteNonQuery();
                MessageBox.Show("Transfer başarıyla tamamlanmıştır.");
            }
            else
            {
            }
        }
    }
}
