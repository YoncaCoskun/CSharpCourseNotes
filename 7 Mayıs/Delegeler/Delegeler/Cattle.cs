using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegeler
{
    public delegate void SicalikKontrolDelege(Cattle sender);
    public class Cattle
    {
        public Cattle()
        {
            _derece = 15;  //cattle bır baslangıc sıcaklıgını olusturduk.(constructor ıle)
        }
        public string Markasi { get; set; }

        public event SicalikKontrolDelege KontrolEt;


        private int _derece;
        public int Derece
        {
            get { return _derece; }
            set
            {
                _derece = value;
                if (_derece >= 100)
                {
                    if (KontrolEt != null)  //bu asagıdakı fon kun hata vermemesı ıcın kontrol et fonk un null kontrolu yapılmalı.classın ıcınde bır metot var ama dısardan gonderılırıp calıstırılıyor.yani baska bir yazılımcının yazmıs oldugu bir metodu calıstırmıs oluyoruz. bu metot kontrolet metodudur.
                        //EVENTLARIN AVANTAJI : DISARDA DURAN BİR METODU CLASS IN ICINDEYMIS GIBI CALISTIRIYORSUN.(metotlar;click,doubleClick.....)
                    {
                        KontrolEt(this);
                    }

                }
            }
        }


    }
}
