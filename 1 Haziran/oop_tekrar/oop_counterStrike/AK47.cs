using oop_counterStrike.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_counterStrike
{
    public class AK47 : Silah, IAtesEdebilable
    {
        public string AtesEt()
        {
            return "AK47 ile ates edildi";
        }

        public string SarjorDoldur()
        {
            return "30 mermi eklendi.Fire in the hole.";
        }

        public int Kalibre
        { get; set; }

        public int Menzil
        {
            get;
            set;
        }
    }
}
