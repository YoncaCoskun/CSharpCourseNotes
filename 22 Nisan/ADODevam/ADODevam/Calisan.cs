using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODevam
{
   public class Calisan
    {
        public int CalisanId { get; set; }
        public string CalisanAdi { get; set; }
        public string CalisanSoyadi { get; set; }

        public string Memleketi { get; set; }

        public string Notlar { get; set; }

        public override string ToString()
        {
            return CalisanAdi+" "+CalisanSoyadi;
        }

    }
}
