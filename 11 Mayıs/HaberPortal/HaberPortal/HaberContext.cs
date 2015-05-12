using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberPortal
{
    public class HaberContext:DbContext
    {
        public HaberContext():base("server=.;database=HaberDb; integrated security=sspi;")
        {

        }
        public DbSet<Haber> Haberler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
    }

    [Table("Kategoriler")]
    public class Kategori
    {
        [Key]
        public int KategoriId { get; set; }

        [MaxLength(50),Required]
        public string KategoriAdi { get; set; }

        [MaxLength(500)]
        public string Aciklamasi{ get; set; }

        public override string ToString()
        {
            return this.KategoriAdi;
        }

    }
    [Table("Haberler")]
    public class Haber
    {
        [Key]
        public int HaberId { get; set; }

        [MaxLength(100),Required]
        public string HaberBaslik { get; set; }
        public string  HaberIcerik { get; set; }

        public virtual Kategori Kategorisi { get; set; }  //virtual dedıgımızde bunun sıfırdan olusturulmaması gerektıgını bu ozellıgı kategorı tablosundan alması gerektıgını soyledık.Bu sekılde baglantılı bır yapı olusturacak.

    
        public DateTime HaberTarihi { get; set; }

        public override string ToString()
        {
            return this.HaberBaslik;
        }

    }
}
