using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06RealWorldScenario01
{
    class OverdraftAccount : BankAccount
    {
        // The associated savings account.
        public BankAccount SavingsAccount { get; set; }

        // Remove money from the account.
        public new void Debit(decimal amount)
        {
            // See if there is this much money in the account.
            if (Balance + SavingsAccount.Balance < amount)
            {

                // Raise the Overdrawn event.
                OnOverdrawn(new OverdrawnEventArgs(Balance, amount));
            }
            else
            {
                // Remove the money we can from the overdraft account.
                if (Balance >= amount) Balance -= amount;
                else
                {
                    amount -= Balance;
                    Balance = 0m;

                    // If there's still an unpaid amount, take it from savings.
                    if (amount > 0m) SavingsAccount.Balance -= amount;
                }
            }
        }
    }
}
