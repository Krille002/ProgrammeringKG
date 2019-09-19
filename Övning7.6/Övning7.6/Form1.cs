using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning7._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string namn1 = textBox1.Text;
            string namn2 = textBox2.Text;

            if (namn1.CompareTo(namn2) < 0)
            {

                label3.Text = namn1 + " " + namn2;

            }
            else
            {
                label3.Text = namn2 + " " + namn1;
            }
        }
    }
}
