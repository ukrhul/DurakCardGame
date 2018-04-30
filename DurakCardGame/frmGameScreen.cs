/** frmGameScreen.cs
*	
*	This is the Main game screen form class
*	that contains all the class instances and 
*	gameplay
*   
*	Author		  Rahul, Jaspreet Kaur, Remya Zacharias
*	Since		  1.0 (25 March 2018)
*	Version       2.0 (27 April 2018)
*/
using CardBox;
using DurakCardLibrary;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace DurakCardGame
{
    public partial class frmGameScreen : Form
    {
        Deck durakDeck = new Deck();
        CardBoxComponent cbxCards;
        static PlayerHand playerHandAi = new PlayerHand();
        static PlayerHand playerHandHuman = new PlayerHand();
        PlayingField playingField = new PlayingField();
        PlayerAI playerAi = new PlayerAI();
        DurakPlayer durakAi = new DurakPlayer("Rahul", playerHandAi, false);
        DurakPlayer durakHuman = new DurakPlayer("Rahul", playerHandHuman, false);

        private Image audioFull;
        private Image audioMute;

        public frmGameScreen()
        {
            InitializeComponent();
            
        }

       public void setDefault(int deckSize)
        {
            isHumanTurn = true;
            durakDeck = new Deck(deckSize);

            durakDeck.Shuffle(deckSize);
            createPlayersHand(durakDeck);

            grpBxDeck.Controls.Clear();
            displayDeck();            

            displayPlayingCard();
            displayAiHand();
            displayHumanHand();
        }

        public void displayDeck()
        {
            grpBxDeck.Controls.Clear();
            for (int i = 0; i < durakDeck.remainingCard(); i++)
            {
                cbxCards = new CardBoxComponent();
                cbxCards.Card = durakDeck.GetCard(i);
                cbxCards.Left = 5 + (i * 10);
                cbxCards.Top = 12;
                cbxCards.Height = 60;
                cbxCards.Width = 40;
                cbxCards.FaceUp = FaceStatus.Up;
                grpBxDeck.Controls.Add(cbxCards);
            }
            Label lblDeckCounter = new Label();
            lblDeckCounter.Top = 200;
            lblDeckCounter.Left = 50;
            lblDeckCounter.Text = durakDeck.remainingCard().ToString();
            grpBxDeck.Controls.Add(lblDeckCounter);


            // For debugging
            Debug.WriteLine("Deck started");
            for (int i = 0; i < durakDeck.remainingCard(); i++)
            {
                Debug.WriteLine(durakDeck.GetCard(i));
            }
            Debug.WriteLine("Deck ended");

        }

        public void displayAiHand()
        {
            grpBxAi.Controls.Clear();

            for (int i = 0; i < playerHandAi.totalCards(); i++)
            {
                cbxCards = new CardBoxComponent();
                cbxCards.Card = durakAi.GetCard(i);
                cbxCards.Left = 5 + (i * 20);
                cbxCards.Top = 12;
                cbxCards.Height = 60;
                cbxCards.Width = 40;
                cbxCards.FaceUp = FaceStatus.Up;
                grpBxAi.Controls.Add(cbxCards);

            }

        }

        public void displayHumanHand()
        {
            grpBxHuman.Controls.Clear();

            for (int i = 0; i < playerHandHuman.totalCards(); i++)
            {
                cbxCards = new CardBoxComponent();
                cbxCards.Card = durakHuman.GetCard(i);
                cbxCards.Left = 5 + (i * 20);
                cbxCards.Top = 12;
                cbxCards.Height = 60;
                cbxCards.Width = 40;
                cbxCards.FaceUp = FaceStatus.Up;
                grpBxHuman.Controls.Add(cbxCards);
                cbxCards.cardClicked += new EventHandler(Card_Click);
            }
        }

        public void createPlayersHand(Deck durakDeck)
        {
            refillCards();
            Card.trump = durakDeck.GetCard(5).Suit;
            cbxTrumpCard.Card = durakDeck.GetCard(5);
        }

        public void displayPlayingCard()
        {

            grpBxPlayingField.Controls.Clear();

            for (int i = 0; i < playingField.totalCards(); i++)
            {
                cbxCards = new CardBoxComponent();
                cbxCards.Card = playingField.GetCard(i);
                cbxCards.Left = 5 + (i * 45);
                cbxCards.Top = 20;
                cbxCards.Height = 60;
                cbxCards.Width = 40;
                cbxCards.FaceUp = FaceStatus.Up;
                grpBxPlayingField.Controls.Add(cbxCards);

            }


        }


        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelpForm helpForm = new frmHelpForm();
            helpForm.ShowDialog();
        }

        private void frmGameScreen_Load(object sender, EventArgs e)
        {
            audioFull = Properties.Resources.Status_audio_volume_high_icon;
            audioMute = Properties.Resources.Status_audio_volume_muted_icon;
            pbxSound.Image = audioFull;
            playSound();
        }

        private void playSound()
        {
            SoundPlayer cardShuffleSound = new SoundPlayer( Properties.Resources.Cards_Shuffling);
            cardShuffleSound.Play();
        }

        private void pbxSound_Click(object sender, EventArgs e)
        {
            changeImage();
        }


        private void changeImage()
        {

            if (pbxSound.Image == audioFull)
            {
                pbxSound.Image = audioMute;
            }
            else
            {
                pbxSound.Image = audioFull;

            }

        }

        private void Card_Click(object sender, EventArgs e)
        {
           
            cbxCards = (CardBoxComponent)sender;
            Card humanDefendCard = cbxCards.Card;
            
            if(humanAttackTurn() == false)
            {
                if(humanDefend(humanDefendCard))
                {
                    btnAction.Text = "...";
                    btnAction.Enabled = false;
                    playingField.clearPlayingField();
                    txtMoves.Text = "Ai Discarded cards";
                    isHumanTurn = true;
                    isHumanAttacking = true;
                }

                whoWin();
                

                displayPlayingCard();
                displayAiHand();
                displayHumanHand();
                displayDeck();
                refillCards();
                
            }
        }




        private void btnAction_Click(object sender, EventArgs e)
        {
            if (btnAction.Text == "Discard")
            {

                playingField.clearPlayingField();
                whoWin();
                refillCards();
                isHumanTurn = false;
                aiAttackTurn();
                


            }
            else if (btnAction.Text == "Take")
            {
                for (int i = 0; i < playingField.totalCards(); i++)
                {
                    playerHandHuman.addCard(playingField.GetCard(i));
                    playingField.clearPlayingField();

                }
                whoWin();
                refillCards();
                isHumanTurn = false;
                aiAttackTurn();
                


            }

            displayPlayingCard();
            displayAiHand();
            displayHumanHand();
            displayDeck();
           
        }

        public void whoWin()
        {
            if (playerHandAi.totalCards() == 0)
            {

                if (MessageBox.Show("You Won the Game!! Ai Loose.", "You Won", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    frmDurakCardGame frmMain = new frmDurakCardGame();

                    frmMain.Show();
                    this.Close();
                    
                    
                }
               

            }

            if (playerHandHuman.totalCards() == 0)
            {

                if(MessageBox.Show("You Won the Game!! Ai Loose.", "You Won", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    frmDurakCardGame frmMain = new frmDurakCardGame();

                    frmMain.Show();
                    this.Close();
                }
            
            }
        }

        public void checkDeckEmpty()
        {
            if(durakDeck.remainingCard() == 0)
            {
                grpBxDeck.Controls.Clear();
                Label newLabel = new Label();
                newLabel.Top = 20;
                newLabel.Left = 50;
                newLabel.Text = "Keep It Up";
                grpBxDeck.Controls.Add(newLabel);
            }
        }
    }
}
