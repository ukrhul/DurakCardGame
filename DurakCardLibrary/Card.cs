using DurakCardGame;
using System;
using System.Drawing;

namespace DurakCardLibrary
{
    public class Card : ICloneable
    {
        /// <summary>
        /// Variables of type enumeration
        /// </summary>
        protected Rank myRank;          //Variable to store the rank of card
        public Rank Rank
        {
            get { return myRank; }
            set { myRank = value; }
        }


        protected Suit mySuit;          //Variable to store the suit of card
        public Suit Suit
        {
            get { return mySuit; }
            set { mySuit = value; }
        }

        protected int myValue;
        public int CardValue
        {
            get { return myValue; }
            set { myValue = value; }
        }

        protected FaceStatus isFaceUp;
        public FaceStatus FaceUp
        {
            get { return isFaceUp; }
            set { isFaceUp = value; }
        }
        /// <summary>
        /// Flag for trump usage. If true, trumps are valued higher
        /// than cards of other suits.
        /// </summary>
        public static bool useTrumps = false;

        /// <summary>
        /// Trump suit to use if useTrumps is true.
        /// </summary>
        public static Suit trump = Suit.Clubs;

        /// <summary>
        /// Determines whether aces are higher than kings or lower
        /// than deuces.
        /// </summary>
        public static bool isAceHigh = true;

        #region" --- Constructors --- "
        /// <summary>
        /// Default constructor 
        /// </summary>
        public Card() { } //No parameter

        /// <summary>
        /// Parameterised Constructor
        /// </summary>
        /// <param name="newSuit">Variable to store suit as type Suit enumeration</param>
        /// <param name="newRank">Variable to store rank as type Rank enumeration</param>
        public Card(Suit newSuit, Rank newRank)
        {
            mySuit = newSuit;             //Assign newSuit to Suit 
            myRank = newRank;             //Assign newRank to Rank
            this.myValue = (int)newRank;
        }
        #endregion

        #region" --- Methods --- "
        /// <summary>
        /// Override ToString method to get the value of card
        /// in string format
        /// </summary>
        /// <returns>Return the string</returns>
        public override string ToString()
        {
            //Return the string in below format
            return "The " + myRank + " of " + mySuit;
        }

        /// <summary>
        /// GetCardImage method to get
        /// the image of cards
        /// </summary>
        /// <returns>Image of card</returns>
        public Image GetCardImage()
        {
            Image cardImage;        // Instance of Image
            string imageName;       // Variable to store imagePath

            //if card face is up
            if (isFaceUp == FaceStatus.Up)
            {
                //if card is a face card
                if (myRank == Rank.Ace || myRank == Rank.Jack || myRank == Rank.Queen
                    || myRank == Rank.King)
                {
                    // Take first letter of rank and suit and 
                    // combine it to make imageName
                    string rankLetter = myRank.ToString().Substring(0, 1);
                    string suitLetter = mySuit.ToString().Substring(0, 1);
                    imageName = rankLetter + suitLetter;
                }
                else   //otherwise
                {
                    // Take the rank value and suit first letter
                    // to make the imageName
                    string tempLetter = mySuit.ToString().Substring(0, 1);
                    imageName = "_" + (int)myRank + tempLetter;
                }
            }
            else
            {
                // if face is down then imagename is "green_back"
                imageName = "cheetah_card";
            }

            //Set the Path of cardImage and get the image 
            cardImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);

            return cardImage; //Return the image
        }

        /// <summary>
        /// Clone method for copying
        /// </summary>
        /// <returns>MemberwiseClone</returns>
        public object Clone()
        {
            return MemberwiseClone();
        }

        #endregion

        #region" --- Overrided Operators --- "

        /// <summary>
        /// Overrided operator ==
        /// </summary>
        /// <param name="card1">Card 1 </param>
        /// <param name="card2">Card 2</param>
        /// <returns>boolean value</returns>
        public static bool operator ==(Card card1, Card card2)
        {

            return (card1.mySuit == card2.mySuit) && (card1.myRank == card2.myRank);
        }

        /// <summary>
        /// Overrided operator !=
        /// </summary>
        /// <param name="card1">Card 1 </param>
        /// <param name="card2">Card 2</param>
        /// <returns>boolean value</returns>
        public static bool operator !=(Card card1, Card card2)
        {
            // if cards are not equal
            return !(card1 == card2);
        }

        /// <summary>
        /// Overrided Equals method
        /// </summary>
        /// <param name="card">Card as object</param>
        /// <returns>boolean value</returns>
        public override bool Equals(object card)
        {
            return this == (Card)card;
        }

        /// <summary>
        /// Overrided GetHashCode method
        /// </summary>
        /// <returns>integer value</returns>
        public override int GetHashCode()
        {
            return 13 * (int)mySuit + (int)myRank;
        }

        /// <summary>
        /// Overrided greater than operator (>)
        /// </summary>
        /// <param name="card1">Card 1 </param>
        /// <param name="card2">Card 2</param>
        /// <returns>boolean value</returns>
        public static bool operator >(Card card1, Card card2)
        {
            // if card1 suit is equal to card 2
            if (card1.mySuit == card2.mySuit)
            {
                if (isAceHigh)      // if Ace is high
                {
                    // if card1 rank is Ace
                    if (card1.myRank == Rank.Ace)
                    {
                        // if card2 rank is Ace
                        if (card2.myRank == Rank.Ace)
                            return false;       //return false
                        else
                            return true;        //return true
                    }
                    else  //otherwise
                    {
                        // if card2 rank is Ace
                        if (card2.myRank == Rank.Ace)
                            return false;       //return false
                        else
                            return (card1.myRank > card2.myRank);   //rank of card1 is greater than rank of card2 
                    }
                }
                else  //otherwise
                {
                    return (card1.myRank > card2.myRank);  //rank of card1 is greater than rank of card2 
                }
            }
            else  //otherwise
            {
                //if card is trumo and using trump
                if (useTrumps && (card2.mySuit == Card.trump))
                    return false;       //return false
                else
                    return true;        //return true
            }
        }

        /// <summary>
        /// Overrided less than operator (<)
        /// </summary>
        /// <param name="card1">Card 1 </param>
        /// <param name="card2">Card 2</param>
        /// <returns>boolean value</returns>
        public static bool operator <(Card card1, Card card2)
        {
            return !(card1 >= card2);
        }

        /// <summary>
        /// Overrided greater than or equals to operator(>=)
        /// </summary>
        /// <param name="card1">Card 1 </param>
        /// <param name="card2">Card 2</param>
        /// <returns>boolean value</returns>
        public static bool operator >=(Card card1, Card card2)
        {
            // if suit of card1 == suit of card2
            if (card1.mySuit == card2.mySuit)
            {
                // if Ace is set as high
                if (isAceHigh)
                {
                    // if card1 rank is Ace
                    if (card1.myRank == Rank.Ace)
                    {
                        return true;        //return true
                    }
                    else    //otherwise
                    {
                        // if card2 rank is Ace
                        if (card2.myRank == Rank.Ace)
                            return false;       //return false
                        else
                            return (card1.myRank >= card2.myRank);      //rank of card1 is >= rank of card2
                    }
                }
                else  //otherwise
                {
                    return (card1.myRank >= card2.myRank);  //rank of card1 is >= rank of card2
                }
            }
            else   //otherwise
            {
                //if useTrumps is true and card2 is a trump
                if (useTrumps && (card2.mySuit == Card.trump))
                    return false;       //return false
                else
                    return true;        //return true

            }
        }

        /// <summary>
        /// Overrided less than or equals to operator (<=)
        /// </summary>
        /// <param name="card1">Card 1 </param>
        /// <param name="card2">Card 2</param>
        /// <returns>boolean value</returns>
        public static bool operator <=(Card card1, Card card2)
        {
            return !(card1 > card2);
        }

        #endregion
    }
}