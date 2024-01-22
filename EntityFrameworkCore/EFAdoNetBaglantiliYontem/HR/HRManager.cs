using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAdoNetBaglantiliYontem.HR
{
    public class HRManager
    {
        private string connectionString;

        public HRManager(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            OracleConnection conn = new OracleConnection(connectionString);

            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand("SELECT * FROM Employees", conn);
                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Employee employee = new Employee
                    {
                        EmployeeId = dr["EMPLOYEE_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["EMPLOYEE_ID"]),
                        FirstName = dr["FIRST_NAME"] == DBNull.Value ? string.Empty : dr["FIRST_NAME"].ToString(),
                        LastName = dr["LAST_NAME"] == DBNull.Value ? string.Empty : dr["LAST_NAME"].ToString(),
                        Salary = dr["SALARY"] == DBNull.Value ? 0 : Convert.ToInt32(dr["SALARY"]),
                        DepartmentId = dr["DEPARTMENT_ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["DEPARTMENT_ID"])
                    };
                    employees.Add(employee);
                }

                dr.Close();
                cmd.Dispose();
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

            return employees;
        }
    }
}
