﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class BankAccount
    {
        private decimal balance;
        public decimal Balance => balance;

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
        }


        public bool Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                return true;
            }
            return false;
        }

    }
}
