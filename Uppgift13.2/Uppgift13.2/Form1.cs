using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift13._2
{
    public partial class Form1 : Form
    {

        Stack<char> tecken = new Stack<char>();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnKontrollera_Click(object sender, EventArgs e)
        {
            int langd = (tbxFoljd.Text).Length;
            string parantesfoljd = tbxFoljd.Text;

            for(int i = 0; i < langd; i++)
            {
                char tempBokstav = parantesfoljd[i];

                if(tempBokstav == '(')
                {
                    tecken.Push(tempBokstav);
                }
                if(tempBokstav == ')')
                {
                    if(tecken.Count == 0)
                    {
                        lblUt.Text = parantesfoljd + " är en felaktig parantesföljd.";
                    }
                    else
                    {
                        tecken.Pop();
                    }
                }
            }

            if(tecken.Count != 0)
            {
                lblUt.Text = parantesfoljd + " är en felaktig parantesföljd.";
            }

        }
    }
}
