using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace Slutprojekt___BlackJack
{
    public partial class Form1 : Form
    {
        //Klasser
        CardDeck currentDeck = new CardDeck();
        PictureBoxes currentPictureboxes;

        //Listor
        public PictureBox[] dealerPictureboxes = new PictureBox[10];
        public PictureBox[] playerPictureboxes = new PictureBox[10];
        List<string> dealerHand;
        

        //Medlemsvariabler
            //int
        int debugInteger = 0;
        int playerHandValue = 0;
        int dealerHandValue = 0;
        int cash = 1000;
        int bet;
            //string
        string statusString = "";
        string projectAddress;
            //Global
        string globalTempCard;



        public Form1()
        {

            InitializeComponent();

            //Dealers kortbilder
            dealerPictureboxes[0] = pbxOpponent1;
            dealerPictureboxes[1] = pbxOpponent2;
            dealerPictureboxes[2] = pbxOpponent3;
            dealerPictureboxes[3] = pbxOpponent4;
            dealerPictureboxes[4] = pbxOpponent5;
            dealerPictureboxes[5] = pbxOpponent6;
            dealerPictureboxes[6] = pbxOpponent7;
            dealerPictureboxes[7] = pbxOpponent8;
            dealerPictureboxes[8] = pbxOpponent9;
            dealerPictureboxes[9] = pbxOpponent10;

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

            lblCash.Text = cash.ToString();
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

            //Första picturebox för motståndare. (Profilbild)
            if (cbxHard.Checked == true)
            {
                pbxOpponent.Image = Image.FromFile(projectAddress + @"\Cards\matt.jpg");
            }
            else
            {
                pbxOpponent.Image = Image.FromFile(projectAddress + @"\Cards\Opponent.png");
            }

            StartGameFunction();
        }

        private void StartGameFunction()
        {

            //Tar bort ritad text på skärm
            statusString = "";
            Invalidate();

            //Klassen som tar hand om kortbilderna rensas (Och filsökväg uppdateras)
            currentPictureboxes = new PictureBoxes();
            currentPictureboxes.SetPath = projectAddress;

            //Listan med dealers kort rensas
            dealerHand = new List<string>();

            //Rensa kortlek och kort i händer
            currentDeck.ClearDeck();
            playerHandValue = 0;
            dealerHandValue = 0;

            //Rensa alla kortbilder
            for (int i = 0; i < 10; i++)
            {
                playerPictureboxes[i].Image = null;
                dealerPictureboxes[i].Image = null;
            }

            //Hantera bet
            try
            {
                bet = int.Parse(tbxBet.Text);
                cash -= bet;
                lblCash.Text = cash.ToString();
            }
            catch
            {
                MessageBox.Show("Felaktig sats. Kolla om du har tillräckligt med cash!", "Inmatningsfel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //Generera kortlek och blanda visst antal platsbyten
            currentDeck.Generate();
            currentDeck.Shuffle(104);

            //Dra första två kort åt dealern (Gömt och första), och sätt bilder för korten

            //Synligt första kort
            string tempPulledCard;
            tempPulledCard = currentDeck.PullCard();
            dealerHand.Add(tempPulledCard);
            currentPictureboxes.DealerShowCards(dealerPictureboxes, dealerHand);
            dealerHandValue += CheckCardValue(tempPulledCard);


            //Gömt andra kort åt dealern
            tempPulledCard = currentDeck.PullCard();
            dealerHand.Add(tempPulledCard);
            currentPictureboxes.DealerSetBackPictures(dealerPictureboxes);
            dealerHandValue = dealerHandValue + CheckCardValue(tempPulledCard);


            //Dra två kort åt spelare

            for (int i = 0; i < 2; i++)
            {
                tempPulledCard = currentDeck.PullCard();
                playerHandValue += CheckCardValue(tempPulledCard);
                currentPictureboxes.PlayerSetPictures(playerPictureboxes, tempPulledCard);
            }


            //Visa alla paneler
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
                //Göm panel
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

                    //globalTempCard är en medlemsvariabel så att knapparna "One" och "Eleven" kan använda den nu
                    globalTempCard = pulledCard;
                }

            }   
            else
            {
                //Går spelare över 21 avslutas spel
                if (playerHandValue + CheckCardValue(pulledCard) > 21)
                {
                    playerHandValue += CheckCardValue(pulledCard);
                    currentPictureboxes.PlayerSetPictures(playerPictureboxes, pulledCard);
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
            //Avsluta spel
            pnlHitStand.Visible = false;
            EndGame();

        }



        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Hantera Ess värde
        private void btnEleven_Click(object sender, EventArgs e)
        {
            //Göm knappar och text
            pnlAceValue.Visible = false;
            playerHandValue = playerHandValue + 11;
            statusString = "";
            Invalidate();

            pnlHitStand.Visible = true;

            //Lägg till bild av kort
            currentPictureboxes.PlayerSetPictures(playerPictureboxes, globalTempCard);

            //DealerTurn();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            //Göm knappar och text
            pnlAceValue.Visible = false;
            playerHandValue = playerHandValue + 1;
            statusString = "";
            Invalidate();

            pnlHitStand.Visible = true;

           //Lägg till bild av kort
            currentPictureboxes.PlayerSetPictures(playerPictureboxes, globalTempCard);

            //DealerTurn();
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

            //Status text egenskaper
            Brush statusPenna = new SolidBrush(Color.Black);
            Font statusFont = new Font("Arial", 16);
            Point statusPoint = new Point(330, 330);

            //Rita status
            g.DrawString(statusString, statusFont, statusPenna, statusPoint);

        }



        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Dra kort åt dealer
        private void DealerTurn()
        {
            
            string tempCard = currentDeck.PullCard();
            int tempCardValue = CheckCardValue(tempCard);

            //Dealer tar kort tills de når minst 17 värde
            if(dealerHandValue < 17)
            {
                dealerHand.Add(tempCard);

                //Om Ess. Ta 11 om resultatet blir under eller lika med 17, annars ta värde 1
                if (tempCardValue == 1)
                {
                    if (dealerHandValue + 11 <= 17)
                    {
                        dealerHandValue += 11;
                    }
                    else
                    {
                        dealerHandValue += 1;
                    }
                }
                else
                {

                    dealerHandValue = dealerHandValue + tempCardValue;
                }
            }


            currentPictureboxes.DealerSetBackPictures(dealerPictureboxes);
            btnNextRound.Visible = true;
            
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
            currentPictureboxes.DealerShowCards(dealerPictureboxes, dealerHand);


            //Hantera vinnare
            if(playerHandValue == 21 && playerHandValue != dealerHandValue)
            {
                statusString = "Blackjack!";
                Invalidate();
            }
            else if(playerHandValue > 21)
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

        private void BtnNextRound_Click(object sender, EventArgs e)
        {
            StartGameFunction();
            btnNextRound.Visible = false;
        }

        private void BetWin()
        {
            int 
        }
    }
}
