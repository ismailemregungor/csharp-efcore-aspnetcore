using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.AccessModifiers1
{
    internal class InternalAudit
    {
        
        public void AuditAccount(BankAccount account)
        {
            // Hesap bilgilerine erişim sağlanabilir çünkü bu sınıf aynı projede.

        }
    }

}
