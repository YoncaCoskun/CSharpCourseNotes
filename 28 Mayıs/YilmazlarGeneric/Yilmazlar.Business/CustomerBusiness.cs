using Yilmazlar.Data.Repositories;
using Yilmazlar.Domain;

namespace Yilmazlar.Business
{
    public class CustomerBusiness
    {
        CustomerRepository repo = new CustomerRepository();
        public Customer SoyadaGoreMusteriGetir(string soyad)
        {
            return repo.SoyadaGoreMusteriGetir(soyad);
        }

    }
}
