namespace AsenkronDelege
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lstAtesEt = new System.Windows.Forms.ListBox();
            this.lstTurboMotor = new System.Windows.Forms.ListBox();
            this.lstRoketAt = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ateş Et";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(322, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "Turbo Motorları Aç";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(595, 405);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 48);
            this.button3.TabIndex = 2;
            this.button3.Text = "Roket At";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lstAtesEt
            // 
            this.lstAtesEt.FormattingEnabled = true;
            this.lstAtesEt.Location = new System.Drawing.Point(12, 21);
            this.lstAtesEt.Name = "lstAtesEt";
            this.lstAtesEt.Size = new System.Drawing.Size(147, 368);
            this.lstAtesEt.TabIndex = 3;
            // 
            // lstTurboMotor
            // 
            this.lstTurboMotor.FormattingEnabled = true;
            this.lstTurboMotor.Location = new System.Drawing.Point(287, 21);
            this.lstTurboMotor.Name = "lstTurboMotor";
            this.lstTurboMotor.Size = new System.Drawing.Size(153, 368);
            this.lstTurboMotor.TabIndex = 4;
            // 
            // lstRoketAt
            // 
            this.lstRoketAt.FormattingEnabled = true;
            this.lstRoketAt.Location = new System.Drawing.Point(560, 21);
            this.lstRoketAt.Name = "lstRoketAt";
            this.lstRoketAt.Size = new System.Drawing.Size(145, 368);
            this.lstRoketAt.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(781, 491);
            this.Controls.Add(this.lstRoketAt);
            this.Controls.Add(this.lstTurboMotor);
            this.Controls.Add(this.lstAtesEt);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox lstAtesEt;
        private System.Windows.Forms.ListBox lstTurboMotor;
        private System.Windows.Forms.ListBox lstRoketAt;
    }
}

