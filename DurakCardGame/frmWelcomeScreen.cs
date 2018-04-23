using System;
using System.Windows.Forms;
using DurakCardLibrary;

namespace DurakCardGame
{
    public partial class frmDurakCardGame : Form
    {
        frmGameScreen gmScreen = new frmGameScreen();

        DeckSizeEnum deckSize = DeckSizeEnum.DeckSizeDefault;


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
            gmScreen.setDefault((int)deckSize);
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

            if (cbxDeckSize.SelectedIndex == 0)
            {
                deckSize = DeckSizeEnum.DeckSize20;
            }
            else if(cbxDeckSize.SelectedIndex == 1)
            {
                deckSize = DeckSizeEnum.DeckSizeDefault;
            }
            else if (cbxDeckSize.SelectedIndex == 2)
            {
                deckSize = DeckSizeEnum.DeckSizeDefault;
            }

        }

        private void nudPlayer_ValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}
