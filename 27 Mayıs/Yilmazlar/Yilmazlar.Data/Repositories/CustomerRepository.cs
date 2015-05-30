using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Yilmazlar.Data.Context;
using Yilmazlar.Domain;

namespace Yilmazlar.Data.Repositories
{
    public class CustomerRepository
    {
        YilmazlarContext context = new YilmazlarContext();
        public void Add(Customer entity)
        {
            context.Customers.Add(entity);
            context.SaveChanges();
        }

        public Customer GetById(int id)
        {
            return context.Customers.Find(id);
        }
        public List<Customer> GetAll()
        {
            return context.Customers.ToList();
        }
        public void Update(Customer entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Remove(Customer entity)
        {
            context.Customers.Remove(entity);
            context.SaveChanges();
        }
    }
}
