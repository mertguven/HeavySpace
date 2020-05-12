using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDPApplication
{
    class Ortak
    {
        public void Listele()
        {
            if (Form1.zoomex.Checked)
            {
                TeleskopBuilder teleskop = new ZoomexBuilder();
                TeleskopUret uret = new TeleskopUret();
                uret.Uret(teleskop);
                islem(teleskop, "zoomex");
            }
            else if (Form1.bushman.Checked)
            {
                TeleskopBuilder teleskop = new BushmanBuilder();
                TeleskopUret uret = new TeleskopUret();
                uret.Uret(teleskop);
                islem(teleskop, "bushman");
            }
            else if (Form1.celestron.Checked)
            {
                TeleskopBuilder teleskop = new CelestronBuilder();
                TeleskopUret uret = new TeleskopUret();
                uret.Uret(teleskop);
                islem(teleskop, "celestron");
            }
            else if (Form1.nikon.Checked)
            {
                TeleskopBuilder teleskop = new NikonBuilder();
                TeleskopUret uret = new TeleskopUret();
                uret.Uret(teleskop);
                islem(teleskop, "nikon");
            }
        }
        private void islem(TeleskopBuilder teleskop, String foto)
        {
            Form1.marka.Text = teleskop.Teleskop.Marka;
            Form1.model.Text = teleskop.Teleskop.Model;
            Form1.boyut.Text = teleskop.Teleskop.Boyut.ToString() + " cm";
            Form1.dboyut.Text = teleskop.Teleskop.DiyaframBoyutu.ToString() + " mm";
            Form1.tip.Text = teleskop.Teleskop.Tipi;
            Form1.yuva.Text = teleskop.Teleskop.Yuva;
            switch (foto)
            {
                case "zoomex":
                    Form1.pictureBox.Image = Properties.Resources.zoomex;
                    break;
                case "bushman":
                    Form1.pictureBox.Image = Properties.Resources.bushman;
                    break;
                case "celestron":
                    Form1.pictureBox.Image = Properties.Resources.celestron;
                    break;
                case "nikon":
                    Form1.pictureBox.Image = Properties.Resources.nikon;
                    break;
            }
            
        }
    }
}
