using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning14._4
{
    public partial class Form1 : Form
    {

        private Papper[] papperArray = new Papper[10];
        private bool ritaPapper = false;
        int antalStorlekar;


        public Form1()
        {
            InitializeComponent();
        }



        private void BtnRita_Click(object sender, EventArgs e)
        {
            antalStorlekar = int.Parse(tbxStorlek.Text);

            skapaPapper(0, 20, 50, 200, 300);
            ritaPapper = true;
            Invalidate();
        }




        private void skapaPapper(int n, int x, int y, int bredd, int hojd)
        {
            if(n < antalStorlekar)
            {
                if (n == 5)
                {
                    Papper p = new Papper(x, y, bredd, hojd);
                    papperArray[n] = p;
                }
                else
                {
                    Papper p = new Papper(x, y, bredd, hojd);
                    papperArray[n] = p;

                    if (n % 2 == 0)
                    {
                        x = x + bredd;
                        hojd = hojd / 2;
                    }
                    else
                    {
                        y = y + hojd;
                        bredd = bredd / 2;
                    }

                    n++;
                    skapaPapper(n, x, y, bredd, hojd);

                }
            }

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (ritaPapper)
            {
                //Rita ut alla rektanglar
                for (int i = 0; i < antalStorlekar; i++)
                {
                    papperArray[i].Rita(g);
                }
            }
        }
    }
}
