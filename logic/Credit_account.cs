using System;

namespace logic
{
    public class Credit_account : Bank_account
    {
        protected double _credit_limit;

        public Credit_account(string social_security_number, double balance, double interest_rate, double credit_limit) : base(social_security_number, balance, interest_rate)
        {
            this._credit_limit = credit_limit;
        }
        
        public override string ToString() 
        {
            return $"Credit account {base.ToString()} - Credit limit: ${this._credit_limit}";
        }
    }
}
