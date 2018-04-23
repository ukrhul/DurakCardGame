using DurakCardLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurakCardGame
{
    public class PlayerAI : DurakPlayer
    {
        //PlayingField playingField = new PlayingField();

        public bool aiAttack(Card playingFieldCard, PlayerHand aiHand, PlayingField currentPlayingField)
        {
            Card goodCard = new Card();
            goodCard = aiHand.GetCard(0);

            bool isGoodCard = false;
            bool isDefended = false;

            for (int i = 0; i < aiHand.totalCards(); i++)
            {
                Card handCard = new Card();
                handCard = aiHand.GetCard(i);
                if (playingFieldCard.Suit == handCard.Suit && playingFieldCard.Rank < handCard.Rank)
                {
                    if (handCard < goodCard)
                    {
                        goodCard = handCard;
                        isGoodCard = true;
                    }
                    else 
                    {
                        goodCard = handCard;
                        isGoodCard = true;
                    }

                }
             
            }

            if (isGoodCard)
            {
                currentPlayingField.addCard(goodCard);
                isDefended = true;
            }
            else
            {
                aiHand.addCard(playingFieldCard);
                isDefended = false;
            }

            return isDefended;
        }

    }
}
