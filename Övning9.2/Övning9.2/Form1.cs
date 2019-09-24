using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning9._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            int räknare = 0;
            double korn = 0.5;

            //Loop kvadrera tal

            while (räknare < 64)
            {

                räknare++;
                korn = korn * 2;

                textBox1.AppendText("Ruta " + räknare + ":" + "\t" + korn + "\r\n");
            }
        }
    }
}
