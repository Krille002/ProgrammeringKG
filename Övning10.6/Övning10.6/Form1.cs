using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning10._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Skapa variablar för radie och höjd
            double radie;
            double hojd;

            //Anropa "lasIn" metoden
            lasIn(out radie, out hojd);

            //Svaret från metoden "volym" sparas i variblen "svar" och printas
            double svar = volym(radie, hojd);
            lblSvar.Text = svar + "";


            //Metod "lasIn" som använder Outparametrar för att läsa in värden och spara dem i "radie" och "höjd"
            void lasIn(out double r, out double h)
            {
                r = double.Parse(tbxRadie.Text);
                h = double.Parse(tbxHojd.Text);

            }


            //Metod "volym" som tar variablarna "radie" och "höjd" och returnerar deras volym
            double volym(double radius, double height)
            {
                return Math.PI * Math.Pow(radius, 2) * height;
            }

        }
    }
}
