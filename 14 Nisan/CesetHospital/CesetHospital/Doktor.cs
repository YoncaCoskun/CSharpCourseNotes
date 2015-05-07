using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CesetHospital
{
    class Doktor
    {
        public string DoktorAdi { get; set; }  //property tanımladık

        public string DoktorSoyadi { get; set; }  //property tanımladık

        private string _brans;   //field tanımladık

        public string Brans {

            //encapsulation: bu get ve set le field i kapsül dısına cıkarmak.

            get { return _brans; }
            set { _brans = value; }
        }

      //propfull tab tab yapınca tum property ve field kalıbını getiriyor.(Yukarıdaki gibi)



        //private string _diplomaNumarasi;

        //public string DiplomaNumarasi
        //{
        //    get { return _diplomaNumarasi; }
        //    set { _diplomaNumarasi = value; }
        //}
        

        //ctrl +r+e : refactor + encapsulation gelir


        //-----------------------------------------------------------------------------------------------------

        public string kendiniTanit() {

            return this.DoktorAdi + " " + this.DoktorSoyadi;  //eger localde tanımlı baska bişi varsa onun ıcın this asıl publicteki doktoradını kullnmak ıcın yazarız this i.


        }
        
    }
}
