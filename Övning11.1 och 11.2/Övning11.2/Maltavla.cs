using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Övning11._2
{
    class Maltavla
    {
        //Privat mittpunkt som inte ska ändras
        public int x = 0;
        public int y = 0;

        //Måltavlas radie
        public float radie = 0;

        //Metoder:
        public void Rita (Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.White), (x - radie), (y - radie), 2 * radie, 2 * radie);
            g.FillEllipse(new SolidBrush(Color.Black), (x - radie * 0.8f), (y - radie * 0.8f), 2 * radie * 0.8f, 2 * radie * 0.8f);
            g.FillEllipse(new SolidBrush(Color.Blue), (x - radie * 0.6f), (y - radie * 0.6f), 2 * radie * 0.6f, 2 * radie * 0.6f);
            g.FillEllipse(new SolidBrush(Color.Red), (x - radie * 0.4f), (y - radie * 0.4f), 2 * radie * 0.4f, 2 * radie * 0.4f);
            g.FillEllipse(new SolidBrush(Color.Yellow), (x - radie * 0.2f), (y - radie * 0.2f), 2 * radie * 0.2f, 2 * radie * 0.2f);
            g.DrawEllipse(new Pen(Color.Black), (x - radie), (y - radie), 2 * radie, 2 * radie);
        }
    }
}
