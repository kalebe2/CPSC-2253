using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_Translation
{
    public partial class formTempCalc : Form
    {
        public formTempCalc()
        {
            InitializeComponent();

        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            double temperatureConvert;
            double temperature = Convert.ToDouble(textBoxInput.Text);

            //F to C
            if (comboBoxTemp.Text == "Fahrenheit")
            {

                // Conversion and Label Control
                if (temperature != 32)
                {
                    temperatureConvert = (temperature - 32) * (5.0 / 9);
                    labelConversion.Text = temperatureConvert.ToString("0.#");
                    labelUnit.Text = "Celsius";
                }
                if (temperature == 32)
                {
                    temperatureConvert = (temperature - 32);
                    labelConversion.Text = temperatureConvert.ToString("0.#");
                    labelUnit.Text = "Celsius";
                }

            }

            //C to F
            if (comboBoxTemp.Text == "Celsius")
            {
                if (temperature != 0)
                {
                    temperatureConvert = (temperature * (9.0 / 5)) + 32;
                    labelConversion.Text = temperatureConvert.ToString("0.#");
                    labelUnit.Text = "Fahrenheit";
                }

                if (temperature == 0)
                {
                    temperatureConvert = (temperature + 32);
                    labelConversion.Text = temperatureConvert.ToString("0.#");
                    labelUnit.Text = "Fahrenheit";
                }
            }

            // Backgrounds
            if ((temperature >= 50 && temperature < 80 && comboBoxTemp.Text == "Fahrenheit") | (temperature >= 10 && temperature < 26.6 && comboBoxTemp.Text == "Celsius"))
            {
                formTempCalc.ActiveForm.BackgroundImage = Properties.Resources.Nice_Weather;
                labelPrompt.ForeColor = Color.Green;
                textBoxInput.ForeColor = Color.Green;
                comboBoxTemp.ForeColor = Color.Green;
                labelConversion.ForeColor = Color.Green;
                labelUnit.ForeColor = Color.Green;
                buttonConvert.ForeColor = Color.Green;
                labelConverted.ForeColor = Color.Green;
            }
            if ((temperature > 80 && comboBoxTemp.Text == "Fahrenheit") | (temperature > 26.6 && comboBoxTemp.Text == "Celsius"))
            {
                formTempCalc.ActiveForm.BackgroundImage = Properties.Resources.Hot_Weather;
                labelPrompt.ForeColor = Color.Red;
                textBoxInput.ForeColor = Color.Red;
                comboBoxTemp.ForeColor = Color.Red;
                labelConversion.ForeColor = Color.Red;
                labelUnit.ForeColor = Color.Red;
                buttonConvert.ForeColor = Color.Red;
                labelConverted.ForeColor = Color.Red;
            }
            if ((temperature < 50 && comboBoxTemp.Text == "Fahrenheit") | (temperature < 10 && comboBoxTemp.Text == "Celsius"))
            {
                formTempCalc.ActiveForm.BackgroundImage = Properties.Resources.Cold_Weather;
                labelPrompt.ForeColor = Color.DeepSkyBlue;
                textBoxInput.ForeColor = Color.DeepSkyBlue;
                comboBoxTemp.ForeColor = Color.DeepSkyBlue;
                labelConversion.ForeColor = Color.DeepSkyBlue;
                labelUnit.ForeColor = Color.DeepSkyBlue;
                buttonConvert.ForeColor = Color.DeepSkyBlue;
                labelConverted.ForeColor = Color.DeepSkyBlue;
            }
        }

        
    }

}
