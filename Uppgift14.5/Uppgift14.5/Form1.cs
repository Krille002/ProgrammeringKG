using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift14._5
{
    public partial class Form1 : Form
    {

        //Skapa array
        int[] Varden = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
        int svar = -1;

        //Skriva ut array till label1
        public Form1()
        {
            InitializeComponent();

            for(int i = 0; i < Varden.Count(); i++)
            {
                label1.Text = label1.Text + Varden[i] + " ";
            }

            
        }

        //Sökknapp
        private void BtnSok_Click(object sender, EventArgs e)
        {
            int soktTal_ = int.Parse(tbxSoktTal.Text);

            int initialMax = Varden.Length - 1;
            int initialMin = 0;

            Hitta(Varden, soktTal_, initialMax, initialMin);

            lblSvar.Text = svar.ToString();
        }


        //Binär sökning
        private void Hitta(int[] lista, int soktTal, int max, int min)
        {
            //Plats på värde är från början odefinerat (-1)
            //mitt skapas varje gång metoden kallas
            int plats = -1;

            //Ej avrundat mitt
            double ejAvrundadMitt = ((max + min) / 2f) + 0.5;
            int mitt = (int)ejAvrundadMitt; //Lägger till 0.5 för att i princip runda uppåt ifall talet blir något med 0.5

            if(mitt == max && mitt == min)
            {
                svar = mitt;
            }
            else
            {
                if(soktTal > lista[mitt])
                {
                    min = mitt + 1;
                    Hitta(lista, soktTal, max, min);
                }
                else
                {
                    max = mitt - 1;
                    Hitta(lista, soktTal, max, min);
                }
            }



        }
    }
}
