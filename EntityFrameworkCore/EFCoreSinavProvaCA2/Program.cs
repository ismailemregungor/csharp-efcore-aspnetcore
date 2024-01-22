using EFCoreSinavProvaCA2.Utilities;

Console.WriteLine("Albüm Mağazası Yönetim Paneline Hoşgeldiniz!");
if (Utility.GirisYap())
{
    // Kullanıcı girişi başarılı ise ana menüyü göster
    bool cikisYap = false;
    while (!cikisYap)
    {
        cikisYap = Utility.MenuGoster();
    }
}
else
{
    // Kullanıcı girişi başarısız ise uyarı ver ve programı sonlandır
    Console.WriteLine("Giriş başarısız. Lütfen bilgilerinizi kontrol edin ve tekrar deneyin.");
}

// Programı düzgün bir şekilde sonlandır
Console.WriteLine("Programdan çıkılıyor...");