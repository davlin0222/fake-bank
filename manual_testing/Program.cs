using System;
using logic;

namespace manual_testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Savings_account savings_account = new Savings_account("111122334444");
            Console.WriteLine(savings_account);
        }
    }
}
