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
        public void DealerSetBackPictures(PictureBox[] list)
        {
            string redBack = "red_back.png";

            list[dealerPictureBoxIndex].Image = Image.FromFile(projectPath + redBack);

        }

        //Show all dealer
        public void DealerShowCards (PictureBox[] list, List<string> cards)
        {
            int i = 0;
            while(i < list.Length && i <= cards.Count)
            {
                list[i].Image = Image.FromFile(projectPath + cards[i] + ".png");
                i++;
            }

        }


        //Player
        public PictureBox[] PlayerSetPictures(PictureBox[] list, string card)
        {
            list[playerPictureBoxIndex].Image = Image.FromFile(projectPath + card + ".png");
            

            playerPictureBoxIndex++;
            return list;
        }


    }
}
