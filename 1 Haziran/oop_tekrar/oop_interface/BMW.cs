using oop_interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_interface
{
   public class BMW:Car,IAutoParkable,IRaceable  //aradaki noktanokta is a anlamında
    {
        public bool Elektrikli { get; set; }

       //-----------------------------------------------IAutoparkable implenmetiton---------------------------------------

        public void Park()
        {
           //...
        }

        public string Warn()
        {
            return "Dikkat dikkatt...!!";
        }

       //---------------------------------------IRaceable implementation---------------------------------
        public string Race()
        {
            return "yarişiyorum";
        }


        public bool HasFrontSensor { get;  set;     }
    }
}
