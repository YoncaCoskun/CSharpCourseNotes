using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CesetHospital
{
    class Doktor1cs
    {
        public string DoktorAdi { get; set; }  

        public string DoktorSoyadi { get; set; }  

        private string _brans;   

        public string Brans
        {


            get { return _brans; }
            set { _brans = value; }
        }

     
        public string kendiniAnlat()
        {

            return this.DoktorAdi + " " + this.DoktorSoyadi;  


        }
        
    }
}
