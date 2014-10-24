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

namespace MoneyMarketAccount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The bank account.
        private MoneyMarketAccount TheAccount;

        // Create the account and subscribe the event handler.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Create the account.
            TheAccount = new MoneyMarketAccount();
            TheAccount.Balance = 100m;

            // Subscribe to the Overdrawn event.
            TheAccount.Overdrawn += OverdrawnHandler;

            // Display the account balance.
            DisplayBalance();
        }

        // The event handler with event args.
        private void OverdrawnHandler(object sender, OverdrawnEventArgs args)
        {
            string message =
                "The account is overdrawn." + Environment.NewLine +
                "Current Balance: " + args.CurrentBalance.ToString("C") + Environment.NewLine +
                "Debit Amount: " + args.DebitAmount.ToString("C");
            MessageBox.Show(message);
        }

        // Add money to the account.
        private void creditButton_Click(object sender, EventArgs e)
        {
            TheAccount.Credit(decimal.Parse(amountTextBox.Text, NumberStyles.Currency));

            // Display the account balance.
            DisplayBalance();
        }

        // Remove money from the account.
        private void debitButton_Click(object sender, EventArgs e)
        {
            TheAccount.Debit(decimal.Parse(amountTextBox.Text, NumberStyles.Currency));

            // Display the account balance.
            DisplayBalance();
        }

        // Display the account balance.
        private void DisplayBalance()
        {
            balanceTextBox.Text = TheAccount.Balance.ToString("C");
        }

        // Remove money from the account.
        private void feeButton_Click(object sender, EventArgs e)
        {
            TheAccount.Debit(decimal.Parse(amountTextBox.Text, NumberStyles.Currency));

            // Display the account balance.
            DisplayBalance();
        }
    }
}
