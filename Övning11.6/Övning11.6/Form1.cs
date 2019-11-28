using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning11._6
{
    public partial class Form1 : Form
    {
        Maltavla mal;
        Sikte sikte;
        Markor traff;

        int pilar = 5;

        public Form1()
        {
            InitializeComponent();

            //Starta klasser för måltavla och sikte
            mal = new Maltavla(ClientSize.Width / 2, ClientSize.Height / 2, 60);
            sikte = new Sikte(ClientSize.Width / 2, ClientSize.Height / 2);

            //Skriva startvärde till label för antal pilar kvar
            lblPilar.Text = pilar.ToString();
        }

        //Bifoga graphics till klasser för att rita
        protected override void OnPaint(PaintEventArgs e)
        {
            mal.Rita(e.Graphics);
            sikte.Rita(e.Graphics);

            if (traff != null) traff.Rita(e.Graphics);
        }

        //Rita sikte där muspekaren befinner sig
        protected override void OnMouseMove(MouseEventArgs e)
        {
            sikte.X = e.X;
            sikte.Y = e.Y;
            Invalidate();
        }

        //Sätta markör där man skjuter (klickar) när man släpper musknappen
        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (pilar > 0)
            {
                traff = new Markor(e.X, e.Y, 6);
                Invalidate();

                pilar -= 1;
                lblPilar.Text = pilar.ToString();
            }
            else
            {
                lblPilar.Text = "Du har inga pilar kvar";
            }




        }
    }
}
