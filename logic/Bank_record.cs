using System;
using System.Collections.Generic;

namespace logic
{
    public class Bank_record
    {
        public List<Bank_account> accounts = new List<Bank_account>();

        public Bank_record(List<Bank_account> accounts)
        {
            this.accounts = accounts;
        }
        public Bank_record()
        {
        }

        public override string ToString()
        {
            return String.Join("\n", this.accounts);
        }
    }
}
