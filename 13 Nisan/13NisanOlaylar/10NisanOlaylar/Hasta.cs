using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10NisanOlaylar
{
    class Hasta
    {
        //Bir class ın içerisinde neler olmalıdır?
        //1- field      :class a özel bilgi tasıyabilen alanlardır.(class dışından erişilemez.)
        //2-property    :class dışına bilgi taşıyabilen alanlardır.
        //3-method      :class için işlem yapabilen yapılardır.
        //4-constructor :class ın dogum anıdır.
        //5-destructor  :class ın ölüm anıdır.(ram den yok etme)

        //class icindeki nesnelere dısarıdan erisim seklini belırten kodlara Access modifier(Erişim Belirleyici) denir.

        //Erişim Belirleyiciler;
        //public    :her yerden erişebilir.
        //private   :sadece class içinden erişilebilir.
        //internal  :sadece proje(namespace) içerisinden erişilir.Başka bir projeden erişilemez.
        //protected :kalıtım alınan diger class lardan erişilir.
        //internal protected:sadece proje içerisinden kalıtım alan diger class lardan erişilir.

        //-------------------------------------------------------------------------------------------------

        private string _hastaligi;  //field örnegi

        /// <summary>
        /// Hastaya ait isim bilgisi bulunur //bilgi olarak hastaAdin da görülür
        /// </summary>
        public string hastaAdi { get; set; }  //property örnegi



    }
}
