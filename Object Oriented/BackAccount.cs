using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Transactions;

namespace Object_Oriented
{
    class BackAccount
    {
        public string Number { get; }
        public string OwnerName { get; set; }
        public decimal Balance {
            get
            {
                decimal Balance= 0;
                foreach (var item in allTransactions)
                {
                    Balance += item.Amount;
                }
                return Balance;
            }
        }
        private List<Transaction>allTransactions = new List<Transaction>();

        private static int accountNumberSeed = 0000000001;
        public BackAccount(string o,decimal b)
        {
            Number = accountNumberSeed.ToString();
            accountNumberSeed++;
            OwnerName = o;
            MakeDeposist(b, DateTime.Now, "Deposist");
        }
        public void MakeDeposist(decimal a, DateTime d, string n)
        {
            if (a <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(a), "Amount of deposist must ne positive");
            }
            var deposit = new Transaction(a, d, n);
            allTransactions.Add(deposit);
        }
        public void MakeWithdrawal(decimal a, DateTime d, string n)
        {
            if (a <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(a), "Amount of deposist must ne positive");
            }
            if (Balance - a < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(a), "Not sufficient for this withdrawal");
            }
            var withdrawal = new Transaction(-a, d, n);
            allTransactions.Add(withdrawal);
        }
    }
}
