using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{
    public abstract class Hayvan
    {
        public int Aclik { get; set; }

        public int Uyku { get; set; }

        public int Temizlik { get; set; }

        public virtual string kaydet() {
            return " db ye kaydedildi";
        }

      //bir metotun abstract olabılmesı ıcın class ın da abstract olması lazım.bu classı ınherıtance alan dıger class lar bu metodu ezmek zorunda kalır. (override edilkmek zorunda kalır)
        //abstract metod sadece abstract class larda yazılır.
        //abstract metotların abstract class larda icerisi bostur.


        public abstract string resimGoster();
    }
}
