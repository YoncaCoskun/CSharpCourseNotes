using NorthwindDAL;
using NorthwindEntity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindBLL
{
    public class ProductBll
    {
        public bool kaydet(ProductEntity urun)
        {
            if (string.IsNullOrEmpty(urun.ProductName))
            {
                throw new Exception("urun Adı boş gecılemez");
            }
            try
            {
                using (ProductDal dal = new ProductDal()) //kaydet fonk calısıp calısmadıgını kontrol etmek ıcın try ıcınde calıstıtırırız.
                {
                    return dal.kaydet(urun);
                }

            }
            catch (SqlException sqlHata) //eger proc ıle ılgılı hata varsa burası calısacak
            {
                throw sqlHata;
            }
            catch (Exception ex)
            {
                //kullanıcıya gostermek ıstemedıgın hataları mail olarak kendimize aktardıgımız kısım burasıdır.mail işlemleri burada yapılır.

                throw new Exception("istenmeyen bir hata olustu.Lutfen yöneticinizle gorusunuz");
            }
        }
        public bool guncelle(ProductEntity urun)
        {
            try
            {
                using (ProductDal dal = new ProductDal())  //var dal=new ProductDal()  ile aynı anlamda
                {
                    return dal.guncelle(urun);
                }
            }
                catch(SqlException sqlHata){
                    if (sqlHata.State==100)
                    {
                        throw sqlHata;
                    }
                    else if(sqlHata.ErrorCode==547)
                    {
                        throw new Exception("stok miktarı 0 dan kucuk olamaz.");
                    }
                    else
                    {
                        //kendimize mail atabılırız burada
                        return false;
                    }
                }
            catch (Exception)
            {
                //kendimize mail
                return false;
                
            }
        }

        public List<ProductEntity> urunleriVer()
        {
            try
            {
                using (ProductDal dal=new ProductDal())
                {
                    return dal.tumUrunleriVer();
                }

            }
            catch (Exception)
            {

                return null;
            }
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------------------------------

        public bool kategoriKaydet(CategoryEntity kategori)
        {
            if (string.IsNullOrEmpty(kategori.CategoryName))
            {
                throw new Exception("kategori Adı boş gecılemez");
            }
            try
            {
                using (ProductDal dal = new ProductDal())
                {
                    return dal.kategoriKaydet(kategori);
                }

            }
            catch (SqlException sqlHata) 
            {
                throw sqlHata;
            }
            catch (Exception ex)
            {
          

                throw new Exception("istenmeyen bir hata olustu.Lutfen yöneticinizle gorusunuz");
            }
        }


        public bool kategoriGuncelle(CategoryEntity kategori)
        {
            try
            {
                using (ProductDal dal = new ProductDal()) 
                {
                    return dal.kategoriGuncelle(kategori);
                }
            }
            catch (SqlException sqlHata)
            {
                if (sqlHata.State == 100)
                {
                    throw sqlHata;
                }
                else
                {   
                    return false;
                }
            }
            catch (Exception)
            {
                return false;

            }
        }

        public List<CategoryEntity> kategoriGoster()
        {
            try
            {
                using (ProductDal dal = new ProductDal())
                {
                    return dal.tumKategorileriGoster();
                }

            }
            catch (Exception)
            {

                return null;
            }
        }

    }
}
