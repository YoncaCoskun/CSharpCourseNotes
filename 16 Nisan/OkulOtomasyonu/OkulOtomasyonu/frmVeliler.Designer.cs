namespace OkulOtomasyonu
{
    partial class frmVeliler
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
            this.lstVeliler = new System.Windows.Forms.ListBox();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstVeliler
            // 
            this.lstVeliler.FormattingEnabled = true;
            this.lstVeliler.Location = new System.Drawing.Point(25, 151);
            this.lstVeliler.Name = "lstVeliler";
            this.lstVeliler.Size = new System.Drawing.Size(312, 160);
            this.lstVeliler.TabIndex = 0;
            this.lstVeliler.DoubleClick += new System.EventHandler(this.lstVeliler_DoubleClick);
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Location = new System.Drawing.Point(25, 40);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(312, 47);
            this.btnYeniKayit.TabIndex = 1;
            this.btnYeniKayit.Text = "Yeni Kayıt";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kayıt güncellemek için çift tıklayınız.";
            // 
            // frmVeliler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(360, 329);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYeniKayit);
            this.Controls.Add(this.lstVeliler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmVeliler";
            this.Text = "Veliler";
            this.Load += new System.EventHandler(this.frmVeliler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstVeliler;
        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.Label label1;
    }
}