using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDPApplication
{
    class ZoomexBuilder : TeleskopBuilder
    {
        public ZoomexBuilder()
        {
            teleskop = new Teleskop();
        }

        public override void SetMarka() => teleskop.Marka = "Zoomex";

        public override void SetModel() => teleskop.Model = "F36050TX";

        public override void SetBoyut() => teleskop.Boyut = 40;

        public override void SetDiyaframBoyutu() => teleskop.DiyaframBoyutu = 30;

        public override void SetTipi() => teleskop.Tipi = "Aynalı";

        public override void SetYuva() => teleskop.Yuva = "Ekvatoral";
    }
}
