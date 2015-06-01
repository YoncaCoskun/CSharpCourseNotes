using oop_counterStrike.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_counterStrike
{
    public class Picak:Silah,IKesebilable
    {

        public string Kes()
        {
            return "Bıçak ile kesildi";
        }
    }
}
