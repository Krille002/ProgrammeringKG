using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning9._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            for (int nummer = 5 ; nummer <= 100 ; nummer = nummer + 5)
            {
                textBox1.Text = textBox1.Text + nummer + " ";
               
            }
        }
    }
}
