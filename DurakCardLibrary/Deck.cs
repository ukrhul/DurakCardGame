using Ch11CardLib;
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
			// cards = new Card[52];        //Creates the new Card array of size 52

			//for loop to go through suit 
			for (int suitVal = 0; suitVal < 4; suitVal++)
			{
				//for loop to go through rank
				for (int rankVal = 1; rankVal < 14; rankVal++)
				{
					//Assign the value to the card
					//cards[suitVal * 13 + rankVal - 1] = new Card((Suit)suitVal, (Rank)rankVal);
					cards.Add(new Card((Suit)suitVal, (Rank)rankVal));
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
		public void Shuffle()
		{
			//Card[] newDeck = new Card[52];          //Array to store the card of type Card
			Cards newDeck = new Cards();
			bool[] assigned = new bool[52];         //Array of bool to check card already assigned or not
			Random sourceGen = new Random();        //Instance to generate random number

			//for loop to go through all cards 
			for (int i = 0; i < 52; i++)
			{
				//int destCard = 0;               //Variable to store the index of card
				int sourceCard = 0;
				bool foundCard = false;         //Boolean type variable to check card is found or not

				//if card is not found
				while (foundCard == false)
				{
					//Generate number b/w 1 to 52
					sourceCard = sourceGen.Next(52);
					if (assigned[sourceCard] == false)        //if assigned card is not true(present)
						foundCard = true;                   //set to foundCard true
				}
				assigned[sourceCard] = true;                  // set to true(present) to assigned array
				newDeck.Add(cards[sourceCard]);             //Assign the card in array
			}
			newDeck.CopyTo(cards);                      //Copy the array to newDeck
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

	}
}
