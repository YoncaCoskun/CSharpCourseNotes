using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yilmazlar.Data.Context;
using Yilmazlar.Domain;

namespace Yilmazlar.Data.Context
{
    public class YilmazlarContext:DbContext
    {
        public YilmazlarContext():base("YilmazlarContext") //kalıtım alınan class ın konstraktırına base icindeki ifade gonderilir.
        {
            
        }

        DbSet<Customer> Customers { get; set; }
        DbSet<Product> Products { get; set; }
 
    }
}
