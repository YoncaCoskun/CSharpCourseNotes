using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlSerializer_ORNEK
{
    [XmlRoot("News")]  //xml e donustugu zaman class ın ismini news olarak donusturmeyı yapıyor.
    public class Haber
    {
        [XmlAttribute("NewsId")]  //haberıd nın attrıbute sekılde tutulmasını ıstersek bunu yapmalıyız.(isimde verebılıyoruz)
        public int HaberId { get; set; }

        [XmlElement("NewsTitle")] //haberbaslıgını ingilizceleştirdik.
        public string HaberBasligi { get; set; }
        public string HaberIcerik { get; set; }
        public DateTime HaberTarihi { get; set; }

        [XmlIgnore]  //eskime guun sayısının xml e donusmesını engellemek ıcın bu attrıbute koyduk.
        public int EskimeGunSayisi {

            get {
                //haberın nekadar gun onceki haber oldugunu gosterme
                //datetime olsalarda geriye datetime tipinden yerıne timespan tipinden donuyor.
                //TimeSpan tt=DateTime.Now-HaberTarihi;
                //tt.Days;
                return (DateTime.Now - HaberTarihi).Days;
            
            } 
        
        } 
    }
}
