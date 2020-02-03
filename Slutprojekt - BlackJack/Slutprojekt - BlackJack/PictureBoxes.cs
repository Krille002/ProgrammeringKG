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
        private int dealerPictureBoxIndex = 1;
        private int playerPictureBoxIndex = 0;

        private string projectPath;



        //Egenskap för att sätta filsökväg
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

        //Dealer (Sätta bakvända kort)       (Typ legacy)
        public void DealerSetBackPictures(PictureBox[] list)
        {
            string redBack = "red_back.png";

            list[dealerPictureBoxIndex].Image = Image.FromFile(projectPath + redBack);

        }

        //Show all dealer (Visar alla dealernas kort)
        public void DealerShowCards (PictureBox[] list, List<string> cards)
        {
            int i = 0;

            //Går igenom listan med dealerns kort och sätter alla bilderna
            while(i < list.Length && i < cards.Count)
            {
                list[i].Image = Image.FromFile(projectPath + cards[i] + ".png");
                i++;
            }

        }


        //Player         (Sätter spelarens kortbilder)
        public PictureBox[] PlayerSetPictures(PictureBox[] list, string card)
        {
            list[playerPictureBoxIndex].Image = Image.FromFile(projectPath + card + ".png");
            

            playerPictureBoxIndex++;
            return list;
        }


    }
}
