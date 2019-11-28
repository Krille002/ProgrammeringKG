using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning11._5
{
    public partial class Form1 : Form
    {
        Maltavla mal;
        Sikte sikte;

        public Form1()
        {
            InitializeComponent();

            //Starta klasser

            mal = new Maltavla(ClientSize.Width / 2, ClientSize.Height / 2, 60);
            sikte = new Sikte(ClientSize.Width / 2, ClientSize.Height / 2);

            
        }

        //Ge klasser tillgång till att rita till skärm
        protected override void OnPaint(PaintEventArgs e)
        {
            mal.Rita(e.Graphics);
            sikte.Rita(e.Graphics);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            sikte.X = e.X;
            sikte.Y = e.Y;
            Invalidate();
        }
    }
}
