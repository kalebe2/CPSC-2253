using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latin_Translator
{
    public partial class Latin2English : Form
    {
        public Latin2English()
        {
            InitializeComponent();
        }

        private void Latin2English_Load(object sender, EventArgs e)
        {

        }

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            labelOneAnswer.Text = "Left";
            labelTwoAnswer.Text = "Middle";
            labelThreeAnswer.Text = "Right";
        }
    }
}
