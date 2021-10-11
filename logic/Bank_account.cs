using System;

namespace logic
{
    public abstract class Bank_account
    {
        protected string _social_security_number;
        public Bank_account(string social_security_number)
        {
            this._social_security_number = social_security_number;
        }
    }
}
