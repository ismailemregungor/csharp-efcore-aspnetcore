
using _5_DependencyInversionPrinciple.Cozum;

MSSql sql = new MSSql();
Oracle oracle = new Oracle();

DatabaseManager2 sqlManager = new DatabaseManager2(sql);
DatabaseManager2 oracleManager = new DatabaseManager2(oracle);

Console.WriteLine(sqlManager.Oku());
Console.WriteLine(oracleManager.Oku());