using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CesetHospital
{
    class Hasta
    {
        public string HastaAdi { get; set; }

        public string HastaSoyadi { get; set; }

        public string TelefonNo { get; set; }

        public DateTime DogumTarihi { get; set; }

        public string Poliklinik { get; set; }

        public string Doktoru { get; set; }



        public List<string> Ilaclar { get; set; }  //ilaclar diye bir list yaptık

        //private List<string> _Ilaclar;  bu yöntemle list in calısmasını saglayıp ılaclara hastaların ılaclarını eklerız

        //public List<string> Ilaclar
        //{
        //    get {
        //        if (_Ilaclar==null)
        //        {
        //            _Ilaclar = new List<string>();
        //        }
        //        return _Ilaclar; 
        //    }
        //    set { _Ilaclar = value; }
        //}


        //---------------------------------------------------------

        //constructor metodun ozellıklerı:
        //mutlaka class ile aynı isme sahip olmalı
        //geriye deger donmezzler void dahi yazılmaz

        internal Hasta() { //constructor metot(eger bız yazmadıysak otomatık sıstem kendı olusturur yazdydak olusturdugunu ıptal eder)
        //constructor lar nesnenin icerisinde tanımlanan yapılarını degıskenlerını propety lerine ram uzerıne yuklerler

            //propert lerın instance larini bu sekılde constructor ıle alırız

            Ilaclar=new List<string>();

        }

        public string KendiniTanit() {

            return this.HastaAdi + " " + this.HastaSoyadi;
        
        }
    }
}
