using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonCapitalizeWords_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text.CapitalizeWords();
        }

        private void buttonCountVowels_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text.CountVowels().ToString();
        }

        private void buttonCountWords_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text.CountWords().ToString();
        }

        private void buttonRemoveVowels_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text.RemoveVowels();
        }

        private void buttonReverseLettersInWords_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text.ReverseLettersInWords();
        }

        private void buttonContainsAlaMaKota_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text.ContainsAlaMaKota().ToString();
        }

        private void buttonRemoveNonLetters_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text.RemoveNonLetters();
        }

        private void buttonRandomizeMiddleLetters_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text.RandomizeMiddleLetters();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Wpisz tekst") textBox1.Text = "";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "Wpisz tekst";

        }

        private void buttonConvertToMorse_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text.ConvertToMorse();
        }
    }
}
