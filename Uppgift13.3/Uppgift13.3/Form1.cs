using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift13._3
{
    public partial class Form1 : Form
    {
        //Kö
        Queue<Ansikte> ansikten = new Queue<Ansikte>();

        //Medlemsvariabler
        int musX;
        int musY;
        int diameter;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnTaBort_Click(object sender, EventArgs e)
        {
            ansikten.Dequeue();
            Invalidate();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            //Egenskaper för ansikte
            musX = e.X;
            musY = e.Y;
            diameter = 20;

            //Temporärt ansikte med egenskaper ovan, för att sättas in i kö
            Ansikte tempAnsikte = new Ansikte(musX, musY, diameter);

            //Lägga in tempAnsikte i kö och rita fönster på nytt
            ansikten.Enqueue(tempAnsikte);
            Invalidate();

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //Graphics för att kunna bifoga till "Rita" metod i klassen "Ansikte"
            Graphics g = e.Graphics;

            //Rita vartenda ansikte som existerar i kön
            for(int i = 0; i < ansikten.Count; i++)
            {
                Ansikte tempAnsikte2 = ansikten.ElementAt(i);

                tempAnsikte2.Rita(g);
            }
            
        }
    }
}
