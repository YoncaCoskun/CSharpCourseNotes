using DbAccess;
using NorthwindEntity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDAL
{
    public class ProductDal : IDisposable           //dal genelde disposable olarak isaretlenır
    {
        //insert,update,select,select by id

        public bool kaydet(ProductEntity entity)
        {
            object sonuc = DB.executeScalar("insert into Products(ProductName,UnitPrice,UnitsInStock) values(@p1,@p2,@p3) select scope_identity()", false,
             new SqlParameter("@p1", entity.ProductName),
             new SqlParameter("@p2", entity.UnitPrice),
             new SqlParameter("@p3", entity.UnitsInStock)
             );

            if (sonuc == null)
            {
                return false;
            }
            entity.ProductID = Convert.ToInt32(sonuc);
            return true;

        }

        public bool guncelle(ProductEntity entity)
        {
            int sonuc = DB.executeNonQuery("UrunGuncelle", true,
                new SqlParameter("@urunAdi", entity.ProductName),
                new SqlParameter("@birimFiyat", entity.UnitPrice),
                new SqlParameter("@stokMiktari", entity.UnitsInStock),
                new SqlParameter("@urunId", entity.ProductID)
                );
            return sonuc > 0;

        }

        public List<ProductEntity> tumUrunleriVer()
        {
            List<ProductEntity> liste = new List<ProductEntity>();
            SqlDataReader reader = DB.executeReader("select * from Products", false);
            while (reader.Read())
            {
                liste.Add(new ProductEntity
                {
                    ProductID = Convert.ToInt32(reader["ProductID"]),
                    ProductName = reader["ProductName"].ToString(),
                    UnitPrice = Convert.ToDouble(reader["UnitPrice"]),
                    UnitsInStock = Convert.ToInt32(reader["UnitsInStock"])
                });
            }
            reader.Close();
            return liste;
        }
        public ProductEntity urunVerIdIle(int id)
        {
            SqlDataReader reader = DB.executeReader("select*from Products where ProductID=@id", false,
                new SqlParameter("@id", id));
            ProductEntity entity = new ProductEntity();

            reader.Read();  //birtane urun cektıgımız ıcın whıle yapmadık.

            entity.ProductID = id;
            entity.ProductName = reader["ProductName"].ToString();
            entity.UnitsInStock = Convert.ToInt32(reader["UnitsInStock"]);
            entity.UnitPrice = Convert.ToDouble(reader["UnitPrice"]);

            reader.Close();

            return entity;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public bool kategoriKaydet(CategoryEntity entity)
        {
            object sonuc = DB.executeScalar("insert into Categories(CategoryName,Description) values(@p1,@p2) select scope_identity()", false,
                new SqlParameter("@p1", entity.CategoryName),
                new SqlParameter("@p2", entity.Description)
             
            );

            if (sonuc == null)
            {
                return false;
            }
            entity.CategoryID = Convert.ToInt32(sonuc);
            return true;



        }

        public bool kategoriGuncelle(CategoryEntity entity)
        {
            int sonuc = DB.executeNonQuery("kategoriGuncelle", true,
               new SqlParameter("@kategoriAdi", entity.CategoryName),
               new SqlParameter("@tanim", entity.Description),
               new SqlParameter("@kategoriId", entity.CategoryID)
               );
            return sonuc > 0;
        }

        public List<CategoryEntity> tumKategorileriGoster()
        {
            List<CategoryEntity> listele = new List<CategoryEntity>();
            SqlDataReader reader = DB.executeReader("select * from Categories", false);
            while (reader.Read())
            {
                listele.Add(new CategoryEntity
                {
                    CategoryID = Convert.ToInt32(reader["CategoryID"]),
                    CategoryName = reader["CategoryName"].ToString(),
                    Description = reader["Description"].ToString()

                });
            }
            reader.Close();
            return listele;
        }

        public CategoryEntity kategoriVerIdIle(int id)
        {
            SqlDataReader reader = DB.executeReader("select*from Categories where CategoryID=@id", false,
                new SqlParameter("@id", id));
            CategoryEntity entity = new CategoryEntity();

            reader.Read();  

            entity.CategoryID = id;
            entity.CategoryName = reader["CategoryName"].ToString();
            entity.Description = reader["Description"].ToString();
          
            reader.Close();

            return entity;
        }


    }
}
