using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDPApplication
{
    abstract class TeleskopBuilder
    {
        protected Teleskop teleskop;
        public Teleskop Teleskop
        {
            get { return teleskop; }
        }

        public abstract void SetMarka();
        public abstract void SetModel();
        public abstract void SetTipi();
        public abstract void SetBoyut();
        public abstract void SetDiyaframBoyutu();
        public abstract void SetYuva();
    }
}
