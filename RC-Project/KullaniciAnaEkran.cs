using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RC_Project
{
    public partial class KullaniciAnaEkran : Form
    {
        public KullaniciAnaEkran()
        {
            InitializeComponent();
        }
        public KullaniciModel kullanici = new KullaniciModel();


        private void KullaniciAnaEkran_Load(object sender, EventArgs e)
        {
            lblKad.Text = kullanici.AdSoyad;
            lblRC.Text = kullanici.ToplamRC.ToString();
            lblSHA.Text = kullanici.SHA256;
            lblUsername.Text = kullanici.KullaniciAdi;
            lblolusturmaTarihi.Text = kullanici.OlusturulmaTarihi.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void rcTransfer_btn_Click(object sender, EventArgs e)
        {
            RCTransfer transferEk = new RCTransfer();
            transferEk.kullanici = kullanici;
            transferEk.Show();
        }

        private void changePassword_btn_Click(object sender, EventArgs e)
        {
            ChangePassword passwordChangeSc = new ChangePassword();
            passwordChangeSc.kullanici = kullanici;
            passwordChangeSc.Show();
        }
    }
}
