using DurakCardGame;
using System;

namespace DurakCardLibrary
{
    public class Card
    {
        public Suit suit;
        public Rank rank;
        public FaceStatus faceStatus;

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
    }
}