/** PlayerAI.cs
*	
*	This is the Player AI class
*	that contains the gameplay logic
*	of AI
*   
*	Author		  Rahul, Jaspreet Kaur, Remya Zacharias
*	Since		  1.0 (25 March 2018)
*	Version       2.0 (27 April 2018)
*/
using DurakCardLibrary;
using System.Windows.Forms;

namespace DurakCardGame
{
    public partial class PlayerAI : DurakPlayer
    {

        public bool aiDefend(Card playingFieldCard, PlayerHand aiHand, PlayingField currentPlayingField, TextBox txtMessage)
        {
            Card goodCard = new Card();


            if (aiHand.totalCards() != 0)
            {
                goodCard = aiHand.GetCard(0);

            }

            bool isGoodCard = false;
            bool isDefended = false;

            for (int i = 0; i < aiHand.totalCards(); i++)
            {
                Card handCard = new Card();
                handCard = aiHand.GetCard(i);

                if (playingFieldCard.Suit == handCard.Suit  && playingFieldCard.CardValue < handCard.CardValue)
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
                aiHand.removeCardFromHand(goodCard);
                isDefended = true;
                
            }
            else
            {
                aiHand.addCard(playingFieldCard);
                currentPlayingField.removeCard(playingFieldCard);
                isDefended = false;
                txtMessage.Text = "Ai took the " + playingFieldCard.ToString();
            }

          
            
            return isDefended;
        }


        public Card aiAttack(PlayerHand aiHand)
        {
            //bool isSuccess = false;
            Card aiCard = new Card();
            Card goodCard = new Card();

            if(aiHand.totalCards() != 0)
            {
                 goodCard = aiHand.GetCard(0);

            }

            for (int i = 0; i < aiHand.totalCards(); i++)
            {
                aiCard = aiHand.GetCard(i);
                if (aiCard.CardValue < goodCard.CardValue)
                {
                    goodCard = aiCard;
                }
            }

            return goodCard;
        }

        public bool humanDefend(Card humanCard, PlayingField currentPlayingField)
        {
            bool isSuccess = false;
            if ((humanCard.Suit == currentPlayingField.GetCard(0).Suit) && humanCard.CardValue > currentPlayingField.GetCard(0).CardValue)
            {
                currentPlayingField.addCard(humanCard);
                
                isSuccess = true;
            }

            return isSuccess;
        }

    }
}
