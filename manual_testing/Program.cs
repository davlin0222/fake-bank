using System;
using logic;

namespace manual_testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Savings_account savings_account = new Savings_account("111122334444", 120, 1.02);
            Bank_account.record.Add(savings_account);

            Credit_account credit_account = new Credit_account("111122334444", 230, 1.04, 500);
            Bank_account.record.Add(credit_account);

            Console.WriteLine(Bank_account.record_string());
        }
    }
}
