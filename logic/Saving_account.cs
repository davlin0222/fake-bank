using System;

namespace logic
{
    public class Savings_account : Bank_account
    {
        public Savings_account(string social_security_number, double balance, double interest_rate) : base(social_security_number, balance, interest_rate)
        {
        }
        
        public override void deposit(double amount)
        {
            this._balance += amount;
        }

        public override bool withdraw(double amount) {
            if (amount > this._balance) return false;

            this._balance -= amount;
            return true;
        }
        
        public override string ToString() 
        {
            return $"Savings account {base.ToString()}";
        }
    }
}
