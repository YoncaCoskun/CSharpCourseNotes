using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arayuzler
{
    public interface IKadin
    {

        string ojeMarkasi { get; set; }

        string rujMarkasi { get; set; }

        void makyajYap();

        void makyajCikar();
    }
}
