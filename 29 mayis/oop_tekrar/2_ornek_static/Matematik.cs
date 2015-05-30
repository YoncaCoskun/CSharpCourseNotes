using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ornek_static
{
    static public class Matematik
    {
        //static olmayan (non-static) class içerisindeki üyeler, insance' a aittir.
        //static class içerisindeki üyeler, class' a (tipe) aittir.
        //static bir class içerisindeki tüm üyeler ya static ya da const olmak zorundadır!!!
        
        public static int PI = 3;
        public const int E = 2;

        public static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public static int Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
        public static int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        public static int Bol(int sayi1, int sayi2)
        {
            return sayi1 / sayi2;
        }

    }
}
