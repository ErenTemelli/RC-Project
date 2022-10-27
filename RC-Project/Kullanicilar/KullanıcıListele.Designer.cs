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
            this.dataGridKullanicilar.Location = new System.Drawing.Point(12, 41);
            this.dataGridKullanicilar.Name = "dataGridKullanicilar";
            this.dataGridKullanicilar.Size = new System.Drawing.Size(776, 397);
            this.dataGridKullanicilar.TabIndex = 0;
            // 
            // bnt_sil
            // 
            this.bnt_sil.Location = new System.Drawing.Point(93, 12);
            this.bnt_sil.Name = "bnt_sil";
            this.bnt_sil.Size = new System.Drawing.Size(75, 23);
            this.bnt_sil.TabIndex = 1;
            this.bnt_sil.Text = "Sil";
            this.bnt_sil.UseVisualStyleBackColor = true;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(12, 12);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 2;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_duzenle
            // 
            this.btn_duzenle.Location = new System.Drawing.Point(174, 12);
            this.btn_duzenle.Name = "btn_duzenle";
            this.btn_duzenle.Size = new System.Drawing.Size(75, 23);
            this.btn_duzenle.TabIndex = 3;
            this.btn_duzenle.Text = "Düzenle";
            this.btn_duzenle.UseVisualStyleBackColor = true;
            // 
            // KullanıcıListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_duzenle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.bnt_sil);
            this.Controls.Add(this.dataGridKullanicilar);
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