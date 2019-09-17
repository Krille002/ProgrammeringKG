using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning7._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            int antal = int.Parse(textBox1.Text);

            //initialize kostnad
            double kostnad;

            if (antal <= 10)
            {
                kostnad = antal * 9.90;
            }
            else if (antal <= 100)
            {
                kostnad = (antal * 9.90) * 0.9;
            }
            else
            {
                kostnad = (antal * 9.90) * 0.85;
            }

            label1.Text = "kostnaden för " + antal + " skivor är " + kostnad + " kronor.";
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }
}
