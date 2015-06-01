using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ornek_static
{
    public class Tools
    {
        public string IslemAdi { get; set; }

        public string IslemAdiGoster()
        {
            //non-static üye içerisinde static üyeye erişebildim. 

            //string ad = ConnectionString;
            return this.IslemAdi;
        }

        public static string ConnectionString = "server=.;database=............";

        public static void IslemYap()
        {
            //static bir üye içerisinde non-static bir üyeye erişemem!!!
            //string ad= IslemAdi;

            int rakam = 0;
        }
    }
}
