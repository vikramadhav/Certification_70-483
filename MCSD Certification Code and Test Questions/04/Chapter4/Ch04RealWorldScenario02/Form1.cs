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

namespace Ch04RealWorldScenario01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Exit.
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Validate the values on the form. If there are errors,
        // tell the user and set focus to the appropriate TextBox.
        // If there are no errors, display a success message and exit.
        private void okButton_Click(object sender, EventArgs e)
        {
            int quantity;
            decimal priceEach, extendedPrice, subtotal;

            // Validate the rows. If any fails, return.
            subtotal = 0;
            if (ValidateRow(descr1TextBox, quantity1TextBox, priceEach1TextBox,
                out quantity, out priceEach)) return;
            extendedPrice = quantity * priceEach;
            if (extendedPrice == 0m) extendedPrice1TextBox.Clear();
            else extendedPrice1TextBox.Text = extendedPrice.ToString();
            subtotal += extendedPrice;

            if (ValidateRow(descr2TextBox, quantity2TextBox, priceEach2TextBox,
                out quantity, out priceEach)) return;
            extendedPrice = quantity * priceEach;
            if (extendedPrice == 0m) extendedPrice2TextBox.Clear();
            else extendedPrice2TextBox.Text = extendedPrice.ToString();
            subtotal += extendedPrice;

            if (ValidateRow(descr3TextBox, quantity3TextBox, priceEach3TextBox,
                out quantity, out priceEach)) return;
            extendedPrice = quantity * priceEach;
            if (extendedPrice == 0m) extendedPrice3TextBox.Clear();
            else extendedPrice3TextBox.Text = extendedPrice.ToString();
            subtotal += extendedPrice;

            if (ValidateRow(descr4TextBox, quantity4TextBox, priceEach4TextBox,
                out quantity, out priceEach)) return;
            extendedPrice = quantity * priceEach;
            if (extendedPrice == 0m) extendedPrice4TextBox.Clear();
            else extendedPrice4TextBox.Text = extendedPrice.ToString();
            subtotal += extendedPrice;

            // Display subtotal.
            subtotalTextBox.Text = subtotal.ToString();

            // Get the tax rate as a string.
            string taxRateString = taxRateTextBox.Text;

            // Remove the % character if it is present.
            taxRateString = taxRateString.Replace("%", "");

            // Parse the tax rate.
            decimal taxRate;
            if (!decimal.TryParse(taxRateString, out taxRate))
            {
                // Complain.
                DisplayErrorMessage(
                    "Invalid format. Tax Rate must be a decimal value.",
                    "Invalid Format", taxRateTextBox);
                return;
            }

            // If the original string contains the % character, divide by 100.
            if (taxRateTextBox.Text.Contains("%")) taxRate /= 100;

            // Make sure Tax Rate is between 0.00 and 0.20.
            if ((taxRate < 0m) || (taxRate > 0.2m))
            {
                // Complain.
                DisplayErrorMessage(
                    "Invalid Tax Rate. Tax Rate must be between 0.00 and 0.20.",
                    "Invalid Tax Rate", taxRateTextBox);
                return;
            }

            // At this point we have all the data we need.

            // Calculate and display the sales tax.
            decimal salesTax = subtotal * taxRate;
            salesTaxTextBox.Text = salesTax.ToString();

            // Calculate and display grand total.
            decimal grandTotal = subtotal + salesTax;
            grandTotalTextBox.Text = grandTotal.ToString();

            // Display the success message and ask if we should continue.
            if (MessageBox.Show("This order is valid. Continue?", "Continue?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // The user clicked Yes. Exit.
                Close();
            }
        }

        // Validate a row. If any value is present, all are required.
        // If all values are present, set the out parameters.
        // If there is an error, tell the user, set focus to the
        // appropriate TextBox, and return true.
        private bool ValidateRow(TextBox descrTextBox, TextBox quantityTextBox,
            TextBox priceEachTextBox, out int quantity, out decimal priceEach)
        {
            // Assume these are 0.
            quantity = 0;
            priceEach = 0;

            // If no values are present, the row is okay.
            if ((descrTextBox.Text == "") &&
                (quantityTextBox.Text == "") &&
                (priceEachTextBox.Text == ""))
                return false;

            // Some values are present to make sure all are.
            if (ValidateRequiredTextBox(descrTextBox, "Description")) return true;
            if (ValidateRequiredTextBox(quantityTextBox, "Quantity")) return true;
            if (ValidateRequiredTextBox(priceEachTextBox, "Price Each")) return true;

            // All values are present.
            // Try to parse quantity.
            if (!int.TryParse(quantityTextBox.Text, out quantity))
            {
                // Complain.
                DisplayErrorMessage(
                    "Invalid format. Quantity must be an integer.",
                    "Invalid Format", quantityTextBox);
                return true;
            }

            // Make sure quantity is between 1 and 100.
            if ((quantity < 1) || (quantity > 100))
            {
                // Complain.
                DisplayErrorMessage(
                    "Invalid Quantity. Quantity must be between 1 and 100.",
                    "Invalid Quantity", quantityTextBox);
                return true;
            }

            // Try to parse priceEach.
            if (!decimal.TryParse(priceEachTextBox.Text, NumberStyles.Currency,
                null, out priceEach))
            {
                // Complain.
                DisplayErrorMessage(
                    "Invalid format. Price Each must be an currency value.",
                    "Invalid Format", priceEachTextBox);
                return true;
            }

            // Make sure priceEach is between $0.01 and $100,000.00.
            if ((priceEach < 0.01m) || (priceEach > 100000.00m))
            {
                // Complain.
                DisplayErrorMessage(
                    "Invalid Price Each. Price Each must be between $0.01 and $100,000.00",
                    "Invalid Quantity", priceEachTextBox);
                return true;
            }

            // If we get here, we have all of our data.
            // Return false to indicate there is no error on this line.
            return false;
        }

        // This TextBox is required. If it is blank,
        // tell the user, set focus to it, and return true.
        private bool ValidateRequiredTextBox(TextBox txt, string name)
        {
            // If the TextBox is not blank, return false.
            if (txt.Text != "") return false;

            // The TextBox is blank. Complain.
            DisplayErrorMessage(name + " is required", "Missing Value", txt);
            return true;
        }

        // Tell the user there is an error, select all of the
        // text in the TextBox, and set focus to the TextBox.
        private void DisplayErrorMessage(string message, string title, TextBox txt)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            txt.SelectAll();
            txt.Focus();
        }
    }
}
