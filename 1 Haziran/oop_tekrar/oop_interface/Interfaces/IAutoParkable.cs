using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_interface.Interfaces
{
    public interface IAutoParkable
    {
        void Park();
        string Warn();

        bool HasFrontSensor { get; set; }  //interface te get ve set ıcı doldurulmaz,normal class a gore karsılastırdıgımızda
    }
}
