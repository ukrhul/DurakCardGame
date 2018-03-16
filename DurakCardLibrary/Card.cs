using DurakCardGame;
using System;

namespace DurakCardLibrary
{
    public class Card : ICloneable
    {
        /// <summary>
        /// Readonly Variables of type enumeration
        /// </summary>
        public readonly Rank rank;          //Variable to store the rank of card
        public readonly Suit suit;          //Variable to store the suit of card

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
            suit = newSuit;             //Assign newSuit to Suit 
            rank = newRank;             //Assign newRank to Rank
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
            return "The " + rank + " of " + suit + "s";
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
            return (card1.suit == card2.suit) && (card1.rank == card2.rank);
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
            return 13 * (int)suit + (int)rank;
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
            if (card1.suit == card2.suit)
            {
                if (isAceHigh)      // if Ace is high
                {
                    // if card1 rank is Ace
                    if (card1.rank == Rank.Ace)
                    {
                        // if card2 rank is Ace
                        if (card2.rank == Rank.Ace)
                            return false;       //return false
                        else
                            return true;        //return true
                    }
                    else  //otherwise
                    {
                        // if card2 rank is Ace
                        if (card2.rank == Rank.Ace)
                            return false;       //return false
                        else
                            return (card1.rank > card2.rank);   //rank of card1 is greater than rank of card2 
                    }
                }
                else  //otherwise
                {
                    return (card1.rank > card2.rank);  //rank of card1 is greater than rank of card2 
                }
            }
            else  //otherwise
            {
                //if card is trumo and using trump
                if (useTrumps && (card2.suit == Card.trump))
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
            if (card1.suit == card2.suit)
            {
                // if Ace is set as high
                if (isAceHigh)
                {
                    // if card1 rank is Ace
                    if (card1.rank == Rank.Ace)
                    {
                        return true;        //return true
                    }
                    else    //otherwise
                    {
                        // if card2 rank is Ace
                        if (card2.rank == Rank.Ace)
                            return false;       //return false
                        else
                            return (card1.rank >= card2.rank);      //rank of card1 is >= rank of card2
                    }
                }
                else  //otherwise
                {
                    return (card1.rank >= card2.rank);  //rank of card1 is >= rank of card2
                }
            }
            else   //otherwise
            {
                //if useTrumps is true and card2 is a trump
                if (useTrumps && (card2.suit == Card.trump))
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