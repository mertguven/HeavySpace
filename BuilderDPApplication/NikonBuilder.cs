using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDPApplication
{
    class NikonBuilder : TeleskopBuilder
    {
        public NikonBuilder()
        {
            teleskop = new Teleskop();
        }

        public override void SetMarka() => teleskop.Marka = "Nikon";

        public override void SetModel() => teleskop.Model = "Prostaff 5";

        public override void SetBoyut() => teleskop.Boyut = 18;

        public override void SetDiyaframBoyutu() => teleskop.DiyaframBoyutu = 73;

        public override void SetTipi() => teleskop.Tipi = "Aynalı";

        public override void SetYuva() => teleskop.Yuva = "Altazimut";
    }
}
