using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yilmazlar.Data.Repositories;

namespace Yilmazlar.Business
{
    public class BaseBusiness<TBusinessEntity> where TBusinessEntity : class
    {
        BaseRepository<TBusinessEntity> repo = new BaseRepository<TBusinessEntity>();

        public void Add(TBusinessEntity nesne)
        {
            repo.Add(nesne);
        }

        public void Remove(TBusinessEntity item)
        {
            repo.Remove(item);
        }

        public void Update(TBusinessEntity obj)
        {
            repo.Update(obj);
        }

        public TBusinessEntity GetById(int id)
        {
            return repo.GetById(id);
        }
        public List<TBusinessEntity> GetAll()
        {
            return repo.GetAll();
        }
    }
}
