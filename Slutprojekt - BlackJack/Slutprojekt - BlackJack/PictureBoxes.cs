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
    class PictureBoxes
    {
        private int dealerPictureBoxIndex = 2;
        private int playerPictureBoxIndex = 0;

        private string projectPath;


        //Egenskap
        public string SetPath
        {
            get
            {
                return projectPath;
            }
            set
            {
                projectPath = value + @"\Cards\";
            }
        }


        //Metoder

        //Dealer
        public PictureBox[] DealerSetPictures(PictureBox[] lista, string card)
        {
            lista[dealerPictureBoxIndex - 2].Image = Image.FromFile(projectPath + card + ".png");

            dealerPictureBoxIndex++;
            return lista;
        }



        //Player
        public PictureBox[] PlayerSetPictures(PictureBox[] lista, string card)
        {
            lista[playerPictureBoxIndex].Image = Image.FromFile(projectPath + card + ".png");
            

            playerPictureBoxIndex++;
            return lista;
        }
    }
}
