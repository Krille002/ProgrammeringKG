using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int monader = int.Parse(textBox1.Text);
            int ar = monader / 12;
            int monader_over = monader % 12;
            label1.Text = ar + " år och " + monader_over + " månader.";
        }
    }
}
