using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueType
{
    public class Siparis
    {
        public int SiparisId { get; set; }

        public string MusteriAdi { get; set; }

        public double ToplamTutar { get; set; }

        public OdemeSekilleri odemeSekli { get; set; }

        public MusteriTurleri musteriTuru { get; set; }

    }
}
