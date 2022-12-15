namespace RC_Project.Urunler
{
    partial class UrunListele1
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
            this.dataGridUrunler = new System.Windows.Forms.DataGridView();
            this.btn_duzenle = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.bnt_sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridUrunler
            // 
            this.dataGridUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUrunler.Location = new System.Drawing.Point(16, 50);
            this.dataGridUrunler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridUrunler.Name = "dataGridUrunler";
            this.dataGridUrunler.RowHeadersWidth = 51;
            this.dataGridUrunler.Size = new System.Drawing.Size(688, 489);
            this.dataGridUrunler.TabIndex = 1;
            // 
            // btn_duzenle
            // 
            this.btn_duzenle.Location = new System.Drawing.Point(232, 15);
            this.btn_duzenle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_duzenle.Name = "btn_duzenle";
            this.btn_duzenle.Size = new System.Drawing.Size(100, 28);
            this.btn_duzenle.TabIndex = 6;
            this.btn_duzenle.Text = "Düzenle";
            this.btn_duzenle.UseVisualStyleBackColor = true;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(16, 15);
            this.btn_ekle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(100, 28);
            this.btn_ekle.TabIndex = 5;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // bnt_sil
            // 
            this.bnt_sil.Location = new System.Drawing.Point(124, 15);
            this.bnt_sil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bnt_sil.Name = "bnt_sil";
            this.bnt_sil.Size = new System.Drawing.Size(100, 28);
            this.bnt_sil.TabIndex = 4;
            this.bnt_sil.Text = "Sil";
            this.bnt_sil.UseVisualStyleBackColor = true;
            this.bnt_sil.Click += new System.EventHandler(this.bnt_sil_Click);
            // 
            // UrunListele1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 554);
            this.Controls.Add(this.btn_duzenle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.bnt_sil);
            this.Controls.Add(this.dataGridUrunler);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UrunListele1";
            this.Text = "UrunListele1";
            this.Activated += new System.EventHandler(this.UrunListele1_Activated);
            this.Load += new System.EventHandler(this.UrunListele1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUrunler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridUrunler;
        private System.Windows.Forms.Button btn_duzenle;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button bnt_sil;
    }
}