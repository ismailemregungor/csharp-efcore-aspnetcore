using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EFAdoNetBaglantiliYontem.HR2
{
    public class HrDbContext
    {
        string strConn = "User Id=hr; Password=HR; Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SID = orcl)))";
        public EmployeeSet Employees { get; set; }

        public HrDbContext()
        {
            Employees = new EmployeeSet(strConn);
        }
    }
}
