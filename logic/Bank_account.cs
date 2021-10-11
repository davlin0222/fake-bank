using System;
using System.Collections.Generic;

namespace logic
{
    public abstract class Bank_account
    {
        public static List<Bank_account> record = new List<Bank_account>();

        public static string record_string()
        {
            return String.Join("\n", record);
        }

        protected string _social_security_number;
        protected double _balance;
        protected double _interest_rate;

        public Bank_account(string social_security_number, double balance, double interest_rate)
        {
            this._social_security_number = social_security_number;
            this._balance = balance;
            this._interest_rate = interest_rate;
        }

        public override string ToString() 
        {
            return $"{this._social_security_number}: ${this._balance} ({Math.Floor((this._interest_rate - 1) * 100)}%)";
        }
    }
}
