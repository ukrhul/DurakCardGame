
/** Cards.cs
*	
*	This is the Cards class which is
*	using collection to add, remove,
*	copyTo, contains and clone method
*	for cards.
*   
*	Author		  Rahul
*	Since		  1.0 (25 Feb 2018)
*	Version       2.0 (11 March 2018)
*	Reference     Chapter 12 Example Application Page 295 From Beginning Visual C# 2012 
*/
using System;
using System.Collections;
using System.Collections.Generic;
using DurakCardLibrary;

namespace Ch11CardLib
{
    public class Cards: List<Card>, ICloneable
    {
        ///// <summary>
        ///// Method to add the card to the collection list
        ///// </summary>
        ///// <param name="newCard">parameter for the card</param>
        //public void Add(Card newCard)
        //{
        //    List.Add(newCard);  //Add the card to the collection list
        //}

        ///// <summary>
        ///// Method to remove the card from the collection list
        ///// </summary>
        ///// <param name="oldCard"></param>
        //public void Remove(Card oldCard)
        //{
        //    List.Remove(oldCard);  //Remove the card from the collection list
        //}

        ///// <summary>
        ///// Property to get and set the card
        ///// </summary>
        ///// <param name="cardIndex">index of the card</param>
        ///// <returns>Card value</returns>
        //public Card this[int cardIndex]
        //{
        //    get
        //    {
        //        return (Card)List[cardIndex];       //return the card from list
        //    }
        //    set
        //    {
        //        List[cardIndex] = value;            //set the value to list at card index
        //    }
        //}

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

        ///// <summary>
        ///// Contains method to check collection contains card or not
        ///// </summary>
        ///// <param name="card"></param>
        ///// <returns>Boolean value</returns>
        //public bool Contains(Card card)
        //{
        //    return InnerList.Contains(card);    //return true or false
        //}

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
