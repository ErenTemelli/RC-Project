﻿using System;
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
        public KullaniciModel kullanici = new KullaniciModel();

        private void OperatorAnaEkran_Load(object sender, EventArgs e)
        {
            lblKad.Text = kullanici.AdSoyad;
            lblRC.Text = kullanici.ToplamRC.ToString();
            lblSHA.Text = kullanici.SHA256;
            lblUsername.Text = kullanici.KullaniciAdi;
            lblolusturmaTarihi.Text = kullanici.OlusturulmaTarihi.ToString();
        }
    }
}
