using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kap4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
        
            int uttag = int.Parse(textBox1.Text);

            //500 lappar
            int femlappar = uttag / 500;

            //100 lappar
            int hundralappar = (uttag - (femlappar * 500))/100;

            //labels
            label1.Text = "Antal 500-sedlar = " + femlappar;
            label2.Text = "Antal 100-sedlar = " + hundralappar;
        }
    }
}
