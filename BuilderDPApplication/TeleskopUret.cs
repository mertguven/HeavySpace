using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDPApplication
{
    class TeleskopUret
    {
        public void Uret(TeleskopBuilder Teleskop)
        {
            Teleskop.SetMarka();
            Teleskop.SetModel();
            Teleskop.SetBoyut();
            Teleskop.SetDiyaframBoyutu();
            Teleskop.SetYuva();
            Teleskop.SetTipi();
        }
    }
}
