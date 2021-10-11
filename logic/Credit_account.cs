using System;

namespace logic
{
    public class Credit_account : Bank_account
    {
        public Credit_account(string social_security_number, double balance, double interest_rate) : base(social_security_number, balance, interest_rate)
        {

        }
        
        public override string ToString() 
        {
            return $"Credit account {base.ToString()}";
        }
    }
}
