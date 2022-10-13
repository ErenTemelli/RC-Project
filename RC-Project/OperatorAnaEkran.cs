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
    public partial class OperatorAnaEkran : Form
    {
        public OperatorAnaEkran()
        {
            InitializeComponent();
        }
        public void SetKadTextForLabel(string kAdi)
        {
            this.lblKad.Text = kAdi;
        }
        public void SetTotalRcLabel(double TotalRC)
        {
            this.lblRC.Text = TotalRC.ToString();
        }
        public void SetSHALabel(string SHA256)
        {
            this.lblSHA.Text = SHA256.ToString();
        }
        public void SetKullaniciAdi(string kAdi)
        {
            this.lblUsername.Text = kAdi.ToString();
        }
        private void OperatorAnaEkran_Load(object sender, EventArgs e)
        {

        }
    }
}
