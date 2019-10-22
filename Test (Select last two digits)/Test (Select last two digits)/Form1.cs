using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test__Select_last_two_digits_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            double tal = double.Parse(tbxTal.Text);

            //Double to string. And length check

            int langd = tal.ToString().Length;

            //Check last two digits

            int sista = tal.ToString()[langd - 1];
            int nast_sista = tal.ToString()[langd - 2];

            //check if last two digits are the same number and print result

            if (sista == nast_sista)
            {
                lblSvar.Text = "De två sista siffrorna i talet \"" + tal + "\" är lika";
            }
            else
            {
                lblSvar.Text = "De två sista siffrorna i talet \"" + tal + "\" är inte lika";
            }
        }
    }
}
