using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Övning11._6
{
    class Markor
    {
        //Markör som ska visa vart pil hamnar

        private int _x;
        private int _y;

        //Storlek är distans från yttre kant av kryss, till mitten av krysset. (Typ radie av krysset)
        private int storlek;
        

        //Konstruktor för att ta in värden

        public Markor(int x, int y, int Storlek)
        {
            _x = x;
            _y = y;
            storlek = Storlek;
        }

        //Egenskaper

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


        //Metod för att rita kryss

        public void Rita (Graphics g)
        {
            Pen traff = new Pen(Color.Red, 2);
            g.DrawLine(traff, _x - storlek, Y - storlek, _x + storlek, _y + storlek);
            g.DrawLine(traff, _x + storlek, _y - storlek, _x - storlek, _y + storlek);
        }


    }
}
