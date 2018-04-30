/** GameMoves.cs
*	
*	This is the game move class
*	that contains the move and
*	logic of game
*   
*	Author		  Rahul, Jaspreet Kaur, Remya Zacharias
*	Since		  1.0 (25 March 2018)
*	Version       2.0 (27 April 2018)
*/
using DurakCardLibrary;


namespace DurakCardGame
{
    public partial class frmGameScreen
    {

        private bool isHumanTurn = true;
        private bool isHumanAttacking = true;
        private bool isHumanDefending = true;


        public bool humanAttackTurn()
        {
         
            if (isHumanTurn)
            {
                if (isHumanAttacking)
                {
                    txtMoves.Text= "You Attack with " + cbxCards.ToString() + "."; 
                    playingField.addCard(cbxCards.Card);
                    playerHandHuman.removeCardFromHand(cbxCards.Card);

                        if (playerAi.aiDefend(cbxCards.Card, playerHandAi, playingField, txtMoves))
                        {
                            txtMoves.Text = "Ai defended you using " + playingField.GetCard(1).ToString() + ".";
                            btnAction.Enabled = true;
                            btnAction.Text = "Discard";
                            isHumanTurn = false;
                            isHumanAttacking = false;
                       
                    }
    
                }
              
            }
            refillCards();
            displayPlayingCard();
            displayAiHand();
            displayHumanHand();
            displayDeck();
            return isHumanAttacking;
        }

        public void aiAttackTurn()
        {
            if (!isHumanTurn)
            {
                if (isHumanDefending)
                {
                    do
                    {

                        Card tempAiCard = new Card();
                        tempAiCard = playerAi.aiAttack(playerHandAi);
                        playingField.addCard(tempAiCard);
                        playerHandAi.removeCardFromHand(tempAiCard);
                        txtMoves.Text = "Ai attacked with " + tempAiCard.ToString();
                        btnAction.Enabled = true;
                        btnAction.Text = "Take";
                        isHumanTurn = true;
                        isHumanAttacking = false;
                        isHumanDefending = true;


                    } while (isHumanTurn == false);
                }
            }

            displayPlayingCard();
            displayAiHand();
            displayHumanHand();
        }

        public bool humanDefend(Card defendCard)
        {
            bool isSuccess = false;
            if (isHumanTurn)
            {
                if(isHumanDefending)
                {
                    if(playerAi.humanDefend(defendCard, playingField))
                    {
                        playerHandHuman.removeCardFromHand(cbxCards.Card);
                        isSuccess = true;
                    }
                }
            }

            return isSuccess;
        }

        public void refillCards()
        {
            if(playerHandAi.totalCards() < 6 && durakDeck.remainingCard() != 0 )
            {
                durakAi.RefillHand(durakDeck, playerHandAi);

            }
            if(playerHandHuman.totalCards() < 6 && durakDeck.remainingCard() != 0)
            {
                durakHuman.RefillHand(durakDeck, playerHandHuman);
            }
            checkDeckEmpty();
        }
      

    }
}
