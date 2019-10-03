using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning9._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string[] namnlista = new string[3];

            namnlista[0] = textBox1.Text;
            namnlista[1] = textBox2.Text;
            namnlista[2] = textBox3.Text;

            textBox1.Text = namnlista[2];
            textBox2.Text = namnlista[0];
            textBox3.Text = namnlista[1];
        }
    }
}
