using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yilmazlar.Data.Context;
using Yilmazlar.Domain;

namespace Yilmazlar.Data.Repositories
{
    public class CustomerRepository
    {
        YilmazlarContext context = new YilmazlarContext();
        public Customer SoyadaGoreMusteriGetir(string soyad)
        {
            Customer musteri= context.Customers.FirstOrDefault(x => x.Lastname == soyad);

            return musteri;
        }

    }
}
