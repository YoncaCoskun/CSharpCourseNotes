using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwindEntities context = new NorthwindEntities();

            //var calisanlar = context.Employees.ToList();
            /*
                        List<string> calisanAdlari2 = context.Employees
                                      .Select(x => x.FirstName).ToList();
 
                        List<string> calisanAdlari = (from c in context.Employees
                                                                            select c.FirstName).ToList();


            */
            /*
            List<Product> urunler = context.Products
                                                        .Where(x => x.UnitPrice > 50)
                                                        .ToList();



            List<Product> urunle2 = (from p in context.Products
                                                        where p.UnitPrice > 50
                                                        select p)
                                                        .ToList();
            */
            /*
            //anonymous type
            var urunAdlari = context.Products
                                                        .Where(a => a.UnitsInStock > 20)
                                                        .Select(x => new
                                                        {
                                                            x.ProductName,
                                                            x.UnitsInStock
                                                        })
                                                        .ToList();
                   //alias verilebilir
                 //        UrunAd = x.ProductName,
               //     Stok = x.UnitsInStock
             //

            var urunAdlari2 = (from p in context.Products
                                              where p.UnitsInStock > 20
                                              select 
                                              new
                                              {
                                                  p.ProductName, 
                                                  p.UnitsInStock
                                              }).ToList();
            */

            // JOIN
            /*/
            var urunler = context.Products
                                                  .Include(x => x.Category)
                                                  //.Include("Category")  
                                                  .ToList();

            //inner join
            var urunler2 = (from p in context.Products
                                        join c in context.Categories
                                        on p.CategoryID equals c.CategoryID
                                        select new {p, c}).ToList();

            //outer join 
            var urunler3 = (from p in context.Products
                            join c in context.Categories
                            on p.CategoryID equals c.CategoryID  into joinedC
                            from  c in  joinedC.DefaultIfEmpty()
                            select new { p, c }).ToList();
            */




            //navigation property
            //string kategori = urunler[0].Category.CategoryName;
        }
    }
}
