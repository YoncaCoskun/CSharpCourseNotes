using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Kisi
    {
        private int Private { get; set; } //auto property
        public int Public { get; set; }
        protected int Protected { get; set; }
        internal int Internal { get; set; }
        protected internal int ProtectedInternal { get; set; } 
        //private string _ad;
        //public string Ad  //buradaki property ile yukarda tanımladıgımız aynı.
        //{
        //    get { return _ad; }
        //    set { _ad = value; }
        //}


        //Bu class ıcınde butun property lere erisebildim.
        void Deneme()
        {
            Kisi k=new Kisi();
            k.Private = 1;
            k.Internal = 2;
            k.Protected = 3;
            k.Public = 4;
            k.ProtectedInternal = 5;
        }

    }

   
    class Calisan:Kisi
    {
        public int Departman { get; set; }
        void Test()
        {

            //instance alıp dıger nesneden erısmeye calıstıgımızda protected hata verir.

            //Kisi k = new Kisi();
            //k.Private = 1;   -->hata verir
            //k.Internal = 2;
            //k.Protected = 3;  --> hata verir.
            //k.Public = 4;
            //k.ProtectedInternal = 5;


         
            Internal = 2;  //hata vermez bu sekılde
            Protected = 3;
            Public = 4;
            ProtectedInternal = 5;
            
        }

       
    }
    class ABC
    {
        Kisi k = new Calisan();  // calısan bır kisidir. 
    }

    class Telefon
    {
         Calisan c=new Calisan();
         Kisi k=new Kisi();

        public Telefon()
        {
            k.Internal = 1;
            k.ProtectedInternal = 2;
            k.Public = 3;  
            //kalıtım almadıgı icin protected ı eledik.


        }
    }
}
