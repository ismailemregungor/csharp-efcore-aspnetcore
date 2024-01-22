
/*
 * SingleThread vs MultiThread
 */

using System.Diagnostics;

void Islem1()
{
	for (int i = 0; i < 10; i++)
	{
		Console.WriteLine(i);
		Thread.Sleep(100);
	}
}

void Islem2()
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("A");
        Thread.Sleep(100);
    }
}

// Single Thread çalışır; önce işlem1, sonra işlem2

//Islem1();
//Islem2();

// Multi Thread çalışır; bazen islem1, bazen islem2

Thread t1 = new Thread(Islem1);
Thread t2 = new Thread(Islem2);

t1.Priority = ThreadPriority.Highest;
t2.Priority = ThreadPriority.Lowest;

//t1.Start();
//t2.Start();

/*
 * Asenkron Programming?
 * return type Task olmalı.
 * Task<bool> --> geriye bool tipinde değer döndürür
 * Task<Personel> --> geriye Personel tipinde değer döndürür
 * Task<List<Customer>> geriye Customer tipinde List döndürür
 */

async Task Process1()
{
    await Task.Delay(10000);
    Console.WriteLine("Process1 finished");
    //return Task.CompletedTask;
}

async Task Process2()
{
    await Task.Delay(5000);
    Console.WriteLine("Process2 finished");
    //return Task.CompletedTask;
}

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();

// Burada Asenkron çalışmaz sırayla çalışır
//await Process1();
//await Process2();

// Burada Asenkron çalışır
Task.WaitAll(Process1(), Process2());


stopwatch.Stop();

Console.WriteLine(stopwatch.ElapsedMilliseconds);