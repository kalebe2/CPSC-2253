using System.Drawing;
using System.Windows.Forms;

namespace Distance_Calculator
{
    partial class DistanceCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DistanceCalculator));
            this.panelBackground = new System.Windows.Forms.Panel();
            this.listResults = new System.Windows.Forms.ListBox();
            this.textHours = new ZBobb.AlphaBlendTextBox();
            this.textSpeed = new ZBobb.AlphaBlendTextBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelPrompt = new System.Windows.Forms.Label();
            this.panelImage = new System.Windows.Forms.Panel();
            this.labelSpeedLimit = new System.Windows.Forms.Label();
            this.panelBackground.SuspendLayout();
            this.panelImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.Controls.Add(this.listResults);
            this.panelBackground.Controls.Add(this.textHours);
            this.panelBackground.Controls.Add(this.textSpeed);
            this.panelBackground.Controls.Add(this.buttonCalc);
            this.panelBackground.Controls.Add(this.labelHours);
            this.panelBackground.Controls.Add(this.labelSpeed);
            this.panelBackground.Controls.Add(this.labelPrompt);
            this.panelBackground.Location = new System.Drawing.Point(62, 66);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(386, 424);
            this.panelBackground.TabIndex = 0;
            // 
            // listResults
            // 
            this.listResults.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listResults.FormattingEnabled = true;
            this.listResults.ItemHeight = 16;
            this.listResults.Location = new System.Drawing.Point(45, 246);
            this.listResults.Name = "listResults";
            this.listResults.Size = new System.Drawing.Size(302, 148);
            this.listResults.TabIndex = 8;
            // 
            // textHours
            // 
            this.textHours.BackAlpha = 10;
            this.textHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textHours.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHours.Location = new System.Drawing.Point(201, 135);
            this.textHours.Name = "textHours";
            this.textHours.Size = new System.Drawing.Size(104, 35);
            this.textHours.TabIndex = 7;
            this.textHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            
            // 
            // textSpeed
            // 
            this.textSpeed.BackAlpha = 10;
            this.textSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textSpeed.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSpeed.Location = new System.Drawing.Point(63, 135);
            this.textSpeed.Name = "textSpeed";
            this.textSpeed.Size = new System.Drawing.Size(104, 35);
            this.textSpeed.TabIndex = 6;
            this.textSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonCalc
            // 
            this.buttonCalc.BackColor = System.Drawing.Color.Transparent;
            this.buttonCalc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCalc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonCalc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalc.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalc.Location = new System.Drawing.Point(131, 185);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(109, 33);
            this.buttonCalc.TabIndex = 5;
            this.buttonCalc.Text = "Calculate";
            this.buttonCalc.UseVisualStyleBackColor = false;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.BackColor = System.Drawing.Color.Transparent;
            this.labelHours.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHours.Location = new System.Drawing.Point(215, 104);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(75, 28);
            this.labelHours.TabIndex = 2;
            this.labelHours.Text = "Hours";
            this.labelHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labelSpeed.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeed.Location = new System.Drawing.Point(76, 104);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(79, 28);
            this.labelSpeed.TabIndex = 1;
            this.labelSpeed.Text = "Speed";
            this.labelSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPrompt
            // 
            this.labelPrompt.AutoSize = true;
            this.labelPrompt.BackColor = System.Drawing.Color.Transparent;
            this.labelPrompt.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrompt.Location = new System.Drawing.Point(40, 38);
            this.labelPrompt.Name = "labelPrompt";
            this.labelPrompt.Size = new System.Drawing.Size(307, 50);
            this.labelPrompt.TabIndex = 0;
            this.labelPrompt.Text = "Please enter the vehicles speed \r\nand number of hours traveled";
            this.labelPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelImage
            // 
            this.panelImage.BackColor = System.Drawing.Color.Transparent;
            this.panelImage.BackgroundImage = global::Distance_Calculator.Properties.Resources.Speed_Limit_Blank;
            this.panelImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelImage.Controls.Add(this.labelSpeedLimit);
            this.panelImage.Location = new System.Drawing.Point(530, 66);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(386, 424);
            this.panelImage.TabIndex = 9;
            // 
            // labelSpeedLimit
            // 
            this.labelSpeedLimit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSpeedLimit.AutoSize = true;
            this.labelSpeedLimit.Font = new System.Drawing.Font("Highway Gothic Wide", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeedLimit.Location = new System.Drawing.Point(24, 202);
            this.labelSpeedLimit.Name = "labelSpeedLimit";
            this.labelSpeedLimit.Size = new System.Drawing.Size(0, 222);
            this.labelSpeedLimit.TabIndex = 0;
            this.labelSpeedLimit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DistanceCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Distance_Calculator.Properties.Resources.road;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panelImage);
            this.Controls.Add(this.panelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DistanceCalculator";
            this.Text = "Distance Calculator";
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            this.panelImage.ResumeLayout(false);
            this.panelImage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Label labelPrompt;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label labelSpeed;
        private ZBobb.AlphaBlendTextBox textHours;
        private ZBobb.AlphaBlendTextBox textSpeed;
        private ListBox listResults;
        private Panel panelImage;
        private Label labelSpeedLimit;
    }
}

