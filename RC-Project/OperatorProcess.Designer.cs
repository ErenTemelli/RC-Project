namespace RC_Project
{
    partial class OperatorProcess
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxKullanicilar = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Tamamla = new System.Windows.Forms.Button();
            this.urunAdi = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCarbon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_totalKarbon = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_totalRC = new System.Windows.Forms.Label();
            this.lbl_totalKP = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxKullanicilar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(579, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 169);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "PUANIN AKTARILACAĞI \r\nKULLANICIYI SEÇİNİZ..";
            // 
            // comboBoxKullanicilar
            // 
            this.comboBoxKullanicilar.FormattingEnabled = true;
            this.comboBoxKullanicilar.Location = new System.Drawing.Point(68, 110);
            this.comboBoxKullanicilar.Name = "comboBoxKullanicilar";
            this.comboBoxKullanicilar.Size = new System.Drawing.Size(299, 24);
            this.comboBoxKullanicilar.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunAdi,
            this.miktar,
            this.totalCarbon});
            this.dataGridView1.Location = new System.Drawing.Point(44, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(567, 597);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // btn_Tamamla
            // 
            this.btn_Tamamla.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Tamamla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tamamla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Tamamla.Location = new System.Drawing.Point(732, 403);
            this.btn_Tamamla.Name = "btn_Tamamla";
            this.btn_Tamamla.Size = new System.Drawing.Size(214, 68);
            this.btn_Tamamla.TabIndex = 4;
            this.btn_Tamamla.Text = "İŞLEMİ TAMAMLA";
            this.btn_Tamamla.UseVisualStyleBackColor = false;
            this.btn_Tamamla.Click += new System.EventHandler(this.btn_Tamamla_Click);
            // 
            // urunAdi
            // 
            this.urunAdi.HeaderText = "Ürün Adı";
            this.urunAdi.MinimumWidth = 6;
            this.urunAdi.Name = "urunAdi";
            this.urunAdi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.urunAdi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.urunAdi.Width = 125;
            // 
            // miktar
            // 
            this.miktar.HeaderText = "Miktar";
            this.miktar.MinimumWidth = 6;
            this.miktar.Name = "miktar";
            this.miktar.Width = 125;
            // 
            // totalCarbon
            // 
            this.totalCarbon.HeaderText = "Toplam Karbon Miktarı";
            this.totalCarbon.MinimumWidth = 6;
            this.totalCarbon.Name = "totalCarbon";
            this.totalCarbon.Width = 125;
            // 
            // lbl_totalKarbon
            // 
            this.lbl_totalKarbon.AutoSize = true;
            this.lbl_totalKarbon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbl_totalKarbon.Location = new System.Drawing.Point(656, 218);
            this.lbl_totalKarbon.Name = "lbl_totalKarbon";
            this.lbl_totalKarbon.Size = new System.Drawing.Size(224, 22);
            this.lbl_totalKarbon.TabIndex = 5;
            this.lbl_totalKarbon.Text = "TOPLAM KARBON PUANI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(655, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "AKTARILACAK TOPLAM RC MİKTARI";
            // 
            // lbl_totalRC
            // 
            this.lbl_totalRC.AutoSize = true;
            this.lbl_totalRC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalRC.Location = new System.Drawing.Point(656, 332);
            this.lbl_totalRC.Name = "lbl_totalRC";
            this.lbl_totalRC.Size = new System.Drawing.Size(19, 20);
            this.lbl_totalRC.TabIndex = 7;
            this.lbl_totalRC.Text = "0";
            // 
            // lbl_totalKP
            // 
            this.lbl_totalKP.AutoSize = true;
            this.lbl_totalKP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalKP.Location = new System.Drawing.Point(656, 258);
            this.lbl_totalKP.Name = "lbl_totalKP";
            this.lbl_totalKP.Size = new System.Drawing.Size(19, 20);
            this.lbl_totalKP.TabIndex = 8;
            this.lbl_totalKP.Text = "0";
            // 
            // OperatorProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 644);
            this.Controls.Add(this.lbl_totalKP);
            this.Controls.Add(this.lbl_totalRC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_totalKarbon);
            this.Controls.Add(this.btn_Tamamla);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "OperatorProcess";
            this.Text = "OperatorProcess";
            this.Load += new System.EventHandler(this.OperatorProcess_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxKullanicilar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Tamamla;
        private System.Windows.Forms.DataGridViewComboBoxColumn urunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCarbon;
        private System.Windows.Forms.Label lbl_totalKarbon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_totalRC;
        private System.Windows.Forms.Label lbl_totalKP;
    }
}