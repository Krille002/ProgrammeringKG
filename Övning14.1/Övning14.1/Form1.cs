using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning14._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFakultet_Click(object sender, EventArgs e)
        {

            //Ankalla rekursiv metod "Fakultet"
            int input = int.Parse(tbxInput.Text);
            int output = Fakultet(input);

            lblSvar.Text = input + "! = " + output;

        }

        private int Fakultet (int tal)
        {
            //svar startar som 0
            int svar;


            //Fakultet uträkning
            if (tal == 1)
            {
                svar = 1;
            }
            else
            {
                svar = tal * Fakultet(tal - 1);
            }

            return svar;
        }
    }
}
