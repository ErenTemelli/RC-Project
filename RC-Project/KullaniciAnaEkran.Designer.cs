using System;

namespace RC_Project
{
    partial class KullaniciAnaEkran
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblSHA = new System.Windows.Forms.Label();
            this.lblRC = new System.Windows.Forms.Label();
            this.lblolusturmaTarihi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKad = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.lblSHA);
            this.panel1.Controls.Add(this.lblRC);
            this.panel1.Controls.Add(this.lblolusturmaTarihi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblKad);
            this.panel1.Location = new System.Drawing.Point(531, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 204);
            this.panel1.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.PeachPuff;
            this.lblUsername.Location = new System.Drawing.Point(23, 50);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(60, 13);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "kullanıcıAdı";
            // 
            // lblSHA
            // 
            this.lblSHA.AutoSize = true;
            this.lblSHA.BackColor = System.Drawing.Color.PeachPuff;
            this.lblSHA.Location = new System.Drawing.Point(23, 72);
            this.lblSHA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSHA.Name = "lblSHA";
            this.lblSHA.Size = new System.Drawing.Size(47, 13);
            this.lblSHA.TabIndex = 5;
            this.lblSHA.Text = "ShaSifre";
            // 
            // lblRC
            // 
            this.lblRC.AutoSize = true;
            this.lblRC.BackColor = System.Drawing.Color.PeachPuff;
            this.lblRC.Location = new System.Drawing.Point(23, 96);
            this.lblRC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRC.Name = "lblRC";
            this.lblRC.Size = new System.Drawing.Size(56, 13);
            this.lblRC.TabIndex = 4;
            this.lblRC.Text = "ToplamRc";
            // 
            // lblolusturmaTarihi
            // 
            this.lblolusturmaTarihi.AutoSize = true;
            this.lblolusturmaTarihi.BackColor = System.Drawing.Color.PeachPuff;
            this.lblolusturmaTarihi.Location = new System.Drawing.Point(23, 118);
            this.lblolusturmaTarihi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblolusturmaTarihi.Name = "lblolusturmaTarihi";
            this.lblolusturmaTarihi.Size = new System.Drawing.Size(62, 13);
            this.lblolusturmaTarihi.TabIndex = 3;
            this.lblolusturmaTarihi.Text = "hesapTarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PeachPuff;
            this.label3.Location = new System.Drawing.Point(23, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PeachPuff;
            this.label2.Location = new System.Drawing.Point(23, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // lblKad
            // 
            this.lblKad.AutoSize = true;
            this.lblKad.BackColor = System.Drawing.Color.PeachPuff;
            this.lblKad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKad.Location = new System.Drawing.Point(21, 13);
            this.lblKad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKad.Name = "lblKad";
            this.lblKad.Size = new System.Drawing.Size(213, 26);
            this.lblKad.TabIndex = 0;
            this.lblKad.Text = "Kullanıcı Ad Soyad";
            this.lblKad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // KullaniciAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "KullaniciAnaEkran";
            this.Text = "KullaniciAnaEkran";
            this.Load += new System.EventHandler(this.KullaniciAnaEkran_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblSHA;
        private System.Windows.Forms.Label lblRC;
        private System.Windows.Forms.Label lblolusturmaTarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKad;
        private EventHandler label4_Click;
        private EventHandler label2_Click;
    }
}