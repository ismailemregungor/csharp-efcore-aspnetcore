//int sayi1= null;

Nullable<int> sayi2 = null;
//Console.WriteLine(sayi2.Value);
Console.WriteLine(sayi2.HasValue);

int? sayi3 = null;
//Console.WriteLine(sayi3.Value);
Console.WriteLine(sayi3.HasValue);

Console.WriteLine(sayi3.GetValueOrDefault());
Console.WriteLine(sayi3 ?? -1);

int sayi4 = sayi2 ?? -1;
Console.WriteLine(sayi4);
