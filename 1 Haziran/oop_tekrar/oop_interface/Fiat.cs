using oop_interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_interface
{
    public class Fiat:Car,ICarryable,IRaceable

    {
        //----------------------------------ICarryable implementation---------------------------------------------------
        public void Carry()
        {
            //...
        }

        //------------------------------------IRaceable implementation-----------------------------------------------------
        public string Race()
        {
            throw new NotImplementedException();
        }
    }
}
