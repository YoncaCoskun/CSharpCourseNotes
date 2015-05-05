namespace ADOdisconnected
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCalisanAdi = new System.Windows.Forms.TextBox();
            this.txtCalisanSoyadi = new System.Windows.Forms.TextBox();
            this.txtCalisanMemleketi = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(28, 44);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(301, 377);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calışan Adı :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Calışan Soyadı :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Memleketi :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCalisanAdi
            // 
            this.txtCalisanAdi.Location = new System.Drawing.Point(445, 83);
            this.txtCalisanAdi.Name = "txtCalisanAdi";
            this.txtCalisanAdi.Size = new System.Drawing.Size(129, 20);
            this.txtCalisanAdi.TabIndex = 5;
            this.txtCalisanAdi.TextChanged += new System.EventHandler(this.txtCalisanAdi_TextChanged);
            // 
            // txtCalisanSoyadi
            // 
            this.txtCalisanSoyadi.Location = new System.Drawing.Point(445, 120);
            this.txtCalisanSoyadi.Name = "txtCalisanSoyadi";
            this.txtCalisanSoyadi.Size = new System.Drawing.Size(129, 20);
            this.txtCalisanSoyadi.TabIndex = 6;
            this.txtCalisanSoyadi.TextChanged += new System.EventHandler(this.txtCalisanSoyadi_TextChanged);
            // 
            // txtCalisanMemleketi
            // 
            this.txtCalisanMemleketi.Location = new System.Drawing.Point(445, 156);
            this.txtCalisanMemleketi.Name = "txtCalisanMemleketi";
            this.txtCalisanMemleketi.Size = new System.Drawing.Size(129, 20);
            this.txtCalisanMemleketi.TabIndex = 7;
            this.txtCalisanMemleketi.TextChanged += new System.EventHandler(this.txtCalisanMemleketi_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(445, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 445);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtCalisanMemleketi);
            this.Controls.Add(this.txtCalisanSoyadi);
            this.Controls.Add(this.txtCalisanAdi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCalisanAdi;
        private System.Windows.Forms.TextBox txtCalisanSoyadi;
        private System.Windows.Forms.TextBox txtCalisanMemleketi;
        private System.Windows.Forms.Button button2;
    }
}