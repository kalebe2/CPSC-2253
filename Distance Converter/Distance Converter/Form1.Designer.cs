namespace Distance_Converter
{
    partial class DistanceConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DistanceConverter));
            this.labelPrompt = new System.Windows.Forms.Label();
            this.textBoxFrom = new ZBobb.AlphaBlendTextBox();
            this.comboBoxUnitA = new System.Windows.Forms.ComboBox();
            this.panelTransparency = new System.Windows.Forms.Panel();
            this.textBoxTo = new ZBobb.AlphaBlendTextBox();
            this.comboBoxUnitB = new System.Windows.Forms.ComboBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.panelTransparency.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPrompt
            // 
            this.labelPrompt.AutoSize = true;
            this.labelPrompt.BackColor = System.Drawing.Color.Transparent;
            this.labelPrompt.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrompt.Location = new System.Drawing.Point(22, 31);
            this.labelPrompt.Name = "labelPrompt";
            this.labelPrompt.Size = new System.Drawing.Size(425, 75);
            this.labelPrompt.TabIndex = 0;
            this.labelPrompt.Text = "Please select enter a measurement and its \r\nunit using the text boxe and dropdown" +
    "s.\r\nClick the arrow to convert.";
            this.labelPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.BackAlpha = 10;
            this.textBoxFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxFrom.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFrom.Location = new System.Drawing.Point(45, 152);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(76, 29);
            this.textBoxFrom.TabIndex = 1;
            // 
            // comboBoxUnitA
            // 
            this.comboBoxUnitA.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUnitA.FormattingEnabled = true;
            this.comboBoxUnitA.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.comboBoxUnitA.Location = new System.Drawing.Point(127, 154);
            this.comboBoxUnitA.MaxDropDownItems = 3;
            this.comboBoxUnitA.Name = "comboBoxUnitA";
            this.comboBoxUnitA.Size = new System.Drawing.Size(68, 27);
            this.comboBoxUnitA.TabIndex = 2;
            // 
            // panelTransparency
            // 
            this.panelTransparency.Controls.Add(this.buttonConvert);
            this.panelTransparency.Controls.Add(this.textBoxTo);
            this.panelTransparency.Controls.Add(this.comboBoxUnitB);
            this.panelTransparency.Controls.Add(this.textBoxFrom);
            this.panelTransparency.Controls.Add(this.comboBoxUnitA);
            this.panelTransparency.Controls.Add(this.labelPrompt);
            this.panelTransparency.Location = new System.Drawing.Point(25, 25);
            this.panelTransparency.Name = "panelTransparency";
            this.panelTransparency.Size = new System.Drawing.Size(474, 251);
            this.panelTransparency.TabIndex = 3;
            this.panelTransparency.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTransparency_Paint);
            // 
            // textBoxTo
            // 
            this.textBoxTo.BackAlpha = 10;
            this.textBoxTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxTo.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTo.Location = new System.Drawing.Point(270, 152);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(76, 29);
            this.textBoxTo.TabIndex = 4;
            // 
            // comboBoxUnitB
            // 
            this.comboBoxUnitB.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUnitB.FormattingEnabled = true;
            this.comboBoxUnitB.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.comboBoxUnitB.Location = new System.Drawing.Point(352, 154);
            this.comboBoxUnitB.MaxDropDownItems = 3;
            this.comboBoxUnitB.Name = "comboBoxUnitB";
            this.comboBoxUnitB.Size = new System.Drawing.Size(68, 27);
            this.comboBoxUnitB.TabIndex = 5;
            // 
            // buttonConvert
            // 
            this.buttonConvert.BackColor = System.Drawing.Color.Transparent;
            this.buttonConvert.BackgroundImage = global::Distance_Converter.Properties.Resources.arrow;
            this.buttonConvert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonConvert.Location = new System.Drawing.Point(213, 156);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(38, 23);
            this.buttonConvert.TabIndex = 6;
            this.buttonConvert.UseVisualStyleBackColor = false;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // DistanceConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Distance_Converter.Properties.Resources.ruler;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(522, 303);
            this.Controls.Add(this.panelTransparency);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DistanceConverter";
            this.Text = "Distance Converter";
            this.panelTransparency.ResumeLayout(false);
            this.panelTransparency.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPrompt;
        private ZBobb.AlphaBlendTextBox textBoxFrom;
        private System.Windows.Forms.ComboBox comboBoxUnitA;
        private System.Windows.Forms.Panel panelTransparency;
        private ZBobb.AlphaBlendTextBox textBoxTo;
        private System.Windows.Forms.ComboBox comboBoxUnitB;
        private System.Windows.Forms.Button buttonConvert;
    }
}

