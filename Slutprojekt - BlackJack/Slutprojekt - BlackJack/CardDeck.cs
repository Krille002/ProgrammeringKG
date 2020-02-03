using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt___BlackJack
{
    class CardDeck
    {
        private List<string> activeDeck = new List<string>();
        private char suitGenerate;
        private string tempStringGenerate;

        Random Shuffler = new Random();


        //Metoder

        public string DebugPrint(int i)
        {
            string kort;

            kort = activeDeck[i];

            return kort;
        }



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
        public void Shuffle(int switches)
        {
            int index1;
            int index2;
            string temporaryString;

            //Plats 1 ska placeras på plats 2 och plats 2 på plats 1
            for(int i = 0; i < switches; i++)
            {
                index1 = Shuffler.Next(0, 52);
                index2 = Shuffler.Next(0, 52);

                temporaryString = activeDeck[index2];

                activeDeck[index2] = activeDeck[index1];
                activeDeck[index1] = temporaryString;

            }


        }


        //Dra översta kort
        public string PullCard()
        {
            //Plocka ut och radera översta kortet i leken
            string card = activeDeck.Last();
            activeDeck.RemoveAt(activeDeck.Count() - 1);


            return card;
        }

        //Rensa lek
        public void ClearDeck()
        {
            activeDeck.Clear();
        }
    }
}
