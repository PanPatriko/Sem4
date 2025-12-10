using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saper
{
    partial class FormUstawienia : Form
    {
        public FormUstawienia()
        {
            InitializeComponent();

        }

        public event EventHandler<SettingsEventArgs> SettingsEvent;
        /* Private field to hold the value that is passed around.
         * Exposed by the NewText property and passed in the NewTextChanged event. */
        protected virtual void OnSettingsEvent(SettingsEventArgs e)
        {
            // Create a copy of the event to work with
            EventHandler<SettingsEventArgs> handler = SettingsEvent;
            /* If there are no subscribers, eh will be null so we need to check
             * to avoid a NullReferenceException. */
            if (handler != null)
                handler(this, e);
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            OnSettingsEvent(new SettingsEventArgs(width, height, mines, sound, buttonBoardColor.BackColor,difficult));
            Dispose();
        }
        private void buttonBoardColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            buttonBoardColor.BackColor = colorDialog1.Color;
        }

        int width = 9;
        int height = 9;
        int mines = 10;
        bool sound = true;
        String difficult = "Easy";
        private void checkBoxSound_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSound.Checked == true) sound = true;
            else sound = false;
        }

        private void radioButtonEasy_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonEasy.Checked == true)
            {
                textBoxHeight.Text = "9";
                textBoxWidth.Text = "9";
                textBoxBombs.Text = "10";
                textBoxHeight.ReadOnly = true;
                textBoxWidth.ReadOnly = true;
                textBoxBombs.ReadOnly = true;
                width = 9;
                height = 9;
                mines = 10;
                difficult = "Easy";

            }

        }

        private void radioButtonMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMedium.Checked == true)
            {
                textBoxHeight.Text = "16";
                textBoxWidth.Text = "16";
                textBoxBombs.Text = "40";
                textBoxHeight.ReadOnly = true;
                textBoxWidth.ReadOnly = true;
                textBoxBombs.ReadOnly = true;
                width = 16;
                height = 16;
                mines = 40;
                difficult = "Medium";

            }
        }

        private void radioButtonHard_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonHard.Checked == true)
            {
                textBoxHeight.Text = "16";
                textBoxWidth.Text = "30";
                textBoxBombs.Text = "99";
                textBoxHeight.ReadOnly = true;
                textBoxWidth.ReadOnly = true;
                textBoxBombs.ReadOnly = true;
                width = 30;
                height = 16;
                mines = 99;
                difficult = "Hard";

            }
        }

        private void radioButtonCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCustom.Checked == true)
            {
                textBoxHeight.ReadOnly = false;
                textBoxWidth.ReadOnly = false;
                textBoxBombs.ReadOnly = false;
                difficult = "Custom";
            }
        }


        private void textBoxHeight_Validated(object sender, EventArgs e)
        {
            try
            {
                int range = Int32.Parse(textBoxHeight.Text);
                if (range < 8 || range > 24)
                {
                    throw new Exception("Value can be only between 8-24");
                }
                else
                {
                    height = range;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nieprawidłowa wartość\r\nPodaj wartość z przedziału  1-24");
                textBoxHeight.Text = height.ToString();
            }
        }

        private void textBoxWidth_Validated(object sender, EventArgs e)
        {
            try
            {
                int range = Int32.Parse(textBoxWidth.Text);
                if (range < 8 || range > 30)
                {
                    throw new Exception("Value can be only between 8-30");
                }
                else
                {
                   width = range;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nieprawidłowa wartość\r\nPodaj wartość z przedziału  1-30");
                textBoxWidth.Text = width.ToString();
            }
        }

        private void textBoxBombs_Validated(object sender, EventArgs e)
        {
            int top_range = (height - 1) * (width - 1);
            try
            {
                int range = Int32.Parse(textBoxBombs.Text);
                if (range < 1 || range > top_range)
                {
                    throw new Exception("Value can be only between 1-" + top_range.ToString());
                }
                else
                {
                    mines = Int32.Parse(textBoxBombs.Text);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nieprawidłowa wartość\r\nPodaj wartość z przedziału  1-"+top_range.ToString());
                textBoxBombs.Text = mines.ToString();
            }
        }




    }
}
