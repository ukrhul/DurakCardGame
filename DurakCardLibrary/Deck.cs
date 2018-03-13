using DurakCardGame;
using System;

namespace DurakCardLibrary
{
    public class Deck
    {
        private Card[] cards;           //Creates the array of cards

        #region" --- Deck Method ---"
        /// <summary>
        /// Deck method to assign the cards
        /// </summary>
        public Deck()
        {
            cards = new Card[52];        //Creates the new Card array of size 52

            //for loop to go through suit 
            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                //for loop to go through rank
                for (int rankVal = 1; rankVal < 14; rankVal++)
                {
                    //Assign the value to the card
                    cards[suitVal * 13 + rankVal - 1] = new Card((Suit)suitVal, (Rank)rankVal);
                }
            }
        }
        #endregion

        #region"--- Shuffle Method ---"
        /// <summary>
        /// Shuffle method to shuffle the deck
        /// </summary>
        public void Shuffle()
        {
            Card[] newDeck = new Card[52];          //Array to store the card of type Card
            bool[] assigned = new bool[52];         //Array of bool to check card already assigned or not
            Random sourceGen = new Random();        //Instance to generate random number

            //for loop to go through all cards 
            for (int i = 0; i < 52; i++)
            {
                int destCard = 0;               //Variable to store the index of card
                bool foundCard = false;         //Boolean type variable to check card is found or not

                //if card is not found
                while (foundCard == false)
                {
                    //Generate number b/w 1 to 52
                    destCard = sourceGen.Next(52);
                    if (assigned[destCard] == false)        //if assigned card is not true(present)
                        foundCard = true;                   //set to foundCard true
                }
                assigned[destCard] = true;                  // set to true(present) to assigned array
                newDeck[destCard] = cards[i];               //Assign the card in array
            }
            newDeck.CopyTo(cards, 0);                      //Copy the array to newDeck
        }
        #endregion

    }
}
