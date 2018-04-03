using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurakCardLibrary
{
    public class PlayerHand : ICloneable
    {
       private Cards playerHand = new Cards();

        public PlayerHand()
        {
         //  playerHand = (Cards)playerHand.Clone();
        }

        public PlayerHand(Cards playerCards)
        {
            playerHand = playerCards;
        }

        public void addCard(Card card)
        {
            playerHand.Add(card);
        }

        public void addCards(Cards cards)
        {
            for (int i = 0; i < cards.Count(); i++)
            {
                playerHand.Add(cards[i]);
            }
        }

        public void removeCardFromHand(Card card)
        {
            playerHand.Remove(card);
        }

        public void removeCardsFromHand(Cards cards)
        {
            for (int i = 0; i < cards.Count(); i++)
            {
                playerHand.Remove(cards[i]);
            }
        }

        public int totalCards()
        {
            return playerHand.Count();
        }
        public object Clone()
        {
            PlayerHand newplayerHand = new PlayerHand(playerHand.Clone() as Cards);
            return newplayerHand;
        }


    }
}
