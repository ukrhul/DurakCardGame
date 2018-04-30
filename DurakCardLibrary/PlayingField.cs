using System;
using System.Collections.Generic;
using System.Linq;


namespace DurakCardLibrary
{
    public class PlayingField : ICloneable
    {

        Cards playingFieldCard = new Cards();


        public void addCard(Card aCard)
        {
            playingFieldCard.Add(aCard);
        }
        
        public void removeCard(Card aCard)
        {
            playingFieldCard.Remove(aCard);
        }

        public object Clone()
        {
           
            return ((ICloneable)playingFieldCard).Clone();
        }

        public PlayingField(Cards newPlayingField)
        {
            playingFieldCard = newPlayingField;
        }

        public PlayingField() { }

        public void clearPlayingField()
        {
            playingFieldCard.Clear();
        }

        public void removeCards(Cards cards)
        {
            for (int i = 0; i < cards.Count(); i++)
            {
                playingFieldCard.Remove(cards[i]);
            }
        }

        public int totalCards()
        {
            return playingFieldCard.Count();
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
                return playingFieldCard[cardNum];          //return card
            else   //Otherwise
                   //Throw out of range exception
                throw (new System.ArgumentOutOfRangeException("cardNum", cardNum, "Value must be between 0 and 51."));
        }
        #endregion

    }
}
