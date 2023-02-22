using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Rock_Paper_Scissors
{
    public partial class RockPaperScissors : Form
    {
        public RockPaperScissors()
        {
            InitializeComponent();
        }

        //initialize a new random
        Random rand = new Random();

        //Using a load event to set the random equal to an integer.
        private void RockPaperScissors_Load(object sender, EventArgs e)
        {
            int computerResult = turnComputer();
        }

        //The computer is picking rock, paper, or scissors using random numbers
        private int turnComputer()
        {
            int computer = rand.Next(1, 4);
            return computer;
        }

        //Clicking rock will set the player equal to 1 and shade their answer green
        //It will also get the random number and store it as the computer result, then call the computer color method
        //Finally it passes the arguements to the gameResult method
        private void pictureRock_Click(object sender, EventArgs e)
        {
            int player = 1;
            pictureRock.BackColor = Color.Green;
            int computerResult = turnComputer();
            computerColor(computerResult);
            gameResult(player, computerResult);
        }

        //Clicking paper will set the player equal to 2 and shade their answer green
        //It will also get the random number and store it as the computer result, then call the computer color method
        //Finally it passes the arguements to the gameResult method
        private void picturePaper_Click(object sender, EventArgs e)
        {
            int player = 2;
            picturePaper.BackColor = Color.Green;
            int computerResult = turnComputer();
            computerColor(computerResult);
            gameResult(player, computerResult);
        }

        //Clicking scissors will set the player equal to 3 and shade their answer green
        //It will also get the random number and store it as the computer result, then call the computer color method
        //Finally it passes the arguements to the gameResult method
        private void pictureScissors_Click(object sender, EventArgs e)
        {
            int player = 3;
            pictureScissors.BackColor = Color.Green;
            int computerResult = turnComputer();
            computerColor(computerResult);
            gameResult(player, computerResult);
        }

        //This method checks whether the computer chose rock(1), paper(2), or scissors(3) and changes the computers answer to green
        private void computerColor(int choice)
        {
            if (choice == 1) {
                pictureRockPC.BackColor = Color.Green;
            }
            else if (choice == 2)
            {
                picturePaperPC.BackColor= Color.Green;
            }
            else if (choice == 3)
            {
                pictureScissorsPC.BackColor = Color.Green;
            }
        }

        //This class takes the player result and computer result as arguements.
        //It then tests to see if the player won, tied, or lost using a series of if statements 
        private void gameResult(int playerResult, int computerResult) 
        {
            if (playerResult == 1 && computerResult == 1) {
                
                MessageBox.Show("You've Tied!");
            }

            if (playerResult == 1 && computerResult == 2)
            {
                MessageBox.Show("You've Lost!");
            }

            if (playerResult == 1 && computerResult == 3)
            {
                MessageBox.Show("You've Won!");
            }

            if (playerResult == 2 && computerResult == 1)
            {
                MessageBox.Show("You've Won!");
            }

            if (playerResult == 2 && computerResult == 2)
            {
                MessageBox.Show("You've Tied!");
            }

            if (playerResult == 2 && computerResult == 3)
            {
                MessageBox.Show("You've Lost!");
            }

            if (playerResult == 3 && computerResult == 1)
            {
                MessageBox.Show("You've Lost!");
            }

            if (playerResult == 3 && computerResult == 2)
            {
                MessageBox.Show("You've Won!");
            }

            if (playerResult == 3 && computerResult == 3)
            {
                MessageBox.Show("You've Tied!");
            }
        }

        //This method resets the shading and calls the for the computer to guess again
        private void buttonRestart_Click(object sender, EventArgs e)
        {
            pictureRock.BackColor = Color.Transparent;
            picturePaper.BackColor = Color.Transparent;
            pictureScissors.BackColor = Color.Transparent;
            pictureRockPC.BackColor = Color.Transparent;
            picturePaperPC.BackColor = Color.Transparent;
            pictureScissorsPC.BackColor = Color.Transparent;
            int computerResult = turnComputer();
        }
    }
}
