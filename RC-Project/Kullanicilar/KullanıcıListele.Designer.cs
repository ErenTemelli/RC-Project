namespace RC_Project
{
    partial class KullanıcıListele
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
            this.dataGridKullanicilar = new System.Windows.Forms.DataGridView();
            this.bnt_sil = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_duzenle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKullanicilar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridKullanicilar
            // 
            this.dataGridKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKullanicilar.Location = new System.Drawing.Point(16, 50);
            this.dataGridKullanicilar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridKullanicilar.Name = "dataGridKullanicilar";
            this.dataGridKullanicilar.RowHeadersWidth = 51;
            this.dataGridKullanicilar.Size = new System.Drawing.Size(1035, 489);
            this.dataGridKullanicilar.TabIndex = 0;
            // 
            // bnt_sil
            // 
            this.bnt_sil.Location = new System.Drawing.Point(124, 15);
            this.bnt_sil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bnt_sil.Name = "bnt_sil";
            this.bnt_sil.Size = new System.Drawing.Size(100, 28);
            this.bnt_sil.TabIndex = 1;
            this.bnt_sil.Text = "Sil";
            this.bnt_sil.UseVisualStyleBackColor = true;
            this.bnt_sil.Click += new System.EventHandler(this.bnt_sil_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(16, 15);
            this.btn_ekle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(100, 28);
            this.btn_ekle.TabIndex = 2;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_duzenle
            // 
            this.btn_duzenle.Location = new System.Drawing.Point(232, 15);
            this.btn_duzenle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_duzenle.Name = "btn_duzenle";
            this.btn_duzenle.Size = new System.Drawing.Size(100, 28);
            this.btn_duzenle.TabIndex = 3;
            this.btn_duzenle.Text = "Düzenle";
            this.btn_duzenle.UseVisualStyleBackColor = true;
            this.btn_duzenle.Click += new System.EventHandler(this.btn_duzenle_Click);
            // 
            // KullanıcıListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_duzenle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.bnt_sil);
            this.Controls.Add(this.dataGridKullanicilar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "KullanıcıListele";
            this.Text = "KullanıcıListele";
            this.Activated += new System.EventHandler(this.KullanıcıListele_Activated);
            this.Load += new System.EventHandler(this.KullanıcıListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKullanicilar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridKullanicilar;
        private System.Windows.Forms.Button bnt_sil;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_duzenle;
    }
}