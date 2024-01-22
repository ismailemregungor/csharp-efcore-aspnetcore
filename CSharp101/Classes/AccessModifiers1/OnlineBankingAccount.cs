using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.AccessModifiers1
{
    public class OnlineBankingAccount : BankAccount
    {
        public OnlineBankingAccount(string ownerName, decimal initialBalance) : base(ownerName, initialBalance)
        {
        }

        protected internal void ResetPassword()
        {
            // Şifre sıfırlama işlemleri
        }
    }

}
