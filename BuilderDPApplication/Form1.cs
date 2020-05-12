using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace BuilderDPApplication
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public Form1()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }
        public static PictureBox pictureBox;
        public static RadioButton zoomex;
        public static RadioButton bushman;
        public static RadioButton celestron;
        public static RadioButton nikon;
        public static TextBox marka;
        public static TextBox model;
        public static TextBox boyut;
        public static TextBox dboyut;
        public static TextBox tip;
        public static TextBox yuva;
        Ortak ortak = new Ortak();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void getirBtn_Click(object sender, EventArgs e)
        {
            ortak.Listele();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox = pictureBox2;
            zoomex = zoomexRBtn;
            bushman = bushmanRBtn;
            celestron = celestronRBtn;
            nikon = nikonRBtn;
            marka = markaTxt;
            model = modelTxt;
            boyut = boyutTxt;
            dboyut = dBoyutuTXT;
            tip = tipTxt;
            yuva = yuvaTxt;
        }
    }
}
