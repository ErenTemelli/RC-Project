namespace RC_Project.Kullanicilar
{
    partial class KullaniciEkle
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
            this.lblKad = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblSHA = new System.Windows.Forms.Label();
            this.lblOP = new System.Windows.Forms.Label();
            this.textBox_Kadi = new System.Windows.Forms.TextBox();
            this.textBox_Sifre = new System.Windows.Forms.TextBox();
            this.textBox_AdSoyad = new System.Windows.Forms.TextBox();
            this.textBox_SHA = new System.Windows.Forms.TextBox();
            this.checkBoxOp = new System.Windows.Forms.CheckBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKad
            // 
            this.lblKad.AutoSize = true;
            this.lblKad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKad.Location = new System.Drawing.Point(24, 28);
            this.lblKad.Name = "lblKad";
            this.lblKad.Size = new System.Drawing.Size(81, 13);
            this.lblKad.TabIndex = 0;
            this.lblKad.Text = "Kullanıcı Adı:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(24, 54);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(37, 13);
            this.lblSifre.TabIndex = 1;
            this.lblSifre.Text = "Şifre:";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.Location = new System.Drawing.Point(24, 79);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(65, 13);
            this.lblAdSoyad.TabIndex = 2;
            this.lblAdSoyad.Text = "Ad Soyad:";
            // 
            // lblSHA
            // 
            this.lblSHA.AutoSize = true;
            this.lblSHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSHA.Location = new System.Drawing.Point(24, 105);
            this.lblSHA.Name = "lblSHA";
            this.lblSHA.Size = new System.Drawing.Size(57, 13);
            this.lblSHA.TabIndex = 3;
            this.lblSHA.Text = "SHA256:";
            // 
            // lblOP
            // 
            this.lblOP.AutoSize = true;
            this.lblOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOP.Location = new System.Drawing.Point(24, 128);
            this.lblOP.Name = "lblOP";
            this.lblOP.Size = new System.Drawing.Size(83, 13);
            this.lblOP.TabIndex = 4;
            this.lblOP.Text = "Operatör mü?";
            // 
            // textBox_Kadi
            // 
            this.textBox_Kadi.Location = new System.Drawing.Point(116, 21);
            this.textBox_Kadi.Name = "textBox_Kadi";
            this.textBox_Kadi.Size = new System.Drawing.Size(100, 20);
            this.textBox_Kadi.TabIndex = 8;
            this.textBox_Kadi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_Sifre
            // 
            this.textBox_Sifre.Location = new System.Drawing.Point(116, 47);
            this.textBox_Sifre.Name = "textBox_Sifre";
            this.textBox_Sifre.Size = new System.Drawing.Size(100, 20);
            this.textBox_Sifre.TabIndex = 9;
            this.textBox_Sifre.TextChanged += new System.EventHandler(this.textBox_Sifre_TextChanged);
            // 
            // textBox_AdSoyad
            // 
            this.textBox_AdSoyad.Location = new System.Drawing.Point(116, 72);
            this.textBox_AdSoyad.Name = "textBox_AdSoyad";
            this.textBox_AdSoyad.Size = new System.Drawing.Size(100, 20);
            this.textBox_AdSoyad.TabIndex = 10;
            // 
            // textBox_SHA
            // 
            this.textBox_SHA.Location = new System.Drawing.Point(116, 98);
            this.textBox_SHA.Name = "textBox_SHA";
            this.textBox_SHA.Size = new System.Drawing.Size(100, 20);
            this.textBox_SHA.TabIndex = 11;
            // 
            // checkBoxOp
            // 
            this.checkBoxOp.AutoSize = true;
            this.checkBoxOp.Location = new System.Drawing.Point(116, 128);
            this.checkBoxOp.Name = "checkBoxOp";
            this.checkBoxOp.Size = new System.Drawing.Size(15, 14);
            this.checkBoxOp.TabIndex = 16;
            this.checkBoxOp.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Save.Location = new System.Drawing.Point(78, 164);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 17;
            this.btn_Save.Text = "Kaydet";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // KullaniciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 199);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.checkBoxOp);
            this.Controls.Add(this.textBox_SHA);
            this.Controls.Add(this.textBox_AdSoyad);
            this.Controls.Add(this.textBox_Sifre);
            this.Controls.Add(this.textBox_Kadi);
            this.Controls.Add(this.lblOP);
            this.Controls.Add(this.lblSHA);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKad);
            this.Name = "KullaniciEkle";
            this.Text = "KullaniciEkle";
            this.Load += new System.EventHandler(this.KullaniciEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKad;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblSHA;
        private System.Windows.Forms.Label lblOP;
        private System.Windows.Forms.TextBox textBox_Kadi;
        private System.Windows.Forms.TextBox textBox_Sifre;
        private System.Windows.Forms.TextBox textBox_AdSoyad;
        private System.Windows.Forms.TextBox textBox_SHA;
        private System.Windows.Forms.CheckBox checkBoxOp;
        private System.Windows.Forms.Button btn_Save;
    }
}