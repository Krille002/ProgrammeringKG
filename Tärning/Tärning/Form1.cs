using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tärning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Random slump = new Random();

            int resultat = slump.Next(1, 7);

            label1.Text = resultat.ToString();

            if (resultat == 6)
            {
                MessageBox.Show("Nice", "Meddelande", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
