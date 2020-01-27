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
        PictureBoxes currentPictureboxes = new PictureBoxes();
        public PictureBox[] dealerPictoreboxes = new PictureBox[10];
        public PictureBox[] playerPictureboxes = new PictureBox[10];
        

        //Medlemsvariabler
            //int
        int debugInteger = 0;
        int playerHandValue = 0;
        int dealerHandValue = 0;
            //bool
        bool justGotAce = false;
            //string
        string statusString = "";
        string dealerHiddenCard;
        string projectAddress;

            //Global
        string globalTempCard;



        public Form1()
        {

            InitializeComponent();
            PictureBox[] dealerPictureboxes = { pbxOpponent1, pbxOpponent2, pbxOpponent3, pbxOpponent4, pbxOpponent4, pbxOpponent5, pbxOpponent6, pbxOpponent7, pbxOpponent8, pbxOpponent9, pbxOpponent10 };
            PictureBox[] playerPictureboxes = { pbxCard1, pbxCard2, pbxCard3, pbxCard4, pbxCard5, pbxCard6, pbxCard7, pbxCard8, pbxCard9, pbxCard10 };
        }



        //Debug
        private void BtnDebug_Click(object sender, EventArgs e)
        {
            if (debugInteger == 52) debugInteger = 0;
            //label1.Text = currentDeck.DebugPrint(debugInteger);
            debugInteger++;

            //label1.Text = currentPlayers.DealerHand[0];
            label1.Text = playerHandValue.ToString();
            //label1.Text = dealerHandValue.ToString();

        }

        //Lås btnStart tills user tbx är skriven i
        private void TbxUser_TextChanged(object sender, EventArgs e)
        {
            btnStartGame.Enabled = true;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Starta Spel
        private void BtnStartGame_Click(object sender, EventArgs e)
        {
            projectAddress = @"C:\Users\" + tbxUser.Text + @"\source\repos\Krille002\ProgrammeringKG\Slutprojekt - BlackJack\Slutprojekt - BlackJack";
            currentPictureboxes.SetPath = projectAddress;

            //Rensa
            currentDeck.ClearDeck();
            playerHandValue = 0;
            dealerHandValue = 0;

            //Första pictureboxes för motståndare. (Profil, Gömt kort, första kort)
            if (cbxHard.Checked == true)
            {
                pbxOpponent.Image = Image.FromFile(projectAddress + @"\Cards\matt.jpg");
            }
            else
            {
                pbxOpponent.Image = Image.FromFile(projectAddress + @"\Cards\Opponent.png");
            }


            //Generera kortlek och blanda 53 platsbyten
            currentDeck.Generate();
            currentDeck.Shuffle(52);

            //Dra första två kort åt dealern (Gömt och första) och sätt bilder för korten
            dealerHiddenCard = currentDeck.PullCard();

            string tempPulledCard = currentDeck.PullCard();
            currentPlayers.DealerHandAdd(tempPulledCard);
            dealerHandValue = dealerHandValue + CheckCardValue(tempPulledCard);

            pbxOpponent1.Image = Image.FromFile(projectAddress + "/Cards/gray_back.png");
            pbxOpponent2.Image = Image.FromFile(projectAddress + "/Cards/red_back.png");


            pnlGame.Visible = true;
            pnlHitStand.Visible = true;
            pnlYourCards.Visible = true;
        }




        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Hit och stand

        //Hit
        private void BtnHit_Click(object sender, EventArgs e)
        {
            pnlHitStand.Visible = false;

            //Dra kort och sätta i handen
            string pulledCard = currentDeck.PullCard();
            currentPlayers.PlayerHandAdd(pulledCard);


            //Test /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            pulledCard = "1S";       //Debug

            //Räkna ut spelares totala poäng
            if(CheckCardValue(pulledCard) == 1)
            {

                if(playerHandValue + 1 > 21)
                {
                    //Avsluta spel om spelaren redan ligger på 21 och alltså går över det med detta kort
                    EndGame();
                }
                else
                {
                    //Hantera ess
                    statusString = "You got an Ace! Choose your preferred value:";
                    Invalidate();
                    justGotAce = true;
                    pnlAceValue.Visible = true;
                    globalTempCard = pulledCard;
                }

            }   
            else
            {
                if (playerHandValue + CheckCardValue(pulledCard) > 21)
                {
                    EndGame();
                }
                else
                {
                    //Addera värde av nytt kort
                    playerHandValue = playerHandValue + CheckCardValue(pulledCard);

                    currentPictureboxes.PlayerSetPictures(playerPictureboxes, pulledCard);
                }
                
            }

        }


        //Stand
        private void BtnStand_Click(object sender, EventArgs e)
        {
            pnlHitStand.Visible = false;
            EndGame();

        }



        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Hantera Ess värde
        private void btnEleven_Click(object sender, EventArgs e)
        {
            pnlAceValue.Visible = false;
            playerHandValue = playerHandValue + 11;
            justGotAce = false;
            statusString = "";
            Invalidate();

            pnlHitStand.Visible = true;

            currentPictureboxes.PlayerSetPictures(playerPictureboxes, globalTempCard);
            //pbxCard1.Image = Image.FromFile(projectAddress + "/Cards/" + globalTempCard + ".png");


        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            pnlAceValue.Visible = false;
            playerHandValue = playerHandValue + 1;
            justGotAce = false;
            statusString = "";
            Invalidate();

            pnlHitStand.Visible = true;

            currentPictureboxes.PlayerSetPictures(playerPictureboxes, globalTempCard);
            //pbxCard1.Image = Image.FromFile(projectAddress + "/Cards/" + globalTempCard + ".png");

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



        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Rita ut skärmen
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Brush statusPenna = new SolidBrush(Color.Black);
            Font statusFont = new Font("Arial", 16);
            Point statusPoint = new Point(330, 330);

            g.DrawString(statusString, statusFont, statusPenna, statusPoint);

        }



        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Dra kort åt dealer
        private void DealerTurn()
        {
            
            string tempCard = currentDeck.PullCard();
            int tempCardValue = CheckCardValue(tempCard);
            
            //Om Ess. Ta 11 om resultatet blir under 21, annars ta värde 1
            if(tempCardValue == 1)
            {
                if(dealerHandValue + 11 <= 21)
                {
                    dealerHandValue = dealerHandValue + 11;
                }
                else
                {
                    dealerHandValue = dealerHandValue + 1;
                }
            }
            else
            {
                dealerHandValue = dealerHandValue + tempCardValue;
            }



            
        }



        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Hantera slutet
        private void EndGame()
        {
            //Se till att dealer drar kort tills handen är värd mer än 17
            while(dealerHandValue < 17)
            {
                DealerTurn();
            }

            //Lägga till gömt kort
            dealerHandValue += CheckCardValue(dealerHiddenCard);

            //Visa alla kort


            //Hantera stand och avslut på spelet
            if(playerHandValue > 21)
            {
                statusString = "Dealer wins!";
                Invalidate();
            }
            else if(playerHandValue == dealerHandValue)
            {
                statusString = "It's a draw!";
                Invalidate();
            }
            else
            {
                statusString = "Player wins!";
                Invalidate();
            }


        }


    }
}
