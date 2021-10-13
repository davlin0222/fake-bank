using System;
using System.Collections.Generic;

namespace logic
{
    public abstract class Bank_account
    {
        protected string _social_security_number;
        protected double _balance;
        protected double _interest_rate;

        public Bank_account(string social_security_number, double balance, double interest_rate)
        {
            this._social_security_number = social_security_number;
            this._balance = balance;
            this._interest_rate = interest_rate;
        }

        public abstract void deposit(double amount);
        public abstract bool withdraw(double amount);

        public override string ToString() 
        {
            return $"{this._social_security_number}: ${this._balance} ({Math.Floor((this._interest_rate - 1) * 100)}%)";
        }

        public double calculate_interest() {
            return Math.Round((this._interest_rate - 1) * this._balance, 2);
        }
    }
}
