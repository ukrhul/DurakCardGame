using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DurakCardGame
{
    public class CardDisplayAndLayout
    {
        private PictureBox[] cardsPictures;

        public PictureBox[] CreateDeck(int DeckSize)
        {
            switch (DeckSize)
            {
                case 0:
                    cardsPictures = new PictureBox[20];
                    break;

                case 1:
                    cardsPictures = new PictureBox[36];
                    break;

                case 2:
                    cardsPictures = new PictureBox[52];
                    break;
            }

            return cardsPictures;
        }

        public void SetPosition(int numberOfPlayer)
        {
            PictureBox[] cardDeck = new PictureBox[numberOfPlayer-1];
            //switch(playerNumber)
            //{
            //    case 3:
            //        cardDeck.Left = 10;
            //        cardDeck.Top = 10;
            //        break;

            //    case 4:
            //        cardDeck.Left = 10;
            //        cardDeck.Top = 10;
            //        break;
            //}

            if(numberOfPlayer == 2)
            {
                cardsPictures[0].Top = 10;
                cardsPictures[1].Left = 10;
            }

        }


    }
}
