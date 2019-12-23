using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning12._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        //Medlemsvariabler. Kan inte sättas till icke-statiska värden här
        int[] lista;
        int sok;
        int funnetIndex;
        

        //Generera randoms
        Random random = new Random();



        private void BtnGenerera_Click(object sender, EventArgs e)
        {
            //antal nummer
            int antalNummer = int.Parse(tbxAntal.Text);

            try
            {
                if (antalNummer <= 10000)
                {
                    lista = new int[antalNummer];

                    for (int i = 0; i < antalNummer; i++)
                    {
                        int rand = random.Next(1, 10000);
                        lista[i] = rand;

                        if(cbxDebug.Checked == true)
                        {
                            tbxLista.AppendText(i + ", " + rand + "\r\n");
                        }
                    }

                    btnSok.Enabled = true;
                    btnSortera.Enabled = true;
                    btnBinarsok.Enabled = false;
                }
                //Ifall if-satsen inte funkar av någon anledning
                else
                {
                    MessageBox.Show("Inmatningsfel", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //Ifall något går väldigt fel
            catch
            {
                MessageBox.Show("Något gick väldigt fel", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void BtnSok_Click(object sender, EventArgs e)
        {
            sok = int.Parse(tbxSok.Text);

            funnetIndex = sekventiellSokning(lista, sok);

            //Om metod inte hittar något index (ger -1)
            if (funnetIndex == -1) lblSvar.Text = "Numret " + sok + " finns inte i listan";

            //Printa svar annars
            else lblSvar.Text = "Numret " + sok + " finns på index " + funnetIndex;


        }

        private void BtnSortera_Click(object sender, EventArgs e)
        {
            bubbelSortera(lista);
            btnBinarsok.Enabled = true;
        }

        private void BtnBinarsok_Click(object sender, EventArgs e)
        {
            sok = int.Parse(tbxSok.Text);
            funnetIndex = binarSokning(lista, sok);

            //Om metod inte hittar något index (ger -1)
            if (funnetIndex == -1) lblSvar.Text = "Numret " + sok + " finns inte i listan";

            //Printa svar annars
            else lblSvar.Text = "Numret " + sok + " finns på index " + funnetIndex;

        }














        //metoder

        //Sekventiell
        public int sekventiellSokning(int[] metodLista, int värde)
        {
            //Returnerar -1 som är omöjligt ifall värde inte finns
            int index = -1;

            //Sekventiell. Jämför alla element mot värdet manuellt
            for(int i = 0; i < metodLista.Length; i++)
            {
                if(metodLista[i] == värde)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

            //Binär

        public int binarSokning(int[] metodLista, int värde)
        {
            int index = -1;
            int min = 0;
            int max = metodLista.Length - 1;

            while(min <= max && index == -1)
            {
                int mitt = (min + max) / 2;

                if (värde > metodLista[mitt])
                {
                    min = mitt + 1;
                }
                else if (värde < metodLista[mitt])
                {
                    max = mitt - 1;
                }
                else index = mitt;
            }
            return index;
        }

            //Sortering (bubbel)

        void bubbelSortera(int[] metodLista)
        {
            //bestäma hur många nummer sorteringen går igenom. 1 mindre varje runda eftersom att sista kommer elementet kommer vara störst
            for(int i = metodLista.Length-1; i > 0; i--)
            {
                //Sortera alla nummer upp till där yttersta for-loopen sätter stopp
                for(int j = 0; j<i; j++)
                {
                    //Om tal bakom större, byt plats
                    if(metodLista[j] > metodLista[j + 1])
                    {
                        int temp = metodLista[j];
                        metodLista[j] = metodLista[j + 1];
                        metodLista[j + 1] = temp;
                    }
                }
            }
        }
    }
}
