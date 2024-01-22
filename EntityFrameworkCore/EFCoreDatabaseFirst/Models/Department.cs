using System;
using System.Collections.Generic;

namespace EFCoreDatabaseFirst.Models
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
            JobHistories = new HashSet<JobHistory>();
        }

        public byte DepartmentId { get; set; }
        public string DepartmentName { get; set; } = null!;
        public int? ManagerId { get; set; }
        public byte? LocationId { get; set; }

        public virtual Location? Location { get; set; }
        public virtual Employee? Manager { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<JobHistory> JobHistories { get; set; }
    }
}
