using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_constructor
{
    class Personel
    {
        //parametreli bir constructor eklendiği zaman, compiler boş constructor oluşturmaz !!!!
        public Personel(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }

        public Personel(string ad, string soyad, int id, DateTime dogumTarihi, string departman, string unvan)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.Id = id;
            this.DogumTarihi = dogumTarihi;
            this.Departman = departman;
            this.Unvan = unvan;
        }

        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Unvan { get; set; }
        public string Departman { get; set; }


        //destructor. Nesne ölürken çağrılır.
        ~Personel()
        {

        }
    }
}
