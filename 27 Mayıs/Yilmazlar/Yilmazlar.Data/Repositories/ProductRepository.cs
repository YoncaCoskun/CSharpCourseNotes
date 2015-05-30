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
    public class ProductRepository
    {
        YilmazlarContext context = new YilmazlarContext();
        public void Add(Product entity)
        {
            context.Products.Add(entity);
            context.SaveChanges();
        }

        public Product GetById(int id)
        {
            return context.Products.Find(id);
        }
        public List<Product> GetAll()
        {
            return context.Products.ToList();
        }
        public void Update(Product entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Remove(Product entity)
        {
            context.Products.Remove(entity);
            context.SaveChanges();
        }
    }
}
