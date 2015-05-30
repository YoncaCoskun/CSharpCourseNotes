using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericOrnekler
{
    class Program
    {
        static void Main(string[] args){

            //--------------------------------GENERIC------------------------------------------------------------
        //{
        //    List<string>isimler=new List<string>();
        //    isimler.Add("Ekin");
        //    isimler.Add("Yonca");
        //    isimler.Add("Tayfun");

        //    List<int>sayilar=new List<int>();
        //    sayilar.Add(1);
        //    sayilar.Add(2);
        //    sayilar.Add(3);

        //    List<Random>rastgeleler=new List<Random>();
        //    rastgeleler.Add(new Random());

            UniversalKumanda<string>kumanda=new UniversalKumanda<string>(); 

            kumanda.Ekle("ayakkabı");
            kumanda.Ekle("dolap");

            UniversalKumanda<int>kmd=new UniversalKumanda<int>();
            kmd.Ekle(3);
            kmd.Ekle(9);
            kmd.Ekle(1);

            string deger1= kumanda.Getir();
            int veri = kmd.Getir();


            UniversalKumanda<Sony>sonyKumandasi=new UniversalKumanda<Sony>();
            Sony sny = sonyKumandasi.Getir();
            sonyKumandasi.Ekle(new Sony());

            UniversalKumanda<Phillips>phillipsKumandasi=new UniversalKumanda<Phillips>();
            Phillips plp = phillipsKumandasi.Getir();
            phillipsKumandasi.Ekle(new Phillips());


            //Generic class icerisindeki generic olmayan DenemeMetot Kullanımı.
            string sonuc1=phillipsKumandasi.DenemeMetot(3);
            string sonuc2 = phillipsKumandasi.DenemeMetot(4);

        }
    }
}
