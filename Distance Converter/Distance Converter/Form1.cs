using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distance_Converter
{
    public partial class DistanceConverter : Form
    {
        public DistanceConverter()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            panelTransparency.BackColor = Color.FromArgb(200, 255, 255, 255);
            
        }

        private void panelTransparency_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            double from, to;
            double.TryParse(textBoxFrom.Text, out from);
            double.TryParse(textBoxFrom.Text, out to);

            if (comboBoxUnitA.SelectedIndex != -1 && comboBoxUnitB.SelectedIndex != -1 && from > 0) {
                if (comboBoxUnitA.SelectedIndex == 0 && comboBoxUnitB.SelectedIndex == 0)
                {
                    textBoxTo.Text = textBoxFrom.Text;
                }
                else if (comboBoxUnitA.SelectedIndex == 0 && comboBoxUnitB.SelectedIndex == 1)
                {
                    to = from / 12;
                    textBoxTo.Text = Convert.ToString(to);
                }
                else if(comboBoxUnitA.SelectedIndex == 0 && comboBoxUnitB.SelectedIndex == 2)
                {
                    to = from / 36;
                    textBoxTo.Text = Convert.ToString(to);
                }
                else if (comboBoxUnitA.SelectedIndex == 1 && comboBoxUnitB.SelectedIndex == 0)
                {
                    to = from * 12;
                    textBoxTo.Text = Convert.ToString(to);
                }
                else if (comboBoxUnitA.SelectedIndex == 1 && comboBoxUnitB.SelectedIndex == 1)
                {
                    textBoxTo.Text = textBoxFrom.Text;
                }
                else if (comboBoxUnitA.SelectedIndex == 1 && comboBoxUnitB.SelectedIndex == 2)
                {
                    to = from / 3;
                    textBoxTo.Text = Convert.ToString(to);
                }
                else if (comboBoxUnitA.SelectedIndex == 2 && comboBoxUnitB.SelectedIndex == 0)
                {
                    to = from * 36;
                    textBoxTo.Text = Convert.ToString(to);
                }
                else if (comboBoxUnitA.SelectedIndex == 2 && comboBoxUnitB.SelectedIndex == 1)
                {
                    to = from * 3;
                    textBoxTo.Text = Convert.ToString(to);
                }
                else if (comboBoxUnitA.SelectedIndex == 2 && comboBoxUnitB.SelectedIndex == 2)
                {
                    textBoxTo.Text = textBoxFrom.Text;
                }
            }
            else
            {
                MessageBox.Show("Please make sure you've select units from both dropdowns and your number greater than 0.");
            }
        }
    }
}
