using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueType
{
    public enum Yonler  //numeric turunden bırseye donustu artık class degıl.value type tır,stack kısmında bulunur.Heap kısmını kullanmıyor(value type oldugu ıcın)
    {
        Sag,
        Sol,
        Yukari=5, //bu durumda yukarı 2 degıl 5 olur(bu 5 olunca bı sonrakı 6 oluyor)
        Asagi  //aynı message boz button gıbı bunlarıda kullanabılırız
    }
}
