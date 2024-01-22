using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAdoNetBaglantiliYontem.HR
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        public int DepartmentId { get; set; }

        public override string ToString()
        {
            return $"{EmployeeId} - {FirstName} {LastName} - {Salary} - DepartmentId: {DepartmentId}";
        }
    }
}
