using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_EntityFrameworkCodeFirst
{
    public class GaleriDb:DbContext   //DbContext=direk bize dataaccesslayer ı olusturdu bile
    {
        public GaleriDb(): base("galeriMsDb")
        {
            //yeni bir property eklendiginden yenidenyaratmak icin yapıyoruz.
            Database.SetInitializer<GaleriDb>(new DbOlusturucu());
        }
        public DbSet<Araba> arabalar { get; set; }
    }


    public class DbOlusturucu:
              DropCreateDatabaseIfModelChanges<GaleriDb>  //tek amacı:IDatabaseInitializer tipinde veri olusturmak ıcın bunu yazdık.
    {

    }
    //----------------------------------------CodeFirst Attiributes--------------------------------

    [Table("Arabalar")]   //modelfirst te direk tabloyu olusturabılıyoruz burda tabloyu kodlarla olusturuyoruz.bu sekılde  attribute vererek tablonun  ic ozellıklerını doldurmayı saglıyoruz.

    public class Araba
    {
        [Key]
        public int ArabaId { get; set; }  //primary key i ve otomatik sıralamayı veriyor.

        [MaxLength(50)]   //nvarchar (50)  olması ıcın yaptık.
        [Column(TypeName="varchar")]      //nvarchar daki n i kaldırmak icin bunu yaptık.
        [Required]  //not null
        public string Marka { get; set; }
        public string Model { get; set; }

        public string Telefon { get; set; }
       
        public override string ToString()
        {
            return this.Marka + " " + this.Model;

        }
    }
}
