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
            Console.WriteLine($"savings_account.withdraw(50) // {savings_account.withdraw(50)}");
            Console.WriteLine($"savings_account.withdraw(200) // {savings_account.withdraw(200)}");
            ;

            Credit_account credit_account = new Credit_account("111122334444", 230, 1.04, 500);
            Bank_account.record.Add(credit_account);
            credit_account.deposit(50);
            Console.WriteLine($"credit_account.withdraw(300) // {credit_account.withdraw(300)}");
            Console.WriteLine($"credit_account.withdraw(500) // {credit_account.withdraw(500)}");
            Console.WriteLine($"credit_account.calculate_interest() // {credit_account.calculate_interest()}");

            Console.WriteLine();
            Console.WriteLine(Bank_account.record_string());
        }
    }
}
