using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MemoryManagement
{
    public class Mahkum:IDisposable
    {
        //classın olmeden once yapabılceklerını gosterır
        //------------------------------------DESTRUCTOR -------------------------------------------

        public Mahkum()  //constructer metot
        {

            

        }

        ~Mahkum()  //bu metot destructor metodudur.
        {
            MessageBox.Show("bir ihtimal daha var o da ölmek mi dersin.");

        }

        public void Dispose()  //IMPLEMENT OLABILMESI ICIN BUI METOTUN OLMASI ZORUNLUDUR!!
        {
            MessageBox.Show("Söyle canım ne dersin");
            GC.SuppressFinalize(this); //sonlandırmak ıcın baskı kurmak
        }
    }
}
