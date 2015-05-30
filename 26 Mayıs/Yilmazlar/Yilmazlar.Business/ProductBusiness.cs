using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yilmazlar.Data.Repositories;
using Yilmazlar.Domain;

namespace Yilmazlar.Business
{
    public class ProductBusiness
    {
        private ProductRepository repo = new ProductRepository();
        public void Add(Product entity)
        {
            repo.Add(entity);
        }
        public Product GetById(int id)
        {
            return repo.GetById(id);
        }

        public List<Product> GetAll()
        {
            return repo.GetAll();
        }

        //update
        //remove ekleyin !!!
    }
}
