using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Övning14._4
{
    class Papper
    {

        private int X;
        private int Y;
        private int bredd_;
        private int hojd_;

        public Papper(int x, int y, int bredd, int hojd)
        {
            X = x;
            Y = y;
            bredd_ = bredd;
            hojd_ = hojd;
        }

        public void Rita(Graphics g)
        {
            Pen penna = new Pen(Color.Red);
            g.DrawRectangle(penna, X, Y, bredd_, hojd_);
        }

    }
}
