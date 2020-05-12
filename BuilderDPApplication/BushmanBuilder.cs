using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDPApplication
{
    class BushmanBuilder : TeleskopBuilder
    {
        public BushmanBuilder()
        {
            teleskop = new Teleskop();
        }

        public override void SetMarka() => teleskop.Marka = "Bushman";

        public override void SetModel() => teleskop.Model = "70-400";

        public override void SetBoyut() => teleskop.Boyut = 38;

        public override void SetDiyaframBoyutu() => teleskop.DiyaframBoyutu = 60;

        public override void SetTipi() => teleskop.Tipi = "Mercekli";

        public override void SetYuva() => teleskop.Yuva = "Altazimut";
    }
}
