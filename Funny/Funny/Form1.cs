using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Funny.Properties;

namespace Funny
{
    public partial class formFunnyHaHa : Form
    {
        private int seconds;
        public formFunnyHaHa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelSetup.Text = "I accidentally rubbed ketchup in my eyes...";
            SoundPlayer setupPlayer = new SoundPlayer(Properties.Resources.JokeSetup);
            setupPlayer.Play();
        }

        private void buttonPunchline_Click(object sender, EventArgs e)
        {
            labelPunchline.Text = "Now I have Heinz-Sight";
            SoundPlayer jokePlayer = new SoundPlayer(Properties.Resources.JokePunchline);
            jokePlayer.Play();
            laughTimer.Start();
        }

        private void laughTimer_Tick(object sender, EventArgs e)
        {
            seconds++;
            if(seconds >= 0 )
            {
                laughTimer.Stop();
                SoundPlayer laughTrack = new SoundPlayer(Properties.Resources.Crowd_Laughing_01);
                laughTrack.Play();
            }
        }
    }
}
