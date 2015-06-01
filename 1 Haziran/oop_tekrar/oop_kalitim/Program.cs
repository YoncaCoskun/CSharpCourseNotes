using System;

namespace oop_kalitim
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Telefon tlf = new Telefon();
            //tlf.Id = 0;
            //tlf.Fiyat = 0;
            //tlf.Marka = "";
            //tlf.Model = "";

            AhizeliTelefon ahizeli = new AhizeliTelefon();

            AkilliTelefon akilli = new AkilliTelefon();


            Console.WriteLine(tlf.Cal());
            Console.WriteLine(ahizeli.Cal());
            Console.WriteLine(akilli.Cal());

            Console.Read();
        }
    }
}
