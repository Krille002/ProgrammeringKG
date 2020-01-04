using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning14._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnHarmonisktTal_Click(object sender, EventArgs e)
        {

            double input = int.Parse(tbxInput.Text);
            double output = HarmonisktTal(input);

            lblSvar.Text = "H(" + input + ") = " + output;

        }

        private double HarmonisktTal(double tal)
        {
            double svar;

            if(tal == 1)
            {
                svar = 1;
            }
            else
            {
                svar = (1 / tal) + HarmonisktTal(tal - 1);
            }

            return svar;
        }

        private void TbxInput_TextChanged(object sender, EventArgs e)
        {
            lblSvar.Text = "";
        }
    }
}
