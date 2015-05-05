using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulLibrary
{
    public class Veli
    {
        public int VeliId { get; set; }

        public string VeliAdi { get; set; }

        public string VeliSoyadi { get; set; }

        public string TelefonNo { get; set; }

        public override string ToString()
        {
            return VeliAdi + "" + VeliSoyadi;   //base.ToString();  //OkulLibrary.Veli gorunur yani tipini dondurur.
        }


    }

}
