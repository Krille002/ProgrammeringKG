using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning14._3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnVisaRatt_Click(object sender, EventArgs e)
        {
            //Skapa fält med värden
            double[] resultat = { 1.65, 1.60, 1.55, 1.5, 1.45, 1.40 };

            VandRatt(resultat, 0);
        }

        private void VandRatt(double[] Resultat, int n)
        {
 
            if (n == 5)
            {
                lblUt.Text += Resultat[5] + " ";
            }
            else
            {
                lblUt.Text += Resultat[n] + " ";
                VandRatt(Resultat, n + 1);
            }
        }


    }
}
