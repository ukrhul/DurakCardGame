/** Cards.cs
*	
*	This is the Cards class which is
*	using collection to add, remove,
*	copyTo, contains and clone method
*	for cards.
*   
*	Author		  Rahul, Jaspreet kaur, Remya Zacharias 
*	Since		  1.0 (25 Feb 2018)
*	Version       3.0 (27 April 2018)
*	Reference     Chapter 12 Example Application Page 295 From Beginning Visual C# 2012 
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace DurakCardLibrary
{
    public class Cards: List<Card>, ICloneable
    {
        /// <summary>
        /// CopyTo method to copy the cards
        /// </summary>
        /// <param name="targetCards">Parameter for targetCards</param>
        public void CopyTo(Cards targetCards)
        {
            // for loop to go through collection of cards
            for (int index = 0; index < this.Count; index++)
            {
                targetCards[index] = this[index];       //assgin card index to target card index
            }
        }

        /// <summary>
        /// Clone method to copy the cards(Deck) 
        /// </summary>
        /// <returns>Cards values</returns>
        public object Clone()
        {
            // Instance of Cards
            Cards newCards = new Cards();

            // foreach loop to go through each card in List
            foreach (Card sourceCard in this)
            {
                // Add the card to the newCards
                newCards.Add((Card)sourceCard.Clone());
            }
            return newCards;    //return the newCards
        }

    }
}
