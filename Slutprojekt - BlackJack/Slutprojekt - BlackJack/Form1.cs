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
    public partial class Form1 : Form
    {
        CardDeck currentDeck = new CardDeck();
        Players currentPlayers = new Players();
        
        int debugInteger = 0;
        int playerHandValue = 0;

        public Form1()
        {
            InitializeComponent();

            //Generera kortlek och blanda 53 platsbyten
            currentDeck.Generate();
            currentDeck.Shuffle(52);

            //Dra första kort åt dealern
            currentPlayers.DealerHandAdd(currentDeck.PullCard());
        }


        //Debug
        private void BtnDebug_Click(object sender, EventArgs e)
        {
            if (debugInteger == 52) debugInteger = 0;
            //label1.Text = currentDeck.DebugPrint(debugInteger);
            debugInteger++;

            //label1.Text = currentPlayers.DealerHand[0];
            label1.Text = playerHandValue.ToString();
        }



        //Hit
        private void BtnHit_Click(object sender, EventArgs e)
        {
            btnHit.Enabled = false;
            btnStand.Enabled = false;

            //Dra kort och sätta i handen
            string PulledCard = currentDeck.PullCard();
            currentPlayers.PlayerHandAdd(PulledCard);

            playerHandValue = playerHandValue + CheckCardValue(PulledCard);
            //Räkna ut spelares totala poäng
            //Rita ut kort och poäng till skärm
            //Hantera ess och gå över 21



        }


        //Stand
        private void BtnStand_Click(object sender, EventArgs e)
        {
            btnHit.Enabled = false;
            btnStand.Enabled = false;

            //Jämföra spelares och Dealers poäng
            //Bestäm vinnare

        }



        public int CheckCardValue (string cardString)
        {
            int firstNumber;
            int secondNumber;

            if(cardString.Length == 2)
            {
                firstNumber = cardString[0];

                return firstNumber;
            }
            else if (cardString.Length == 3)
            {
                firstNumber = cardString[0];
                secondNumber = cardString[1];

                string cardNumberString = firstNumber.ToString() + secondNumber.ToString();

                return int.Parse(cardNumberString);
            }
            else
            {
                return -1;
            }
            
        }
    }
}
