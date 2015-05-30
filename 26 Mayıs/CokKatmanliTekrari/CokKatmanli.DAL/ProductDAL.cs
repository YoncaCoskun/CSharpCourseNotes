using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CokKatmanli.Entity;

namespace CokKatmanli.DAL
{
    public class ProductDAL
    {
        //Urun ekle metodu,parametre olarak product entitysi alacak ve onu Product tablosuna yazacak,ADO.NET(northwind)

        public void UrunEkle(Product entity)
        {
           string connectStr=ConfigurationManager.ConnectionStrings["NorthConnect"].ConnectionString;
            SqlConnection connect=new SqlConnection(connectStr);
            SqlCommand  command=new SqlCommand("insert into Products(ProductName,UnitsInStock,UnitPrice) values(@name,@stock,@price)",connect);

            
            command.Parameters.AddWithValue("@name",entity.ProductName);
            command.Parameters.AddWithValue("@stock",entity.UnitsInStock);
            command.Parameters.AddWithValue("@price",Convert.ToDecimal(entity.UnitPrice));

            connect.Open();
            int etkilenenSatirSayisi=command.ExecuteNonQuery();
            connect.Close();



        }
    }
}
