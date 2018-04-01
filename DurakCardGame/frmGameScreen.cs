using CardBox;
using DurakCardLibrary;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DurakCardGame
{
    public partial class frmGameScreen : Form
    {

        Deck durakDeck;

        public frmGameScreen()
        {
            InitializeComponent();
            setDefault();
        }

       public void setDefault()
        {
            CardBoxComponent cbxDeck = new CardBoxComponent();
            cbxDeck.Left = 14;
            cbxDeck.Top = 14;
            cbxDeck.Height = 60;
            cbxDeck.Width = 40;
            grpBxDeck.Controls.Add(cbxDeck);

        }

        public void createDeck(int deckSize)
        {
            durakDeck = new Deck(deckSize);
            durakDeck.Shuffle(deckSize);
            lblDeckCounter.Text = durakDeck.remainingCard().ToString();
        }

    }
}
