using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_counterStrike
{
   public class Silah
    {
        public string Ad { get; set; }
        public int Hasar { get; set; }

        public override string ToString()
        {
            return Ad;
        }
    }
}
