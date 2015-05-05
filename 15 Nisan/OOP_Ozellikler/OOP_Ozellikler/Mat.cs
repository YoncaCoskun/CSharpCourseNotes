using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ozellikler
{
    public static class Mat
    {
        /// <summary>
        /// içerisine verilen en büyük sayıyı döner
        /// </summary>
        /// <param name="sayi1">Birinci sayıyı ver</param>
        /// <param name="sayi2">İkinci sayıyı ver</param>
        /// <returns></returns>
        public static int Maks(int sayi1, int sayi2) {

           if (sayi1>sayi2)
           {
              return sayi1;
           }
            else
            {
                return sayi2;
            }
        }

        public static double Maks(double sayi1, double sayi2)  //overload:parametre sayısı ya farklı olmalı yada tipleri farklı olmalı
        {

            if (sayi1 > sayi2)
            {
                return sayi1;
            }
            else
            {
                return sayi2;
           }
        }

        //overload(kullanım sekli): bir metodun overloadı metot ıle aynı isme sahip olmalıdır.Parametre sayısı ya farklı olmalıdır yada parametrelerden en birinin tipi farklı olmalıdır.Geri donus degeri farklı olması overload olusturmaz.

        //---------------------------------------------------------------------------------------------

        public static double Maks(double sayi1, double sayi2,double sayi3)
        {

            if (sayi1 > sayi2)
            {
                return sayi1;
            }
            else if (sayi2 > sayi1)
            {
                return sayi2;
            }
            else
                return sayi3;
        }

        public static double Maks(double sayi1, double sayi2,int sayi3)
        {
            if (sayi1 > sayi2)
            {
                return sayi1;
            }
            else if (sayi2 > sayi1)
            {
                return sayi2;
            }
            else
                return sayi3;
        }


        //------------------------------------------------------------------------------------

        public static double Maks(params double[] sayilar) {

            double enBuyuk = 0;

            foreach (double item in sayilar)
            {
                if (enBuyuk<item)
                {
                    enBuyuk = item;
                }
              
            }
          return enBuyuk;
        }

        // public static const double PI = 3.14;  //const : sabitlik veriyor const genelde kullanılmıyor onun yerıne readonly kullanılır cunku const static olarak tanımlanamıyor
        public static readonly double PI = 3.14;

        public static readonly double E = 2.54;

      
        
        
    }
}
