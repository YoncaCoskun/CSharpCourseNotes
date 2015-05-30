using System;
using System.Data.SqlClient;

namespace oop_constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel p1 = new Personel("Ayşe Hatun", "Önal");
            p1.Id = 1;
            //p1.Ad = "Ayşe Hatun";
            //p1.Soyad = "Önal";
            p1.DogumTarihi = new DateTime(1981, 5, 27);
            p1.Unvan = "Developer";
            p1.Departman = "Yazılım ve Veritabanı Birimi";

            SqlConnection cnn = new SqlConnection("server=.;databa.........");

            SqlConnection cnn2 = new SqlConnection();
            cnn2.ConnectionString = "server=.;databa.........";
            

        }
    }
}
