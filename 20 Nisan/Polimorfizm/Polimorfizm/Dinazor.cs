using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{
    public class Dinazor:Hayvan
    {
        public override string kaydet() {
            return "ucretli db ye kaydedildi";

        
        }

        public override string resimGoster()
        {
            throw new NotImplementedException();
        }
    }
}
