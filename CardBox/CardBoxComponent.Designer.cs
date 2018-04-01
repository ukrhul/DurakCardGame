namespace CardBox
{
    partial class CardBoxComponent
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbCardImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCardImage
            // 
            this.pbCardImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCardImage.Location = new System.Drawing.Point(0, 0);
            this.pbCardImage.Name = "pbCardImage";
            this.pbCardImage.Size = new System.Drawing.Size(100, 150);
            this.pbCardImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCardImage.TabIndex = 0;
            this.pbCardImage.TabStop = false;
            // 
            // CardBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbCardImage);
            this.Name = "CardBox";
            this.Size = new System.Drawing.Size(100, 150);
            this.Load += new System.EventHandler(this.CardBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCardImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCardImage;
    }
}
