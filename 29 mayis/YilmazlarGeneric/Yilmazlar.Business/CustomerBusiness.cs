using Yilmazlar.Data.Repositories;
using Yilmazlar.Domain;

namespace Yilmazlar.Business
{
    public class CustomerBusiness : BaseBusiness<Customer>
    {
        CustomerRepository repo = new CustomerRepository();
        public Customer SoyadaGoreMusteriGetir(string soyad)
        {
            return repo.SoyadaGoreMusteriGetir(soyad);
        }

    }
}
