﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift12._1
{
    public partial class Form1 : Form
    {
        //Medlemsvariabler
        int[] listaTal;

        public Form1()
        {
            InitializeComponent();
            listaTal = new int[5];

        }

        private void BtnSortera_Click(object sender, EventArgs e)
        {

            listaTal[0] = int.Parse(textBox1.Text);
            listaTal[1] = int.Parse(textBox2.Text);
            listaTal[2] = int.Parse(textBox3.Text);
            listaTal[3] = int.Parse(textBox4.Text);
            listaTal[4] = int.Parse(textBox5.Text);


            //Bifoga lista och ankalla metod för sortering
            if (cbxBaklanges.Checked == true)
            {
                sorteraBaklanges(listaTal);
            }
            else
            {
                sorteraArray(listaTal);
            }

        }






        //metod för att sortera array

        public void sorteraArray(int[] lista)
        {
            int i, n;
            int length = lista.Length;
            int jamforelsetal;

            //Är listan under två element lång måste den inte sorteras
            if (length < 2) return;


            for (n = 1; n < length; n++)
            {
                //Spara jämförelsetal
                jamforelsetal = lista[n];

                //Gå tillbaka ett element

                i = n - 1;

                while (i >= 0 && lista[i] > jamforelsetal)
                {
                    lista[i + 1] = lista[i];
                    i--;
                }

                lista[i + 1] = jamforelsetal;

            }

            label1.Text = lista[0].ToString();
            label2.Text = lista[1].ToString();
            label3.Text = lista[2].ToString();
            label4.Text = lista[3].ToString();
            label5.Text = lista[4].ToString();
        }



        public void sorteraBaklanges(int[] lista)
        {
            int i, n;
            int length = lista.Length;
            int jamforelsetal;

            //Är listan under två element lång måste den inte sorteras
            if (length < 2) return;


            for (n = length - 1; n > 0; n--)
            {
                //Spara jämförelsetal
                jamforelsetal = lista[n];

                //Gå fram ett element

                i = n + 1;


                //Om tal index framför är mindre än max index, och element på "i" är större än jämförelsetal

                while (i <= 4 && lista[i] > jamforelsetal)
                {
                    if(i >= 0)                                //Är detta nödvändigt? kraschade utan
                    {
                        lista[i - 1] = lista[i];
                        i--;
                    }

                }

                lista[i - 1] = jamforelsetal;

            }

            label1.Text = lista[0].ToString();
            label2.Text = lista[1].ToString();
            label3.Text = lista[2].ToString();
            label4.Text = lista[3].ToString();
            label5.Text = lista[4].ToString();
        }

    }
}
