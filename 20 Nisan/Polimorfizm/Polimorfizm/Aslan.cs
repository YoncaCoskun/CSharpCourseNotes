using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{
    public sealed class Aslan:Kedi
    {
        //bıdaha baska bir sınıf aslandan tureyemeyecek

        //sealed:instance alıyor,inheritance alamıcak durumdur.Yani bir class sealed isaretlendiginde o class tan inheritance alınması engellenir,sadece instance alınması saglanır
        public override string resimGoster()
        {
            throw new NotImplementedException();
        }
    }
}
