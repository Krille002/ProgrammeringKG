using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slutprojekt___BlackJack
{
    public partial class Form1 : Form
    {
        Kortlek myDeck = new Kortlek();


        public Form1()
        {
            InitializeComponent();
            
        }

        private void BtnHit_Click(object sender, EventArgs e)
        {
            myDeck.Generate();

            label1.Text = myDeck.First;
        }

        private void BtnStand_Click(object sender, EventArgs e)
        {

        }
    }
}
