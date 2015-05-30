using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public void Add(Customer entity)
        {
            context.Set<Customer>().Add(entity);
            context.SaveChanges();
        }

        public Customer GetById(int id)
        {
            return context.Set<Customer>().Find(id);  
        }

        public List<Customer> GetAll()
        {
            return context.Set<Customer>().ToList();

        }

        public void Update(Customer entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();

        }
        public void Remove(Customer entity)
        {
            context.Set<Customer>().Remove(entity);
            context.SaveChanges();
        }
    }
}
