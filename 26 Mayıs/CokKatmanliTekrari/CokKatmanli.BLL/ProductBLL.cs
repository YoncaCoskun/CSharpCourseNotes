using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using CokKatmanli.DAL;
using CokKatmanli.Entity;

namespace CokKatmanli.BLL
{
    public class ProductBLL
    {
        public void UrunEkle(Product entity)
        {
            if (entity.UnitPrice>5000)
            {
                string kimlere = "g.seref@yahoo.ca";
                string baslik = "Yüksek Fiyatlı Ürün girişi";
                string icerik = "Sistem yuksek fiyatlı bir urun girişi yapıldı. <br/> Bilginize";

                MailHelper.MailGonder(kimlere,baslik,icerik);  //metodu static yaptık ve instance almadan bu islem yapıldı.
            }
            ProductDAL dal=new ProductDAL();
            dal.UrunEkle(entity);
        }
    }
}
