namespace RC_Project
{
    partial class GeriDonusumEkle
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
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.textbox_geriDonusum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ekle.Location = new System.Drawing.Point(99, 60);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_Ekle.TabIndex = 0;
            this.btn_Ekle.Text = "Kaydet";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl1.Location = new System.Drawing.Point(12, 26);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(120, 13);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Geri Dönüşüm Türü:";
            // 
            // textbox_geriDonusum
            // 
            this.textbox_geriDonusum.Location = new System.Drawing.Point(138, 23);
            this.textbox_geriDonusum.Name = "textbox_geriDonusum";
            this.textbox_geriDonusum.Size = new System.Drawing.Size(127, 20);
            this.textbox_geriDonusum.TabIndex = 2;
            // 
            // GeriDonusumEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 107);
            this.Controls.Add(this.textbox_geriDonusum);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btn_Ekle);
            this.Name = "GeriDonusumEkle";
            this.Text = "GeriDonusumEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox textbox_geriDonusum;
    }
}