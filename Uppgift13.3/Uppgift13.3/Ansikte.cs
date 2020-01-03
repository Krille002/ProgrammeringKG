using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Uppgift13._3
{
    class Ansikte
    {
        //Medlemsvariabler
        private int X;
        private int Y;
        private int diameter = 20;


        //Konstruktor
        public Ansikte(int x, int y, int d)
        {
            X = x;
            Y = y;
            diameter = d;
        }


        //Egenskaper (Behövs inte)


        //metoder

        public void Rita(Graphics g)
        {
            int radie = diameter / 2;
            Brush AnsikteBrush = new SolidBrush(Color.LightPink);
            Brush OgonBrush = new SolidBrush(Color.Blue);

            //Ansikte
            g.FillEllipse(AnsikteBrush, X - radie, Y - radie, diameter, diameter);

            //Vänster öga
            g.FillRectangle(OgonBrush, (X - 5), (Y - 5), 4, 4);

            //Höger öga
            g.FillRectangle(OgonBrush, (X + 3), (Y - 5), 4, 4);
        }
    }
}
