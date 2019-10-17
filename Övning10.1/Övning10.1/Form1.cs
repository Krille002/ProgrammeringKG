using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning10._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBerakna_Click(object sender, EventArgs e)
        {
            //Läs in värde
            double radie = double.Parse(textBox1.Text);
            double area = omvandla(radie);
            lblArea.Text = area.ToString();
        }

        //Metod omvandlar radie till area
        double omvandla(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
    }
}
