using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning13._2
{
    public partial class Form1 : Form
    {

        Stack<char> bokstaver = new Stack<char>();

        string ord = "";
        string omvantord;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnKontrollera_Click(object sender, EventArgs e)
        {
            omvantord = "";
            ord = tbxOrd.Text;

            int ordLangd = ord.Length;

            //Läsa in bokstav för bokstav
            for(int i = 0; i < ordLangd; i++)
            {
                bokstaver.Push(ord[i]);
            }

            //Skriva ut omvänt
            for(int i = 0; i < ordLangd; i++)
            {
                //Lägga till poppade värdet ur stacken på stringen och bygga upp den baklänges
                omvantord = omvantord + bokstaver.Pop();
            }

            if(ord == omvantord)
            {
                lblSvar.Text = "Ordet " + ord + " är en palindrom";
            }
            else
            {
                lblSvar.Text = "Ordet " + ord + " är inte en palindrom";
            }


        }
    }
}
