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

namespace Ch06RealWorldScenario01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private OverdraftAccount TheAccount;

        // Make the accounts.
        private void Form1_Load(object sender, EventArgs e)
        {
            TheAccount = new OverdraftAccount();
            TheAccount.SavingsAccount = new BankAccount();
            TheAccount.Balance = 50m;
            TheAccount.SavingsAccount.Balance = 50m;
            DisplayBalances();

            // Subscribe to the accounts' Overdrawn events.
            TheAccount.Overdrawn += OverdraftOverdrawnHandler;
            TheAccount.SavingsAccount.Overdrawn += SavingsOverdrawnHandler;
        }

        // The event handler with event args.
        private void OverdraftOverdrawnHandler(object sender, OverdrawnEventArgs args)
        {
            // Get the overdraft account.
            OverdraftAccount account = sender as OverdraftAccount;
            string message =
                "The account is overdrawn." + Environment.NewLine +
                "Current Balance: " + account.Balance.ToString("C") + Environment.NewLine +
                "Savings Balance: " + account.SavingsAccount.Balance.ToString("C") + Environment.NewLine +
                "Debit Amount: " + args.DebitAmount.ToString("C");
            MessageBox.Show(message);
        }

        // The event handler with event args.
        private void SavingsOverdrawnHandler(object sender, OverdrawnEventArgs args)
        {
            string message =
                "The savings account is overdrawn." + Environment.NewLine +
                "Current Balance: " + args.CurrentBalance.ToString("C") + Environment.NewLine +
                "Debit Amount: " + args.DebitAmount.ToString("C");
            MessageBox.Show(message);
        }

        // Add money to the account.
        private void overdraftCreditButton_Click(object sender, EventArgs e)
        {
            TheAccount.Credit(decimal.Parse(overdraftAmountTextBox.Text, NumberStyles.Currency));

            // Display the account balance.
            DisplayBalances();
        }

        // Remove money from the account.
        private void overdraftDebitButton_Click(object sender, EventArgs e)
        {
            TheAccount.Debit(decimal.Parse(overdraftAmountTextBox.Text, NumberStyles.Currency));

            // Display the account balance.
            DisplayBalances();
        }

        // Add money to the savings account.
        private void savingsCreditButton_Click(object sender, EventArgs e)
        {
            TheAccount.SavingsAccount.Credit(
                decimal.Parse(savingsAmountTextBox.Text,
                NumberStyles.Currency));

            // Display the account balance.
            DisplayBalances();
        }

        // Remove money from the savings account.
        private void savingsDebitButton_Click(object sender, EventArgs e)
        {
            TheAccount.SavingsAccount.Debit(decimal.Parse(
                savingsAmountTextBox.Text,
                NumberStyles.Currency));

            // Display the account balance.
            DisplayBalances();
        }

        // Display the account balances.
        private void DisplayBalances()
        {
            overdraftBalanceTextBox.Text = TheAccount.Balance.ToString("C");
            savingsBalanceTextBox.Text = TheAccount.SavingsAccount.Balance.ToString("C");
        }
    }
}
