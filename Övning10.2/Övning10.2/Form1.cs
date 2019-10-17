using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning10._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnVlym_Click(object sender, EventArgs e)
        {
            double radie = double.Parse(tbxRadie.Text);
            double hojd = double.Parse(tbxHojd.Text);
            double volym = omvandla(radie, hojd);
            lblSvar.Text = volym.ToString();
        }

        double omvandla(double radie, double hojd)
        {
            double Volym = Math.PI * Math.Pow(radie, 2) * hojd;
            return Volym;
        }
    }
}
