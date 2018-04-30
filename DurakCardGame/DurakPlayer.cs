/** DurakPlayer.cs
*	
*	This is the DurakPlayer class
*	that represent the durak player
*   
*	Author		  Rahul, Jaspreet Kaur, Remya Zacharias
*	Since		  1.0 (25 March 2018)
*	Version       2.0 (27 April 2018)
*/
using DurakCardLibrary;

namespace DurakCardGame
{
    public class DurakPlayer : Player
    {

        Cards cards = new Cards();

        protected PlayerHand playerHand;

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
            this.playerHand = playerHand;
            IsHuman = isHuman;
        }

        public void RefillHand(Deck durakDeck, PlayerHand currentPlayerHand)
        {
            cards = durakDeck.removeCards(6-currentPlayerHand.totalCards());
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
            return playerHand.GetCard(cardNum);          //return card
        }
        #endregion


    }
}
