using Indexers;

Depo depo = new Depo();
Console.WriteLine(depo[2]);


string str = "Merhaba";
Console.WriteLine(str[0]);

/*
 * Eğer bir sınıfı çağrırken this[]'i görüyorsak bu bir indeksleyicidir ve
 * bir sınıfı dizi olarak kullanabilmemeizi sağlar.
 */