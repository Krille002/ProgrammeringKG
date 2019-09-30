using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning9._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int start = int.Parse(txtbxstart.Text);
            int slut = int.Parse(txtbxslut.Text);
            int steg = int.Parse(txtbxsteg.Text);

            for (int i = start ; i <= slut ; i = i + steg)
            {
                textBox1.Text = textBox1.Text + i + " ";
            }

        }
    }
}
