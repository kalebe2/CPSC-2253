namespace Random_Number_Game
{
    partial class formGuessingGame
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
            this.labelDescription = new System.Windows.Forms.Label();
            this.panelOverlay = new System.Windows.Forms.Panel();
            this.buttonGuess = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.pictureTitle = new System.Windows.Forms.PictureBox();
            this.textGuess = new ZBobb.AlphaBlendTextBox();
            this.labelGuessed = new System.Windows.Forms.Label();
            this.labelHighScore = new System.Windows.Forms.Label();
            this.labelWin = new System.Windows.Forms.Label();
            this.panelOverlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.Color.White;
            this.labelDescription.Location = new System.Drawing.Point(260, 110);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(454, 22);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "Pick a number between 1 and 100; see if you\'re right!";
            // 
            // panelOverlay
            // 
            this.panelOverlay.Controls.Add(this.labelWin);
            this.panelOverlay.Controls.Add(this.labelDescription);
            this.panelOverlay.Controls.Add(this.textGuess);
            this.panelOverlay.Controls.Add(this.labelHighScore);
            this.panelOverlay.Controls.Add(this.labelGuessed);
            this.panelOverlay.Controls.Add(this.buttonGuess);
            this.panelOverlay.Controls.Add(this.labelStatus);
            this.panelOverlay.Location = new System.Drawing.Point(-14, -20);
            this.panelOverlay.Name = "panelOverlay";
            this.panelOverlay.Size = new System.Drawing.Size(1015, 373);
            this.panelOverlay.TabIndex = 2;
            // 
            // buttonGuess
            // 
            this.buttonGuess.BackColor = System.Drawing.Color.Transparent;
            this.buttonGuess.Location = new System.Drawing.Point(436, 303);
            this.buttonGuess.Name = "buttonGuess";
            this.buttonGuess.Size = new System.Drawing.Size(75, 23);
            this.buttonGuess.TabIndex = 8;
            this.buttonGuess.Text = "Guess!";
            this.buttonGuess.UseVisualStyleBackColor = false;
            this.buttonGuess.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelStatus.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.White;
            this.labelStatus.Location = new System.Drawing.Point(352, 147);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(308, 31);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "Click the button to guess";
            // 
            // pictureTitle
            // 
            this.pictureTitle.BackColor = System.Drawing.Color.Transparent;
            this.pictureTitle.Image = global::Random_Number_Game.Properties.Resources.NeonTitle;
            this.pictureTitle.Location = new System.Drawing.Point(193, 3);
            this.pictureTitle.Name = "pictureTitle";
            this.pictureTitle.Size = new System.Drawing.Size(561, 70);
            this.pictureTitle.TabIndex = 3;
            this.pictureTitle.TabStop = false;
            // 
            // textGuess
            // 
            this.textGuess.BackAlpha = 10;
            this.textGuess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.textGuess.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGuess.ForeColor = System.Drawing.Color.White;
            this.textGuess.Location = new System.Drawing.Point(423, 244);
            this.textGuess.Name = "textGuess";
            this.textGuess.Size = new System.Drawing.Size(100, 35);
            this.textGuess.TabIndex = 6;
            this.textGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelGuessed
            // 
            this.labelGuessed.AutoSize = true;
            this.labelGuessed.BackColor = System.Drawing.Color.Transparent;
            this.labelGuessed.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGuessed.ForeColor = System.Drawing.Color.White;
            this.labelGuessed.Location = new System.Drawing.Point(375, 193);
            this.labelGuessed.Name = "labelGuessed";
            this.labelGuessed.Size = new System.Drawing.Size(196, 31);
            this.labelGuessed.TabIndex = 9;
            this.labelGuessed.Text = "Times Guessed:";
            // 
            // labelHighScore
            // 
            this.labelHighScore.AutoSize = true;
            this.labelHighScore.BackColor = System.Drawing.Color.Transparent;
            this.labelHighScore.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHighScore.ForeColor = System.Drawing.Color.White;
            this.labelHighScore.Location = new System.Drawing.Point(830, 29);
            this.labelHighScore.Name = "labelHighScore";
            this.labelHighScore.Size = new System.Drawing.Size(134, 28);
            this.labelHighScore.TabIndex = 10;
            this.labelHighScore.Text = "High Score:";
            // 
            // labelWin
            // 
            this.labelWin.AutoSize = true;
            this.labelWin.BackColor = System.Drawing.Color.Transparent;
            this.labelWin.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWin.ForeColor = System.Drawing.Color.White;
            this.labelWin.Location = new System.Drawing.Point(412, 157);
            this.labelWin.Name = "labelWin";
            this.labelWin.Size = new System.Drawing.Size(0, 31);
            this.labelWin.TabIndex = 11;
            // 
            // formGuessingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Random_Number_Game.Properties.Resources.neondice;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 347);
            this.Controls.Add(this.pictureTitle);
            this.Controls.Add(this.panelOverlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "formGuessingGame";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Guessing Game";
            this.panelOverlay.ResumeLayout(false);
            this.panelOverlay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Panel panelOverlay;
        private System.Windows.Forms.PictureBox pictureTitle;
        private ZBobb.AlphaBlendTextBox textGuess;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonGuess;
        private System.Windows.Forms.Label labelGuessed;
        private System.Windows.Forms.Label labelHighScore;
        private System.Windows.Forms.Label labelWin;
    }
}

