namespace Katmanlar
{
    partial class Form2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtBirimFiyati = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(25, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(280, 472);
            this.listBox1.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(440, 197);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(89, 30);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(421, 74);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(126, 20);
            this.txtUrunAdi.TabIndex = 2;
            // 
            // txtBirimFiyati
            // 
            this.txtBirimFiyati.Location = new System.Drawing.Point(421, 115);
            this.txtBirimFiyati.Name = "txtBirimFiyati";
            this.txtBirimFiyati.Size = new System.Drawing.Size(126, 20);
            this.txtBirimFiyati.TabIndex = 3;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(421, 153);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(126, 20);
            this.txtMiktar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Urun Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Birim Fiyatı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Miktar :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 515);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.txtBirimFiyati);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.listBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtBirimFiyati;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}