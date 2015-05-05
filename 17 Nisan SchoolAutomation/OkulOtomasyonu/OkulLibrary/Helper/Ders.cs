using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulLibrary.Helper
{
   public class Ders
    {
        public int DersId { get; set; }

        public string DersAdi { get; set; }

        public int Kredisi { get; set; }

        public int HaftalikSaat { get; set; }

        public override string ToString()
        {
            return this.DersAdi;
        }


    }
}
