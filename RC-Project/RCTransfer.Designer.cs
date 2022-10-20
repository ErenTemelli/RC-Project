namespace RC_Project
{
    partial class RCTransfer
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
            this.txtSHA = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.btn_Transfer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lütfen Recycle Coin transferi yapmak istediğiniz SHA-256 adresini ve miktarını gi" +
    "riniz.";
            // 
            // txtSHA
            // 
            this.txtSHA.Location = new System.Drawing.Point(67, 55);
            this.txtSHA.Name = "txtSHA";
            this.txtSHA.Size = new System.Drawing.Size(500, 22);
            this.txtSHA.TabIndex = 1;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(573, 55);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(98, 22);
            this.txtMiktar.TabIndex = 2;
            // 
            // btn_Transfer
            // 
            this.btn_Transfer.Location = new System.Drawing.Point(677, 55);
            this.btn_Transfer.Name = "btn_Transfer";
            this.btn_Transfer.Size = new System.Drawing.Size(127, 23);
            this.btn_Transfer.TabIndex = 3;
            this.btn_Transfer.Text = "Transfer Yap";
            this.btn_Transfer.UseVisualStyleBackColor = true;
            this.btn_Transfer.Click += new System.EventHandler(this.btn_Transfer_Click);
            // 
            // RCTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 93);
            this.Controls.Add(this.btn_Transfer);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.txtSHA);
            this.Controls.Add(this.label1);
            this.Name = "RCTransfer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RCTransfer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSHA;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Button btn_Transfer;
    }
}