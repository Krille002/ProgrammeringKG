using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift5._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            int sekunder = int.Parse(textBox1.Text);
            int timmar = sekunder / (60 * 60);
            int minuter = (sekunder % (60 * 60)) / 60;
            int sekunderOver = (sekunder % (60 * 60)) % 60;

            label1.Text = "Timmar: " + timmar;
            label2.Text = "Minuter: " + minuter;
            label3.Text = "Sekunder: " + sekunderOver;
        }
    }
}
