using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CesetHospital
{
    class Hasta
    {
        public string HastaAdi { get; set; }

        public string HastaSoyadi { get; set; }

        public string TelefonNo { get; set; }

        public DateTime DogumTarihi { get; set; }

        public string Poliklinik { get; set; }

        public string Doktoru { get; set; }


        public string KendiniTanit() {

            return this.HastaAdi + " " + this.HastaSoyadi;
        
        }
    }
}
