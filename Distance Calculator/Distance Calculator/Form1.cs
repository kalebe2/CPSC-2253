using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distance_Calculator
{
    public partial class DistanceCalculator : Form
    {
        public DistanceCalculator()
        {
            InitializeComponent();
            //Makes UI elements transparent. Pure white is ugly
            panelBackground.BackColor = Color.FromArgb(180, 255, 255, 255);
            buttonCalc.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 255, 255, 255);
        }

        

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            //Declaration of ints for calculation
            int speed = 0;
            int hours = 0;
            int distance = 0;

            //Clears the listbox for a new result
            listResults.Items.Clear();

            //Validates that the user input is an integer
            if (int.TryParse(textSpeed.Text, out speed) && int.TryParse(textHours.Text, out hours)) { 
                //for loop to calculate distance and to format listbox text    
                for (int time = 1; time <= hours; time++)
                    {
                        distance = (speed * time);

                        if (time < 10)
                        {
                            listResults.Items.Add("Hour: " + time + "   ||   Distance Traveled: " + distance + " Miles");
                        }
                        else
                        {
                            listResults.Items.Add("Hour: " + time + " ||   Distance Traveled: " + distance + " Miles");
                        }
                    }   
            
                }
            else
            {
                MessageBox.Show("Please enter valid numbers");
            }
            //Changes speed limit text to reflect speed
            labelSpeedLimit.Text = Convert.ToString(speed);
        }

        
    }
}
