using Structs;

Nokta nokta1 = new Nokta { X = 10, Y = 20 };
Console.WriteLine(nokta1.Point());

Nokta nokta2 = new Nokta(10, 20);
Console.WriteLine(nokta2.Point());
