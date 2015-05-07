namespace CesetHospital
{
    partial class EmergencyHospital
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(676, 323);
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
            this.tabPage1.Size = new System.Drawing.Size(668, 297);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Doktorlar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstDoktorlar
            // 
            this.lstDoktorlar.FormattingEnabled = true;
            this.lstDoktorlar.Location = new System.Drawing.Point(368, 17);
            this.lstDoktorlar.Name = "lstDoktorlar";
            this.lstDoktorlar.Size = new System.Drawing.Size(143, 238);
            this.lstDoktorlar.TabIndex = 15;
            // 
            // lblBrans
            // 
            this.lblBrans.AutoSize = true;
            this.lblBrans.Location = new System.Drawing.Point(123, 94);
            this.lblBrans.Name = "lblBrans";
            this.lblBrans.Size = new System.Drawing.Size(40, 13);
            this.lblBrans.TabIndex = 14;
            this.lblBrans.Text = "Branş :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(197, 141);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 25);
            this.btnKaydet.TabIndex = 13;
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
            this.cmbBrans.Location = new System.Drawing.Point(172, 91);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(121, 21);
            this.cmbBrans.TabIndex = 12;
            // 
            // lblDoktorSoyadi
            // 
            this.lblDoktorSoyadi.AutoSize = true;
            this.lblDoktorSoyadi.Location = new System.Drawing.Point(83, 57);
            this.lblDoktorSoyadi.Name = "lblDoktorSoyadi";
            this.lblDoktorSoyadi.Size = new System.Drawing.Size(80, 13);
            this.lblDoktorSoyadi.TabIndex = 11;
            this.lblDoktorSoyadi.Text = "Doktor Soyadı :";
            // 
            // txtDoktorSoyadi
            // 
            this.txtDoktorSoyadi.Location = new System.Drawing.Point(172, 54);
            this.txtDoktorSoyadi.Name = "txtDoktorSoyadi";
            this.txtDoktorSoyadi.Size = new System.Drawing.Size(121, 20);
            this.txtDoktorSoyadi.TabIndex = 10;
            // 
            // txtDoktorAdi
            // 
            this.txtDoktorAdi.Location = new System.Drawing.Point(172, 17);
            this.txtDoktorAdi.Name = "txtDoktorAdi";
            this.txtDoktorAdi.Size = new System.Drawing.Size(121, 20);
            this.txtDoktorAdi.TabIndex = 9;
            // 
            // lblDoktorAdi
            // 
            this.lblDoktorAdi.AutoSize = true;
            this.lblDoktorAdi.Location = new System.Drawing.Point(100, 17);
            this.lblDoktorAdi.Name = "lblDoktorAdi";
            this.lblDoktorAdi.Size = new System.Drawing.Size(63, 13);
            this.lblDoktorAdi.TabIndex = 8;
            this.lblDoktorAdi.Text = "Doktor Adı :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
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
            this.tabPage2.Size = new System.Drawing.Size(668, 297);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hastalar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstHastalar
            // 
            this.lstHastalar.FormattingEnabled = true;
            this.lstHastalar.Location = new System.Drawing.Point(410, 35);
            this.lstHastalar.Name = "lstHastalar";
            this.lstHastalar.Size = new System.Drawing.Size(164, 264);
            this.lstHastalar.TabIndex = 25;
            // 
            // clbDoktorlar
            // 
            this.clbDoktorlar.CheckOnClick = true;
            this.clbDoktorlar.FormattingEnabled = true;
            this.clbDoktorlar.Location = new System.Drawing.Point(141, 192);
            this.clbDoktorlar.Name = "clbDoktorlar";
            this.clbDoktorlar.Size = new System.Drawing.Size(190, 94);
            this.clbDoktorlar.TabIndex = 24;
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
            this.cmbPoliklinik.Location = new System.Drawing.Point(141, 129);
            this.cmbPoliklinik.Name = "cmbPoliklinik";
            this.cmbPoliklinik.Size = new System.Drawing.Size(159, 21);
            this.cmbPoliklinik.TabIndex = 23;
            // 
            // txtTelefonNo
            // 
            this.txtTelefonNo.Location = new System.Drawing.Point(141, 99);
            this.txtTelefonNo.Mask = "(999) 000-0000";
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.Size = new System.Drawing.Size(159, 20);
            this.txtTelefonNo.TabIndex = 22;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(141, 73);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(159, 20);
            this.dtpDogumTarihi.TabIndex = 21;
            // 
            // txtHastaSoyadi
            // 
            this.txtHastaSoyadi.Location = new System.Drawing.Point(141, 47);
            this.txtHastaSoyadi.Name = "txtHastaSoyadi";
            this.txtHastaSoyadi.Size = new System.Drawing.Size(159, 20);
            this.txtHastaSoyadi.TabIndex = 20;
            // 
            // txtHastaAdi
            // 
            this.txtHastaAdi.Location = new System.Drawing.Point(141, 23);
            this.txtHastaAdi.Name = "txtHastaAdi";
            this.txtHastaAdi.Size = new System.Drawing.Size(159, 20);
            this.txtHastaAdi.TabIndex = 19;
            // 
            // lblPoliklinik
            // 
            this.lblPoliklinik.AutoSize = true;
            this.lblPoliklinik.Location = new System.Drawing.Point(44, 129);
            this.lblPoliklinik.Name = "lblPoliklinik";
            this.lblPoliklinik.Size = new System.Drawing.Size(54, 13);
            this.lblPoliklinik.TabIndex = 18;
            this.lblPoliklinik.Text = "Poliklinik :";
            // 
            // lblTelefonNo
            // 
            this.lblTelefonNo.AutoSize = true;
            this.lblTelefonNo.Location = new System.Drawing.Point(44, 102);
            this.lblTelefonNo.Name = "lblTelefonNo";
            this.lblTelefonNo.Size = new System.Drawing.Size(66, 13);
            this.lblTelefonNo.TabIndex = 17;
            this.lblTelefonNo.Text = "Telefon No :";
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Location = new System.Drawing.Point(39, 74);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(76, 13);
            this.lblDogumTarihi.TabIndex = 16;
            this.lblDogumTarihi.Text = "Doğum Tarihi :";
            // 
            // lblHastaSoyadi
            // 
            this.lblHastaSoyadi.AutoSize = true;
            this.lblHastaSoyadi.Location = new System.Drawing.Point(39, 50);
            this.lblHastaSoyadi.Name = "lblHastaSoyadi";
            this.lblHastaSoyadi.Size = new System.Drawing.Size(76, 13);
            this.lblHastaSoyadi.TabIndex = 15;
            this.lblHastaSoyadi.Text = "Hasta Soyadı :";
            // 
            // lblHastaAdi
            // 
            this.lblHastaAdi.AutoSize = true;
            this.lblHastaAdi.Location = new System.Drawing.Point(54, -10);
            this.lblHastaAdi.Name = "lblHastaAdi";
            this.lblHastaAdi.Size = new System.Drawing.Size(59, 13);
            this.lblHastaAdi.TabIndex = 14;
            this.lblHastaAdi.Text = "Hasta Adı :";
            // 
            // btnHastaKaydet
            // 
            this.btnHastaKaydet.Location = new System.Drawing.Point(181, 156);
            this.btnHastaKaydet.Name = "btnHastaKaydet";
            this.btnHastaKaydet.Size = new System.Drawing.Size(86, 30);
            this.btnHastaKaydet.TabIndex = 13;
            this.btnHastaKaydet.Text = "Kaydet";
            this.btnHastaKaydet.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Hasta Adı :";
            // 
            // EmergencyHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 318);
            this.Controls.Add(this.tabControl1);
            this.Name = "EmergencyHospital";
            this.Text = "EmergencyHospital";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lstDoktorlar;
        private System.Windows.Forms.Label lblBrans;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Label lblDoktorSoyadi;
        private System.Windows.Forms.TextBox txtDoktorSoyadi;
        private System.Windows.Forms.TextBox txtDoktorAdi;
        private System.Windows.Forms.Label lblDoktorAdi;
        private System.Windows.Forms.ListBox lstHastalar;
        private System.Windows.Forms.CheckedListBox clbDoktorlar;
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
        private System.Windows.Forms.Label label1;

    }
}