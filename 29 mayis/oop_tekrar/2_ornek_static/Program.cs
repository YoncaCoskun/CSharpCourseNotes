using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ornek_static
{
    class Program
    {
        static void Main(string[] args)
        {
            //Matematik mat = new Matematik();

            //int sonuc1 = mat.Topla(4, 5);
            //int sonuc2 = mat.Bol(6, 3);
            //int sonuc3 = mat.Carp(5, 45);
            //int sonuc4 = mat.Cikar(9, 3);


            int sonuc1 = Matematik.Topla(4, 5);
            int sonuc2 = Matematik.Bol(6, 3);
            int sonuc3 = Matematik.Carp(5, 45);
            int sonuc4 = Matematik.Cikar(9, 3);

            //

            //non-static olan Tools class' ının içerisindeki static üyeye, instance almadan tip isminde sonraki nokta ile eriştim.
            string cnn = Tools.ConnectionString;


            //non-static olan Tools class' ının içerisindeki non-static üye(ler)e, instance alarak eriştim.
            Tools tls1 = new Tools();
            tls1.IslemAdi = "Insert";
            Console.WriteLine(tls1.IslemAdiGoster());

            Tools tls2 = new Tools();
            tls2.IslemAdi = "Select";
            Console.WriteLine(tls2.IslemAdiGoster());

            //hata verir.
            //tls1.ConnectionString

            Console.WriteLine(Tools.ConnectionString);

            Console.ReadLine();
        }
    }
}
