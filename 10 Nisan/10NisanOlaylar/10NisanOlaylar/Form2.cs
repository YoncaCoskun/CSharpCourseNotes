using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10NisanOlaylar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kapansinMi = true;
            this.Close();
            //butonu bulundugu yerden baska yerlere tasımak
            //bunlar butonu sabıtler
            //button1.Left = 50; 
            //button1.Top = 50;


            //Random rnd = new Random();
            //button1.Left = rnd.Next(500);
            //button1.Top = rnd.Next(500); 


            //eger formun dısına cıkmasını ıstemıyorsak butonun;
            
            //Random rnd = new Random();
            //button1.Left = rnd.Next(this.Width-button1.Width);
            //button1.Top = rnd.Next(this.Height-button1.Height); 

        }

        Random rnd = new Random(); //random da aynı gelme olasılıgı daha az
        Boolean kapansinMi = false;
        private void button1_MouseEnter(object sender, EventArgs e)
        {

           
            button1.Left = rnd.Next(this.Width - button1.Width);
            button1.Top = rnd.Next(this.Height - button1.Height); 
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

            //form kapanmadan once oldugu ıcın closing kullanılır busekılde alert verırız
            if (kapansinMi)
            {
                MessageBox.Show("Çıkış için aşağıdaki çıkış butonuna basınız");
                e.Cancel = true;
            }
            
        }

     
    }
}
