using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.AccessModifiers1
{
    public class VIPBankAccount : BankAccount
    {
        protected decimal overdraftLimit;

        public VIPBankAccount(string ownerName, decimal initialBalance, decimal overdraftLimit)
            : base(ownerName, initialBalance)
        {
            this.overdraftLimit = overdraftLimit;
        }
    }

}
