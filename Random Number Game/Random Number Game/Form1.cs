using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Number_Game
{
    public partial class formGuessingGame : Form
    {

        //Declaring a couple of new ints for the random number and times guessed
        //Calling the random class & setting it equal to rand
        int next, guessed;
        Random rand = new Random();
        
        //Declaring a int for the highscore, giving it a temporary value;
        int highscore = 100;

        public formGuessingGame()
        {
            InitializeComponent();

            //A transparent overlay for contrast
            panelOverlay.BackColor = Color.FromArgb(70, 100, 100, 100);
            pictureTitle.BackColor = Color.FromArgb(70, 100, 100, 100);
            labelStatus.BackColor = Color.FromArgb(100, 100, 100, 100);
            
            
            //Generating a new random number
            next = rand.Next(1, 100);

            
        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            //Resetting the Winning label
            labelWin.Text = "";

            //Parsing the player input for testing
            Int32.TryParse(textGuess.Text, out int guess);

            //Adding 1 to the times guessed everytime the button is clicked
            //Updating the label to display the amount of times guessed
            guessed += 1;
            labelGuessed.Text = "Times Guessed: " + guessed;

            //Testing whether the number guessed is too high or too low
            //If it's too low, the status label changes to Too Low! Try Again!
            //If it's too high, surprise, the status label changes to Too High! Try Again!
            //If it's equal, then Status text is changed to blank and the Win label is changed to You Win!
            //Then an if statement is used to test whether the times guessed is lower than the high score,
            //if so a new highscore was achieved and then the high score label updates.
            //Then a new random number is selected and the times guessed variable and label are reset.
            if (guess < next)
            {
                labelStatus.Text = "Too Low! Try Again!";
            }
            else if (guess > next)
            {
                labelStatus.Text = "Too High! Try Again!";
            }
            else
            {
                labelStatus.Text = "";
                labelWin.Text = "You Win!";
                
                if (guessed < highscore)
                {
                    highscore = guessed;
                }
                labelHighScore.Text = "High Score: " + highscore;
                next = rand.Next(1, 100);
                guessed = 0;
                labelGuessed.Text = "Times Guessed: ";
            }
        }
    }
}
