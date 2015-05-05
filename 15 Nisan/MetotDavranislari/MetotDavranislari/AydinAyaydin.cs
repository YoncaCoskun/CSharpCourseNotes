using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotDavranislari
{
    class AydinAyaydin:Yigit
    {
        public override string yogurtYe()
        {
            
            return base.yogurtYe()+" "+"Bazen de çatalla dalar";
        }
    }
}
