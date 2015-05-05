namespace CesetHospital
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstDoktorlar = new System.Windows.Forms.ListBox();
            this.lblBrans = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.lblDoktorSoyadi = new System.Windows.Forms.Label();
            this.txtDoktorSoyadi = new System.Windows.Forms.TextBox();
            this.txtDoktorAdi = new System.Windows.Forms.TextBox();
            this.lblDoktorAdi = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstHastalar = new System.Windows.Forms.ListBox();
            this.clbDoktorlar = new System.Windows.Forms.CheckedListBox();
            this.cmbPoliklinik = new System.Windows.Forms.ComboBox();
            this.txtTelefonNo = new System.Windows.Forms.MaskedTextBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtHastaSoyadi = new System.Windows.Forms.TextBox();
            this.txtHastaAdi = new System.Windows.Forms.TextBox();
            this.lblPoliklinik = new System.Windows.Forms.Label();
            this.lblTelefonNo = new System.Windows.Forms.Label();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.lblHastaSoyadi = new System.Windows.Forms.Label();
            this.lblHastaAdi = new System.Windows.Forms.Label();
            this.btnHastaKaydet = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnIlacKaydet = new System.Windows.Forms.Button();
            this.clbIlaclar = new System.Windows.Forms.CheckedListBox();
            this.lblIlaclar = new System.Windows.Forms.Label();
            this.lstDoktorHastalari = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDoktorlar = new System.Windows.Forms.ComboBox();
            this.btnDenemeler = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(639, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstDoktorlar);
            this.tabPage1.Controls.Add(this.lblBrans);
            this.tabPage1.Controls.Add(this.btnKaydet);
            this.tabPage1.Controls.Add(this.cmbBrans);
            this.tabPage1.Controls.Add(this.lblDoktorSoyadi);
            this.tabPage1.Controls.Add(this.txtDoktorSoyadi);
            this.tabPage1.Controls.Add(this.txtDoktorAdi);
            this.tabPage1.Controls.Add(this.lblDoktorAdi);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(631, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Doktor Kayıt";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstDoktorlar
            // 
            this.lstDoktorlar.FormattingEnabled = true;
            this.lstDoktorlar.Location = new System.Drawing.Point(299, 44);
            this.lstDoktorlar.Name = "lstDoktorlar";
            this.lstDoktorlar.Size = new System.Drawing.Size(181, 316);
            this.lstDoktorlar.TabIndex = 7;
            this.lstDoktorlar.DoubleClick += new System.EventHandler(this.lstDoktorlar_DoubleClick);
            // 
            // lblBrans
            // 
            this.lblBrans.AutoSize = true;
            this.lblBrans.Location = new System.Drawing.Point(79, 121);
            this.lblBrans.Name = "lblBrans";
            this.lblBrans.Size = new System.Drawing.Size(40, 13);
            this.lblBrans.TabIndex = 6;
            this.lblBrans.Text = "Branş :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(153, 155);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cmbBrans
            // 
            this.cmbBrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Items.AddRange(new object[] {
            "Seçiniz...",
            "Onkoloji",
            "Kardiyoloji",
            "Dermotoloji",
            "Ortopedi",
            "KBB"});
            this.cmbBrans.Location = new System.Drawing.Point(128, 118);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(121, 21);
            this.cmbBrans.TabIndex = 4;
            // 
            // lblDoktorSoyadi
            // 
            this.lblDoktorSoyadi.AutoSize = true;
            this.lblDoktorSoyadi.Location = new System.Drawing.Point(39, 84);
            this.lblDoktorSoyadi.Name = "lblDoktorSoyadi";
            this.lblDoktorSoyadi.Size = new System.Drawing.Size(80, 13);
            this.lblDoktorSoyadi.TabIndex = 3;
            this.lblDoktorSoyadi.Text = "Doktor Soyadı :";
            // 
            // txtDoktorSoyadi
            // 
            this.txtDoktorSoyadi.Location = new System.Drawing.Point(128, 81);
            this.txtDoktorSoyadi.Name = "txtDoktorSoyadi";
            this.txtDoktorSoyadi.Size = new System.Drawing.Size(121, 20);
            this.txtDoktorSoyadi.TabIndex = 2;
            // 
            // txtDoktorAdi
            // 
            this.txtDoktorAdi.Location = new System.Drawing.Point(128, 44);
            this.txtDoktorAdi.Name = "txtDoktorAdi";
            this.txtDoktorAdi.Size = new System.Drawing.Size(121, 20);
            this.txtDoktorAdi.TabIndex = 1;
            // 
            // lblDoktorAdi
            // 
            this.lblDoktorAdi.AutoSize = true;
            this.lblDoktorAdi.Location = new System.Drawing.Point(56, 44);
            this.lblDoktorAdi.Name = "lblDoktorAdi";
            this.lblDoktorAdi.Size = new System.Drawing.Size(63, 13);
            this.lblDoktorAdi.TabIndex = 0;
            this.lblDoktorAdi.Text = "Doktor Adı :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lstHastalar);
            this.tabPage2.Controls.Add(this.clbDoktorlar);
            this.tabPage2.Controls.Add(this.cmbPoliklinik);
            this.tabPage2.Controls.Add(this.txtTelefonNo);
            this.tabPage2.Controls.Add(this.dtpDogumTarihi);
            this.tabPage2.Controls.Add(this.txtHastaSoyadi);
            this.tabPage2.Controls.Add(this.txtHastaAdi);
            this.tabPage2.Controls.Add(this.lblPoliklinik);
            this.tabPage2.Controls.Add(this.lblTelefonNo);
            this.tabPage2.Controls.Add(this.lblDogumTarihi);
            this.tabPage2.Controls.Add(this.lblHastaSoyadi);
            this.tabPage2.Controls.Add(this.lblHastaAdi);
            this.tabPage2.Controls.Add(this.btnHastaKaydet);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(631, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hasta Kayıt";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstHastalar
            // 
            this.lstHastalar.FormattingEnabled = true;
            this.lstHastalar.Location = new System.Drawing.Point(396, 42);
            this.lstHastalar.Name = "lstHastalar";
            this.lstHastalar.Size = new System.Drawing.Size(205, 329);
            this.lstHastalar.TabIndex = 12;
            this.lstHastalar.DoubleClick += new System.EventHandler(this.lstHastalar_DoubleClick);
            // 
            // clbDoktorlar
            // 
            this.clbDoktorlar.CheckOnClick = true;
            this.clbDoktorlar.FormattingEnabled = true;
            this.clbDoktorlar.Location = new System.Drawing.Point(127, 245);
            this.clbDoktorlar.Name = "clbDoktorlar";
            this.clbDoktorlar.Size = new System.Drawing.Size(231, 154);
            this.clbDoktorlar.TabIndex = 11;
            this.clbDoktorlar.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbDoktorlar_ItemCheck);
            // 
            // cmbPoliklinik
            // 
            this.cmbPoliklinik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPoliklinik.FormattingEnabled = true;
            this.cmbPoliklinik.Items.AddRange(new object[] {
            "Seçiniz...",
            "Onkoloji",
            "Kardiyoloji",
            "Dermotoloji",
            "Ortopedi",
            "KBB"});
            this.cmbPoliklinik.Location = new System.Drawing.Point(142, 168);
            this.cmbPoliklinik.Name = "cmbPoliklinik";
            this.cmbPoliklinik.Size = new System.Drawing.Size(200, 21);
            this.cmbPoliklinik.TabIndex = 10;
            this.cmbPoliklinik.SelectedIndexChanged += new System.EventHandler(this.cmbPoliklinik_SelectedIndexChanged);
            // 
            // txtTelefonNo
            // 
            this.txtTelefonNo.Location = new System.Drawing.Point(142, 138);
            this.txtTelefonNo.Mask = "(999) 000-0000";
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.Size = new System.Drawing.Size(200, 20);
            this.txtTelefonNo.TabIndex = 9;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(142, 112);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpDogumTarihi.TabIndex = 8;
            // 
            // txtHastaSoyadi
            // 
            this.txtHastaSoyadi.Location = new System.Drawing.Point(142, 86);
            this.txtHastaSoyadi.Name = "txtHastaSoyadi";
            this.txtHastaSoyadi.Size = new System.Drawing.Size(200, 20);
            this.txtHastaSoyadi.TabIndex = 7;
            // 
            // txtHastaAdi
            // 
            this.txtHastaAdi.Location = new System.Drawing.Point(142, 62);
            this.txtHastaAdi.Name = "txtHastaAdi";
            this.txtHastaAdi.Size = new System.Drawing.Size(200, 20);
            this.txtHastaAdi.TabIndex = 6;
            // 
            // lblPoliklinik
            // 
            this.lblPoliklinik.AutoSize = true;
            this.lblPoliklinik.Location = new System.Drawing.Point(45, 168);
            this.lblPoliklinik.Name = "lblPoliklinik";
            this.lblPoliklinik.Size = new System.Drawing.Size(54, 13);
            this.lblPoliklinik.TabIndex = 5;
            this.lblPoliklinik.Text = "Poliklinik :";
            // 
            // lblTelefonNo
            // 
            this.lblTelefonNo.AutoSize = true;
            this.lblTelefonNo.Location = new System.Drawing.Point(45, 141);
            this.lblTelefonNo.Name = "lblTelefonNo";
            this.lblTelefonNo.Size = new System.Drawing.Size(66, 13);
            this.lblTelefonNo.TabIndex = 4;
            this.lblTelefonNo.Text = "Telefon No :";
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Location = new System.Drawing.Point(40, 113);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(76, 13);
            this.lblDogumTarihi.TabIndex = 3;
            this.lblDogumTarihi.Text = "Doğum Tarihi :";
            // 
            // lblHastaSoyadi
            // 
            this.lblHastaSoyadi.AutoSize = true;
            this.lblHastaSoyadi.Location = new System.Drawing.Point(40, 89);
            this.lblHastaSoyadi.Name = "lblHastaSoyadi";
            this.lblHastaSoyadi.Size = new System.Drawing.Size(76, 13);
            this.lblHastaSoyadi.TabIndex = 2;
            this.lblHastaSoyadi.Text = "Hasta Soyadı :";
            // 
            // lblHastaAdi
            // 
            this.lblHastaAdi.AutoSize = true;
            this.lblHastaAdi.Location = new System.Drawing.Point(40, 62);
            this.lblHastaAdi.Name = "lblHastaAdi";
            this.lblHastaAdi.Size = new System.Drawing.Size(59, 13);
            this.lblHastaAdi.TabIndex = 1;
            this.lblHastaAdi.Text = "Hasta Adı :";
            // 
            // btnHastaKaydet
            // 
            this.btnHastaKaydet.Location = new System.Drawing.Point(199, 195);
            this.btnHastaKaydet.Name = "btnHastaKaydet";
            this.btnHastaKaydet.Size = new System.Drawing.Size(77, 44);
            this.btnHastaKaydet.TabIndex = 0;
            this.btnHastaKaydet.Text = "Kaydet";
            this.btnHastaKaydet.UseVisualStyleBackColor = true;
            this.btnHastaKaydet.Click += new System.EventHandler(this.btnHastaKaydet_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.btnDenemeler);
            this.tabPage3.Controls.Add(this.cmbDoktorlar);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.lstDoktorHastalari);
            this.tabPage3.Controls.Add(this.lblIlaclar);
            this.tabPage3.Controls.Add(this.clbIlaclar);
            this.tabPage3.Controls.Add(this.btnIlacKaydet);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(631, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Randevu";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnIlacKaydet
            // 
            this.btnIlacKaydet.Location = new System.Drawing.Point(431, 338);
            this.btnIlacKaydet.Name = "btnIlacKaydet";
            this.btnIlacKaydet.Size = new System.Drawing.Size(137, 43);
            this.btnIlacKaydet.TabIndex = 0;
            this.btnIlacKaydet.Text = "Kaydet";
            this.btnIlacKaydet.UseVisualStyleBackColor = true;
            this.btnIlacKaydet.Click += new System.EventHandler(this.btnIlacKaydet_Click);
            // 
            // clbIlaclar
            // 
            this.clbIlaclar.CheckOnClick = true;
            this.clbIlaclar.FormattingEnabled = true;
            this.clbIlaclar.Items.AddRange(new object[] {
            "Apranax",
            "Parol",
            "Vermidon",
            "Nurofen",
            "Bengay"});
            this.clbIlaclar.Location = new System.Drawing.Point(387, 58);
            this.clbIlaclar.Name = "clbIlaclar";
            this.clbIlaclar.Size = new System.Drawing.Size(223, 274);
            this.clbIlaclar.TabIndex = 1;
            // 
            // lblIlaclar
            // 
            this.lblIlaclar.AutoSize = true;
            this.lblIlaclar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIlaclar.Location = new System.Drawing.Point(384, 32);
            this.lblIlaclar.Name = "lblIlaclar";
            this.lblIlaclar.Size = new System.Drawing.Size(51, 20);
            this.lblIlaclar.TabIndex = 2;
            this.lblIlaclar.Text = "İlaçlar";
            // 
            // lstDoktorHastalari
            // 
            this.lstDoktorHastalari.FormattingEnabled = true;
            this.lstDoktorHastalari.Location = new System.Drawing.Point(83, 68);
            this.lstDoktorHastalari.Name = "lstDoktorHastalari";
            this.lstDoktorHastalari.Size = new System.Drawing.Size(193, 264);
            this.lstDoktorHastalari.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Doktorlar :";
            // 
            // cmbDoktorlar
            // 
            this.cmbDoktorlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoktorlar.FormattingEnabled = true;
            this.cmbDoktorlar.Location = new System.Drawing.Point(83, 29);
            this.cmbDoktorlar.Name = "cmbDoktorlar";
            this.cmbDoktorlar.Size = new System.Drawing.Size(193, 21);
            this.cmbDoktorlar.TabIndex = 5;
            this.cmbDoktorlar.SelectedIndexChanged += new System.EventHandler(this.cmbDoktorlar_SelectedIndexChanged);
            // 
            // btnDenemeler
            // 
            this.btnDenemeler.Location = new System.Drawing.Point(305, 340);
            this.btnDenemeler.Name = "btnDenemeler";
            this.btnDenemeler.Size = new System.Drawing.Size(94, 39);
            this.btnDenemeler.TabIndex = 6;
            this.btnDenemeler.Text = "Denemeler";
            this.btnDenemeler.UseVisualStyleBackColor = true;
            this.btnDenemeler.Click += new System.EventHandler(this.btnDenemeler_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Denemeler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 458);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblBrans;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Label lblDoktorSoyadi;
        private System.Windows.Forms.TextBox txtDoktorSoyadi;
        private System.Windows.Forms.TextBox txtDoktorAdi;
        private System.Windows.Forms.Label lblDoktorAdi;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lstDoktorlar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cmbPoliklinik;
        private System.Windows.Forms.MaskedTextBox txtTelefonNo;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.TextBox txtHastaSoyadi;
        private System.Windows.Forms.TextBox txtHastaAdi;
        private System.Windows.Forms.Label lblPoliklinik;
        private System.Windows.Forms.Label lblTelefonNo;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.Label lblHastaSoyadi;
        private System.Windows.Forms.Label lblHastaAdi;
        private System.Windows.Forms.Button btnHastaKaydet;
        private System.Windows.Forms.ListBox lstHastalar;
        private System.Windows.Forms.CheckedListBox clbDoktorlar;
        private System.Windows.Forms.ComboBox cmbDoktorlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstDoktorHastalari;
        private System.Windows.Forms.Label lblIlaclar;
        private System.Windows.Forms.CheckedListBox clbIlaclar;
        private System.Windows.Forms.Button btnIlacKaydet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDenemeler;
    }
}

