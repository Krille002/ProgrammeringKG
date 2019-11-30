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
        Markor[] traff;

        int pilarKvar = 5;
        int skjutnaPilar = 0;

        public Form1()
        {
            InitializeComponent();

            //Starta klasser för måltavla och sikte
            mal = new Maltavla(ClientSize.Width / 2, ClientSize.Height / 2, 60);
            sikte = new Sikte(ClientSize.Width / 2, ClientSize.Height / 2);

            //Gör så att det kan finnas 6 "upplagor" av "traff" objektet
            traff = new Markor[5];

            //Skriva startvärde till label för antal pilar kvar
            lblPilar.Text = pilarKvar.ToString();
        }

        //Bifoga graphics till klasser för att rita
        protected override void OnPaint(PaintEventArgs e)
        {
            mal.Rita(e.Graphics);
            sikte.Rita(e.Graphics);

            for (int i = 0; i < skjutnaPilar; i++)
            {
                if (traff[i] != null) traff[i].Rita(e.Graphics);
            }
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
            pilarKvar = 5 - skjutnaPilar;

            if (pilarKvar > 0)
            {
                //Felet var att jag skrivit "skjutnaPilar++;" på denna rad. Och använt "[skjutnaPilar]" på nästa
                traff[skjutnaPilar++] = new Markor(e.X, e.Y, 6);
                Invalidate();

                
                lblPilar.Text = pilarKvar.ToString();
            }
            else
            {
                lblPilar.Text = "Du har inga pilar kvar";
            }


        }
    }
}
