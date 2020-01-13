using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt___BlackJack
{
    class Kortlek
    {
        private List<string> activeDeck = new List<string>();
        private char suitGenerate;
        private int cardGenerate;
        private string tempStringGenerate;

        //Egenskap för att testa

        public string First
        {
            get
            {
                return activeDeck[13];
            }
            set
            {
                activeDeck.Add(value);
            }
        }




        //Metoder


        //Generera lista
        public void Generate()
        {
            for(int suit = 0; suit < 4; suit++)
            {
                //Bestämma svitmärke som ska genereras. H-earts, D-iamonds, C-lubs, S-pades
                switch (suit)
                {
                    case 0:
                        suitGenerate = 'H';
                        break;
                    case 1:
                        suitGenerate = 'D';
                        break;
                    case 2:
                        suitGenerate = 'C';
                        break;
                    case 3:
                        suitGenerate = 'S';
                        break;
                }

                for(int card = 1; card < 14; card++)
                {
                    //Skapa temporär string och lägga till i lista
                    tempStringGenerate = card.ToString() + suitGenerate;

                    activeDeck.Add(tempStringGenerate);

                }

            }
        }


        //Blanda kortlek
        public List<string> Shuffle(List<string> tempList)
        {


            return tempList;
        }


        //Dra översta kort
        public string PullCard(List<string> tempList2)
        {
            string card = tempList2.Last();


            return card;
        }
    }
}
