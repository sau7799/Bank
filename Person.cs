using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Person
    {
        public uint PersonID { get; set; }

        public  string Name { get; set; }

        public Person(uint personID,string name)
        {
            PersonID = personID;
            Name = name;
        }
    }
}
