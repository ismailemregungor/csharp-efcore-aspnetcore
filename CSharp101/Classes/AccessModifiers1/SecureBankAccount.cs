using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.AccessModifiers1
{
    public class SecureBankAccount : BankAccount
    {
        public SecureBankAccount(string ownerName, decimal initialBalance) : base(ownerName, initialBalance)
        {
        }

        private protected void PerformSecurityCheck()
        {
            // Güvenlik kontrolü işlemleri
        }
    }
}
