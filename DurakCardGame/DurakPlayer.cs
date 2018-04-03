using CardBox;
using DurakCardLibrary;
using System;

namespace DurakCardGame
{
    public class DurakPlayer : Player
    {
   
        private PlayerHand playerHand = new PlayerHand();
        Cards cards = new Cards();

        public PlayerHand PlayerHand
        {
            get { return playerHand; }
            set { playerHand = value; }
        }

        public bool isHuman;

        public bool IsHuman
        {
            get {return isHuman; }
            set { isHuman = value; }
        }

        public DurakPlayer()
        {
            
        }

        public DurakPlayer(string name, PlayerHand playerHand, bool isHuman)
        {
            playerName = name;
            PlayerHand = playerHand;
            IsHuman = isHuman;
        }

        public void RefillHand(Deck durakDeck)
        {
            cards = durakDeck.removeCards(6 - playerHand.totalCards());
            playerHand.addCards(cards);
        }

        public int totalCards()
        {
            return playerHand.totalCards();
        }

        #region"--- GetCard Method ---"
        /// <summary>
        /// GetCard method of type card to get the card at given index
        /// </summary>
        /// <param name="cardNum">index of card</param>
        /// <returns>return the value of card</returns>
        public Card GetCard(int cardNum)
        {
            //if cardNum is in between 0 to 51
            if (cardNum >= 0 && cardNum <= 51)
                return cards[cardNum];          //return card
            else   //Otherwise
                   //Throw out of range exception
                throw (new System.ArgumentOutOfRangeException("cardNum", cardNum, "Value must be between 0 and 51."));
        }
        #endregion


    }
}
