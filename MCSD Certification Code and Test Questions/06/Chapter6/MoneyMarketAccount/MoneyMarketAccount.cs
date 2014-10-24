using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyMarketAccount
{
    class MoneyMarketAccount : BankAccount
    {
        public void DebitFee(decimal amount)
        {
            // See if there is this much money in the account.
            if (Balance >= amount)
            {
                // Remove the money.
                Balance -= amount;
            }
            else
            {
                // Raise the Overdrawn event.
                OnOverdrawn(new OverdrawnEventArgs(Balance, amount));
            }
        }
    }
}
