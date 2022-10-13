namespace RC_Project
{
    partial class OperatorAnaEkran
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
            this.lblKad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRC = new System.Windows.Forms.Label();
            this.lblSHA = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.lblSHA);
            this.panel1.Controls.Add(this.lblRC);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblKad);
            this.panel1.Location = new System.Drawing.Point(713, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 250);
            this.panel1.TabIndex = 0;
            // 
            // lblKad
            // 
            this.lblKad.AutoSize = true;
            this.lblKad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKad.Location = new System.Drawing.Point(125, 16);
            this.lblKad.Name = "lblKad";
            this.lblKad.Size = new System.Drawing.Size(75, 32);
            this.lblKad.TabIndex = 0;
            this.lblKad.Text = "KAD";
            this.lblKad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // lblRC
            // 
            this.lblRC.AutoSize = true;
            this.lblRC.Location = new System.Drawing.Point(128, 122);
            this.lblRC.Name = "lblRC";
            this.lblRC.Size = new System.Drawing.Size(44, 16);
            this.lblRC.TabIndex = 4;
            this.lblRC.Text = "label5";
            // 
            // lblSHA
            // 
            this.lblSHA.AutoSize = true;
            this.lblSHA.Location = new System.Drawing.Point(131, 91);
            this.lblSHA.Name = "lblSHA";
            this.lblSHA.Size = new System.Drawing.Size(44, 16);
            this.lblSHA.TabIndex = 5;
            this.lblSHA.Text = "label6";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(131, 61);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(44, 16);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "label7";
            // 
            // OperatorAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 581);
            this.Controls.Add(this.panel1);
            this.Name = "OperatorAnaEkran";
            this.Text = "OperatorAnaEkran";
            this.Load += new System.EventHandler(this.OperatorAnaEkran_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblSHA;
        private System.Windows.Forms.Label lblRC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKad;
    }
}