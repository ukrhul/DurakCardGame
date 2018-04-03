using CardBox;
using DurakCardGame;
using DurakCardLibrary;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DurakCardGame
{
    public partial class frmGameScreen : Form
    {
       // int deckSize = 36;
        Deck durakDeck = new Deck();
        CardBoxComponent cbxCards;

        public frmGameScreen()
        {
            InitializeComponent();
           // setDefault();
            
        }

       public void setDefault(int deckSize)
        {
            Deck durakDeck = new Deck(deckSize);
            durakDeck.Shuffle(deckSize);
            createDeck(durakDeck);
            createPlayersHand(durakDeck);
            grpBxDeck.Controls.Clear();
            createDeck(durakDeck);
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
                //cbxCards.FaceUp = FaceStatus.Up;
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

        public void createPlayersHand(Deck durakDeck)
        {

            PlayerHand playerHand = new PlayerHand();
            DurakPlayer durakPlayer1 = new DurakPlayer("Rahul", playerHand, false);

            durakPlayer1.RefillHand(durakDeck);
            
            grpBxPlayer1.Controls.Clear();
            for (int i = 0; i < 6; i++)
            {
                CardBoxComponent cbxCards1 = new CardBoxComponent();
                cbxCards1.Card = durakPlayer1.GetCard(i);
                cbxCards1.Left = 5 + (i * 10);
                cbxCards1.Top = 12;
                cbxCards1.Height = 60;
                cbxCards1.Width = 40;
               // cbxCards.FaceUp = FaceStatus.Up;
                grpBxPlayer1.Controls.Add(cbxCards1);
                
            }

            Label lblPlayerCounter = new Label();
            lblPlayerCounter.Top = 180;
            lblPlayerCounter.Left = 50;
            lblPlayerCounter.Text = durakPlayer1.totalCards().ToString();
            grpBxPlayer1.Controls.Add(lblPlayerCounter);


        }

        private void frmGameScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelpForm helpForm = new frmHelpForm();
            helpForm.ShowDialog();
        }
    }
}
