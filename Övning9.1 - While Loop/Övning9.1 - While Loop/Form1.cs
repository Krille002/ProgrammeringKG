using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning9._1___While_Loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int räknare = 0, slut = int.Parse(textBox1.Text);

            while (räknare < slut)
            {
                räknare++;
                textBox2.AppendText(räknare + "\r\n" );
                //textBox2.Text = textBox2.Text + räknare + " ";
            }
        }
    }
}
