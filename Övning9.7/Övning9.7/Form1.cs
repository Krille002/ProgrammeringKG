using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning9._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int niva = int.Parse(txtbxniva.Text);
            string tabell = "";
            int tal = 0;

            for (int i = 1 ; i <= niva ; i++)
            {
                for (int j = 0 ; j <= 10 ; j++)
                {

                    tal = i * j;

                    txtBxOutput.AppendText(tal + "\t");

                }

                txtBxOutput.AppendText("\r\n");
            }







        }
    }
}
