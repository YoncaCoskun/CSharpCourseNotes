using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GenericOrnekler
{
    public class UniversalKumanda<T>
    {
        public void Ekle(T nesne)
        {
            //---
        }

        public T Getir()
        {
            return default(T);
        }

        public string DenemeMetot(int sayi)
        {
            return sayi + "";
        }

    }
}
