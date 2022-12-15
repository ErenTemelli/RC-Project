namespace RC_Project.Urunler
{
    partial class UrunEkle
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
            this.textBox_CPoint = new System.Windows.Forms.TextBox();
            this.textBox_NAdi = new System.Windows.Forms.TextBox();
            this.lblRType = new System.Windows.Forms.Label();
            this.lblCPoint = new System.Windows.Forms.Label();
            this.lblNad = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.comboBoxGeriDonusum = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox_CPoint
            // 
            this.textBox_CPoint.Location = new System.Drawing.Point(177, 53);
            this.textBox_CPoint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_CPoint.Name = "textBox_CPoint";
            this.textBox_CPoint.Size = new System.Drawing.Size(132, 22);
            this.textBox_CPoint.TabIndex = 17;
            // 
            // textBox_NAdi
            // 
            this.textBox_NAdi.Location = new System.Drawing.Point(177, 21);
            this.textBox_NAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_NAdi.Name = "textBox_NAdi";
            this.textBox_NAdi.Size = new System.Drawing.Size(132, 22);
            this.textBox_NAdi.TabIndex = 16;
            // 
            // lblRType
            // 
            this.lblRType.AutoSize = true;
            this.lblRType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRType.Location = new System.Drawing.Point(16, 87);
            this.lblRType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRType.Name = "lblRType";
            this.lblRType.Size = new System.Drawing.Size(148, 17);
            this.lblRType.TabIndex = 14;
            this.lblRType.Text = "Geri Dönüşüm Tipi:";
            // 
            // lblCPoint
            // 
            this.lblCPoint.AutoSize = true;
            this.lblCPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCPoint.Location = new System.Drawing.Point(16, 57);
            this.lblCPoint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPoint.Name = "lblCPoint";
            this.lblCPoint.Size = new System.Drawing.Size(111, 17);
            this.lblCPoint.TabIndex = 13;
            this.lblCPoint.Text = "Karbon Puanı:";
            // 
            // lblNad
            // 
            this.lblNad.AutoSize = true;
            this.lblNad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNad.Location = new System.Drawing.Point(16, 25);
            this.lblNad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNad.Name = "lblNad";
            this.lblNad.Size = new System.Drawing.Size(87, 17);
            this.lblNad.TabIndex = 12;
            this.lblNad.Text = "Nesne Adı:";
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Save.Location = new System.Drawing.Point(119, 130);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(100, 28);
            this.btn_Save.TabIndex = 20;
            this.btn_Save.Text = "Kaydet";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // comboBoxGeriDonusum
            // 
            this.comboBoxGeriDonusum.FormattingEnabled = true;
            this.comboBoxGeriDonusum.Location = new System.Drawing.Point(177, 87);
            this.comboBoxGeriDonusum.Name = "comboBoxGeriDonusum";
            this.comboBoxGeriDonusum.Size = new System.Drawing.Size(132, 24);
            this.comboBoxGeriDonusum.TabIndex = 21;
            // 
            // UrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 174);
            this.Controls.Add(this.comboBoxGeriDonusum);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.textBox_CPoint);
            this.Controls.Add(this.textBox_NAdi);
            this.Controls.Add(this.lblRType);
            this.Controls.Add(this.lblCPoint);
            this.Controls.Add(this.lblNad);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UrunEkle";
            this.Text = "UrunEkle";
            this.Load += new System.EventHandler(this.UrunEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_CPoint;
        private System.Windows.Forms.TextBox textBox_NAdi;
        private System.Windows.Forms.Label lblRType;
        private System.Windows.Forms.Label lblCPoint;
        private System.Windows.Forms.Label lblNad;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox comboBoxGeriDonusum;
    }
}