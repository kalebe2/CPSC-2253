namespace Temperature_Translation
{
    partial class formTempCalc
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
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.comboBoxTemp = new System.Windows.Forms.ComboBox();
            this.labelPrompt = new System.Windows.Forms.Label();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.labelConversion = new System.Windows.Forms.Label();
            this.labelUnit = new System.Windows.Forms.Label();
            this.labelConverted = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInput.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInput.Location = new System.Drawing.Point(262, 155);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(114, 30);
            this.textBoxInput.TabIndex = 0;
            this.textBoxInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBoxTemp
            // 
            this.comboBoxTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTemp.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTemp.FormattingEnabled = true;
            this.comboBoxTemp.Items.AddRange(new object[] {
            "Fahrenheit",
            "Celsius"});
            this.comboBoxTemp.Location = new System.Drawing.Point(386, 154);
            this.comboBoxTemp.Name = "comboBoxTemp";
            this.comboBoxTemp.Size = new System.Drawing.Size(143, 31);
            this.comboBoxTemp.TabIndex = 1;
            // 
            // labelPrompt
            // 
            this.labelPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrompt.AutoSize = true;
            this.labelPrompt.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrompt.Location = new System.Drawing.Point(78, 64);
            this.labelPrompt.Name = "labelPrompt";
            this.labelPrompt.Size = new System.Drawing.Size(658, 25);
            this.labelPrompt.TabIndex = 2;
            this.labelPrompt.Text = "Insert a temperature and its unit in the text box and dropdown below\r\n";
            // 
            // buttonConvert
            // 
            this.buttonConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConvert.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConvert.Location = new System.Drawing.Point(330, 222);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(106, 32);
            this.buttonConvert.TabIndex = 3;
            this.buttonConvert.Text = "Convert!";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // labelConversion
            // 
            this.labelConversion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConversion.AutoSize = true;
            this.labelConversion.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConversion.Location = new System.Drawing.Point(325, 354);
            this.labelConversion.Name = "labelConversion";
            this.labelConversion.Size = new System.Drawing.Size(0, 25);
            this.labelConversion.TabIndex = 4;
            // 
            // labelUnit
            // 
            this.labelUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUnit.AutoSize = true;
            this.labelUnit.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnit.Location = new System.Drawing.Point(381, 354);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(0, 25);
            this.labelUnit.TabIndex = 5;
            // 
            // labelConverted
            // 
            this.labelConverted.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConverted.AutoSize = true;
            this.labelConverted.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConverted.Location = new System.Drawing.Point(257, 292);
            this.labelConverted.Name = "labelConverted";
            this.labelConverted.Size = new System.Drawing.Size(272, 29);
            this.labelConverted.TabIndex = 6;
            this.labelConverted.Text = "Converted Temperature:";
            // 
            // formTempCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Temperature_Translation.Properties.Resources.Temp_Gradient2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(821, 450);
            this.Controls.Add(this.labelConverted);
            this.Controls.Add(this.labelUnit);
            this.Controls.Add(this.labelConversion);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.labelPrompt);
            this.Controls.Add(this.comboBoxTemp);
            this.Controls.Add(this.textBoxInput);
            this.Name = "formTempCalc";
            this.Text = "Temperature Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.ComboBox comboBoxTemp;
        private System.Windows.Forms.Label labelPrompt;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Label labelConversion;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.Label labelConverted;
    }
}

