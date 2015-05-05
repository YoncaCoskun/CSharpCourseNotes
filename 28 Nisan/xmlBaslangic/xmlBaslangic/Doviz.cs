using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xmlBaslangic
{
    public class Doviz
    {
        public int Birim { get; set; }
        public string DovizAdi { get; set; }
        public double AlisFiyati { get; set; }
        public double SatisFiyati { get; set; }


        public override string ToString()
        {
            return this.DovizAdi;
        }
    }
}
