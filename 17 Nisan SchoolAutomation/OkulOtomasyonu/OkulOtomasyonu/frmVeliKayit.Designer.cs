namespace OkulOtomasyonu
{
    partial class frmVeliKayit
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
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVeliAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVeliSoyadi = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVazgec);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 288);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 54);
            this.panel1.TabIndex = 0;
            // 
            // btnVazgec
            // 
            this.btnVazgec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVazgec.Location = new System.Drawing.Point(176, 0);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(162, 54);
            this.btnVazgec.TabIndex = 1;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnKaydet.Location = new System.Drawing.Point(0, 0);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(176, 54);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtVeliSoyadi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtVeliAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 280);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Kayıt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Veli Telefon :";
            // 
            // txtVeliAdi
            // 
            this.txtVeliAdi.Location = new System.Drawing.Point(126, 95);
            this.txtVeliAdi.Name = "txtVeliAdi";
            this.txtVeliAdi.Size = new System.Drawing.Size(121, 20);
            this.txtVeliAdi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Veli Soyadı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veli Adı :";
            // 
            // txtVeliSoyadi
            // 
            this.txtVeliSoyadi.Location = new System.Drawing.Point(126, 147);
            this.txtVeliSoyadi.Name = "txtVeliSoyadi";
            this.txtVeliSoyadi.Size = new System.Drawing.Size(121, 20);
            this.txtVeliSoyadi.TabIndex = 5;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(126, 198);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(121, 20);
            this.txtTelefon.TabIndex = 6;
            // 
            // frmVeliKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(338, 342);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmVeliKayit";
            this.Text = "Veli Kayit";
            this.Load += new System.EventHandler(this.frmVeliKayit_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVeliAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.TextBox txtVeliSoyadi;
    }
}