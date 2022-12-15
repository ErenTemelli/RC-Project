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
            this.textBox_RType = new System.Windows.Forms.TextBox();
            this.textBox_CPoint = new System.Windows.Forms.TextBox();
            this.textBox_NAdi = new System.Windows.Forms.TextBox();
            this.lblRType = new System.Windows.Forms.Label();
            this.lblCPoint = new System.Windows.Forms.Label();
            this.lblNad = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_RType
            // 
            this.textBox_RType.Location = new System.Drawing.Point(133, 68);
            this.textBox_RType.Name = "textBox_RType";
            this.textBox_RType.Size = new System.Drawing.Size(100, 20);
            this.textBox_RType.TabIndex = 18;
            // 
            // textBox_CPoint
            // 
            this.textBox_CPoint.Location = new System.Drawing.Point(133, 43);
            this.textBox_CPoint.Name = "textBox_CPoint";
            this.textBox_CPoint.Size = new System.Drawing.Size(100, 20);
            this.textBox_CPoint.TabIndex = 17;
            // 
            // textBox_NAdi
            // 
            this.textBox_NAdi.Location = new System.Drawing.Point(133, 17);
            this.textBox_NAdi.Name = "textBox_NAdi";
            this.textBox_NAdi.Size = new System.Drawing.Size(100, 20);
            this.textBox_NAdi.TabIndex = 16;
            // 
            // lblRType
            // 
            this.lblRType.AutoSize = true;
            this.lblRType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRType.Location = new System.Drawing.Point(12, 71);
            this.lblRType.Name = "lblRType";
            this.lblRType.Size = new System.Drawing.Size(115, 13);
            this.lblRType.TabIndex = 14;
            this.lblRType.Text = "Geri Dönüşüm Tipi:";
            // 
            // lblCPoint
            // 
            this.lblCPoint.AutoSize = true;
            this.lblCPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCPoint.Location = new System.Drawing.Point(12, 46);
            this.lblCPoint.Name = "lblCPoint";
            this.lblCPoint.Size = new System.Drawing.Size(87, 13);
            this.lblCPoint.TabIndex = 13;
            this.lblCPoint.Text = "Karbon Puanı:";
            // 
            // lblNad
            // 
            this.lblNad.AutoSize = true;
            this.lblNad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNad.Location = new System.Drawing.Point(12, 20);
            this.lblNad.Name = "lblNad";
            this.lblNad.Size = new System.Drawing.Size(69, 13);
            this.lblNad.TabIndex = 12;
            this.lblNad.Text = "Nesne Adı:";
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Save.Location = new System.Drawing.Point(89, 106);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 20;
            this.btn_Save.Text = "Kaydet";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // UrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 141);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.textBox_RType);
            this.Controls.Add(this.textBox_CPoint);
            this.Controls.Add(this.textBox_NAdi);
            this.Controls.Add(this.lblRType);
            this.Controls.Add(this.lblCPoint);
            this.Controls.Add(this.lblNad);
            this.Name = "UrunEkle";
            this.Text = "UrunEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_RType;
        private System.Windows.Forms.TextBox textBox_CPoint;
        private System.Windows.Forms.TextBox textBox_NAdi;
        private System.Windows.Forms.Label lblRType;
        private System.Windows.Forms.Label lblCPoint;
        private System.Windows.Forms.Label lblNad;
        private System.Windows.Forms.Button btn_Save;
    }
}