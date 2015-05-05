using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arayuzler
{
    public abstract class Erkek
    {
        public string kolonyaMarkasi { get; set; }

        public string jiletMarkasi { get; set; }

        public virtual void tirasOl()
        {


        }

        public abstract void kolonyaSur();
        


        
    }
}
