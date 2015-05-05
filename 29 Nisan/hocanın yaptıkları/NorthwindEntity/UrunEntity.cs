using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindEntity
{
    public class UrunEntity
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public double BirimFiyat { get; set; }
        public int StokMiktari { get; set; }

        public override string ToString()
        {
            return UrunAdi;
        }
    }
}
