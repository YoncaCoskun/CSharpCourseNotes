namespace BasitUygulama
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnCalisanlar = new System.Windows.Forms.Button();
            this.btnKategoriler = new System.Windows.Forms.Button();
            this.btnUrunler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalisanlar
            // 
            this.btnCalisanlar.BackColor = System.Drawing.Color.Transparent;
            this.btnCalisanlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalisanlar.Image = ((System.Drawing.Image)(resources.GetObject("btnCalisanlar.Image")));
            this.btnCalisanlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalisanlar.Location = new System.Drawing.Point(136, 37);
            this.btnCalisanlar.Name = "btnCalisanlar";
            this.btnCalisanlar.Size = new System.Drawing.Size(208, 64);
            this.btnCalisanlar.TabIndex = 0;
            this.btnCalisanlar.Text = "Employees";
            this.btnCalisanlar.UseVisualStyleBackColor = false;
            this.btnCalisanlar.Click += new System.EventHandler(this.btnCalisanlar_Click);
            // 
            // btnKategoriler
            // 
            this.btnKategoriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKategoriler.Image = ((System.Drawing.Image)(resources.GetObject("btnKategoriler.Image")));
            this.btnKategoriler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKategoriler.Location = new System.Drawing.Point(136, 116);
            this.btnKategoriler.Name = "btnKategoriler";
            this.btnKategoriler.Size = new System.Drawing.Size(208, 64);
            this.btnKategoriler.TabIndex = 1;
            this.btnKategoriler.Text = "Categories";
            this.btnKategoriler.UseVisualStyleBackColor = true;
            this.btnKategoriler.Click += new System.EventHandler(this.btnKategoriler_Click);
            // 
            // btnUrunler
            // 
            this.btnUrunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrunler.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunler.Image")));
            this.btnUrunler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunler.Location = new System.Drawing.Point(136, 207);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(208, 64);
            this.btnUrunler.TabIndex = 2;
            this.btnUrunler.Text = "Products";
            this.btnUrunler.UseVisualStyleBackColor = true;
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(465, 325);
            this.Controls.Add(this.btnUrunler);
            this.Controls.Add(this.btnKategoriler);
            this.Controls.Add(this.btnCalisanlar);
            this.Name = "frmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalisanlar;
        private System.Windows.Forms.Button btnKategoriler;
        private System.Windows.Forms.Button btnUrunler;
    }
}

