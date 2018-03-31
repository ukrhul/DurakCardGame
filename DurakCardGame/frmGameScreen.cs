using System;
using System.Drawing;
using System.Windows.Forms;

namespace DurakCardGame 
{
    public partial class frmGameScreen : Form
    {

        PictureBox[] cardDeck = new PictureBox[52];
        //public const string PATH_OF_CARDS

        public frmGameScreen()
        {
            InitializeComponent();
            SetPosition(2);
        }

        public void SetPosition(int numberOfPlayer)
        {
           //PictureBox[] cardDeck = new PictureBox[numberOfPlayer - 1];
            
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

            if (numberOfPlayer == 2)
            {
                Image image = Properties.Resources.background;
                var pictureBox = new PictureBox();
                pictureBox.BackColor = System.Drawing.Color.AliceBlue;
                pictureBox.Width = 100;
                pictureBox.Height = 100;
                pictureBox.Top = 10;
                pictureBox.Left = 10;
                cardDeck[0].Image = image;
            }

        }

    }
}
