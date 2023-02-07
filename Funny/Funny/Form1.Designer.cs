namespace Funny
{
    partial class formFunnyHaHa
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
            this.components = new System.ComponentModel.Container();
            this.labelSetup = new System.Windows.Forms.Label();
            this.buttonSetup = new System.Windows.Forms.Button();
            this.buttonPunchline = new System.Windows.Forms.Button();
            this.labelPunchline = new System.Windows.Forms.Label();
            this.laughTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelSetup
            // 
            this.labelSetup.AutoSize = true;
            this.labelSetup.BackColor = System.Drawing.Color.Transparent;
            this.labelSetup.Font = new System.Drawing.Font("Sans Serif Collection", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSetup.ForeColor = System.Drawing.Color.White;
            this.labelSetup.Location = new System.Drawing.Point(114, 133);
            this.labelSetup.Name = "labelSetup";
            this.labelSetup.Size = new System.Drawing.Size(0, 71);
            this.labelSetup.TabIndex = 0;
            // 
            // buttonSetup
            // 
            this.buttonSetup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSetup.BackColor = System.Drawing.Color.Transparent;
            this.buttonSetup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSetup.FlatAppearance.BorderSize = 0;
            this.buttonSetup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetup.Font = new System.Drawing.Font("Sans Serif Collection", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetup.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSetup.Location = new System.Drawing.Point(331, 537);
            this.buttonSetup.Name = "buttonSetup";
            this.buttonSetup.Size = new System.Drawing.Size(138, 52);
            this.buttonSetup.TabIndex = 1;
            this.buttonSetup.Text = "Setup";
            this.buttonSetup.UseVisualStyleBackColor = false;
            this.buttonSetup.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPunchline
            // 
            this.buttonPunchline.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPunchline.BackColor = System.Drawing.Color.Transparent;
            this.buttonPunchline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPunchline.FlatAppearance.BorderSize = 0;
            this.buttonPunchline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.buttonPunchline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPunchline.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPunchline.ForeColor = System.Drawing.Color.Transparent;
            this.buttonPunchline.Location = new System.Drawing.Point(596, 541);
            this.buttonPunchline.Name = "buttonPunchline";
            this.buttonPunchline.Size = new System.Drawing.Size(171, 52);
            this.buttonPunchline.TabIndex = 2;
            this.buttonPunchline.Text = "Punch Line";
            this.buttonPunchline.UseVisualStyleBackColor = false;
            this.buttonPunchline.Click += new System.EventHandler(this.buttonPunchline_Click);
            // 
            // labelPunchline
            // 
            this.labelPunchline.AutoSize = true;
            this.labelPunchline.BackColor = System.Drawing.Color.Transparent;
            this.labelPunchline.Font = new System.Drawing.Font("Sans Serif Collection", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPunchline.ForeColor = System.Drawing.Color.White;
            this.labelPunchline.Location = new System.Drawing.Point(292, 319);
            this.labelPunchline.Name = "labelPunchline";
            this.labelPunchline.Size = new System.Drawing.Size(0, 71);
            this.labelPunchline.TabIndex = 3;
            // 
            // laughTimer
            // 
            this.laughTimer.Interval = 1750;
            this.laughTimer.Tick += new System.EventHandler(this.laughTimer_Tick);
            // 
            // formFunnyHaHa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Funny.Properties.Resources.rob_laughter_WW1jsInXgwM_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1132, 599);
            this.Controls.Add(this.labelPunchline);
            this.Controls.Add(this.buttonPunchline);
            this.Controls.Add(this.buttonSetup);
            this.Controls.Add(this.labelSetup);
            this.Name = "formFunnyHaHa";
            this.Text = "Punchliner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSetup;
        private System.Windows.Forms.Button buttonSetup;
        private System.Windows.Forms.Button buttonPunchline;
        private System.Windows.Forms.Label labelPunchline;
        private System.Windows.Forms.Timer laughTimer;
    }
}

