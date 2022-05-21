using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Owner
    {
        public uint PersonId { get; set; }

        public uint AccountId { get; set; }

        public Owner( uint personId , uint accountId)
        {
            PersonId = personId;
            AccountId = accountId;
        }

    }
}
