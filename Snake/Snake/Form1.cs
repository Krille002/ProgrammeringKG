using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.FillRectangle(new SolidBrush(color: Color.Black), 20, 20, this.Width - 55, this.Height - 80);

        }

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
