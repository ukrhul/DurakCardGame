using DurakCardGame;
using System;

namespace DurakCardLibrary
{

    public class Deck : ICloneable
	{
		//private Card[] cards;           //Creates the array of cards
		private Cards cards = new Cards();

		#region"--- Constructors ---"
		/// <summary>
		/// Contructor to set the cards 
		/// </summary>
		/// <param name="newCards"></param>
		private Deck(Cards newCards)
		{
			cards = newCards;
		}

        /// <summary>
        /// Nondefault constructor. Allows aces to be set high.
        /// </summary>
        public Deck(bool isAceHigh) : this()
        {
            Card.isAceHigh = isAceHigh;
        }

        /// <summary>
        /// Nondefault constructor. Allows a trump suit to be used.
        /// </summary>
        public Deck(bool useTrumps, Suit trump) : this()
        {
            Card.useTrumps = useTrumps;
            Card.trump = trump;
        }

        /// <summary>
        /// Nondefault constructor. Allows aces to be set high and a trump suit
        /// to be used.
        /// </summary>
        public Deck(bool isAceHigh, bool useTrumps, Suit trump) : this()
        {
            Card.isAceHigh = isAceHigh;
            Card.useTrumps = useTrumps;
            Card.trump = trump;
        }

        /// <summary>
        /// Deck method to assign the cards
        /// </summary>
        public Deck()
		{

            //for loop to go through suit 
            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                //for loop to go through rank
                for (int rankVal = 1; rankVal < 14; rankVal++)
                {
                    //Assign the value to the card
                    cards.Add(new Card((Suit)suitVal, (Rank)rankVal));
                }
            }
        }

        public Deck(int deckSize)
        {

            //for loop to go through suit 
            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                //for loop to go through rank
                for (int rankVal = 1; rankVal < 14; rankVal++)
                {
                    if (deckSize == (int)DeckSizeEnum.DeckSize20)
                    {

                        if (rankVal > 9 || rankVal < 2)
                        {
                            cards.Add(new Card((Suit)suitVal, (Rank)rankVal));
                        }

                    }
                    else if (deckSize == (int)DeckSizeEnum.DeckSizeDefault)
                    {
                        if (rankVal < 2 || rankVal > 5)
                        {
                            cards.Add(new Card((Suit)suitVal, (Rank)rankVal));

                        }
                    }
                    else
                    {
                        //Assign the value to the card
                        cards.Add(new Card((Suit)suitVal, (Rank)rankVal));
                    }
                }
            }
        }
        #endregion


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

        #region"--- Shuffle Method ---"
        /// <summary>
        /// Shuffle method to shuffle the deck
        /// </summary>
        public void Shuffle(int deckSize)
		{
            if (deckSize == (int)DeckSizeEnum.DeckSize20)
            {
                Cards newDeck = new Cards();
                bool[] assigned = new bool[(int)DeckSizeEnum.DeckSize20];         //Array of bool to check card already assigned or not
                Random sourceGen = new Random();        //Instance to generate random number

                //for loop to go through all cards 
                for (int i = 0; i < (int)DeckSizeEnum.DeckSize20; i++)
                {
                    int sourceCard = 0;
                    bool foundCard = false;         //Boolean type variable to check card is found or not

                    //if card is not found
                    while (foundCard == false)
                    {
                        //Generate number b/w 1 to 20
                        sourceCard = sourceGen.Next((int)DeckSizeEnum.DeckSize20);
                        if (assigned[sourceCard] == false)        //if assigned card is not true(present)
                            foundCard = true;                   //set to foundCard true
                    }
                    assigned[sourceCard] = true;                  // set to true(present) to assigned array
                    newDeck.Add(cards[sourceCard]);             //Assign the card in array
                }
                newDeck.CopyTo(cards);                      //Copy the array to newDeck
            }
            else if(deckSize == (int)DeckSizeEnum.DeckSizeDefault)
            {
                Cards newDeck = new Cards();
                bool[] assigned = new bool[(int)DeckSizeEnum.DeckSizeDefault];         //Array of bool to check card already assigned or not
                Random sourceGen = new Random();        //Instance to generate random number

                //for loop to go through all cards 
                for (int i = 0; i < (int)DeckSizeEnum.DeckSizeDefault; i++)
                {
                    int sourceCard = 0;
                    bool foundCard = false;         //Boolean type variable to check card is found or not

                    //if card is not found
                    while (foundCard == false)
                    {
                        //Generate number b/w 1 to 36
                        sourceCard = sourceGen.Next((int)DeckSizeEnum.DeckSizeDefault);
                        if (assigned[sourceCard] == false)        //if assigned card is not true(present)
                            foundCard = true;                   //set to foundCard true
                    }
                    assigned[sourceCard] = true;                  // set to true(present) to assigned array
                    newDeck.Add(cards[sourceCard]);             //Assign the card in array
                }
                newDeck.CopyTo(cards);                      //Copy the array to newDeck
            }
            else if (deckSize == (int)DeckSizeEnum.DeckSizeFull)
            {
                Cards newDeck = new Cards();
                bool[] assigned = new bool[(int)DeckSizeEnum.DeckSizeFull];         //Array of bool to check card already assigned or not
                Random sourceGen = new Random();        //Instance to generate random number

                //for loop to go through all cards 
                for (int i = 0; i < (int)DeckSizeEnum.DeckSizeFull; i++)
                {
                    int sourceCard = 0;
                    bool foundCard = false;         //Boolean type variable to check card is found or not

                    //if card is not found
                    while (foundCard == false)
                    {
                        //Generate number b/w 1 to 52
                        sourceCard = sourceGen.Next((int)DeckSizeEnum.DeckSizeFull);
                        if (assigned[sourceCard] == false)        //if assigned card is not true(present)
                            foundCard = true;                   //set to foundCard true
                    }
                    assigned[sourceCard] = true;                  // set to true(present) to assigned array
                    newDeck.Add(cards[sourceCard]);             //Assign the card in array
                }
                newDeck.CopyTo(cards);                      //Copy the array to newDeck
            }

        }
		#endregion

		#region"--- Clone Method ---"
		/// <summary>
		/// Clone method for copying
		/// </summary>
		/// <returns></returns>
		public object Clone()
		{
			// Instance of Deck class with cloned cards
			Deck newDeck = new Deck(cards.Clone() as Cards);
			return newDeck;     //return the cloned deck
		}
		#endregion

        public int remainingCard()
        {
            return cards.Count; 
        }

        public Card removeCard()
        {
            Card myCard = new Card();
            if(cards != null)
            {
                myCard = cards[0];
                cards.RemoveAt(0);
            }

            return myCard;
        }

        public Cards removeCards(int totalCards)
        {
            Cards myCards = new Cards();

            for (int i = 0; i < totalCards; i++)
            {
                myCards.Add(cards[0]);
                cards.RemoveAt(0);
            }

            return myCards;
        }

    }
}
