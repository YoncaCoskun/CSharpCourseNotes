using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeOyun
{
    [Serializable]
    public class OyunKayit
    {
        public OyunKayit()
        {
            Kelebekler = new List<Kelebek>();
        }
        public string KayitAdi { get; set; }
        public int Skor { get; set; }
        public List<Kelebek> Kelebekler { get; set; }

        public override string ToString()
        {
            return KayitAdi;
        }
    }
}
