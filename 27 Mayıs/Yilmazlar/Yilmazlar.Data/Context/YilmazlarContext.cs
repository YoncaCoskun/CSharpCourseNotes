using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Globalization;
using System.Linq;
using System.Reflection;
using Yilmazlar.Domain;

namespace Yilmazlar.Data.Context
{
    public class YilmazlarContext : DbContext
    {
        public YilmazlarContext()
            : base("YilmazlarContext")
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //ProductName max 50 yaptık
            modelBuilder.Entity<Product>().Property(t => t.ProductName).HasMaxLength(50);
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            foreach (DbEntityEntry kayit in ChangeTracker.Entries())
            {
                PropertyInfo nesne = kayit.Entity.GetType().GetProperty("RegisterDate");

                if (nesne != null)
                {
                    if (kayit.State == EntityState.Added)
                    {
                        kayit.Property("RegisterDate").CurrentValue = DateTime.Now;
                    }
                    //else if (kayit.State == EntityState.Modified)
                    //{
                    //    kayit.Property("RegisterDate").IsModified = false;
                    //}
                }

            }
            return base.SaveChanges();





            //foreach (var kayit in ChangeTracker.Entries().Where(x => x.Entity.GetType().GetProperty("RegisterDate") != null))
            //{

            //}
            //return base.SaveChanges();
        }
    }
}
