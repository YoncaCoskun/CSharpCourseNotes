using System.Collections.Generic;
using Yilmazlar.Data.Repositories;
using Yilmazlar.Domain;

namespace Yilmazlar.Business
{  
    public class CustomerBusiness
    {
        private CustomerRepository repo = new CustomerRepository();
        public void Add(Customer entity)
        {
            repo.Add(entity);
        }
        public void Update(Customer entity)
        {
            repo.Update(entity);
        }

        public void Remove(Customer entity)
        {
            repo.Remove(entity);
        }

        public Customer GetById(int id)
        {
            return repo.GetById(id);
        }

        public List<Customer> GetAll()
        {
            return repo.GetAll();
        }

    }
}