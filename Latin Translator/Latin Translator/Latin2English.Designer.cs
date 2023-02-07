using System.Windows.Forms;

namespace Latin_Translator
{
    partial class Latin2English
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
            this.translateInstructions = new System.Windows.Forms.Label();
            this.labelOne = new System.Windows.Forms.Label();
            this.labelTwo = new System.Windows.Forms.Label();
            this.labelThree = new System.Windows.Forms.Label();
            this.labelOneAnswer = new System.Windows.Forms.Label();
            this.labelTwoAnswer = new System.Windows.Forms.Label();
            this.labelThreeAnswer = new System.Windows.Forms.Label();
            this.buttonAnswer = new System.Windows.Forms.Button();
            this.tableWords = new System.Windows.Forms.TableLayoutPanel();
            this.tableWords.SuspendLayout();
            this.SuspendLayout();
            // 
            // translateInstructions
            // 
            this.translateInstructions.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.translateInstructions.AutoSize = true;
            this.translateInstructions.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translateInstructions.ForeColor = System.Drawing.Color.Snow;
            this.translateInstructions.Location = new System.Drawing.Point(44, 20);
            this.translateInstructions.Name = "translateInstructions";
            this.translateInstructions.Size = new System.Drawing.Size(787, 28);
            this.translateInstructions.TabIndex = 0;
            this.translateInstructions.Text = "Press the \"Translate\" button to translate the Latin words to English.\r\n";
            this.translateInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOne
            // 
            this.labelOne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOne.AutoSize = true;
            this.labelOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelOne.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOne.ForeColor = System.Drawing.Color.Snow;
            this.labelOne.Location = new System.Drawing.Point(3, 0);
            this.labelOne.Name = "labelOne";
            this.labelOne.Size = new System.Drawing.Size(153, 49);
            this.labelOne.TabIndex = 1;
            this.labelOne.Text = "Sinister";
            this.labelOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTwo
            // 
            this.labelTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTwo.AutoSize = true;
            this.labelTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTwo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTwo.ForeColor = System.Drawing.Color.Snow;
            this.labelTwo.Location = new System.Drawing.Point(162, 0);
            this.labelTwo.Name = "labelTwo";
            this.labelTwo.Size = new System.Drawing.Size(150, 49);
            this.labelTwo.TabIndex = 2;
            this.labelTwo.Text = "Medium";
            this.labelTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelThree
            // 
            this.labelThree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelThree.AutoSize = true;
            this.labelThree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelThree.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThree.ForeColor = System.Drawing.Color.Snow;
            this.labelThree.Location = new System.Drawing.Point(318, 0);
            this.labelThree.Name = "labelThree";
            this.labelThree.Size = new System.Drawing.Size(142, 49);
            this.labelThree.TabIndex = 3;
            this.labelThree.Text = "Dexter";
            this.labelThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOneAnswer
            // 
            this.labelOneAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOneAnswer.AutoSize = true;
            this.labelOneAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelOneAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelOneAnswer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOneAnswer.ForeColor = System.Drawing.Color.Snow;
            this.labelOneAnswer.Location = new System.Drawing.Point(3, 49);
            this.labelOneAnswer.Name = "labelOneAnswer";
            this.labelOneAnswer.Size = new System.Drawing.Size(153, 49);
            this.labelOneAnswer.TabIndex = 5;
            this.labelOneAnswer.Text = "       ";
            this.labelOneAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTwoAnswer
            // 
            this.labelTwoAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTwoAnswer.AutoSize = true;
            this.labelTwoAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTwoAnswer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTwoAnswer.ForeColor = System.Drawing.Color.Snow;
            this.labelTwoAnswer.Location = new System.Drawing.Point(162, 49);
            this.labelTwoAnswer.Name = "labelTwoAnswer";
            this.labelTwoAnswer.Size = new System.Drawing.Size(150, 49);
            this.labelTwoAnswer.TabIndex = 6;
            this.labelTwoAnswer.Text = "            ";
            this.labelTwoAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelThreeAnswer
            // 
            this.labelThreeAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelThreeAnswer.AutoSize = true;
            this.labelThreeAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelThreeAnswer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThreeAnswer.ForeColor = System.Drawing.Color.Snow;
            this.labelThreeAnswer.Location = new System.Drawing.Point(318, 49);
            this.labelThreeAnswer.Name = "labelThreeAnswer";
            this.labelThreeAnswer.Size = new System.Drawing.Size(142, 49);
            this.labelThreeAnswer.TabIndex = 7;
            this.labelThreeAnswer.Text = "         ";
            this.labelThreeAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAnswer
            // 
            this.buttonAnswer.BackColor = System.Drawing.Color.Black;
            this.buttonAnswer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAnswer.FlatAppearance.BorderSize = 2;
            this.buttonAnswer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonAnswer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnswer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnswer.ForeColor = System.Drawing.Color.White;
            this.buttonAnswer.Location = new System.Drawing.Point(383, 213);
            this.buttonAnswer.Name = "buttonAnswer";
            this.buttonAnswer.Size = new System.Drawing.Size(98, 34);
            this.buttonAnswer.TabIndex = 8;
            this.buttonAnswer.Text = "Translate";
            this.buttonAnswer.UseVisualStyleBackColor = false;
            this.buttonAnswer.Click += new System.EventHandler(this.buttonAnswer_Click);
            // 
            // tableWords
            // 
            this.tableWords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableWords.ColumnCount = 3;
            this.tableWords.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.56604F));
            this.tableWords.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.43396F));
            this.tableWords.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.tableWords.Controls.Add(this.labelOne, 0, 0);
            this.tableWords.Controls.Add(this.labelTwo, 1, 0);
            this.tableWords.Controls.Add(this.labelThreeAnswer, 2, 1);
            this.tableWords.Controls.Add(this.labelThree, 2, 0);
            this.tableWords.Controls.Add(this.labelTwoAnswer, 1, 1);
            this.tableWords.Controls.Add(this.labelOneAnswer, 0, 1);
            this.tableWords.Location = new System.Drawing.Point(194, 79);
            this.tableWords.Name = "tableWords";
            this.tableWords.RowCount = 2;
            this.tableWords.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableWords.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableWords.Size = new System.Drawing.Size(465, 100);
            this.tableWords.TabIndex = 9;
            // 
            // Latin2English
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(877, 279);
            this.Controls.Add(this.tableWords);
            this.Controls.Add(this.buttonAnswer);
            this.Controls.Add(this.translateInstructions);
            this.Name = "Latin2English";
            this.Text = "Latin2English";
            this.Load += new System.EventHandler(this.Latin2English_Load);
            this.tableWords.ResumeLayout(false);
            this.tableWords.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label translateInstructions;
        private System.Windows.Forms.Label labelOne;
        private System.Windows.Forms.Label labelTwo;
        private System.Windows.Forms.Label labelThree;
        private System.Windows.Forms.Label labelOneAnswer;
        private System.Windows.Forms.Label labelTwoAnswer;
        private System.Windows.Forms.Label labelThreeAnswer;
        private System.Windows.Forms.Button buttonAnswer;
        private System.Windows.Forms.TableLayoutPanel tableWords;
    }
}

