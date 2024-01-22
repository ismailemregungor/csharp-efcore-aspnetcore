using EFCoreDatabaseFirst.Models;

Console.WriteLine();

ModelContext modelContext = new ModelContext();

foreach (var item in modelContext.Employees)
{
    Console.WriteLine(item);
}

