namespace The_Rock_Paper_Scissors
{
    partial class RockPaperScissors
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDocumentation = new System.Windows.Forms.Label();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.labelComputer = new System.Windows.Forms.Label();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.pictureScissorsPC = new System.Windows.Forms.PictureBox();
            this.picturePaperPC = new System.Windows.Forms.PictureBox();
            this.pictureRockPC = new System.Windows.Forms.PictureBox();
            this.pictureScissors = new System.Windows.Forms.PictureBox();
            this.picturePaper = new System.Windows.Forms.PictureBox();
            this.pictureRock = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureScissorsPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePaperPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRockPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRock)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Lucida Sans", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(154, 16);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(473, 42);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "The Rock, Paper, Scissors";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDocumentation
            // 
            this.labelDocumentation.AutoSize = true;
            this.labelDocumentation.BackColor = System.Drawing.Color.Transparent;
            this.labelDocumentation.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDocumentation.Location = new System.Drawing.Point(165, 63);
            this.labelDocumentation.Name = "labelDocumentation";
            this.labelDocumentation.Size = new System.Drawing.Size(450, 38);
            this.labelDocumentation.TabIndex = 1;
            this.labelDocumentation.Text = "You\'re playing Rock, Paper, Scissors against the computer.\r\nPick either rock, pap" +
    "er, or scissors on the left and see if you win!";
            this.labelDocumentation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer.Font = new System.Drawing.Font("Lucida Sans", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer.Location = new System.Drawing.Point(182, 151);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(100, 33);
            this.labelPlayer.TabIndex = 2;
            this.labelPlayer.Text = "Player";
            this.labelPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelComputer
            // 
            this.labelComputer.AutoSize = true;
            this.labelComputer.BackColor = System.Drawing.Color.Transparent;
            this.labelComputer.Font = new System.Drawing.Font("Lucida Sans", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComputer.Location = new System.Drawing.Point(471, 151);
            this.labelComputer.Name = "labelComputer";
            this.labelComputer.Size = new System.Drawing.Size(156, 33);
            this.labelComputer.TabIndex = 6;
            this.labelComputer.Text = "Computer";
            this.labelComputer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRestart
            // 
            this.buttonRestart.BackColor = System.Drawing.Color.Transparent;
            this.buttonRestart.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestart.Location = new System.Drawing.Point(351, 613);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(75, 29);
            this.buttonRestart.TabIndex = 10;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = false;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // pictureScissorsPC
            // 
            this.pictureScissorsPC.BackColor = System.Drawing.Color.Transparent;
            this.pictureScissorsPC.BackgroundImage = global::The_Rock_Paper_Scissors.Properties.Resources.scissors;
            this.pictureScissorsPC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureScissorsPC.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureScissorsPC.Location = new System.Drawing.Point(486, 478);
            this.pictureScissorsPC.Name = "pictureScissorsPC";
            this.pictureScissorsPC.Size = new System.Drawing.Size(129, 104);
            this.pictureScissorsPC.TabIndex = 9;
            this.pictureScissorsPC.TabStop = false;
            // 
            // picturePaperPC
            // 
            this.picturePaperPC.BackColor = System.Drawing.Color.Transparent;
            this.picturePaperPC.BackgroundImage = global::The_Rock_Paper_Scissors.Properties.Resources.paper;
            this.picturePaperPC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturePaperPC.Cursor = System.Windows.Forms.Cursors.No;
            this.picturePaperPC.Location = new System.Drawing.Point(486, 346);
            this.picturePaperPC.Name = "picturePaperPC";
            this.picturePaperPC.Size = new System.Drawing.Size(129, 104);
            this.picturePaperPC.TabIndex = 8;
            this.picturePaperPC.TabStop = false;
            // 
            // pictureRockPC
            // 
            this.pictureRockPC.BackColor = System.Drawing.Color.Transparent;
            this.pictureRockPC.BackgroundImage = global::The_Rock_Paper_Scissors.Properties.Resources.Rock;
            this.pictureRockPC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureRockPC.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureRockPC.Location = new System.Drawing.Point(486, 215);
            this.pictureRockPC.Name = "pictureRockPC";
            this.pictureRockPC.Size = new System.Drawing.Size(129, 104);
            this.pictureRockPC.TabIndex = 7;
            this.pictureRockPC.TabStop = false;
            // 
            // pictureScissors
            // 
            this.pictureScissors.BackColor = System.Drawing.Color.Transparent;
            this.pictureScissors.BackgroundImage = global::The_Rock_Paper_Scissors.Properties.Resources.scissors;
            this.pictureScissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureScissors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureScissors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureScissors.Location = new System.Drawing.Point(169, 478);
            this.pictureScissors.Name = "pictureScissors";
            this.pictureScissors.Size = new System.Drawing.Size(129, 104);
            this.pictureScissors.TabIndex = 5;
            this.pictureScissors.TabStop = false;
            this.pictureScissors.Click += new System.EventHandler(this.pictureScissors_Click);
            // 
            // picturePaper
            // 
            this.picturePaper.BackColor = System.Drawing.Color.Transparent;
            this.picturePaper.BackgroundImage = global::The_Rock_Paper_Scissors.Properties.Resources.paper;
            this.picturePaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturePaper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picturePaper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturePaper.Location = new System.Drawing.Point(169, 346);
            this.picturePaper.Name = "picturePaper";
            this.picturePaper.Size = new System.Drawing.Size(129, 104);
            this.picturePaper.TabIndex = 4;
            this.picturePaper.TabStop = false;
            this.picturePaper.Click += new System.EventHandler(this.picturePaper_Click);
            // 
            // pictureRock
            // 
            this.pictureRock.BackColor = System.Drawing.Color.Transparent;
            this.pictureRock.BackgroundImage = global::The_Rock_Paper_Scissors.Properties.Resources.Rock;
            this.pictureRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureRock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureRock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureRock.Location = new System.Drawing.Point(169, 215);
            this.pictureRock.Name = "pictureRock";
            this.pictureRock.Size = new System.Drawing.Size(129, 104);
            this.pictureRock.TabIndex = 3;
            this.pictureRock.TabStop = false;
            this.pictureRock.Click += new System.EventHandler(this.pictureRock_Click);
            // 
            // RockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Rock_Paper_Scissors.Properties.Resources.Classroom_Overlay;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 721);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.pictureScissorsPC);
            this.Controls.Add(this.picturePaperPC);
            this.Controls.Add(this.pictureRockPC);
            this.Controls.Add(this.labelComputer);
            this.Controls.Add(this.pictureScissors);
            this.Controls.Add(this.picturePaper);
            this.Controls.Add(this.pictureRock);
            this.Controls.Add(this.labelPlayer);
            this.Controls.Add(this.labelDocumentation);
            this.Controls.Add(this.labelTitle);
            this.Name = "RockPaperScissors";
            this.Text = "The Rock, Paper, Scissors";
            this.Load += new System.EventHandler(this.RockPaperScissors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureScissorsPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePaperPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRockPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDocumentation;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.PictureBox pictureRock;
        private System.Windows.Forms.PictureBox picturePaper;
        private System.Windows.Forms.PictureBox pictureScissors;
        private System.Windows.Forms.PictureBox pictureScissorsPC;
        private System.Windows.Forms.PictureBox picturePaperPC;
        private System.Windows.Forms.PictureBox pictureRockPC;
        private System.Windows.Forms.Label labelComputer;
        private System.Windows.Forms.Button buttonRestart;
    }
}

