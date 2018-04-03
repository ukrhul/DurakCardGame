namespace DurakCardGame
{
    partial class frmHelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelpForm));
            this.tbcHelpForm = new System.Windows.Forms.TabControl();
            this.tbpHelp = new System.Windows.Forms.TabPage();
            this.tbpCredits = new System.Windows.Forms.TabPage();
            this.pbxDurhamLogo = new System.Windows.Forms.PictureBox();
            this.lblAbout = new System.Windows.Forms.Label();
            this.tbpReference = new System.Windows.Forms.TabPage();
            this.tbAboutGame = new System.Windows.Forms.TabPage();
            this.lblAboutGame = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lklblDurakVideo = new System.Windows.Forms.LinkLabel();
            this.lklbDurakRules = new System.Windows.Forms.LinkLabel();
            this.lklblFaviconImage = new System.Windows.Forms.LinkLabel();
            this.lklbBackCard = new System.Windows.Forms.LinkLabel();
            this.lklbDeckImage = new System.Windows.Forms.LinkLabel();
            this.lklbBackgroundImage = new System.Windows.Forms.LinkLabel();
            this.tbcHelpForm.SuspendLayout();
            this.tbpHelp.SuspendLayout();
            this.tbpCredits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDurhamLogo)).BeginInit();
            this.tbpReference.SuspendLayout();
            this.tbAboutGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcHelpForm
            // 
            this.tbcHelpForm.Controls.Add(this.tbpCredits);
            this.tbcHelpForm.Controls.Add(this.tbpHelp);
            this.tbcHelpForm.Controls.Add(this.tbpReference);
            this.tbcHelpForm.Controls.Add(this.tbAboutGame);
            this.tbcHelpForm.Location = new System.Drawing.Point(12, 12);
            this.tbcHelpForm.Name = "tbcHelpForm";
            this.tbcHelpForm.SelectedIndex = 0;
            this.tbcHelpForm.Size = new System.Drawing.Size(623, 403);
            this.tbcHelpForm.TabIndex = 0;
            // 
            // tbpHelp
            // 
            this.tbpHelp.BackgroundImage = global::DurakCardGame.Properties.Resources.background;
            this.tbpHelp.Controls.Add(this.lklbDurakRules);
            this.tbpHelp.Controls.Add(this.lklblDurakVideo);
            this.tbpHelp.Controls.Add(this.label1);
            this.tbpHelp.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpHelp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbpHelp.Location = new System.Drawing.Point(4, 22);
            this.tbpHelp.Name = "tbpHelp";
            this.tbpHelp.Padding = new System.Windows.Forms.Padding(3);
            this.tbpHelp.Size = new System.Drawing.Size(615, 377);
            this.tbpHelp.TabIndex = 1;
            this.tbpHelp.Text = "Help";
            this.tbpHelp.UseVisualStyleBackColor = true;
            // 
            // tbpCredits
            // 
            this.tbpCredits.BackgroundImage = global::DurakCardGame.Properties.Resources.background;
            this.tbpCredits.Controls.Add(this.pbxDurhamLogo);
            this.tbpCredits.Controls.Add(this.lblAbout);
            this.tbpCredits.Location = new System.Drawing.Point(4, 22);
            this.tbpCredits.Name = "tbpCredits";
            this.tbpCredits.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCredits.Size = new System.Drawing.Size(615, 377);
            this.tbpCredits.TabIndex = 0;
            this.tbpCredits.Text = "Credits";
            this.tbpCredits.UseVisualStyleBackColor = true;
            // 
            // pbxDurhamLogo
            // 
            this.pbxDurhamLogo.BackColor = System.Drawing.Color.White;
            this.pbxDurhamLogo.Image = global::DurakCardGame.Properties.Resources.elearn_logo;
            this.pbxDurhamLogo.Location = new System.Drawing.Point(187, 178);
            this.pbxDurhamLogo.Name = "pbxDurhamLogo";
            this.pbxDurhamLogo.Size = new System.Drawing.Size(380, 156);
            this.pbxDurhamLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDurhamLogo.TabIndex = 1;
            this.pbxDurhamLogo.TabStop = false;
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAbout.Location = new System.Drawing.Point(6, 13);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(478, 200);
            this.lblAbout.TabIndex = 0;
            this.lblAbout.Text = "This program is a course requirement of NETD 4201 in \r\nDurham College Oshawa, Ont" +
    "ario.\r\n\r\nIt was developed by Group 8:\r\nRahul Upadhyay\r\nJaspreet Kaur\r\nRemya Zach" +
    "arias\r\n\r\n";
            // 
            // tbpReference
            // 
            this.tbpReference.BackgroundImage = global::DurakCardGame.Properties.Resources.background;
            this.tbpReference.Controls.Add(this.lklbBackgroundImage);
            this.tbpReference.Controls.Add(this.lklbDeckImage);
            this.tbpReference.Controls.Add(this.lklbBackCard);
            this.tbpReference.Controls.Add(this.lklblFaviconImage);
            this.tbpReference.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpReference.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbpReference.Location = new System.Drawing.Point(4, 22);
            this.tbpReference.Name = "tbpReference";
            this.tbpReference.Padding = new System.Windows.Forms.Padding(3);
            this.tbpReference.Size = new System.Drawing.Size(615, 377);
            this.tbpReference.TabIndex = 2;
            this.tbpReference.Text = "References";
            this.tbpReference.UseVisualStyleBackColor = true;
            // 
            // tbAboutGame
            // 
            this.tbAboutGame.BackgroundImage = global::DurakCardGame.Properties.Resources.background;
            this.tbAboutGame.Controls.Add(this.lblAboutGame);
            this.tbAboutGame.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAboutGame.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tbAboutGame.Location = new System.Drawing.Point(4, 22);
            this.tbAboutGame.Name = "tbAboutGame";
            this.tbAboutGame.Padding = new System.Windows.Forms.Padding(3);
            this.tbAboutGame.Size = new System.Drawing.Size(615, 377);
            this.tbAboutGame.TabIndex = 3;
            this.tbAboutGame.Text = "About Game";
            this.tbAboutGame.UseVisualStyleBackColor = true;
            // 
            // lblAboutGame
            // 
            this.lblAboutGame.AutoSize = true;
            this.lblAboutGame.Location = new System.Drawing.Point(3, 3);
            this.lblAboutGame.Name = "lblAboutGame";
            this.lblAboutGame.Size = new System.Drawing.Size(594, 325);
            this.lblAboutGame.TabIndex = 0;
            this.lblAboutGame.Text = resources.GetString("lblAboutGame.Text");
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 371);
            this.label1.TabIndex = 0;
            // 
            // lklblDurakVideo
            // 
            this.lklblDurakVideo.AutoSize = true;
            this.lklblDurakVideo.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklblDurakVideo.LinkColor = System.Drawing.Color.Red;
            this.lklblDurakVideo.Location = new System.Drawing.Point(113, 84);
            this.lklblDurakVideo.Name = "lklblDurakVideo";
            this.lklblDurakVideo.Size = new System.Drawing.Size(391, 25);
            this.lklblDurakVideo.TabIndex = 1;
            this.lklblDurakVideo.TabStop = true;
            this.lklblDurakVideo.Text = "How to play Durak (Video)";
            this.lklblDurakVideo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblDurakVideo_LinkClicked);
            // 
            // lklbDurakRules
            // 
            this.lklbDurakRules.AutoSize = true;
            this.lklbDurakRules.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklbDurakRules.LinkColor = System.Drawing.Color.Red;
            this.lklbDurakRules.Location = new System.Drawing.Point(150, 214);
            this.lklbDurakRules.Name = "lklbDurakRules";
            this.lklbDurakRules.Size = new System.Drawing.Size(308, 25);
            this.lklbDurakRules.TabIndex = 2;
            this.lklbDurakRules.TabStop = true;
            this.lklbDurakRules.Text = "Rules of Durak Game";
            this.lklbDurakRules.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklbDurakRules_LinkClicked);
            // 
            // lklblFaviconImage
            // 
            this.lklblFaviconImage.AutoSize = true;
            this.lklblFaviconImage.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklblFaviconImage.LinkColor = System.Drawing.Color.LimeGreen;
            this.lklblFaviconImage.Location = new System.Drawing.Point(42, 43);
            this.lklblFaviconImage.Name = "lklblFaviconImage";
            this.lklblFaviconImage.Size = new System.Drawing.Size(216, 25);
            this.lklblFaviconImage.TabIndex = 2;
            this.lklblFaviconImage.TabStop = true;
            this.lklblFaviconImage.Text = "Favicon Image";
            this.lklblFaviconImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblFaviconImage_LinkClicked);
            // 
            // lklbBackCard
            // 
            this.lklbBackCard.AutoSize = true;
            this.lklbBackCard.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklbBackCard.LinkColor = System.Drawing.Color.LimeGreen;
            this.lklbBackCard.Location = new System.Drawing.Point(42, 111);
            this.lklbBackCard.Name = "lklbBackCard";
            this.lklbBackCard.Size = new System.Drawing.Size(343, 25);
            this.lklbBackCard.TabIndex = 3;
            this.lklbBackCard.TabStop = true;
            this.lklbBackCard.Text = "Backside of Card Image";
            this.lklbBackCard.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklbBackCard_LinkClicked);
            // 
            // lklbDeckImage
            // 
            this.lklbDeckImage.AutoSize = true;
            this.lklbDeckImage.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklbDeckImage.LinkColor = System.Drawing.Color.LimeGreen;
            this.lklbDeckImage.Location = new System.Drawing.Point(42, 185);
            this.lklbDeckImage.Name = "lklbDeckImage";
            this.lklbDeckImage.Size = new System.Drawing.Size(301, 25);
            this.lklbDeckImage.TabIndex = 4;
            this.lklbDeckImage.TabStop = true;
            this.lklbDeckImage.Text = "Deck of cards image";
            this.lklbDeckImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklbDeckImage_LinkClicked);
            // 
            // lklbBackgroundImage
            // 
            this.lklbBackgroundImage.AutoSize = true;
            this.lklbBackgroundImage.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklbBackgroundImage.LinkColor = System.Drawing.Color.LimeGreen;
            this.lklbBackgroundImage.Location = new System.Drawing.Point(42, 264);
            this.lklbBackgroundImage.Name = "lklbBackgroundImage";
            this.lklbBackgroundImage.Size = new System.Drawing.Size(282, 25);
            this.lklbBackgroundImage.TabIndex = 5;
            this.lklbBackgroundImage.TabStop = true;
            this.lklbBackgroundImage.Text = "Background image";
            this.lklbBackgroundImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklbBackgroundImage_LinkClicked);
            // 
            // frmHelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 427);
            this.Controls.Add(this.tbcHelpForm);
            this.Name = "frmHelpForm";
            this.Text = "HelpForm";
            this.tbcHelpForm.ResumeLayout(false);
            this.tbpHelp.ResumeLayout(false);
            this.tbpHelp.PerformLayout();
            this.tbpCredits.ResumeLayout(false);
            this.tbpCredits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDurhamLogo)).EndInit();
            this.tbpReference.ResumeLayout(false);
            this.tbpReference.PerformLayout();
            this.tbAboutGame.ResumeLayout(false);
            this.tbAboutGame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcHelpForm;
        private System.Windows.Forms.TabPage tbpCredits;
        private System.Windows.Forms.PictureBox pbxDurhamLogo;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.TabPage tbpHelp;
        private System.Windows.Forms.TabPage tbpReference;
        private System.Windows.Forms.TabPage tbAboutGame;
        private System.Windows.Forms.Label lblAboutGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lklblDurakVideo;
        private System.Windows.Forms.LinkLabel lklbDurakRules;
        private System.Windows.Forms.LinkLabel lklblFaviconImage;
        private System.Windows.Forms.LinkLabel lklbBackCard;
        private System.Windows.Forms.LinkLabel lklbDeckImage;
        private System.Windows.Forms.LinkLabel lklbBackgroundImage;
    }
}