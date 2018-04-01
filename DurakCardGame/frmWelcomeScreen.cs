using System;
using System.Windows.Forms;
using DurakCardLibrary;

namespace DurakCardGame
{
    public partial class frmDurakCardGame : Form
    {
        frmGameScreen gmScreen = new frmGameScreen();

        public frmDurakCardGame()
        {
            InitializeComponent();
        }

        private void DurakCardGame_Load(object sender, EventArgs e)
        {
            cbxDeckSize.SelectedIndex = 1;
        }


        private void btnStart_Click(object sender, EventArgs e)
        {

            gmScreen.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure? You want to exit!", "Exit Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void cbxDeckSize_SelectedIndexChanged(object sender, EventArgs e)
        {

           // frmGameScreen gmSetting = new frmGameScreen();

            if (cbxDeckSize.SelectedIndex == 0)
            {
                gmScreen.createDeck((int)DeckSize.DeckSize20);
            }
            else if(cbxDeckSize.SelectedIndex == 1)
            {
                gmScreen.createDeck((int)DeckSize.DeckSizeDefault);
            }
            else if (cbxDeckSize.SelectedIndex == 2)
            {
                gmScreen.createDeck((int)DeckSize.DeckSizeFull);
            }

        }

        private void nudPlayer_ValueChanged(object sender, EventArgs e)
        {
            int numberOfPlayers = (int)nudPlayer.Value;
            switch(numberOfPlayers)
            {
                case 1:

                    break;

                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
            }
        }
    }
}
