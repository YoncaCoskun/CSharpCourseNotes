using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBaslangic
{
    class Program
    {
        static void Main(string[] args)
        {

            //unsafe kodlama: bunu kullandıgınızda .net e ihtiyac duymazsınız.kolay kolay herseye ızın verilmez.eger bir form gelistiriyorsanız unsafe ten giderseniz herseyi siz yazmanız gerekir cunku kutuphane yoktur.
            //hem .net hemde unsafe coding te yapılabilir.

            // c# complier        MSIL          JIT(just in time)



            //-------------Tam Sayılar--------------
           //tinyint        byte
           //smallint       short
           //int            int
           //bigint         long

            //------------Ondalıklı sayılar--------
            //float     float
            //money     double
            //decimal   decimal

            //---------------Metinsel Ifade------------
            //char(1)       char
            //varchar(max)  string
            //nvarchar(max) string
            //ntext,text    string

            //------------Mantıksal tip--------------
            //bit       bool yada Boolean
            
            //----------Tarih Tipleri--------------------
            //time          DateTime
            //date          DateTime
            //datetime      DateTime
            //smalldatetime DateTime


            //tipi isim=deger;
            byte sayi = 12;
            double rakam = 10.5;
            float kasa = 10.5F;
            long babaSayi = 2000000000000L;
            bool test = 5 < 3;

            char harf='a'; //char tek tırnaklar string ise cıft tırnakla tanımlanır
            string metin = "bu bir metindir";


            DateTime buGun = DateTime.Now;  //tarih alımı bu sekilde gerçeklesir  (ingiliz anahtarı cıkıyor yanında bunlara property dıyecegız bunlar sadece deger tasırlar.esittirler deger aktarır yıne esıttırle deger alır.)
            //ide de cıkan mavi sembol filled ifadesidir
            //ide de kş mor semboller function ı temsıl eder.

        }
    }
}
