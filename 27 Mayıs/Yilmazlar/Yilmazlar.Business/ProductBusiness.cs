using System.Collections.Generic;
using Yilmazlar.Data.Repositories;
using Yilmazlar.Domain;

namespace Yilmazlar.Business
{
    public class ProductBusiness
    {
        private ProductRepository repo = new ProductRepository();
        public void Add(Product entity)
        {
            if (entity.Price > 5000)
            {
                //.. mail gönderme
            }

            repo.Add(entity);
        }
        public void Update(Product entity)
        {
            repo.Update(entity);
        }

        public void Remove(Product entity)
        {
            repo.Remove(entity);
        }

        public Product GetById(int id)
        {
            return repo.GetById(id);
        }

        public List<Product> GetAll()
        {
            return repo.GetAll();
        }

    }
}
