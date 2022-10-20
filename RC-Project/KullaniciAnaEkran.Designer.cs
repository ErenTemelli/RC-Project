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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.lblSHA);
            this.panel1.Controls.Add(this.lblRC);
            this.panel1.Controls.Add(this.lblolusturmaTarihi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblKad);
            this.panel1.Location = new System.Drawing.Point(657, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 186);
            this.panel1.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.PeachPuff;
            this.lblUsername.Location = new System.Drawing.Point(133, 63);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 16);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "kullanıcıAdı";
            // 
            // lblSHA
            // 
            this.lblSHA.AutoSize = true;
            this.lblSHA.BackColor = System.Drawing.Color.PeachPuff;
            this.lblSHA.Location = new System.Drawing.Point(108, 90);
            this.lblSHA.Name = "lblSHA";
            this.lblSHA.Size = new System.Drawing.Size(58, 16);
            this.lblSHA.TabIndex = 5;
            this.lblSHA.Text = "ShaSifre";
            // 
            // lblRC
            // 
            this.lblRC.AutoSize = true;
            this.lblRC.BackColor = System.Drawing.Color.PeachPuff;
            this.lblRC.Location = new System.Drawing.Point(157, 119);
            this.lblRC.Name = "lblRC";
            this.lblRC.Size = new System.Drawing.Size(71, 16);
            this.lblRC.TabIndex = 4;
            this.lblRC.Text = "ToplamRc";
            // 
            // lblolusturmaTarihi
            // 
            this.lblolusturmaTarihi.AutoSize = true;
            this.lblolusturmaTarihi.BackColor = System.Drawing.Color.PeachPuff;
            this.lblolusturmaTarihi.Location = new System.Drawing.Point(179, 146);
            this.lblolusturmaTarihi.Name = "lblolusturmaTarihi";
            this.lblolusturmaTarihi.Size = new System.Drawing.Size(79, 16);
            this.lblolusturmaTarihi.TabIndex = 3;
            this.lblolusturmaTarihi.Text = "hesapTarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PeachPuff;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kullanıcı Adı:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PeachPuff;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "SHA-256:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lblKad
            // 
            this.lblKad.AutoSize = true;
            this.lblKad.BackColor = System.Drawing.Color.PeachPuff;
            this.lblKad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKad.Location = new System.Drawing.Point(56, 17);
            this.lblKad.Name = "lblKad";
            this.lblKad.Size = new System.Drawing.Size(271, 32);
            this.lblKad.TabIndex = 0;
            this.lblKad.Text = "Kullanıcı Ad Soyad";
            this.lblKad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kullanılabilir RC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PeachPuff;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hesap Oluşturulma:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 186);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(346, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 186);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(346, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(224, 186);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(44, 308);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(224, 186);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(657, 308);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(224, 186);
            this.button5.TabIndex = 6;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // KullaniciAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}