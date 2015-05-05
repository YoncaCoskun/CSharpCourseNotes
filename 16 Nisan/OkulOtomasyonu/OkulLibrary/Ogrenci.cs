using OkulLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulLibrary
{
   public class Ogrenci
    {
        public int OgrenciId { get; set; }

        public string OgrenciAdi { get; set; }

        public string OgrenciSoyadi { get; set; }

        public DateTime DogumTarihi { get; set; }

        public string Memleketi { get; set; }

        public Veli Velisi { get; set; } //bir classın baska bır class ta veri olup kullanılmasına class assosiation(sınıf sosyallesmesi) denir.bu sekılde velinmin butun bilgilerini cekmis oluruz.


        public List<Ders> Dersler { get; set; }// yukarıya herzaman using diye ekleyemedıgımız durumlarda olabilir(Örn: aynı isimli class lar)
        

        

    }
}
