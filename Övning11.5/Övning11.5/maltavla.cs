using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Övning11._5
{
    class Maltavla
    {
        //Privat mittpunkt som inte ska ändras
        private int _x = 0;
        private int _y = 0;

        //Måltavlas radie
        private float radie = 0;

        //Konstruktor för att läsa in x,_y och radie första gången
        public Maltavla( int x, int y, float r)
        {
            _x = x;
            _y = y;
            radie = r;
        }

        //Egenskaper för att redigera (get and set) privata variabler
        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        public float Radie
        {
            get
            {
                return radie;
            }
            set
            {
                if (value < 0)
                    radie = -value;
                else
                    radie = value;
            }
        }

        //Metoder:
        public void Rita(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.White), (_x - radie), (_y - radie), 2 * radie, 2 * radie);
            g.FillEllipse(new SolidBrush(Color.Black), (_x - radie * 0.8f), (_y - radie * 0.8f), 2 * radie * 0.8f, 2 * radie * 0.8f);
            g.FillEllipse(new SolidBrush(Color.Blue), (_x - radie * 0.6f), (_y - radie * 0.6f), 2 * radie * 0.6f, 2 * radie * 0.6f);
            g.FillEllipse(new SolidBrush(Color.Red), (_x - radie * 0.4f), (_y - radie * 0.4f), 2 * radie * 0.4f, 2 * radie * 0.4f);
            g.FillEllipse(new SolidBrush(Color.Yellow), (_x - radie * 0.2f), (_y - radie * 0.2f), 2 * radie * 0.2f, 2 * radie * 0.2f);
            g.DrawEllipse(new Pen(Color.Black), (_x - radie), (_y - radie), 2 * radie, 2 * radie);
        }
    }
}
