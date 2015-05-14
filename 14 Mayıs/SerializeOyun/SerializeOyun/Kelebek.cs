using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerializeOyun
{
    [Serializable]
    public class Kelebek
    {
        public Kelebek()
        {
            genislik = 70;
            yukseklik = 70;
        }
        public int xKoord { get; set; }
        public int yKoord { get; set; }
        public int genislik { get; set; }
        public int yukseklik { get; set; }

        public byte kelebekIndex { get; set; }


    }
}
