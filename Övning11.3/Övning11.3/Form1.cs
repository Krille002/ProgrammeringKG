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
        Maltavla mal = new Maltavla();
        public Form1()
        {
            InitializeComponent();
            mal.x = ClientSize.Width / 2;
            mal.y = ClientSize.Height / 2;
            mal.radie = 30;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            mal.Rita(g);
        }

        private void btnRadie_Click(object sender, EventArgs e)
        {
            mal.radie = int.Parse(tbxRadie.Text);
            Invalidate();
        }
    }
}
