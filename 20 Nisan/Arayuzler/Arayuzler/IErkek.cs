using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arayuzler
{
    //interface:belli bir kalıp belirtmek ıcın kullanılır.
    //interface ler I ifadesi ıle baslarlar.
    //property ler olurlar fakat access modifier yazılmaz.
    //metotlar olur ama ıcerısı yazılmaz(abstract metot gibidir)
    //degısken olur fakat baslangıc degeri aldıktan sonra degerı degıstırılemez.
    public interface IErkek
    {
        string kolonyaMarkasi { get; set; }

        string jiletMarkasi { get; set; }

        void tirasOl();

        void kolonyaSur();

    }
}
