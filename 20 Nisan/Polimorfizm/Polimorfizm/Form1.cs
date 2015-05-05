using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polimorfizm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Oyuncu o = new Oyuncu();


            // Kedi k = new Kedi();
            // o.temizle(k);

            Dinazor d = new Dinazor();
            o.yemekYedir(d);

            Ayi a = new Ayi();
            o.uyut(a);

           //  Hayvan h = new Hayvan();  //eger hayvan nesnesınden ınstance alınamaması ıcın abstract kullanılı
            //abstract ifadesi bir class tan instance alınması nı engeller sadece inheritance alınabılır hale getırır
          //  o.uyut(h);

            Aslan aa = new Aslan();
            o.uyut(aa);


            MessageBox.Show(d.kaydet());
            MessageBox.Show(aa.kaydet());



        }
    }
}
