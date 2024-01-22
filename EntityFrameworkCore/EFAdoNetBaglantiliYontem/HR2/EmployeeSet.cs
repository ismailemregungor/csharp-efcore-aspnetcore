using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAdoNetBaglantiliYontem.HR2
{
    public class EmployeeSet : ISet<Employee>
    {
        private string ConnStr { get;  set; }
        public EmployeeSet(string strConn)
        {
            ConnStr = strConn;
        }

        public List<Employee> GetAll()
        {
            OracleConnection conn = new OracleConnection(ConnStr);
            List<Employee> employees = new List<Employee>();
            conn.Open();
            using (OracleCommand cmd = new OracleCommand("Select Employee_Id, First_Name, Last_Name, Salary, Department_Id FROM Employees", conn))
            {
                OracleDataReader dr = cmd.ExecuteReader(); ;
                while (dr.Read())
                {
                    Employee emp = new Employee();
                    emp.EmployeeId = dr.GetInt32(0);
                    emp.FirstName = dr["First_Name"].ToString();
                    emp.LastName = dr.GetString(2);
                    emp.Salary = dr.GetDouble(3);
                    emp.DepartmentId = ((int?)dr[4]).GetValueOrDefault();
                    employees.Add(emp);

                }
            }
            return employees;
        }
        public Employee Find(int id)
        {
            OracleConnection conn = new OracleConnection(ConnStr);
            conn.Open();
            Employee emp = new Employee();

            using (OracleCommand cmd = new OracleCommand(("Select Employee_Id, First_Name, Last_Name, Salary, Department_Id FROM Employees Where Employee_Id=@id"), conn))
            {
                cmd.Parameters.Add("@id", id);
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                emp.EmployeeId = -1; ;

                if (dr.HasRows)
                {
                    emp.FirstName = dr["First_Name"].ToString();
                    emp.LastName = dr.GetString(2);
                    emp.Salary = dr.GetDouble(3);
                    emp.DepartmentId = (int)dr[4];
                }
            }
            return emp;
        }
    }
}
