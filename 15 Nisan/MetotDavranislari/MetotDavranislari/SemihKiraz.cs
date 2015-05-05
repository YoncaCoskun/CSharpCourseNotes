using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotDavranislari
{
    class SemihKiraz:Yigit
    {
        public override string yogurtYe()
        {
            return "Hapur hüpür yer"; 
            //return base.yogurtYe();  //class ıcındekı bas dırek yıgıt klasını alır.Yani bir classın ıcındeysek o klasa this derken ama turedıgı klasa yanı babaya base ıle hıtap edıyoruz.yigitin icindeki yogurtye yi almayı anlar.
        }
    }
}
