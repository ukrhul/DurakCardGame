﻿using System;
using System.Windows.Forms;

namespace DurakCardGame
{
    public partial class frmDurakCardGame : Form
    {
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
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure? You want to exit!", "Exit Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
            
        }
    }
}
