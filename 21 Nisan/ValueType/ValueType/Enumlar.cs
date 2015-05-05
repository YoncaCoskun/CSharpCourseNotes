using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueType
{
    public enum OdemeSekilleri : byte  //objetc, ve ınt akrabası oldugu ıcın byte hem daha kucuk boyutta yeterlı oldugu ıcın dedık
    {
        KrediKarti = 1,
        Nakit = 10,
        MailOrder = 20,
        Paypal = 30,  //araya baska bısılerde ekleyebılmek ıcın bu sekılde aralıklı yapıyoruz
        Havale = 40,
        EFT = 50
    }
    public enum MusteriTurleri
    {
        ToptanYukluMusteri,
        ToptanKucukMusteri,
        BireyselMusteri,
        ToptanMusteri
    }
}
