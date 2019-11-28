using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Övning11._5
{
    class Sikte
    {
        //Skapa medlemsvariabler
        private int _x;
        private int _y;
        private int radie = 30;

        //konstruktor för att sätta första värden

        public Sikte (int x, int y)
        {
            _x = x;
            _y = y;
        }

        ///Egenskaper för att flytta sikte
        //Flytta x-led
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

        //Flytta y-led

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


        //Metod för att rita siktet till skärmen

        public void Rita(Graphics g)
        {
            Pen sikteKantFarg = new Pen(Color.Green, 3);
            Pen sikteFarg = new Pen(Color.Green, 1);

            g.DrawEllipse(sikteKantFarg, _x - radie, _y - radie, radie * 2, radie * 2);
            g.DrawLine(sikteFarg, _x, _y - radie, _x, _y + radie);
            g.DrawLine(sikteFarg, _x - radie, _y, _x + radie, _y);
        }
    }
}
