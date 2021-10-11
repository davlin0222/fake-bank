using System;

namespace logic
{
    public class Credit_account : Bank_account
    {
        public Credit_account(string social_security_number) : base(social_security_number)
        {

        }
        
        public override string ToString() 
        {
            return $"Credit account {base._social_security_number}";
        }
    }
}
