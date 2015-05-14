using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSerilizasyon
{
    [Serializable]                         //artık bu class harddisk uzerınde yazılabılır hale geliyor.[Serializable]
    public class Ogrenci
    {
        public string OgrenciAdi { get; set; }
        public string OgrenciSoyadi { get; set; }
        public bool Cinsiyet { get; set; }
        public string EvAdresi { get; set; }
        public string Telefon { get; set; }

        public override string ToString()
        {
            return this.OgrenciAdi+" "+this.OgrenciSoyadi;
        }

    }
}
