namespace WindowsFormsApplication1
{
    partial class frmBilgeAnaokuluUygulama
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.çalışanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanGirişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanGirişToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çalışanToolStripMenuItem,
            this.öğrenciToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(899, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // çalışanToolStripMenuItem
            // 
            this.çalışanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çalışanGirişToolStripMenuItem,
            this.çalışanGirişToolStripMenuItem1});
            this.çalışanToolStripMenuItem.Name = "çalışanToolStripMenuItem";
            this.çalışanToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.çalışanToolStripMenuItem.Text = "Calisan";
            // 
            // çalışanGirişToolStripMenuItem
            // 
            this.çalışanGirişToolStripMenuItem.Name = "çalışanGirişToolStripMenuItem";
            this.çalışanGirişToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.çalışanGirişToolStripMenuItem.Text = "Calisan Kayit";
            // 
            // çalışanGirişToolStripMenuItem1
            // 
            this.çalışanGirişToolStripMenuItem1.Name = "çalışanGirişToolStripMenuItem1";
            this.çalışanGirişToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.çalışanGirişToolStripMenuItem1.Text = "Calisan Giris";
            this.çalışanGirişToolStripMenuItem1.Click += new System.EventHandler(this.calisanGirisToolStripMenuItem1_Click);
            // 
            // öğrenciToolStripMenuItem
            // 
            this.öğrenciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciKayıtToolStripMenuItem});
            this.öğrenciToolStripMenuItem.Name = "öğrenciToolStripMenuItem";
            this.öğrenciToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.öğrenciToolStripMenuItem.Text = "Ogrenci";
            // 
            // öğrenciKayıtToolStripMenuItem
            // 
            this.öğrenciKayıtToolStripMenuItem.Name = "öğrenciKayıtToolStripMenuItem";
            this.öğrenciKayıtToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.öğrenciKayıtToolStripMenuItem.Text = "Ogrenci Giris";
            this.öğrenciKayıtToolStripMenuItem.Click += new System.EventHandler(this.ogrenciKayitToolStripMenuItem_Click);
            // 
            // frmBilgeAnaokuluUygulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 600);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmBilgeAnaokuluUygulama";
            this.Text = "Bilge Anaokulu";
          
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem çalışanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çalışanGirişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çalışanGirişToolStripMenuItem1;
    }
}