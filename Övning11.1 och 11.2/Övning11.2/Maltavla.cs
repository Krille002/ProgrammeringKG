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
        int x = 400;
        int y = 350;

        //Måltavlas radie
        public float radie = 0;

        //Metoder:
        public void Rita (Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.White), x, y, radie, radie);
            g.FillEllipse(new SolidBrush(Color.Black), x, y, (radie * 0.8f), (radie * 0.8f));
            g.FillEllipse(new SolidBrush(Color.Blue), x, y, (radie * 0.6f), (radie * 0.6f));
            g.FillEllipse(new SolidBrush(Color.Red), x, y, (radie * 0.4f), (radie * 0.4f));
            g.FillEllipse(new SolidBrush(Color.Yellow), x, y, (radie * 0.2f), (radie * 0.2f));
            g.DrawEllipse(new Pen(Color.Black), x, y, radie, radie);
        }
    }
}
