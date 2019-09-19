using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Villkorsoperatorn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double tal1 = double.Parse(textBox1.Text);
            double tal2 = double.Parse(textBox2.Text);

            double max = tal1 > tal2 ? tal1 : tal2;

            label3.Text = "Det största talet är " + max;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            label3.Text = "";
        }
    }
}
