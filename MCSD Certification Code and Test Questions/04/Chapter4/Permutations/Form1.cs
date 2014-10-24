using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Permutations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Make permutations.
        private void goButton_Click(object sender, EventArgs e)
        {
            permutationsTextBox.Clear();
            concatenationTextBox.Clear();
            stringBuilderTextBox.Clear();
            Cursor = Cursors.WaitCursor;

            int numLetters = (int)numLettersNumericUpDown.Value;
            numPermutationsTextBox.Text = Factorial(numLetters).ToString();

            Refresh();

            // Make a String holding the letters to use.
            string letters = "";
            for (int i = 0; i < numLetters; i++)
            {
                letters += (char)((int)'A' + i);
            }

            // Generate permutations.
            DateTime startTime, stopTime;

            string permutations = "";
            startTime = DateTime.Now;
            ConcatenatePermutations(ref permutations, letters, "");
            permutationsTextBox.Text = permutations;
            stopTime = DateTime.Now;
            TimeSpan elapsed = stopTime - startTime;
            concatenationTextBox.Text = elapsed.TotalSeconds.ToString("0.00") + " sec";
            Refresh();

            StringBuilder permutationsBuilder = new StringBuilder();
            startTime = DateTime.Now;
            StringBuilderPermutations(permutationsBuilder, letters, "");
            permutationsTextBox.Text = permutationsBuilder.ToString();
            stopTime = DateTime.Now;
            elapsed = stopTime - startTime;
            stringBuilderTextBox.Text = elapsed.TotalSeconds.ToString("0.00") + " sec";
            Refresh();

            // Validate the result.
            System.Diagnostics.Debug.Assert(permutations == permutationsBuilder.ToString());

            Cursor = Cursors.Default;
        }

        // Use concatenation to make permutations separated by new lines.
        private void ConcatenatePermutations(ref string permutations, string letters, string word)
        {
            // See if we're out of letters.
            if (letters.Length == 0)
            {
                // Add word to the result.
                permutations += word + Environment.NewLine;
            }
            else
            {
                // Add another letter to word and continue recursion.
                for (int i = 0; i < letters.Length; i++)
                {
                    char ch = letters[i];
                    string newWord = word + ch;
                    string newLetters = letters.Remove(i, 1);
                    ConcatenatePermutations(ref permutations, newLetters, newWord);
                }
            }
        }

        // Use a StringBuilder to make permutations separated by new lines.
        private void StringBuilderPermutations(StringBuilder permutations, string letters, string word)
        {
            // See if we're out of letters.
            if (letters.Length == 0)
            {
                // Add word to the result.
                permutations.AppendLine(word);
            }
            else
            {
                // Add another letter to word and continue recursion.
                for (int i = 0; i < letters.Length; i++)
                {
                    char ch = letters[i];
                    string newWord = word + ch;
                    string newLetters = letters.Remove(i, 1);
                    StringBuilderPermutations(permutations, newLetters, newWord);
                }
            }
        }

        // Return number!
        private long Factorial(long number)
        {
            long result = 1;
            for (int i = 2; i < number; i++) result *= i;
            return result;
        }
    }
}
