using SingletonDesingPattern;

// Uygulamanın başka bir yerinde kullanımı:
var settings = Settings.GetInstance();
Console.WriteLine(settings.Language);