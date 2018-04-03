using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DurakCardGame
{
    public partial class frmHelpForm : Form
    {
        public frmHelpForm()
        {
            InitializeComponent();
        }

        private void lklblDurakVideo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=hQHW_CuGG2A");
        }

        private void lklblFaviconImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.ca/url?sa=i&rct=j&q=&esrc=s&source=images&cd=&ved=0ahUKEwi-p8S2-YrZAhUq9YMKHbFuAcEQjBwIBA&url=http%3A%2F%2Fwww.iconarchive.com%2Fdownload%2Fi48635%2Fcustom-icon-design%2Fpretty-office-7%2FGame-playingcards.ico&psig=AOvVaw32CX2czDwBjubdyIidBaos&ust=1517788636555123");
        }

        private void lklbBackCard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://4vector.com/i/free-vector-gyrosigma-vector-black-background_016483_2.jpg");
        }

        private void lklbDeckImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://acbl.mybigcommerce.com/52-playing-cards/");
        }

        private void lklbBackgroundImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://4vector.com/i/free-vector-gyrosigma-vector-black-background_016483_2.jpg");
        }

        private void lklbDurakRules_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.pagat.com/beating/podkidnoy_durak.html");
        }
    }
}
