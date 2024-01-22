
using BankaDLL;

void VeriGoster<T>(List<T> items)
{
	Console.WriteLine();
	foreach (T item in items)
	{
		Console.WriteLine(item);
	}
}

Banka banka = new Banka();
VeriGoster(banka.Vezneler.Listele());
VeriGoster(banka.Musteriler.Listele());
VeriGoster(banka.Personeller.Listele());

