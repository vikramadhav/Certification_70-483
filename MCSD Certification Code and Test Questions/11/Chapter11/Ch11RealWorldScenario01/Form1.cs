using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Globalization;
using System.Text.RegularExpressions;

namespace Ch11RealWorldScenario01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Regular expressions for validation.
        private const string namePattern = @"^([A-Z][a-z]*[-' ]?)+$";

        // Sanity check bounds.
        private const int minNameLength = 3;
        private const int minDescrLength = 6;
        private const decimal minUnitCost = 1.00m;
        private const decimal maxUnitCost = 1000;
        private const int minQuantity = 1;
        private const int maxQuantity = 100;

        // ZIP codes for different cities.
        private string[][] zips =
        {
            new string[] { "13370", "13371", "13372" },             // City 0
            new string[] { "13375", "13376" },                      // City 1
            new string[] { "13376", "13377", "13378", "13379" },    // City 2
        };

        // Colors for valid and invalid fields.
        private Color validColor = SystemColors.Window;
        private Color invalidColor = Color.Yellow;

        // An array holding the item row TextBoxes.
        private TextBox[,] rowTextBoxes;

        #region Field Validation Methods

        // Validate a TextBox.
        private void ValidateTextBoxPattern(TextBox txt, bool allowBlank, string pattern)
        {
            // Assume it's invalid.
            bool valid = false;

            // Check for allowed blank.
            string text = txt.Text;
            if (allowBlank && (text.Length == 0)) valid = true;

            // If the regular expression matches the text, allow it.
            if (Regex.IsMatch(text, pattern)) valid = true;

            // Display the appropriate background color.
            if (valid) txt.BackColor = validColor;
            else txt.BackColor = invalidColor;
        }

        // Validate a TextBox containing a currency value.
        // Return true if the TextBox's value is valid.
        private bool ValidateTextBoxCurrency(TextBox txt, bool allowBlank, out decimal value)
        {
            // Assume it's invalid.
            bool valid = false;

            // Check for allowed blank.
            string text = txt.Text;
            if (allowBlank && (text.Length == 0)) valid = true;

            // If it contains a currency value, allow it.
            if (decimal.TryParse(text, NumberStyles.Currency,
                    CultureInfo.CurrentCulture, out value))
                valid = true;

            // Display the appropriate background color.
            if (valid) txt.BackColor = validColor;
            else txt.BackColor = invalidColor;

            return valid;
        }

        // Validate a TextBox containing an integer.
        // Return true if the TextBox's value is valid.
        private bool ValidateTextBoxInteger(TextBox txt, bool allowBlank, out int value)
        {
            // Assume it's invalid.
            bool valid = false;

            // If the text is blank and blank is allowed, allow it.
            string text = txt.Text;
            if (allowBlank && (text.Length == 0)) valid = true;

            // If it contains a currency value, allow it.
            if (int.TryParse(text, out value)) valid = true;

            // Display the appropriate background color.
            if (valid) txt.BackColor = validColor;
            else txt.BackColor = invalidColor;

            return valid;
        }

        // Validate the entries for a row.
        // Return true if the row is valid.
        private bool ValidateRow(int row)
        {
            // If every field is blank, it's valid.
            if ((rowTextBoxes[row, 0].Text.Length == 0) &&
                (rowTextBoxes[row, 1].Text.Length == 0) &&
                (rowTextBoxes[row, 2].Text.Length == 0))
            {
                rowTextBoxes[row, 0].BackColor = validColor;
                rowTextBoxes[row, 1].BackColor = validColor;
                rowTextBoxes[row, 2].BackColor = validColor;

                // Clear the total.
                rowTextBoxes[row, 3].Clear();
                return true;
            }

            // Some fields are non-blank so all are required.
            bool descrIsValid = (rowTextBoxes[row, 0].Text.Length > 0);
            if (descrIsValid) rowTextBoxes[row, 0].BackColor = validColor;
            else rowTextBoxes[row, 0].BackColor = invalidColor;

            // Validate unit cost.
            decimal unitCost;
            bool unitCostIsValid =
                ValidateTextBoxCurrency(rowTextBoxes[row, 1], false, out unitCost);

            // Validate quantity.
            int quantity;
            bool quantityIsValid =
                ValidateTextBoxInteger(rowTextBoxes[row, 2], false, out quantity);

            // If unit cost and quantity are present, calculate total cost.
            if (unitCostIsValid && quantityIsValid)
            {
                decimal total = unitCost * quantity;
                rowTextBoxes[row, 3].Text = total.ToString("C");
            }
            else rowTextBoxes[row, 3].Clear();

            // Enable or disable the OK button.
            EnableOkButton();

            // Return true if all fields are valid.
            return (descrIsValid && unitCostIsValid && quantityIsValid);
        }

        #endregion Field Validation Methods

        // Get ready.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Select a city so there's always a selection.
            cityComboBox.SelectedIndex = 0;

            // Initialize the array of item row TextBoxes.
            rowTextBoxes = new TextBox[,]
            {
                { descrTextBox1, unitCostTextBox1, quantityTextBox1, totalTextBox1 },
                { descrTextBox2, unitCostTextBox2, quantityTextBox2, totalTextBox2 },
                { descrTextBox3, unitCostTextBox3, quantityTextBox3, totalTextBox3 },
                { descrTextBox4, unitCostTextBox4, quantityTextBox4, totalTextBox4 },
            };
        }

        // Just close the form.
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Validate first name and last name.
        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxPattern(firstNameTextBox, false, namePattern);
            EnableOkButton();
        }
        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxPattern(lastNameTextBox, false, namePattern);
            EnableOkButton();
        }

        // Just make sure the street is non-blank.
        private void streetTextBox_TextChanged(object sender, EventArgs e)
        {
            // Display the appropriate background color.
            if (streetTextBox.Text.Length > 0) streetTextBox.BackColor = validColor;
            else streetTextBox.BackColor = invalidColor;
            EnableOkButton();
        }

        // Set the list of allowed ZIP codes for this city.
        private void cityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            zipComboBox.Items.Clear();
            foreach (string zip in zips[cityComboBox.SelectedIndex])
                zipComboBox.Items.Add(zip);
            zipComboBox.SelectedIndex = 0;
        }

        // Validate item entries.
        private void row1_TextChanged(object sender, EventArgs e)
        {
            ValidateRow(0);
        }
        private void row2_TextChanged(object sender, EventArgs e)
        {
            ValidateRow(1);
        }
        private void row3_TextChanged(object sender, EventArgs e)
        {
            ValidateRow(2);
        }
        private void row4_TextChanged(object sender, EventArgs e)
        {
            ValidateRow(3);
        }

        // Enable the OK button if all fields are okay.
        private void EnableOkButton()
        {
            // Assume all fields are okay.
            bool valid = true;

            // See if the contact fields are okay.
            if (firstNameTextBox.Text.Length == 0) valid = false;
            if (lastNameTextBox.Text.Length == 0) valid = false;
            if (streetTextBox.Text.Length == 0) valid = false;

            // See if all item fields are okay.
            foreach (TextBox txt in rowTextBoxes)
                if (txt.BackColor == invalidColor)
                {
                    valid = false;
                    break;
                }

            // Calculate the grand total.
            CalculateGrandTotal();

            // Make sure at least one item row has values in it.
            if (grandTotalTextBox.Text.Length == 0) valid = false;

            // Enable or disable the button.
            okButton.Enabled = valid;
        }

        // Calculate the grand total if possible.
        private void CalculateGrandTotal()
        {
            // See if any row has a total.
            if ((totalTextBox1.Text.Length == 0) &&
                (totalTextBox2.Text.Length == 0) &&
                (totalTextBox3.Text.Length == 0) &&
                (totalTextBox4.Text.Length == 0))
            {
                grandTotalTextBox.Clear();
                return;
            }

            // Add up the item totals.
            decimal grandTotal = 0;
            for (int row = 0; row < 4; row++)
            {
                if (rowTextBoxes[row, 3].Text.Length > 0)
                    grandTotal += decimal.Parse(
                        rowTextBoxes[row, 3].Text, NumberStyles.Currency);
            }

            // Display the grand total.
            grandTotalTextBox.Text = grandTotal.ToString("C");
        }

        // Perform sanity checks for a row.
        // If a field fails its checks, add a message to the message string
        // and set focus to that field (if focus isn't already set somewhere else).
        private void SanityCheckRow(int row, ref string message, ref TextBox focusTextBox)
        {
            // Either every field is present or every field is blank.
            // If the description is blank, returnu true.
            if (rowTextBoxes[row, 0].Text.Length == 0) return;

            // Check the description.
            if (rowTextBoxes[row, 0].Text.Length < minDescrLength)
            {
                message += "Description " + (row + 1) + " is unusually short.\n";
                if (focusTextBox == null) focusTextBox = rowTextBoxes[row, 0];
            }

            // Check the unit price.
            decimal price = decimal.Parse(
                rowTextBoxes[row, 1].Text, NumberStyles.Currency);
            if ((price < minUnitCost) || (price > maxUnitCost))
            {
                message += "Unit price " + (row + 1) + " is unusual.\n";
                if (focusTextBox == null) focusTextBox = rowTextBoxes[row, 1];
            }

            // Check the quantity.
            int quantity = int.Parse(rowTextBoxes[row, 2].Text);
            if ((price < minUnitCost) || (price > maxUnitCost))
            {
                message += "Quantity " + (row + 1) + " is unusual.\n";
                if (focusTextBox == null) focusTextBox = rowTextBoxes[row, 1];
            }
        }

        // Make sure the form is complete.
        private void okButton_Click(object sender, EventArgs e)
        {
            // Perform validations that require fixing.
            string message = "";
            TextBox focusTextBox = null;
            if (firstNameTextBox.Text.Length == 0)
            {
                message += "First name cannot be blank.\n";
                if (focusTextBox == null) focusTextBox = firstNameTextBox;
            }
            if (lastNameTextBox.Text.Length == 0)
            {
                message += "Last name cannot be blank.\n";
                if (focusTextBox == null) focusTextBox = lastNameTextBox;
            }
            if (streetTextBox.Text.Length == 0)
            {
                message += "Street cannot be blank.\n";
                if (focusTextBox == null) focusTextBox = streetTextBox;
            }
            if (grandTotalTextBox.Text.Length == 0)
            {
                message += "At least one item row must be entered.\n";
                if (focusTextBox == null) focusTextBox = descrTextBox1;
            }

            // See if any of these failed.
            if (message.Length > 0)
            {
                // Remove the final \n.
                message = message.Substring(0, message.Length - 1);

                // Display the message.
                MessageBox.Show(message, "Invalid Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                focusTextBox.Focus();
                return;
            }

            // Perform sanity checks.
            if (firstNameTextBox.Text.Length < minNameLength)
            {
                message += "The first name is unusually short.\n";
                if (focusTextBox == null) focusTextBox = firstNameTextBox;
            }
            if (lastNameTextBox.Text.Length < minNameLength)
            {
                message += "The last name is unusually short.\n";
                if (focusTextBox == null) focusTextBox = lastNameTextBox;
            }
            if (streetTextBox.Text.Length < minNameLength)
            {
                message += "The street name is unusually short.\n";
                if (focusTextBox == null) focusTextBox = streetTextBox;
            }            
            for (int row = 0; row < 4; row++)
            {
                SanityCheckRow(row, ref message, ref focusTextBox);
            }

            // See if any sanity checks failed.
            if (message.Length > 0)
            {
                // Compose the question.
                message = "Some fields contain unusual values.\n\n" +
                    message + "\nDo you want to continue anyway?";

                // Display the message and let the user decide whether to continue.
                if (MessageBox.Show(message, "Continue?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Continue anymway.
                    Close();
                }
                else
                {
                    // Let the user edit the data.
                    focusTextBox.Focus();
                }
            }
        }
    }
}
