namespace OkulOtomasyonu
{
    partial class frmOgrenciKayit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtOgrenciSoyadi = new System.Windows.Forms.TextBox();
            this.txtOgrenciAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOgrenciKaydet = new System.Windows.Forms.Button();
            this.txtMemleketi = new System.Windows.Forms.TextBox();
            this.cmbVelisi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clbDersleri = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnYeniVeliEkle = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMemleketi);
            this.groupBox1.Controls.Add(this.dtpDogumTarihi);
            this.groupBox1.Controls.Add(this.txtOgrenciSoyadi);
            this.groupBox1.Controls.Add(this.txtOgrenciAdi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 362);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgileri";
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(98, 123);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(197, 20);
            this.dtpDogumTarihi.TabIndex = 6;
            // 
            // txtOgrenciSoyadi
            // 
            this.txtOgrenciSoyadi.Location = new System.Drawing.Point(98, 90);
            this.txtOgrenciSoyadi.Name = "txtOgrenciSoyadi";
            this.txtOgrenciSoyadi.Size = new System.Drawing.Size(197, 20);
            this.txtOgrenciSoyadi.TabIndex = 5;
            // 
            // txtOgrenciAdi
            // 
            this.txtOgrenciAdi.Location = new System.Drawing.Point(98, 60);
            this.txtOgrenciAdi.Name = "txtOgrenciAdi";
            this.txtOgrenciAdi.Size = new System.Drawing.Size(197, 20);
            this.txtOgrenciAdi.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Memleketi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doğum Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Öğrenci Soyadı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Adı :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnYeniVeliEkle);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.clbDersleri);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbVelisi);
            this.groupBox2.Location = new System.Drawing.Point(314, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 362);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diğer Bilgiler";
            // 
            // btnOgrenciKaydet
            // 
            this.btnOgrenciKaydet.Location = new System.Drawing.Point(638, 339);
            this.btnOgrenciKaydet.Name = "btnOgrenciKaydet";
            this.btnOgrenciKaydet.Size = new System.Drawing.Size(95, 44);
            this.btnOgrenciKaydet.TabIndex = 2;
            this.btnOgrenciKaydet.Text = "Kaydet";
            this.btnOgrenciKaydet.UseVisualStyleBackColor = true;
            this.btnOgrenciKaydet.Click += new System.EventHandler(this.btnOgrenciKaydet_Click);
            // 
            // txtMemleketi
            // 
            this.txtMemleketi.Location = new System.Drawing.Point(98, 158);
            this.txtMemleketi.Name = "txtMemleketi";
            this.txtMemleketi.Size = new System.Drawing.Size(197, 20);
            this.txtMemleketi.TabIndex = 7;
            // 
            // cmbVelisi
            // 
            this.cmbVelisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVelisi.FormattingEnabled = true;
            this.cmbVelisi.Location = new System.Drawing.Point(137, 55);
            this.cmbVelisi.Name = "cmbVelisi";
            this.cmbVelisi.Size = new System.Drawing.Size(138, 21);
            this.cmbVelisi.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Velisi :";
            // 
            // clbDersleri
            // 
            this.clbDersleri.CheckOnClick = true;
            this.clbDersleri.FormattingEnabled = true;
            this.clbDersleri.Location = new System.Drawing.Point(6, 247);
            this.clbDersleri.Name = "clbDersleri";
            this.clbDersleri.Size = new System.Drawing.Size(296, 109);
            this.clbDersleri.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Dersleri";
            // 
            // btnYeniVeliEkle
            // 
            this.btnYeniVeliEkle.Location = new System.Drawing.Point(137, 90);
            this.btnYeniVeliEkle.Name = "btnYeniVeliEkle";
            this.btnYeniVeliEkle.Size = new System.Drawing.Size(138, 23);
            this.btnYeniVeliEkle.TabIndex = 4;
            this.btnYeniVeliEkle.Text = "Yeni Veli Ekle";
            this.btnYeniVeliEkle.UseVisualStyleBackColor = true;
            this.btnYeniVeliEkle.Click += new System.EventHandler(this.btnYeniVeliEkle_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 389);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(490, 163);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Öğrenci Adı";
            this.columnHeader1.Width = 81;
            // 
            // columnHeader
            // 
            this.columnHeader.Text = "Öğrenci Soyadı";
            this.columnHeader.Width = 104;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Memleketi";
            this.columnHeader2.Width = 111;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Doğum Tarihi";
            this.columnHeader3.Width = 153;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Veli Adı Soyadı";
            this.columnHeader4.Width = 123;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Veli Telefon No";
            this.columnHeader5.Width = 105;
            // 
            // frmOgrenciKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 564);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnOgrenciKaydet);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOgrenciKayit";
            this.Text = "Ogrenci Kayit";
            this.Load += new System.EventHandler(this.frmOgrenciKayit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOgrenciKaydet;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.TextBox txtOgrenciSoyadi;
        private System.Windows.Forms.TextBox txtOgrenciAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMemleketi;
        private System.Windows.Forms.Button btnYeniVeliEkle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox clbDersleri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbVelisi;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}