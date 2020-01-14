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
        ///////////////////////////////////////////////////////////Kortlek myDeck = new Kortlek();
        
        int debugInteger = 0;

        public Form1()
        {
            InitializeComponent();
            myDeck.Generate();
        }

        private void BtnDebug_Click(object sender, EventArgs e)
        {
            if (debugInteger == 52) debugInteger = 0;
            label1.Text = myDeck.DebugPrint(debugInteger);
            debugInteger++;
        }

        private void BtnHit_Click(object sender, EventArgs e)
        {

        }

        private void BtnStand_Click(object sender, EventArgs e)
        {

        }
    }
}
