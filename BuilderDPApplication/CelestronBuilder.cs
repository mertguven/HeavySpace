using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDPApplication
{
    class CelestronBuilder : TeleskopBuilder
    {
        public CelestronBuilder()
        {
            teleskop = new Teleskop();
        }

        public override void SetMarka() => teleskop.Marka = "Celestron";

        public override void SetModel() => teleskop.Model = "PowerSeeker 127EQ";

        public override void SetBoyut() => teleskop.Boyut = 28;

        public override void SetDiyaframBoyutu() => teleskop.DiyaframBoyutu = 80;

        public override void SetTipi() => teleskop.Tipi = "Mercekli";

        public override void SetYuva() => teleskop.Yuva = "Ekvatoral";

        
    }
}
