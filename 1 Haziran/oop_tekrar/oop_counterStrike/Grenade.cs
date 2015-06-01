using oop_counterStrike.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_counterStrike
{
    public class Grenade:Silah,IPatlayabilable
    {
        public string Patla()
        {
            return "Grenade patlatıldı";
        }

        public int EtkiAlani
        { get;set; }
    }
}
