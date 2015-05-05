namespace FormUygulaması1
{
    partial class Form3
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
            this.btnAskerEkle = new System.Windows.Forms.Button();
            this.btnSehirEkle = new System.Windows.Forms.Button();
            this.btnDagit = new System.Windows.Forms.Button();
            this.lstAskerler = new System.Windows.Forms.ListBox();
            this.lstSehirler = new System.Windows.Forms.ListBox();
            this.lstDagitim = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAskerEkle
            // 
            this.btnAskerEkle.Location = new System.Drawing.Point(46, 336);
            this.btnAskerEkle.Name = "btnAskerEkle";
            this.btnAskerEkle.Size = new System.Drawing.Size(75, 23);
            this.btnAskerEkle.TabIndex = 0;
            this.btnAskerEkle.Text = "Asker Ekle";
            this.btnAskerEkle.UseVisualStyleBackColor = true;
            this.btnAskerEkle.Click += new System.EventHandler(this.btnAskerEkle_Click);
            // 
            // btnSehirEkle
            // 
            this.btnSehirEkle.Location = new System.Drawing.Point(306, 336);
            this.btnSehirEkle.Name = "btnSehirEkle";
            this.btnSehirEkle.Size = new System.Drawing.Size(75, 23);
            this.btnSehirEkle.TabIndex = 1;
            this.btnSehirEkle.Text = "Sehir Ekle";
            this.btnSehirEkle.UseVisualStyleBackColor = true;
            this.btnSehirEkle.Click += new System.EventHandler(this.btnSehirEkle_Click);
            // 
            // btnDagit
            // 
            this.btnDagit.Location = new System.Drawing.Point(538, 303);
            this.btnDagit.Name = "btnDagit";
            this.btnDagit.Size = new System.Drawing.Size(88, 56);
            this.btnDagit.TabIndex = 2;
            this.btnDagit.Text = "Dağıt";
            this.btnDagit.UseVisualStyleBackColor = true;
            this.btnDagit.Click += new System.EventHandler(this.btnDagit_Click);
            // 
            // lstAskerler
            // 
            this.lstAskerler.FormattingEnabled = true;
            this.lstAskerler.Location = new System.Drawing.Point(27, 43);
            this.lstAskerler.Name = "lstAskerler";
            this.lstAskerler.Size = new System.Drawing.Size(143, 238);
            this.lstAskerler.TabIndex = 3;
            // 
            // lstSehirler
            // 
            this.lstSehirler.FormattingEnabled = true;
            this.lstSehirler.Location = new System.Drawing.Point(267, 43);
            this.lstSehirler.Name = "lstSehirler";
            this.lstSehirler.Size = new System.Drawing.Size(163, 238);
            this.lstSehirler.TabIndex = 4;
            // 
            // lstDagitim
            // 
            this.lstDagitim.FormattingEnabled = true;
            this.lstDagitim.Location = new System.Drawing.Point(507, 43);
            this.lstDagitim.Name = "lstDagitim";
            this.lstDagitim.Size = new System.Drawing.Size(154, 238);
            this.lstDagitim.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "İsimler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(293, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şehirler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dağıtım";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 303);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(267, 303);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 20);
            this.textBox2.TabIndex = 10;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 415);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstDagitim);
            this.Controls.Add(this.lstSehirler);
            this.Controls.Add(this.lstAskerler);
            this.Controls.Add(this.btnDagit);
            this.Controls.Add(this.btnSehirEkle);
            this.Controls.Add(this.btnAskerEkle);
            this.Name = "Form3";
            this.Text = "Şehirler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAskerEkle;
        private System.Windows.Forms.Button btnSehirEkle;
        private System.Windows.Forms.Button btnDagit;
        private System.Windows.Forms.ListBox lstAskerler;
        private System.Windows.Forms.ListBox lstSehirler;
        private System.Windows.Forms.ListBox lstDagitim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}