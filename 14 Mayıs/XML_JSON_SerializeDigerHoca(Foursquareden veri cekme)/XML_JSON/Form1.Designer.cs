namespace XML_JSON
{
    partial class Form1
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.pbFotograf = new System.Windows.Forms.PictureBox();
            this.lstKisiler = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnXMLDisari = new System.Windows.Forms.Button();
            this.btnXMLIceri = new System.Windows.Forms.Button();
            this.dosyaAc = new System.Windows.Forms.OpenFileDialog();
            this.dosyaKaydet = new System.Windows.Forms.SaveFileDialog();
            this.btnDisariJson = new System.Windows.Forms.Button();
            this.btnIceriJson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotograf)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(61, 5);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(121, 20);
            this.txtAd.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyad";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(61, 31);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(121, 20);
            this.txtSoyad.TabIndex = 1;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(61, 58);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(176, 20);
            this.dtpDogumTarihi.TabIndex = 2;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(61, 84);
            this.txtTelefon.Mask = "9999 000 00 00";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(121, 20);
            this.txtTelefon.TabIndex = 3;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(61, 111);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(121, 21);
            this.cmbCinsiyet.TabIndex = 4;
            // 
            // pbFotograf
            // 
            this.pbFotograf.Location = new System.Drawing.Point(15, 138);
            this.pbFotograf.Name = "pbFotograf";
            this.pbFotograf.Size = new System.Drawing.Size(167, 170);
            this.pbFotograf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotograf.TabIndex = 5;
            this.pbFotograf.TabStop = false;
            this.pbFotograf.Click += new System.EventHandler(this.pbFotograf_Click);
            // 
            // lstKisiler
            // 
            this.lstKisiler.FormattingEnabled = true;
            this.lstKisiler.Location = new System.Drawing.Point(261, 5);
            this.lstKisiler.Name = "lstKisiler";
            this.lstKisiler.Size = new System.Drawing.Size(134, 303);
            this.lstKisiler.TabIndex = 6;
            this.lstKisiler.SelectedIndexChanged += new System.EventHandler(this.lstKisiler_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "DT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cinsiyet";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(188, 138);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(67, 48);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnXMLDisari
            // 
            this.btnXMLDisari.Location = new System.Drawing.Point(261, 315);
            this.btnXMLDisari.Name = "btnXMLDisari";
            this.btnXMLDisari.Size = new System.Drawing.Size(60, 56);
            this.btnXMLDisari.TabIndex = 7;
            this.btnXMLDisari.Text = "Dışarı Aktar XML";
            this.btnXMLDisari.UseVisualStyleBackColor = true;
            this.btnXMLDisari.Click += new System.EventHandler(this.btnXMLDisari_Click);
            // 
            // btnXMLIceri
            // 
            this.btnXMLIceri.Location = new System.Drawing.Point(335, 315);
            this.btnXMLIceri.Name = "btnXMLIceri";
            this.btnXMLIceri.Size = new System.Drawing.Size(60, 56);
            this.btnXMLIceri.TabIndex = 8;
            this.btnXMLIceri.Text = "İçeri Aktar XML";
            this.btnXMLIceri.UseVisualStyleBackColor = true;
            this.btnXMLIceri.Click += new System.EventHandler(this.btnXMLIceri_Click);
            // 
            // btnDisariJson
            // 
            this.btnDisariJson.Location = new System.Drawing.Point(261, 378);
            this.btnDisariJson.Name = "btnDisariJson";
            this.btnDisariJson.Size = new System.Drawing.Size(60, 56);
            this.btnDisariJson.TabIndex = 9;
            this.btnDisariJson.Text = "Dışarı Aktar Json";
            this.btnDisariJson.UseVisualStyleBackColor = true;
            this.btnDisariJson.Click += new System.EventHandler(this.btnDisariJson_Click);
            // 
            // btnIceriJson
            // 
            this.btnIceriJson.Location = new System.Drawing.Point(335, 377);
            this.btnIceriJson.Name = "btnIceriJson";
            this.btnIceriJson.Size = new System.Drawing.Size(60, 56);
            this.btnIceriJson.TabIndex = 9;
            this.btnIceriJson.Text = "İçeri Aktar Json";
            this.btnIceriJson.UseVisualStyleBackColor = true;
            this.btnIceriJson.Click += new System.EventHandler(this.btnIceriJson_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 455);
            this.Controls.Add(this.btnIceriJson);
            this.Controls.Add(this.btnDisariJson);
            this.Controls.Add(this.btnXMLIceri);
            this.Controls.Add(this.btnXMLDisari);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lstKisiler);
            this.Controls.Add(this.pbFotograf);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFotograf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.PictureBox pbFotograf;
        private System.Windows.Forms.ListBox lstKisiler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnXMLDisari;
        private System.Windows.Forms.Button btnXMLIceri;
        private System.Windows.Forms.OpenFileDialog dosyaAc;
        private System.Windows.Forms.SaveFileDialog dosyaKaydet;
        private System.Windows.Forms.Button btnDisariJson;
        private System.Windows.Forms.Button btnIceriJson;
    }
}

