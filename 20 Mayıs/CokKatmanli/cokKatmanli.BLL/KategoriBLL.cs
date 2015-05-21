using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cokKatmanli.DAL;
using cokKatmanli.Entity;

namespace cokKatmanli.BLL
{
   public  class KategoriBLL
    {
       public Category KategoriGetir(int pId)
       {
          
          CategoryDAL dal=new CategoryDAL();
          Category ct= dal.KategoriGetir(pId);
           return ct;

          



       }

    }
}
