using ismailemregungorAlbumDukkani.Utilities;

Console.WriteLine("Albüm Mağazası Yönetim Paneline Hoşgeldiniz!");

if (Utility.GirisYap())
{
    bool cikisYap = false;
    while (!cikisYap)
    {
        cikisYap = Utility.MenuGoster();
    }
}
else
{
    Console.WriteLine("Giriş başarısız. Lütfen bilgilerinizi kontrol edin ve tekrar deneyin.");
}

Console.WriteLine("Programdan çıkılıyor...");