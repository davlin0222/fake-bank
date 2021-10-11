using System;

namespace logic
{
    public class Savings_account : Bank_account
    {
        public Savings_account(string social_security_number) : base(social_security_number)
        {
            
        }
        
        public override string ToString() 
        {
            return $"Savings account {base._social_security_number}";
        }
    }
}
