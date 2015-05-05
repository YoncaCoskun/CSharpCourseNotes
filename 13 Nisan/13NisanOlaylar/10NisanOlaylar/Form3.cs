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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //keypress son karakterı almaz
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //text box ın ıcıne gırılen metın sadece sayılardan olusuyorsa zayıf ,
            //sadece metinden olusuyorsa yine zayıf,
            //hem metin hemde sayıdan olusuyorsa güçlü yazdırınız.

            bool harfVarMi = false;
            bool sayiVarMi=false;

            foreach (char item in textBox1.Text)
            {
                if (char.IsDigit(item))
                {
                    sayiVarMi = true;
                }
                else if (char.IsLetter(item))
                {
                    harfVarMi = true;
                }
            }
            if (harfVarMi==true && sayiVarMi==true)
            {
                label1.Text = "Güçlü";
                label1.BackColor = Color.LightGreen;
            
            }
            else
            {
                label1.Text = "Zayıf";
                label1.BackColor = Color.PaleVioletRed;
            }
            textBox2_TextChanged(null,null);  //once label2 ye yazıp sonra label bırdede eslesıp eslesmedıgını gormek ıcın bu sekılde yazdık burda fonk u calıstırdık
            
        }

     

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
                {
                    label2.Text = "eşleşti";
                }
            else
                {
                    label2.Text = "eşleşmedi";
                }
        }
   
    }
}
