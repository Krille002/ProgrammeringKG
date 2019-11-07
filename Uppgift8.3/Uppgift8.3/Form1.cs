using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift8._3
{
    public partial class Form1 : Form
    {
        //medlemsvariabler
        int nrDatorVinster;
        int nrSpelarVinster;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSpela_Click(object sender, EventArgs e)
        {
            gbxStenSaxPåse.Enabled = true;
            gbxMinaResultat.Enabled = true;
            btnSpela.Enabled = false;

            lblDatornsVal.Text = "";
            lblResultat.Text = "";

            nrDatorVinster = 0;
            nrSpelarVinster = 0;

        }

        private void pbxSten_Click(object sender, EventArgs e)
        {

            //Generera datorns val som int
            Random slump = new Random();
            int datornsTal = slump.Next(1, 4);

            //Översätta datorns val till sten, sax eller påse
            string datornsVal = "";
            switch (datornsTal)
            {
                case 1:
                    datornsVal = "Sten";
                    break;
                case 2:
                    datornsVal = "Sax";
                    break;
                case 3:
                    datornsVal = "Påse";
                    break;
            }

            lblDatornsVal.Text = datornsVal;

            //Välja vinnare
            if (datornsVal.Equals("Sax"))
            {
                nrSpelarVinster++;
            }
            else if (datornsVal.Equals("Påse"))
            {
                nrDatorVinster++;
            }

            //Visa rundans resultat
            lblResultat.Text = "Dator: " + nrDatorVinster + "  Spelare: " + nrSpelarVinster;


            //Kolla om någon har 3 poäng
            if (nrDatorVinster > 2 || nrSpelarVinster > 2)
            {
                gbxStenSaxPåse.Enabled = false;
                btnSpela.Enabled = true;
                tbxMinaResultat.AppendText("Dator: " + nrDatorVinster + "  Spelare " + nrSpelarVinster + "\r\n");
            }

        }

        private void pbxSax_Click(object sender, EventArgs e)
        {
            ///Pallar inte fixa för andra två knapparna. Nästan samma kod
        }

        private void pbxPase_Click(object sender, EventArgs e)
        {
            ///Pallar inte fixa för andra två knapparna. Nästan samma kod
        }
    }
}
