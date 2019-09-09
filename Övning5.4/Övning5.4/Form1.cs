using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning5._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtbxa.Text);
            int b = int.Parse(txtbxb.Text);
            int c = int.Parse(txtbxc.Text);

            bool ordning;

            bool ab = a < b;
            bool bc = b < c;

            ordning = ab && bc;
            label1.Text = "Talen är i ordning: " + ordning.ToString();
        }
    }
}
