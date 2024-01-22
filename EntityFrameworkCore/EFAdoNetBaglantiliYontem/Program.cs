
using EFAdoNetBaglantiliYontem.HR;
using EFAdoNetBaglantiliYontem.HR2;
using Oracle.ManagedDataAccess.Client;

//OracleConnection conn = new OracleConnection("User Id=hr; Password=HR; Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1)(PORT = 1521)))(CONNECT_DATA = (SERVER=DEDICATED)(SID = orcl)))");

//conn.Open();

//OracleCommand cmd = new OracleCommand("Select * From departments", conn);


//OracleDataReader dr = cmd.ExecuteReader();

//while (dr.Read())
//{
//    Console.WriteLine(dr[0] + " " + dr[1]);
//}
//conn.Close();

///*
// * HR
// */

//HRManager hrManager = new HRManager("User Id=hr; Password=HR; Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1)(PORT = 1521)))(CONNECT_DATA = (SERVER=DEDICATED)(SID = orcl)))");
//List<Employee> employees = hrManager.GetEmployees();
//foreach (var employee in employees)
//{
//    Console.WriteLine(employee);
//}

/*
 * HR2
 */

HrDbContext hrDbContext = new HrDbContext();
foreach (var emp in hrDbContext.Employees.GetAll())
{

}