using System.Data.Entity;
using Yilmazlar.Domain;

namespace Yilmazlar.Data.Context
{
    public class YilmazlarContext : DbContext
    {
        public YilmazlarContext()
            : base("YilmazlarContext")
        {
        }

        DbSet<Customer> Customers { get; set; }
        DbSet<Product> Products { get; set; }

    }
}
 