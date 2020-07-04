using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented
{
    class Transaction
    {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }
        public Transaction(decimal a, DateTime d, string n)
        {
            Amount = a;
            Date = d;
            Notes = n;
        }
    }
}
