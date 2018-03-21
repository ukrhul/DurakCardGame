using System;
using System.Windows.Forms;

namespace DurakCardGame 
{
    public partial class frmGameScreen : Form
    {
        private PictureBox[] cardsPictures;

        //public const string PATH_OF_CARDS

        public frmGameScreen()
        {
            InitializeComponent();
            cardsPictures = new PictureBox[52];
        }



    }
}
