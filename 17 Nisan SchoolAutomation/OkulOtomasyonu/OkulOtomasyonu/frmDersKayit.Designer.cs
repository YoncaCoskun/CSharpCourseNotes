namespace OkulOtomasyonu
{
    partial class frmDersKayit
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
            this.components = new System.ComponentModel.Container();
            this.lstDersler = new System.Windows.Forms.ListBox();
            this.txtDersAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numKredisi = new System.Windows.Forms.NumericUpDown();
            this.numSaat = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnDersKayit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numKredisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSaat)).BeginInit();
            this.SuspendLayout();
            // 
            // lstDersler
            // 
            this.lstDersler.FormattingEnabled = true;
            this.lstDersler.Location = new System.Drawing.Point(231, 26);
            this.lstDersler.Name = "lstDersler";
            this.lstDersler.Size = new System.Drawing.Size(169, 316);
            this.lstDersler.TabIndex = 0;
            this.lstDersler.DoubleClick += new System.EventHandler(this.lstDersler_DoubleClick);
            // 
            // txtDersAdi
            // 
            this.txtDersAdi.Location = new System.Drawing.Point(80, 23);
            this.txtDersAdi.Name = "txtDersAdi";
            this.txtDersAdi.Size = new System.Drawing.Size(120, 20);
            this.txtDersAdi.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtDersAdi, "Litaraturde gecen ders adi");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ders Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kredisi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Saat :";
            // 
            // numKredisi
            // 
            this.numKredisi.Location = new System.Drawing.Point(80, 60);
            this.numKredisi.Name = "numKredisi";
            this.numKredisi.Size = new System.Drawing.Size(120, 20);
            this.numKredisi.TabIndex = 5;
            this.toolTip1.SetToolTip(this.numKredisi, "Dersten gecildiginde kazanilacak kredi");
            // 
            // numSaat
            // 
            this.numSaat.Location = new System.Drawing.Point(80, 100);
            this.numSaat.Name = "numSaat";
            this.numSaat.Size = new System.Drawing.Size(120, 20);
            this.numSaat.TabIndex = 6;
            this.toolTip1.SetToolTip(this.numSaat, "Bir haftada ogrencinin katilmasi gereken saat");
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ShowAlways = true;
            // 
            // btnDersKayit
            // 
            this.btnDersKayit.Location = new System.Drawing.Point(96, 146);
            this.btnDersKayit.Name = "btnDersKayit";
            this.btnDersKayit.Size = new System.Drawing.Size(89, 31);
            this.btnDersKayit.TabIndex = 7;
            this.btnDersKayit.Text = "Kaydet";
            this.btnDersKayit.UseVisualStyleBackColor = true;
            this.btnDersKayit.Click += new System.EventHandler(this.btnDersKayit_Click);
            // 
            // frmDersKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 354);
            this.Controls.Add(this.btnDersKayit);
            this.Controls.Add(this.numSaat);
            this.Controls.Add(this.numKredisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDersAdi);
            this.Controls.Add(this.lstDersler);
            this.Name = "frmDersKayit";
            this.Text = "Ders Kayıt";
            this.Load += new System.EventHandler(this.frmDersKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numKredisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSaat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDersler;
        private System.Windows.Forms.TextBox txtDersAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numKredisi;
        private System.Windows.Forms.NumericUpDown numSaat;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnDersKayit;
    }
}