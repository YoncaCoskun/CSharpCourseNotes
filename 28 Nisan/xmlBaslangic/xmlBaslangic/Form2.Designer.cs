namespace xmlBaslangic
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAlisFiyati = new System.Windows.Forms.Label();
            this.lblSatisFiyati = new System.Windows.Forms.Label();
            this.lblBirim = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 103);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(234, 342);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(270, 272);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(313, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Dönüştür";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Alış Fıyatı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Satış Fıyatı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Birim :";
            // 
            // lblAlisFiyati
            // 
            this.lblAlisFiyati.AutoSize = true;
            this.lblAlisFiyati.Location = new System.Drawing.Point(401, 132);
            this.lblAlisFiyati.Name = "lblAlisFiyati";
            this.lblAlisFiyati.Size = new System.Drawing.Size(13, 13);
            this.lblAlisFiyati.TabIndex = 9;
            this.lblAlisFiyati.Text = "0";
            // 
            // lblSatisFiyati
            // 
            this.lblSatisFiyati.AutoSize = true;
            this.lblSatisFiyati.Location = new System.Drawing.Point(401, 158);
            this.lblSatisFiyati.Name = "lblSatisFiyati";
            this.lblSatisFiyati.Size = new System.Drawing.Size(13, 13);
            this.lblSatisFiyati.TabIndex = 10;
            this.lblSatisFiyati.Text = "0";
            // 
            // lblBirim
            // 
            this.lblBirim.AutoSize = true;
            this.lblBirim.Location = new System.Drawing.Point(401, 183);
            this.lblBirim.Name = "lblBirim";
            this.lblBirim.Size = new System.Drawing.Size(13, 13);
            this.lblBirim.TabIndex = 11;
            this.lblBirim.Text = "0";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(360, 355);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(13, 13);
            this.lblSonuc.TabIndex = 13;
            this.lblSonuc.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sonuc :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 502);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblBirim);
            this.Controls.Add(this.lblSatisFiyati);
            this.Controls.Add(this.lblAlisFiyati);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAlisFiyati;
        private System.Windows.Forms.Label lblSatisFiyati;
        private System.Windows.Forms.Label lblBirim;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label label5;
    }
}