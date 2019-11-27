using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning11._2
{
    public partial class Form1 : Form
    {
        Maltavla mal = new Maltavla(0, 0, 30);
        public Form1()
        {
            InitializeComponent();
            mal.X = ClientSize.Width / 2;
            mal.Y = ClientSize.Height / 2;
            mal.Radie = 30;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            mal.Rita(g);
        }

        private void BtnRadie_Click_1(object sender, EventArgs e)
        {
            mal.Radie = int.Parse(tbxRadie.Text);
            Invalidate();
        }
    }
}
