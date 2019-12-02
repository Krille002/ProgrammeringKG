﻿using System;
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

        Kontakt[] kontaktlista ;

        //Variabler

        string _fornamn;
        string _efternamn;
        string _telefon;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            _fornamn = tbxFornamn.Text;
            _efternamn = tbxEfternamn.Text;
            _telefon = tbxTelefon.Text;

            if (kontaktlista != null && kontaktlista.Length < 100)
            {
                kontaktlista[kontaktlista.Length] = new Kontakt(_fornamn, _efternamn, _telefon);
            }
            else
            {
                MessageBox.Show("Inmatningsfel. Är kontaktlistan full? (100 platser)", "Inmatningsfel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            


        }
    }
}
