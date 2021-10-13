using System;
using logic;

namespace manual_testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank_record bank = new Bank_record();


            Savings_account savings_account = new Savings_account("111122334444", 120, 1.02);
            bank.accounts.Add(savings_account);

            Console.WriteLine($"savings_account.withdraw(50) // {savings_account.withdraw(50)}");
            Console.WriteLine($"savings_account.withdraw(200) // {savings_account.withdraw(200)}");
            Console.WriteLine($"savings_account.calculate_interest() // {savings_account.calculate_interest()}");


            Credit_account credit_account = new Credit_account("111122334444", 230, 1.04, 500);
            bank.accounts.Add(credit_account);

            credit_account.deposit(50);
            Console.WriteLine($"credit_account.withdraw(300) // {credit_account.withdraw(300)}");
            Console.WriteLine($"credit_account.withdraw(500) // {credit_account.withdraw(500)}");
            Console.WriteLine($"credit_account.calculate_interest() // {credit_account.calculate_interest()}");


            Console.WriteLine();
            Console.WriteLine(bank.ToString());
        }
    }
}
