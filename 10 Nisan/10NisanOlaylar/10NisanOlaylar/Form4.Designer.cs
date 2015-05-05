namespace _10NisanOlaylar
{
    partial class Form4
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstDoktorlar = new System.Windows.Forms.ListBox();
            this.cmbDoktorBrans = new System.Windows.Forms.ComboBox();
            this.txtDoktorSoyadi = new System.Windows.Forms.TextBox();
            this.txtDoktorAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDoktorKaydet = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnHastaKaydet = new System.Windows.Forms.Button();
            this.lstHastalar = new System.Windows.Forms.ListBox();
            this.lstDoktorSec = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbPoliklinik = new System.Windows.Forms.ComboBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtTelefonNo = new System.Windows.Forms.MaskedTextBox();
            this.txtHastaSoyadi = new System.Windows.Forms.TextBox();
            this.txtHastaAdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(838, 471);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.lstDoktorlar);
            this.tabPage2.Controls.Add(this.cmbDoktorBrans);
            this.tabPage2.Controls.Add(this.txtDoktorSoyadi);
            this.tabPage2.Controls.Add(this.txtDoktorAdi);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnDoktorKaydet);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(830, 445);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Doktor Kayıt";
            // 
            // lstDoktorlar
            // 
            this.lstDoktorlar.Dock = System.Windows.Forms.DockStyle.Right;
            this.lstDoktorlar.FormattingEnabled = true;
            this.lstDoktorlar.Location = new System.Drawing.Point(629, 3);
            this.lstDoktorlar.Name = "lstDoktorlar";
            this.lstDoktorlar.Size = new System.Drawing.Size(198, 439);
            this.lstDoktorlar.TabIndex = 7;
            this.lstDoktorlar.DoubleClick += new System.EventHandler(this.lstDoktorlar_DoubleClick);
            // 
            // cmbDoktorBrans
            // 
            this.cmbDoktorBrans.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDoktorBrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoktorBrans.FormattingEnabled = true;
            this.cmbDoktorBrans.Items.AddRange(new object[] {
            "Seçiniz...",
            "Kardiyoloji",
            "KBB",
            "Dermotoloji",
            "Onkoloji",
            "Ortopedi"});
            this.cmbDoktorBrans.Location = new System.Drawing.Point(140, 81);
            this.cmbDoktorBrans.Name = "cmbDoktorBrans";
            this.cmbDoktorBrans.Size = new System.Drawing.Size(178, 21);
            this.cmbDoktorBrans.TabIndex = 6;
            // 
            // txtDoktorSoyadi
            // 
            this.txtDoktorSoyadi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDoktorSoyadi.Location = new System.Drawing.Point(140, 53);
            this.txtDoktorSoyadi.Name = "txtDoktorSoyadi";
            this.txtDoktorSoyadi.Size = new System.Drawing.Size(178, 20);
            this.txtDoktorSoyadi.TabIndex = 5;
            // 
            // txtDoktorAdi
            // 
            this.txtDoktorAdi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDoktorAdi.Location = new System.Drawing.Point(140, 20);
            this.txtDoktorAdi.Name = "txtDoktorAdi";
            this.txtDoktorAdi.Size = new System.Drawing.Size(178, 20);
            this.txtDoktorAdi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(35, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Branşı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(35, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doktor Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(35, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doktor Adı";
            // 
            // btnDoktorKaydet
            // 
            this.btnDoktorKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDoktorKaydet.Location = new System.Drawing.Point(168, 119);
            this.btnDoktorKaydet.Name = "btnDoktorKaydet";
            this.btnDoktorKaydet.Size = new System.Drawing.Size(121, 36);
            this.btnDoktorKaydet.TabIndex = 0;
            this.btnDoktorKaydet.Text = "Kaydet";
            this.btnDoktorKaydet.UseVisualStyleBackColor = true;
            this.btnDoktorKaydet.Click += new System.EventHandler(this.btnDoktorKaydet_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.btnHastaKaydet);
            this.tabPage1.Controls.Add(this.lstHastalar);
            this.tabPage1.Controls.Add(this.lstDoktorSec);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.cmbPoliklinik);
            this.tabPage1.Controls.Add(this.dtpDogumTarihi);
            this.tabPage1.Controls.Add(this.txtTelefonNo);
            this.tabPage1.Controls.Add(this.txtHastaSoyadi);
            this.tabPage1.Controls.Add(this.txtHastaAdi);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(830, 445);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hasta Kayıt";
            // 
            // btnHastaKaydet
            // 
            this.btnHastaKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHastaKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastaKaydet.Image = global::_10NisanOlaylar.Properties.Resources.kaydet;
            this.btnHastaKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHastaKaydet.Location = new System.Drawing.Point(509, 301);
            this.btnHastaKaydet.Name = "btnHastaKaydet";
            this.btnHastaKaydet.Size = new System.Drawing.Size(106, 39);
            this.btnHastaKaydet.TabIndex = 13;
            this.btnHastaKaydet.Text = "Kaydet";
            this.btnHastaKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHastaKaydet.UseVisualStyleBackColor = true;
            // 
            // lstHastalar
            // 
            this.lstHastalar.FormattingEnabled = true;
            this.lstHastalar.Location = new System.Drawing.Point(444, 31);
            this.lstHastalar.Name = "lstHastalar";
            this.lstHastalar.Size = new System.Drawing.Size(233, 264);
            this.lstHastalar.TabIndex = 12;
            // 
            // lstDoktorSec
            // 
            this.lstDoktorSec.CheckOnClick = true;
            this.lstDoktorSec.FormattingEnabled = true;
            this.lstDoktorSec.Location = new System.Drawing.Point(175, 200);
            this.lstDoktorSec.Name = "lstDoktorSec";
            this.lstDoktorSec.Size = new System.Drawing.Size(194, 124);
            this.lstDoktorSec.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Doktorlar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Poliklinik";
            // 
            // cmbPoliklinik
            // 
            this.cmbPoliklinik.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPoliklinik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPoliklinik.FormattingEnabled = true;
            this.cmbPoliklinik.Items.AddRange(new object[] {
            "Seçiniz...",
            "Kardiyoloji",
            "KBB",
            "Dermotoloji",
            "Onkoloji",
            "Ortopedi"});
            this.cmbPoliklinik.Location = new System.Drawing.Point(175, 163);
            this.cmbPoliklinik.Name = "cmbPoliklinik";
            this.cmbPoliklinik.Size = new System.Drawing.Size(194, 21);
            this.cmbPoliklinik.TabIndex = 8;
            this.cmbPoliklinik.SelectedIndexChanged += new System.EventHandler(this.cmbPoliklinik_SelectedIndexChanged);
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(175, 127);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(194, 20);
            this.dtpDogumTarihi.TabIndex = 7;
            // 
            // txtTelefonNo
            // 
            this.txtTelefonNo.Location = new System.Drawing.Point(175, 92);
            this.txtTelefonNo.Mask = "(999) 000-0000";
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.Size = new System.Drawing.Size(194, 20);
            this.txtTelefonNo.TabIndex = 6;
            // 
            // txtHastaSoyadi
            // 
            this.txtHastaSoyadi.Location = new System.Drawing.Point(175, 60);
            this.txtHastaSoyadi.Name = "txtHastaSoyadi";
            this.txtHastaSoyadi.Size = new System.Drawing.Size(194, 20);
            this.txtHastaSoyadi.TabIndex = 5;
            // 
            // txtHastaAdi
            // 
            this.txtHastaAdi.Location = new System.Drawing.Point(175, 31);
            this.txtHastaAdi.Name = "txtHastaAdi";
            this.txtHastaAdi.Size = new System.Drawing.Size(194, 20);
            this.txtHastaAdi.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Doğum Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Telefon Numarası";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Hasta Soyadı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hasta Adı";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(830, 445);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Randevular";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 471);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form4";
            this.Text = "Ceset Hospital";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDoktorKaydet;
        private System.Windows.Forms.ComboBox cmbDoktorBrans;
        private System.Windows.Forms.TextBox txtDoktorSoyadi;
        private System.Windows.Forms.TextBox txtDoktorAdi;
        private System.Windows.Forms.ListBox lstDoktorlar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.MaskedTextBox txtTelefonNo;
        private System.Windows.Forms.TextBox txtHastaSoyadi;
        private System.Windows.Forms.TextBox txtHastaAdi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbPoliklinik;
        private System.Windows.Forms.Button btnHastaKaydet;
        private System.Windows.Forms.ListBox lstHastalar;
        private System.Windows.Forms.CheckedListBox lstDoktorSec;
        private System.Windows.Forms.Label label9;
    }
}