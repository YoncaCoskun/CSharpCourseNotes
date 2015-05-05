using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueType
{
    public struct Kitap  //ARTIK CLASS DEGIL STRUCT YAPILDI,clas oldugunda new anahtarı zorunluydu fakat bunda zorunlu degıl dırek olarak value type oluyor buyuzden de new yapmamıza gerek kalmıyor
    {
        public string KitapAdi { get; set; }

    }
}
