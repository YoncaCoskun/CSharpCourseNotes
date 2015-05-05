using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotDavranislari
{
    public class Yigit  //bir metot virtual: olarak ısaretlendıgı zaman baska bır sınıf tarafından yenıden yazılabilir anlamında
    {
        public virtual string yogurtYe() 
        {

            return "Kaşıkla dalar";
        }
    }
}
