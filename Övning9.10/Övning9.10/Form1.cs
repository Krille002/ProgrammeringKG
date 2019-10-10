using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning9._10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGenerera_Click(object sender, EventArgs e)
        {
            //Rensa textboxes
            tbxRad1.Text = "";
            tbxRad2.Text = "";
            tbxRad3.Text = "";
            tbxVal.Text = "";

            Random rnd = new Random();
            
            //printa 6 integers på egna rader till 3 olika textboxes
            //Loop för 3 olika textboxes
            for (int i = 0 ; i <= 2 ; i++ )
            {
                //Loop för att printa 6 integers
                for (int j = 0 ; j <= 5 ; j++)
                {
                    int stat = rnd.Next(1, 21);

                    //Printa till rätt textbox (Rad 1, Rad 2, Rad 3)
                    switch(i)
                    {
                        case 0:
                            {
                                tbxRad1.AppendText(stat + "\t");
                                break;
                            }
                        case 1:
                            {
                                tbxRad2.AppendText(stat + "\t");
                                break;
                            }
                        case 2:
                            {
                                tbxRad3.AppendText(stat + "\t");
                                break;
                            }
                    }
                }
            }



        }

        private void LbxMeny_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(lbxMeny.SelectedItem.ToString() == "Rad 1")
            switch (lbxMeny.SelectedIndex)
            {
                case 0:
                    {
                        tbxVal.Text = tbxRad1.Text;
                        break;
                    }
                case 1:
                    {
                        tbxVal.Text = tbxRad2.Text;
                        break;
                    }
                case 2:
                    {
                        tbxVal.Text = tbxRad3.Text;
                        break;
                    }
            }
        }

        private void BtnValj_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ditt Val Är " + lbxMeny.SelectedItem, "Ditt Val", MessageBoxButtons.YesNo, MessageBoxIcon.None);
        }
    }
}
