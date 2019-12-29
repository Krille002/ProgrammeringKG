using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Övning13._1
{
    class Rektangel
    {
        //Variabler
        private int x = 0;
        private int y = 0;
        private int h = 50;
        private int b = 75;


        //Konstruktor
        public Rektangel (int X, int Y, int hojd, int bredd)
        {
            x = X;
            y = Y;
            h = hojd;
            b = bredd;
        }


        //Egenskaper

            //X-koordinat
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
            //Y-koordinat
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
            //Bredd
        public int Bredd
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
            //Höjd
        public int Hojd
        {
            get
            {
                return h;
            }
            set
            {
                h = value;
            }
        }

        //Metoder

               //Rita Rektanglar
        public void Rita (Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Red), x, y, b, h);

        }

        public bool Träffad(int musX, int musY)
        {
            //Kolla om muspekare är i någon rektangel
        }
    }
}
