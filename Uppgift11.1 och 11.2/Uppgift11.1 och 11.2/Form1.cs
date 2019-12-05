using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift11._1_och_11._2
{
    public partial class Form1 : Form
    {

        Kontakt[] kontaktlista;
        

        //Variabler

        string _fornamn;
        string _efternamn;
        string _telefon;
        int antalKontakter = 0;
        

        public Form1()
        {
            InitializeComponent();

            kontaktlista = new Kontakt[100];
            this.Text = "Hentai! - Elias";
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            _fornamn = tbxFornamn.Text;
            _efternamn = tbxEfternamn.Text;
            _telefon = tbxTelefon.Text;

            //if-sats som sköter hantering av data i "kontaklista"
            //"k" är en temporär instans av "Kontakt" klassen som används för att lägga in nästa värde i arrayen "kontaklista"

            if ( antalKontakter < 100 )
            {
                Kontakt k = new Kontakt(_fornamn, _efternamn, _telefon);
                kontaktlista[antalKontakter++] = k;
                //lbxLista.Items.Add(k);

            }

            /*
            else if (antalKontakter < 100 && rbtnEfternamnForst.Checked == true)
            {

                Kontakt k = new Kontakt(_fornamn, _efternamn, _telefon);
                kontaktlista[antalKontakter++] = k;
                lbxLista.Items.Add(k.EfternamnForst());

            }
            */

            //Uppstår problem, visas felmeddelande

            else
            {
                MessageBox.Show("Inmatningsfel. Är kontaktlistan full?", "Inmatningsfel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Skicka vidare uppgift till "SkrivUt" metod som löser visuella
            skrivUt();


        }


        //Metod som rensar visuella listboxen och sedan skriver in värden av kontaklista
        private void skrivUt()
        {
            lbxLista.Items.Clear();

            for(int i = 0; i < antalKontakter; i++)
            {

                //Skriver ut till listbox i olika format beroende på ifylld "RadioButton"

                if (rbtnFornamnForst.Checked == true)
                {
                    lbxLista.Items.Add(kontaktlista[i]);
                }
                else
                {
                    lbxLista.Items.Add(kontaktlista[i].EfternamnForst());
                }

            }

        }

        private void rbtnFornamnForst_CheckedChanged(object sender, EventArgs e)
        {
            skrivUt();
        }

        private void rbtnEfternamnForst_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
