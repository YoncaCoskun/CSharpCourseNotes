using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDevam
{
    class Program
    {
        static void Main(string[] args)
        {

            //-------------------------------DİZİ TANIMLAMA--------------------------------------

            //string[] dizi1=new string[10];
            //double[] dizi2 = {12.5,25.4,45.8,20 };
            //Array.Resize(ref dizi2,dizi2.Length+1);
            //Console.Write(dizi2[dizi2.Length-1]);
            //Console.Read();

            //------------------------KARAR YAPILARI------------------------------
            //          if (true)
            //          {
                
            //          }
            //          else if (true)
            //          {
                
            //          }
            //          else
            //          {

            //          }
            //          for (int i = 0; i < 10; i++)
            //          {
                
            //          }

            //          while (true)
            //          {
                
            //          }
            //          do
            //          {
                
            //          } while (true);

            //-----------------------------------------------------------------------------------------------------------------------------

            //          string[] dizi = {"Ekin","Tayfun","Yonca"};

            //          foreach (string isim in dizi)
            //          {
            //          Console.WriteLine(isim);
            //          }
            //          Console.Read(); //ekrana diziyi yazdırır
            //          Console.ReadKey();  //herhangi bir harfe rakama basıldıgında dırek kapanır

            //---------------------------------------Tip Donusumlerı-----------------------------------------------------------------------------

            int sayi = 45;
            long babaSayi = 78;
            string farkliSayi= "65";

            // farkliSayi = sayi;  //tipleri farklı oldugu ıcın esıtlenmıyor

            babaSayi = sayi;
            // sayi = babaSayi;  //esitlenmez cunku kucuk balık buyuk balıgı yıyemez
            sayi=(int)babaSayi; //bu sekilde long tipini int olarak rol yapıyor bu olaya casting denir.Casting sadece akraba tiplerde calısır.Eger akraba degıllerse donusturme fonksıyonu uygulanır yanı convert;

            farkliSayi = Convert.ToString(sayi); //bunu yerine asagıdaki de yapılabiliyor
            farkliSayi = sayi.ToString();

            //metinsel bir degeri sayısal bır degere  toInt ıle donusturebılırız
            sayi = Convert.ToInt32(farkliSayi); //16 short ,32 int, 64 long doner


            //byte ta small ınt e denk oldugu ıcın bundanda sıkıntı cıkmaz
            babaSayi=sayi;
            byte test = 45;
            sayi = test;
            babaSayi = test;


            //object tipi bilinen butun tipleri babasıdır.Istenırse ıcıne string alır,int alabiilir long alabilir...
            object obje;
            obje = farkliSayi;
            obje = sayi;
            obje = babaSayi;
            babaSayi=(long)obje;  //casting yaparak donusturebılıriz


            //int,long,short kapladıgı alanı gormek ıcın yaptık
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(short.MaxValue);

            Console.Read();
            //--------------------------------------------------------------------------------------------------------------------------------

            object[] dizi=new object[0];  //icerisine herturlu tipte deger alıyor


            
        }
    }
}
