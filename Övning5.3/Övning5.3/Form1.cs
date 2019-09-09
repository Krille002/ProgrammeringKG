using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning5._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int pengar = int.Parse(minapengar.Text);
            int cost = int.Parse(kostnad.Text);

            bool jagHarRåd = cost <= pengar;
            label1.Text = "Jag har råd? " + jagHarRåd.ToString();
        }
    }
}
