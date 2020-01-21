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
        
        //Medlemsvariabler
            //int
        int debugInteger = 0;
        int playerHandValue = 0;
        int dealerHandValue = 0;
        int dealerHiddenCard;
        //bool
        bool justGotAce = false;
            //string
        string statusString = "";
        

        public Form1()
        {
            InitializeComponent();
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

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Hit och stand

        //Hit
        private void BtnHit_Click(object sender, EventArgs e)
        {
            pnlHitStand.Visible = false;

            //Dra kort och sätta i handen
            string PulledCard = currentDeck.PullCard();
            currentPlayers.PlayerHandAdd(PulledCard);                             //Kan göras på en rad


            //Test /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            PulledCard = "1S";       //Debug

            //Räkna ut spelares totala poäng
            if(CheckCardValue(PulledCard) == 1)
            {

                if(playerHandValue + 1 > 21)
                {
                    EndGame();
                }
                else
                {
                    //Hantera ess
                    statusString = "Du drog ett ess. Välj värdet du föredrar:";
                    Invalidate();
                    justGotAce = true;
                    pnlAceValue.Visible = true;

                    pbxCard1.Image = Image.FromFile(Environment.CurrentDirectory + "/Cards/" + PulledCard + ".png");

                    //Olika test
                    //pbxCard1.Image = Image.FromFile("C:/Users/chrris0223/Source/Repos/Krille002/ProgrammeringKG/Slutprojekt - BlackJack/Slutprojekt - BlackJack/Resources/Cards/" + PulledCard + ".png");
                    //label1.Text = System.Windows.Forms.Application.StartupPath;
                    //label1.Text = Environment.CurrentDirectory + "/Cards/" + PulledCard + ".png";
                }

            }   
            else
            {
                //Addera värde av nytt kort
                playerHandValue = playerHandValue + CheckCardValue(PulledCard);
            }


            //Rita ut kort och poäng till skärm
            //Hantera ess och gå över 21



        }


        //Stand
        private void BtnStand_Click(object sender, EventArgs e)
        {
            pnlHitStand.Visible = false;

            //Jämföra spelares och Dealers poäng
            //Bestäm vinnare

        }



        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Kolla kortets värde i integers. (kortets nummer)
        public int CheckCardValue (string cardString)
        {
            char firstNumberChar;
            char secondNumberChar;

            if(cardString.Length == 2)
            {
                firstNumberChar = cardString[0];

                return int.Parse(firstNumberChar.ToString());
            }
            else if (cardString.Length == 3)
            {
                firstNumberChar = cardString[0];
                secondNumberChar = cardString[1];

                return int.Parse(firstNumberChar.ToString() + secondNumberChar.ToString());
            }
            else
            {
                return -1;
            }
            
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Hantera Ess värde
        private void btnEleven_Click(object sender, EventArgs e)
        {
            pnlAceValue.Visible = false;
            playerHandValue = playerHandValue + 11;
            justGotAce = false;

            pnlHitStand.Visible = true;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            pnlAceValue.Visible = false;
            playerHandValue = playerHandValue + 1;
            justGotAce = false;

            pnlHitStand.Visible = true;
        }


        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Starta Spel
        private void BtnStartGame_Click(object sender, EventArgs e)
        {
            //Rensa
            currentDeck.ClearDeck();
            playerHandValue = 0;
            dealerHandValue = 0;

            //Första pictureboxes för motståndare. (Profil, Gömt kort, första kort)
            if (cbxHard.Checked == true)
            {
                pbxOpponent.Image = Image.FromFile(Environment.CurrentDirectory + "/Cards/" + "matt.jpg");
            }
            else
            {
                pbxOpponent.Image = Image.FromFile(Environment.CurrentDirectory + "/Cards/" + "Opponent.png");
            }

            pbxOpponent1.Image = Image.FromFile(Environment.CurrentDirectory + "/Cards/" + "gray_back.png");
            pbxOpponent2.Image = Image.FromFile(Environment.CurrentDirectory + "/Cards/" + "red_back.png");


            //Generera kortlek och blanda 53 platsbyten
            currentDeck.Generate();
            currentDeck.Shuffle(52);

            //Dra första kort åt dealern
            dealerHiddenCard = CheckCardValue(currentDeck.PullCard());
            currentPlayers.DealerHandAdd(currentDeck.PullCard());

            pnlGame.Visible = true;
            pnlHitStand.Visible = true;
            pnlYourCards.Visible = true;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Rita ut skärmen
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Brush statusPenna = new SolidBrush(Color.Black);
            Font statusFont = new Font("Arial", 16);
            Point statusPoint = new Point(275, 330);

            g.DrawString(statusString, statusFont, statusPenna, statusPoint);

        


        }


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Hantera slutet
        private void EndGame()
        {

        }

    }
}
