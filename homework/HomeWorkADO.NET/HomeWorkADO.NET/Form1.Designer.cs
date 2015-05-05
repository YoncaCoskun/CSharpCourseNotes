namespace HomeWorkADO.NET
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
            this.button2 = new System.Windows.Forms.Button();
            this.txtCalisanMemleketi = new System.Windows.Forms.TextBox();
            this.txtCalisanSoyadi = new System.Windows.Forms.TextBox();
            this.txtCalisanAdi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtCalisanID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(539, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 35);
            this.button2.TabIndex = 17;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtCalisanMemleketi
            // 
            this.txtCalisanMemleketi.Location = new System.Drawing.Point(527, 140);
            this.txtCalisanMemleketi.Name = "txtCalisanMemleketi";
            this.txtCalisanMemleketi.Size = new System.Drawing.Size(129, 20);
            this.txtCalisanMemleketi.TabIndex = 16;
            // 
            // txtCalisanSoyadi
            // 
            this.txtCalisanSoyadi.Location = new System.Drawing.Point(527, 104);
            this.txtCalisanSoyadi.Name = "txtCalisanSoyadi";
            this.txtCalisanSoyadi.Size = new System.Drawing.Size(129, 20);
            this.txtCalisanSoyadi.TabIndex = 15;
            // 
            // txtCalisanAdi
            // 
            this.txtCalisanAdi.Location = new System.Drawing.Point(527, 67);
            this.txtCalisanAdi.Name = "txtCalisanAdi";
            this.txtCalisanAdi.Size = new System.Drawing.Size(129, 20);
            this.txtCalisanAdi.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Memleketi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Calışan Soyadı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Calışan Adı :";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(31, 49);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(347, 286);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Çalışan ID";
            this.columnHeader1.Width = 66;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Çalışan Adı";
            this.columnHeader2.Width = 86;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Çalışan Soyadı";
            this.columnHeader3.Width = 96;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Memleketi";
            this.columnHeader4.Width = 92;
            // 
            // txtCalisanID
            // 
            this.txtCalisanID.Location = new System.Drawing.Point(527, 41);
            this.txtCalisanID.Name = "txtCalisanID";
            this.txtCalisanID.Size = new System.Drawing.Size(129, 20);
            this.txtCalisanID.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Calışan ID :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 439);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCalisanID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtCalisanMemleketi);
            this.Controls.Add(this.txtCalisanSoyadi);
            this.Controls.Add(this.txtCalisanAdi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtCalisanMemleketi;
        private System.Windows.Forms.TextBox txtCalisanSoyadi;
        private System.Windows.Forms.TextBox txtCalisanAdi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtCalisanID;
        private System.Windows.Forms.Label label4;
    }
}

