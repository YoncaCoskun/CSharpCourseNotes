using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_counterStrike.Interfaces
{
   public interface IAtesEdebilable
    {
       string AtesEt();

       string SarjorDoldur();

       int Kalibre { get; set; }
       int Menzil { get; set; }
    }
}
