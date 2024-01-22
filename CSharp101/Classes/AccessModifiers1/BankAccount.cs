using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.AccessModifiers1
{
    public class BankAccount
    {
        private string ownerName;
        private decimal balance;

        public BankAccount(string ownerName, decimal initialBalance)
        {
            this.ownerName = ownerName;
            this.balance = initialBalance;
        }

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

        public decimal GetBalance()
        {
            return balance;
        }
    }
}
