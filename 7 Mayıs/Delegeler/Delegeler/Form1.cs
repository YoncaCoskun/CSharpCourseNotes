using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegeler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public delegate void mesajGosterDelege();  

         
        public void mesajGoster() //delegeler yaptıgın metoda gore belırlenır.bu metodun public,void gibi ozellıklerını tasır.
        {
            MessageBox.Show("Hello World");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // mesajGoster();   //mesaj gosterme ısı asıl kisiye(basbakan) yaptırıldı

            //delege ile yapıldıgında;
            mesajGosterDelege ahmet = new mesajGosterDelege(mesajGoster);
            ahmet();  //bu delegeyi calıstırmıs oluyoruz.



        }

        //-------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------


        void sayiCarp(int sayi1,int sayi2)
        {
            int sonuc = sayi1 * sayi2;
            MessageBox.Show(sonuc.ToString());
        }


       delegate void sayiCarpDelege(int sayi1,int sayi2);
        private void button2_Click(object sender, EventArgs e)
        {
            //yukarıdaki metodu bır delegeye yaptırınız.

            sayiCarpDelege delege = new sayiCarpDelege(sayiCarp);
            delege.Invoke(4,5);    //bu sekılde de yapılır.                  //sayiCarp(4,5);         

        }

       //-------------------------------------------------------------------------------------------------------------
       //-------------------------------------------------------------------------------------------------------------

        //int sayiCarp(int sayi1, int sayi2)
        //{
        //    int sonuc = sayi1 * sayi2;
        //    return sonuc;
        //}


        //delegate int sayiCarpDelege(int sayi1, int sayi2);
        //private void button2_Click(object sender, EventArgs e)
        //{
     

        //    sayiCarpDelege delege = new sayiCarpDelege(sayiCarp);
        //      int sonuc=delege.Invoke(4, 5);         
        //      MessageBox.Show(sonuc.ToString());

        //}
       
        //--------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------





    }
}
