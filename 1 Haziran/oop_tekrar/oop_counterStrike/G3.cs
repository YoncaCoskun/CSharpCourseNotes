using oop_counterStrike.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_counterStrike
{
   public class G3:Silah,IAtesEdebilable,IKesebilable
    {
        public string AtesEt()
        {
            return "G3 ile ates edildi.";
        }

        public string SarjorDoldur()
        {
            return "12 mermi eklendi.";
        }

        public int Kalibre
        {   get;set; }

        public int Menzil
        {  get;  set; }

        public string Kes()
        {
            return "Sungu ıle kesıldı";
        }
    }
}
