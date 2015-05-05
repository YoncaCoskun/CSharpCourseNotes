using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arayuzler
{
    public abstract class Kadin
    {
        public string ojeMarkasi { get; set; }

        public string rujMarkasi { get; set; }

        public virtual void makyajYap() { 
           
        }

        public abstract void makyajCikar();
    }
}
