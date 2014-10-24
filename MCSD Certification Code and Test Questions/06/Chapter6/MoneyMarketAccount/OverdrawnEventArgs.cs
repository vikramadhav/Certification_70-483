using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyMarketAccount
{
    class OverdrawnEventArgs : EventArgs
    {
        public decimal CurrentBalance, DebitAmount;

        public OverdrawnEventArgs(decimal currentBalance, decimal debitAmount)
        {
            CurrentBalance = currentBalance;
            DebitAmount = debitAmount;
        }
    }
}
