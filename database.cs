using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public static class database
    {
        public static List<Person> people = new List<Person>(); 
        public static List<Account> accounts = new List<Account>();  
        public static List<Owner> owners = new List<Owner>();

        public static void InItData()
        {
            // people

            people.Add(new Person(1, "Saurabh"));
            people.Add(new Person(2, "ankush"));
            people.Add(new Person(3, "pushpak"));
            people.Add(new Person(4, "tushar"));
            people.Add(new Person(5, "swami"));




            //  account

            accounts.Add(new Account(1,"checking",  100));
            accounts.Add(new Account(1, "checking", 200));
            accounts.Add(new Account(1, "checking", 300));
            accounts.Add(new Account(1, "checking", 400));
            accounts.Add(new Account(1, "checking", 500));
            accounts.Add(new Account(1, "checking", 600));
            accounts.Add(new Account(1, "checking", 700));


            // Owner
            owners.Add(new Owner(1, 1));
            owners.Add(new Owner(1, 2));
            owners.Add(new Owner(2, 3)); 
            owners.Add(new Owner(3, 4));
            owners.Add(new Owner(4, 5));
            owners.Add(new Owner(5, 6));

        }
    }
}
