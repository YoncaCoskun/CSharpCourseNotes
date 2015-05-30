using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Yilmazlar.Data.Context;

namespace Yilmazlar.Data.Repositories
{
    public class BaseRepository<TEntity> where TEntity : class
    {
        YilmazlarContext context = new YilmazlarContext();

        public void Add(TEntity obj)
        {
            //Set metodu generic olarak yazılmış ve bizden bir tip bekler. verdiğimiz tipin DbSet' ini döndürür
            //context.Set<Product>().Add(new Product());
            //context.Set<Customer>().Add(new Customer());

            context.Set<TEntity>().Add(obj);
            context.SaveChanges();
        }

        public void Remove(TEntity nesne)
        {
            context.Set<TEntity>().Remove(nesne);
            context.SaveChanges();
        }

        public void Update(TEntity item)
        {
            context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();
        }
          
        public TEntity GetById(int id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public List<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();
        }
    }
}
