using CardBox;
using DurakCardGame;
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
       // int deckSize = 36;
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
           // setDefault();
            
        }

       public void setDefault(int deckSize)
        {
            Deck durakDeck = new Deck(deckSize);

            durakDeck.Shuffle(deckSize);

            

            createPlayersHand(durakDeck);

            grpBxDeck.Controls.Clear();

            createDeck(durakDeck);

            displayPlayingCard();
            displayAiHand();
            displayHumanHand();
            //lblDeckCounter.Text = durakDeck.remainingCard().ToString();
        }

        public void createDeck(Deck durakDeck)
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
                cbxCards.FaceUp = FaceStatus.Down;
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
            
            durakAi.RefillHand(durakDeck);
            durakHuman.RefillHand(durakDeck);
            cbxTrumpCard.Card = durakAi.GetCard(5);
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
            
            playingField.addCard(cbxCards.Card);

            if (playerAi.aiAttack(cbxCards.Card, playerHandAi, playingField))
            {
                btnAction.Text = "Discard";
            }

            displayPlayingCard();
            displayAiHand();
            displayHumanHand();
            
        }
    }
}
