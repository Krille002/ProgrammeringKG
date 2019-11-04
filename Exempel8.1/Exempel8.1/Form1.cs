using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exempel8._1
{
    public partial class Form1 : Form
    {
        //Medlemsvariabler
        int datornsTal;
        int antalGissningar;

        public Form1()
        {
            InitializeComponent();

            //Lägg till tal 10 och 20
            lbxStörstaTalet.Items.Add(10);
            lbxStörstaTalet.Items.Add(20);
            //Markera första tal i lista
            lbxStörstaTalet.SelectedItem = lbxStörstaTalet.Items[0];
        }

        private void BtnStartaSpelet_Click(object sender, EventArgs e)
        {
            //Skapa datorns tal genom att hämta största talet från listbox.
            //Översätt till heltal och skapa slumptal som ligger i korrekt intervall
            string störstaTal = lbxStörstaTalet.SelectedItem.ToString();
            int störst = int.Parse(störstaTal);
            Random slump = new Random();
            datornsTal = slump.Next(1, störst + 1);

            //Avaktivera knappen btnStarta spelet och grupprutan gbxSpeldata
            //Aktivera grupprutan gbxSpelet
            btnStartaSpelet.Enabled = false;
            gbxSpeldata.Enabled = false;
            gbxSpelet.Enabled = true;

            //Skriv ?? ietiketten lblDatornstal
            lblDatornsTal.Text = "??";
            //Sätt instansvariabel antalGissningar till 0
            antalGissningar = 0;

        }

        private void BtnGissa_Click(object sender, EventArgs e)
        {
            antalGissningar++;
            string gissa = tbxGissa.Text;
            int gissatTal = int.Parse(gissa);

            if (gissatTal == datornsTal)
            {
                lblResultat.Text = "Korrekt efter " + antalGissningar + " försök";
                gbxSpelet.Enabled = false;
                btnSpelaIgen.Enabled = true;

                lblDatornsTal.Text = datornsTal.ToString();
                tbxMinaResultat.AppendText(antalGissningar + " försök\r\n");
            }

            else if (gissatTal < datornsTal)
            {
                lblResultat.Text = "För lågt. Försök igen.";
            }

            else
            {
                lblResultat.Text = "För högt. Försök igen.";
            }
        }

        private void BtnSpelaIgen_Click(object sender, EventArgs e)
        {
            gbxSpelet.Enabled = true;
            btnSpelaIgen.Enabled = false;

            antalGissningar = 0;

            tbxGissa.Text = "";

            lblResultat.Text = "";

            lblDatornsTal.Text = "??";
        }
    }
}
