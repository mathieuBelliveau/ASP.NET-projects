using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { 
            get
            {
                decimal balance = 0;
                foreach(Transaction trans in transactions)
                {
                    balance += trans.Amount;
                }
                return balance;
            }
        }

        private static int accountNumberSeed = 1234567890;

        private List<Transaction> transactions = new List<Transaction>();

        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;

            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");

            Number = accountNumberSeed++.ToString();
        }


        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            transactions.Add(deposit);
        }

        public void makeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Must be positive");
            }
            if (Balance - amount < 0)
                throw new InvalidOperationException("Insufficient funds");

            var withdrawal = new Transaction(-amount, date, note);
            transactions.Add(withdrawal);
        }

        public string getAccountHistory()
        {
            var report = new StringBuilder();

            report.AppendLine("Date\tAmmount\tNote");
            foreach(var trans in transactions)
            {
                report.AppendLine($"{trans.Date.ToShortDateString()}\t{trans.Amount}\t{trans.Notes}");

            }

            return report.ToString();
        }
    }

    
}
