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

        public Bank_account(string social_security_number)
        {
            this._social_security_number = social_security_number;
        }

        public override string ToString() 
        {
            return $"Bank account {this._social_security_number}";
        }
    }
}
