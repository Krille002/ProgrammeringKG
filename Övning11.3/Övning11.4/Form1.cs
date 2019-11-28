using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning11._4
{
    public partial class Form1 : Form
    {
        Maltavla mal;
        Sikte sikte;
        Random slump = new Random();
        public Form1()
        {
            InitializeComponent();

            //Sätta egenskaper för mal class

            mal = new Maltavla(ClientSize.Width / 2, ClientSize.Height / 2, 60);

            //Sätta egenskaper för sikte klass

            int x = slump.Next(ClientSize.Width / 2 - 30, ClientSize.Width / 2 + 30);
            int y = slump.Next(ClientSize.Height / 2 - 30, ClientSize.Height / 2 + 30);

            sikte = new Sikte(x, y);


        }


        //Ge måltavla tillgåmg till graphics

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            mal.Rita(g);
            sikte.Rita(g);
        }

        private void btnNer_Click(object sender, EventArgs e)
        {
            sikte.Y += 2;
            Invalidate();
        }

        private void btnUpp_Click(object sender, EventArgs e)
        {
            sikte.Y -= 2;
            Invalidate();
        }

        private void btnVanster_Click(object sender, EventArgs e)
        {
            sikte.X -= 2;
            Invalidate();
        }

        private void btnHoger_Click(object sender, EventArgs e)
        {
            sikte.X += 2;
            Invalidate();
        }
    }
}
