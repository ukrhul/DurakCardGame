namespace DurakCardGame
{
    partial class frmGameScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DurakCardLibrary.Card card1 = new DurakCardLibrary.Card();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameScreen));
            this.grpBxPlayingField = new System.Windows.Forms.GroupBox();
            this.btnAction = new System.Windows.Forms.Button();
            this.grpBxAi = new System.Windows.Forms.GroupBox();
            this.grpBxHuman = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDeckCounter = new System.Windows.Forms.Label();
            this.grpBxDeck = new System.Windows.Forms.GroupBox();
            this.pbxSound = new System.Windows.Forms.PictureBox();
            this.cbxTrumpCard = new CardBox.CardBoxComponent();
            this.menuStrip1.SuspendLayout();
            this.grpBxDeck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSound)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBxPlayingField
            // 
            this.grpBxPlayingField.BackColor = System.Drawing.Color.Transparent;
            this.grpBxPlayingField.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpBxPlayingField.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxPlayingField.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpBxPlayingField.Location = new System.Drawing.Point(218, 284);
            this.grpBxPlayingField.Name = "grpBxPlayingField";
            this.grpBxPlayingField.Size = new System.Drawing.Size(838, 241);
            this.grpBxPlayingField.TabIndex = 2;
            this.grpBxPlayingField.TabStop = false;
            this.grpBxPlayingField.Text = "Playing Field";
            // 
            // btnAction
            // 
            this.btnAction.BackColor = System.Drawing.Color.Black;
            this.btnAction.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAction.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAction.Location = new System.Drawing.Point(1082, 376);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(136, 58);
            this.btnAction.TabIndex = 4;
            this.btnAction.Text = "DEFAUlT";
            this.btnAction.UseVisualStyleBackColor = false;
            // 
            // grpBxAi
            // 
            this.grpBxAi.BackColor = System.Drawing.Color.Transparent;
            this.grpBxAi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpBxAi.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxAi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpBxAi.Location = new System.Drawing.Point(214, 50);
            this.grpBxAi.Name = "grpBxAi";
            this.grpBxAi.Size = new System.Drawing.Size(852, 214);
            this.grpBxAi.TabIndex = 3;
            this.grpBxAi.TabStop = false;
            this.grpBxAi.Text = "AI";
            // 
            // grpBxHuman
            // 
            this.grpBxHuman.BackColor = System.Drawing.Color.Transparent;
            this.grpBxHuman.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpBxHuman.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxHuman.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpBxHuman.Location = new System.Drawing.Point(218, 531);
            this.grpBxHuman.Name = "grpBxHuman";
            this.grpBxHuman.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpBxHuman.Size = new System.Drawing.Size(838, 192);
            this.grpBxHuman.TabIndex = 4;
            this.grpBxHuman.TabStop = false;
            this.grpBxHuman.Text = "You";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1245, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // lblDeckCounter
            // 
            this.lblDeckCounter.AutoSize = true;
            this.lblDeckCounter.Location = new System.Drawing.Point(70, 205);
            this.lblDeckCounter.Name = "lblDeckCounter";
            this.lblDeckCounter.Size = new System.Drawing.Size(41, 33);
            this.lblDeckCounter.TabIndex = 1;
            this.lblDeckCounter.Text = "36";
            // 
            // grpBxDeck
            // 
            this.grpBxDeck.BackColor = System.Drawing.Color.Transparent;
            this.grpBxDeck.Controls.Add(this.lblDeckCounter);
            this.grpBxDeck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpBxDeck.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxDeck.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpBxDeck.Location = new System.Drawing.Point(12, 284);
            this.grpBxDeck.Name = "grpBxDeck";
            this.grpBxDeck.Size = new System.Drawing.Size(187, 241);
            this.grpBxDeck.TabIndex = 4;
            this.grpBxDeck.TabStop = false;
            this.grpBxDeck.Text = "Deck";
            // 
            // pbxSound
            // 
            this.pbxSound.BackColor = System.Drawing.Color.Transparent;
            this.pbxSound.Location = new System.Drawing.Point(1122, 77);
            this.pbxSound.Name = "pbxSound";
            this.pbxSound.Size = new System.Drawing.Size(66, 61);
            this.pbxSound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSound.TabIndex = 7;
            this.pbxSound.TabStop = false;
            this.pbxSound.Click += new System.EventHandler(this.pbxSound_Click);
            // 
            // cbxTrumpCard
            // 
            card1.CardValue = 0;
            card1.FaceUp = DurakCardLibrary.FaceStatus.Up;
            card1.Rank = DurakCardLibrary.Rank.Ace;
            card1.Suit = DurakCardGame.Suit.Clubs;
            this.cbxTrumpCard.Card = card1;
            this.cbxTrumpCard.FaceUp = DurakCardLibrary.FaceStatus.Up;
            this.cbxTrumpCard.Location = new System.Drawing.Point(39, 549);
            this.cbxTrumpCard.Name = "cbxTrumpCard";
            this.cbxTrumpCard.Rank = DurakCardLibrary.Rank.Ace;
            this.cbxTrumpCard.Size = new System.Drawing.Size(100, 150);
            this.cbxTrumpCard.Suit = DurakCardGame.Suit.Clubs;
            this.cbxTrumpCard.TabIndex = 6;
            // 
            // frmGameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DurakCardGame.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1245, 749);
            this.Controls.Add(this.pbxSound);
            this.Controls.Add(this.cbxTrumpCard);
            this.Controls.Add(this.grpBxDeck);
            this.Controls.Add(this.grpBxHuman);
            this.Controls.Add(this.grpBxAi);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.grpBxPlayingField);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmGameScreen";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Durak Game";
            this.Load += new System.EventHandler(this.frmGameScreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpBxDeck.ResumeLayout(false);
            this.grpBxDeck.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxPlayingField;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.GroupBox grpBxAi;
        private System.Windows.Forms.GroupBox grpBxHuman;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lblDeckCounter;
        private System.Windows.Forms.GroupBox grpBxDeck;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private CardBox.CardBoxComponent cbxTrumpCard;
        private System.Windows.Forms.PictureBox pbxSound;
    }
}