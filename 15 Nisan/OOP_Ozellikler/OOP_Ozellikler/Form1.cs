using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Ozellikler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //double buyukSayi = Math.Max(20.5,30.5);

            //double buyuk = Mat.Maks(20, 30); //static olunca sınıf, bizim yaptıgımız metot ta hemen busekılde gelebiliyor. bizim yaptıgımız double olarak yazamıyoruz buyuzden bızde overload yapmalıyız
           // int buyuk = new Mat().Maks(20, 30);

            //--------------------------------------------------------------------------

            double sayi1 = 25.5;
            double sayi2 = 54.5;
            double sayi3 = 25;

            //bu üc sayıdan en buyugunu mesaj box ta gosterınız

            double buyukSayi = Mat.Maks(sayi1,sayi2,sayi3);
            MessageBox.Show(buyukSayi.ToString());


            //--------------------------------------------------------------------

           // Mat.Maks(); //boş olması ıcın hata vermemesı ıcın params yazarız




            //params: params ifadesi bir metotda sadece bir defa yazılır.
            //params herzaman en son parametredir.params tan sonra baska parametre verilmez.
            //const:tanımlandıgı yerde degerı alırlar bıdaha hıc degıstırılemezler

            double onlarinki = Math.PI;
            double bizimki = Mat.PI;


            //Math.PI = 5;
            //Mat.PI = 6;

            //onlarinki = Math.E;
            //bizimki = Mat.E;

            //Mat m = new Mat();
            //Math ma = new Math();

            //static nesneler ram de baş köşeyi alırlar ve hızlı gelirler
            //dezavantajı kullanılmayan nesneler static olursa bos yere ram lerı doldurmus oluruz.



        }
    }
}
