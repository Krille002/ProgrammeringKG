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
        PictureBoxes currentPictureboxes;

        public PictureBox[] dealerPictoreboxes = new PictureBox[10];
        public PictureBox[] playerPictureboxes = new PictureBox[10];
        List<string> dealerHand;
        

        //Medlemsvariabler
            //int
        int debugInteger = 0;
        int playerHandValue = 0;
        int dealerHandValue = 0;
            //string
        string statusString = "";
        string dealerHiddenCard;
        string projectAddress;

            //Global
        string globalTempCard;



        public Form1()
        {

            InitializeComponent();

            //Dealers kortbilder
            dealerPictoreboxes[0] = pbxOpponent1;
            dealerPictoreboxes[1] = pbxOpponent2;
            dealerPictoreboxes[2] = pbxOpponent3;
            dealerPictoreboxes[3] = pbxOpponent4;
            dealerPictoreboxes[4] = pbxOpponent5;
            dealerPictoreboxes[5] = pbxOpponent6;
            dealerPictoreboxes[6] = pbxOpponent7;
            dealerPictoreboxes[7] = pbxOpponent8;
            dealerPictoreboxes[8] = pbxOpponent9;
            dealerPictoreboxes[9] = pbxOpponent10;

            //Spelares kortbilder
            playerPictureboxes[0] = pbxCard1;
            playerPictureboxes[1] = pbxCard2;
            playerPictureboxes[2] = pbxCard3;
            playerPictureboxes[3] = pbxCard4;
            playerPictureboxes[4] = pbxCard5;
            playerPictureboxes[5] = pbxCard6;
            playerPictureboxes[6] = pbxCard7;
            playerPictureboxes[7] = pbxCard8;
            playerPictureboxes[8] = pbxCard9;
            playerPictureboxes[9] = pbxCard10;

        }



        //Debug
        private void BtnDebug_Click(object sender, EventArgs e)
        {
            if (debugInteger == 52) debugInteger = 0;
            //label1.Text = currentDeck.DebugPrint(debugInteger);
            debugInteger++;

            //label1.Text = currentPlayers.DealerHand[0];
            //label1.Text = playerHandValue.ToString();
            label1.Text = dealerHandValue.ToString();

        }


        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Starta Spel
        private void BtnStartGame_Click(object sender, EventArgs e)
        {
            projectAddress = @"C:\Users\" + tbxUser.Text + @"\source\repos\Krille002\ProgrammeringKG\Slutprojekt - BlackJack\Slutprojekt - BlackJack";

            //Rensa
            statusString = "";
            Invalidate();

            currentPictureboxes = new PictureBoxes();
            currentPictureboxes.SetPath = projectAddress;

            dealerHand = new List<string>();

            currentDeck.ClearDeck();
            playerHandValue = 0;
            dealerHandValue = 0;

            for(int i = 0; i < 10; i++)
            {
                playerPictureboxes[i].Image = null;
                dealerPictoreboxes[i].Image = null;
            }

            //Första picturebox för motståndare. (Profil, Gömt kort, första kort)
            if (cbxHard.Checked == true)
            {
                pbxOpponent.Image = Image.FromFile(projectAddress + @"\Cards\matt.jpg");
            }
            else
            {
                pbxOpponent.Image = Image.FromFile(projectAddress + @"\Cards\Opponent.png");
            }


            //Generera kortlek och blanda visst antal platsbyten
            currentDeck.Generate();
            currentDeck.Shuffle(104);

            //Dra första två kort åt dealern (Gömt och första) och sätt bilder för korten
            //Gömt kort
            dealerHiddenCard = currentDeck.PullCard();
            dealerHand.Add(dealerHiddenCard);
            currentPictureboxes.DealerShowCards(dealerPictoreboxes, dealerHand);
            dealerHandValue += CheckCardValue(dealerHiddenCard);

            //Andra kort
            string tempPulledCard = currentDeck.PullCard();
            dealerHandValue = dealerHandValue + CheckCardValue(tempPulledCard);
            dealerHand.Add(tempPulledCard);
            currentPictureboxes.DealerSetBackPictures(dealerPictoreboxes);


            pnlGame.Visible = true;
            pnlHitStand.Visible = true;
            pnlYourCards.Visible = true;
        }




        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Hit och stand

        //Hit
        private void BtnHit_Click(object sender, EventArgs e)
        {
            //Dra kort
            string pulledCard = currentDeck.PullCard();


            //Test //////////////////////////////////////
            //pulledCard = "1S";       //Debug

            //Räkna ut spelares totala poäng
            if(CheckCardValue(pulledCard) == 1)
            {
                pnlHitStand.Visible = false;

                if (playerHandValue + 1 > 21)
                {
                    //Avsluta spel om spelaren redan ligger på 21 och alltså går över det med detta kort
                    playerHandValue += 1;
                    currentPictureboxes.PlayerSetPictures(playerPictureboxes, pulledCard);
                    EndGame();
                }
                else
                {
                    //Hantera ess
                    statusString = "You got an Ace! Choose your preferred value:";
                    Invalidate();
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
                    //DealerTurn();
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
            statusString = "";
            Invalidate();

            pnlHitStand.Visible = true;

            currentPictureboxes.PlayerSetPictures(playerPictureboxes, globalTempCard);
            //pbxCard1.Image = Image.FromFile(projectAddress + "/Cards/" + globalTempCard + ".png");

            //DealerTurn();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            pnlAceValue.Visible = false;
            playerHandValue = playerHandValue + 1;
            statusString = "";
            Invalidate();

            pnlHitStand.Visible = true;

           
            currentPictureboxes.PlayerSetPictures(playerPictureboxes, globalTempCard);
            //pbxCard1.Image = Image.FromFile(projectAddress + "/Cards/" + globalTempCard + ".png");

            DealerTurn();
        }




        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Kolla kortets värde i integers. (kortets nummer)
        public int CheckCardValue (string cardString)
        {
            char NumberChar;


            if(cardString.Length == 2)
            {
                NumberChar = cardString[0];

                return int.Parse(NumberChar.ToString());
            }
            else if (cardString.Length == 3)
            {
                return 10;
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


            if(dealerHandValue < 17)
            {
                dealerHand.Add(tempCard);

                //Om Ess. Ta 11 om resultatet blir under eller lika med 17, annars ta värde 1
                if (tempCardValue == 1)
                {
                    if (dealerHandValue + 11 <= 17)
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


            currentPictureboxes.DealerSetBackPictures(dealerPictoreboxes);
            
        }



        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Hantera slutet
        private void EndGame()
        {
            pnlHitStand.Visible = false;

            //Se till att dealer drar kort tills handen är värd mer än 17
            while(dealerHandValue < 17)
            {
                DealerTurn();
            }

            //Visa dealers kort
            currentPictureboxes.DealerShowCards(dealerPictoreboxes, dealerHand);

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
            else if(dealerHandValue > playerHandValue && dealerHandValue <= 21)
            {
                statusString = "Dealer wins!";
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
