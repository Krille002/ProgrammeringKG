using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning11._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            //Skapa cirklar från klassen "Cirkel.cs"
            Cirkel vansterEllips = new Cirkel();
            vansterEllips.bredd = 50;
            vansterEllips.hojd = 100;
            vansterEllips.x = 200;
            vansterEllips.y = 200;

            Cirkel hogerEllips = new Cirkel();
            hogerEllips.bredd = 100;
            hogerEllips.hojd = 50;
            hogerEllips.x = 400;
            hogerEllips.y = 225;


            //Rita grejer

            e.Graphics.FillEllipse(new SolidBrush(Color.Red), vansterEllips.x, vansterEllips.y, vansterEllips.bredd, vansterEllips.hojd);
            e.Graphics.FillEllipse(new SolidBrush(Color.Blue), hogerEllips.x, hogerEllips.y, hogerEllips.bredd, hogerEllips.hojd);
        }
    }
}
