using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Customer_klass
    {
        public string Name { get; }
        public decimal PersonalNumber { get; }
        public BankAccount Account { get; }

        private const string PIN = "1234";
        public Customer_klass(string name, decimal personalNumber, BankAccount account)
        {
            Name = name;
            PersonalNumber = personalNumber;
            Account = account;
        }
    }
     
}
