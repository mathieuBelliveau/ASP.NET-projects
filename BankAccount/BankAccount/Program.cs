using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("matt", 2000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

            account.makeWithdrawal(20, DateTime.Now, "test");
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

            Console.WriteLine(account.getAccountHistory());
        }
    }
}
