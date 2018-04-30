/** CardBox.cs
*	
*	This is the CardBox class
*	to dynamically creates the
*   property of cards to set the
*   rank, suit and value
*	of card 
*   
*	Author		  Rahul, Jaspreet Kaur, Remya Zacharias
*	Since		  1.0 (25 March 2018)
*	Version       2.0 (27 April 2018)
*	Reference     I. (2018, January 30). CardBox Tutorial 1: Class Library Review (1 of 6).
*	              Retrieved March 25, 2018,
*	              from https://www.youtube.com/watch?v=xXohVJYKqjw&list=PLfNfAX7mRzNqDFJr-9UJZ6praJY10fXvY&index=2
*/
using System;
using DurakCardLibrary;
using System.Windows.Forms;
using DurakCardGame;
using System.Media;

namespace CardBox
{
    public partial class CardBoxComponent : UserControl
    {

        public event EventHandler cardClicked;
                
        #region " --- Property Procedures ---"
        private Card myCard;       //Variable of type card to set the card details

        /// <summary>
        /// Property to get and set the card
        /// </summary>
        public Card Card
        {
            get { return myCard; }
            set
            {
                myCard = value;
                updateCardImage();    // Update the image of card
            }
        }

        /// <summary>
        /// Property to get and set the suit
        /// </summary>
        public Suit Suit
        {
            get { return Card.Suit; }
            set
            {
                Card.Suit = value;   
                updateCardImage();   // Update the image of card
            }
        }

        /// <summary>
        /// Property to get and set the rank
        /// </summary>
        public Rank Rank
        {
            get { return Card.Rank; }
            set
            {
                Card.Rank = value;
                updateCardImage();   // Update the image of card
            }
        }

        /// <summary>
        /// Property to get and set the face status
        /// </summary>
        public FaceStatus FaceUp
        {
            get { return Card.FaceUp; }
            set
            {
                Card.FaceUp = value;
                updateCardImage();   // Update the image of card
            }
        }

       
        #endregion

        #region " --- Constructors ---"
        /// <summary>
        /// Default constructors 
        /// </summary>
        public CardBoxComponent()
        {
            InitializeComponent();   // Initialise the card box components
            myCard = new Card();     // Instance of card
            myCard.Suit = Suit.Clubs;
            myCard.Rank = Rank.Ace;
        }
        #endregion

        #region " --- Methods ---"
        /// <summary>
        /// updateCardImage method to set
        /// the picture box to card
        /// </summary>
        public void updateCardImage()
        {
            // Setting the mycard image to picture box
            pbCardImage.Image = myCard.GetCardImage();
        }

        /// <summary>
        /// Overriding the toString method
        /// </summary>
        /// <returns>overrided String</returns>
        public override string ToString()
        {
            return myCard.ToString();
        }

        #endregion

        #region " --- Event Handler ---"
        /// <summary>
        /// When Cardbox first loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardBox_Load(object sender, EventArgs e)
        {
            updateCardImage();      //Call the updateCardImage method
        }
        #endregion

        private void pbCardImage_Click(object sender, EventArgs e)
        {
            OnCardClick(EventArgs.Empty);
            cardClickSound();
        }

        protected virtual void OnCardClick(EventArgs e)
        {
            if (cardClicked != null)
                cardClicked(this, e);
        }

        private void cardClickSound()
        {
            SoundPlayer clickSound = new SoundPlayer(Properties.Resources.CardClicked);
            clickSound.Play();
        }

    }
}
