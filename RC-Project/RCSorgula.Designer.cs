namespace RC_Project
{
    partial class RCSorgula
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_SHA256 = new System.Windows.Forms.TextBox();
            this.btn_Sorgula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "RC miktarını sorgulamak istediğiniz SHA-256 adresini giriniz.";
            // 
            // textBox_SHA256
            // 
            this.textBox_SHA256.Location = new System.Drawing.Point(92, 64);
            this.textBox_SHA256.Name = "textBox_SHA256";
            this.textBox_SHA256.Size = new System.Drawing.Size(395, 22);
            this.textBox_SHA256.TabIndex = 1;
            // 
            // btn_Sorgula
            // 
            this.btn_Sorgula.Location = new System.Drawing.Point(510, 63);
            this.btn_Sorgula.Name = "btn_Sorgula";
            this.btn_Sorgula.Size = new System.Drawing.Size(142, 23);
            this.btn_Sorgula.TabIndex = 2;
            this.btn_Sorgula.Text = "Sorgula";
            this.btn_Sorgula.UseVisualStyleBackColor = true;
            this.btn_Sorgula.Click += new System.EventHandler(this.btn_Sorgula_Click);
            // 
            // RCSorgula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 103);
            this.Controls.Add(this.btn_Sorgula);
            this.Controls.Add(this.textBox_SHA256);
            this.Controls.Add(this.label1);
            this.Name = "RCSorgula";
            this.Text = "RCSorgula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_SHA256;
        private System.Windows.Forms.Button btn_Sorgula;
    }
}