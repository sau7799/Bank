using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Account
    {
        public uint  AccountID { get; set; }

        public string AccountType { get; set; }

        public double Balance { get; set; }
        public Account(uint accountID, string accountType, double balance)
        {
            AccountID = accountID;
            AccountType = accountType;
            Balance = balance;      


        }
    }
}
