using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning7._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            float tank = float.Parse(textBox1.Text);

            if (tank < 10)
            {
                double bensin = 50 - tank;
                double kostnad = bensin * 14.50;
                label1.Text = "Tanka " + bensin + "L. Det kostar " + kostnad + "kr.";
            }
            else
            {
                label1.Text = "Niggu not hungery";
            }

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }
}
