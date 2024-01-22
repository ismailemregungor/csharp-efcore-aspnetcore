

// * CompanyCRUD
// */

//using WeekendTasks.CompanyCRUD;

//List<Personel> personelListesi = new List<Personel>();
//PersonelManager personelManager = new PersonelManager(personelListesi);
//bool devam = true;
//while (devam)
//{
//    Console.WriteLine("***********************************************************************************");
//    Console.Write("1 - Persone Ekle\n2 - Personel Sil\n3 - Id ile Personel Ara\n4 - Personel Güncelle\n5 - İlçe ile Personel Ara\n6 - Tüm Personelleri Listele\n0 - Çıkış\nSeçiminiz = ");
//    string secim = Console.ReadLine();
//    Console.WriteLine("***********************************************************************************");
//    switch (secim)
//    {
//        case "1":
//            Console.WriteLine("Personel Ekleme İşlemi");
//            Personel yeniPersonel = new Personel();
//            Console.Write("Id: ");
//            yeniPersonel.Id = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Ad: ");
//            yeniPersonel.Ad = Console.ReadLine();
//            Console.Write("Soyad: ");
//            yeniPersonel.Soyad = Console.ReadLine();
//            Console.Write("İlçe: ");
//            yeniPersonel.Ilce = Console.ReadLine();
//            personelManager.Ekle(yeniPersonel);
//            Console.WriteLine("***********************************************************************************");
//            break;

//        case "2":
//            Console.WriteLine("Personel Silme İşlemi");
//            Console.Write("Silmek istediğiniz personelin Id: ");
//            int silinecekId = Convert.ToInt32(Console.ReadLine());
//            personelManager.Sil(silinecekId);
//            Console.WriteLine("***********************************************************************************");
//            break;

//        case "3":
//            Console.WriteLine("Id ile Personel Arama İşlemi");
//            Console.Write("Aramak istediğiniz personelin Id: ");
//            int arananId = Convert.ToInt32(Console.ReadLine());
//            Personel bulunanPersonel = personelManager.GetirIdIle(arananId);
//            if (bulunanPersonel != null)
//            {
//                Console.WriteLine($"ID: {bulunanPersonel.Id}, Ad: {bulunanPersonel.Ad}, Soyad: {bulunanPersonel.Soyad}, İlçe: {bulunanPersonel.Ilce}");
//            }
//            else
//            {
//                Console.WriteLine("Personel bulunamadı.");
//            }
//            Console.WriteLine("***********************************************************************************");
//            break;

//        case "4":
//            Console.WriteLine("Personel Güncelleme İşlemi");
//            Console.Write("Güncellemek istediğiniz personelin Id: ");
//            int guncellenecekId = Convert.ToInt32(Console.ReadLine());

//            Personel guncellenecekPersonel = personelManager.GetirIdIle(guncellenecekId);
//            if (guncellenecekPersonel != null)
//            {
//                Console.Write("Yeni Ad: ");
//                guncellenecekPersonel.Ad = Console.ReadLine();
//                Console.Write("Yeni Soyad: ");
//                guncellenecekPersonel.Soyad = Console.ReadLine();
//                Console.Write("Yeni İlçe: ");
//                guncellenecekPersonel.Ilce = Console.ReadLine();
//                personelManager.Guncelle(guncellenecekPersonel);
//            }
//            else
//            {
//                Console.WriteLine("Personel bulunamadı.");
//            }
//            Console.WriteLine("***********************************************************************************");
//            break;

//        case "5":
//            Console.WriteLine("İlçe ile Personel Arama İşlemi");
//            Console.Write("Aramak istediğiniz ilçe: ");
//            string ilce = Console.ReadLine();
//            var ilcePersonelleri = personelManager.GetirIlceyeGore(ilce);
//            if (ilcePersonelleri.Count > 0)
//            {
//                foreach (var personel in ilcePersonelleri)
//                {
//                    Console.WriteLine($"ID: {personel.Id}, Ad: {personel.Ad}, Soyad: {personel.Soyad}, İlçe: {personel.Ilce}");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Bu ilçede personel bulunamadı.");
//            }
//            Console.WriteLine("***********************************************************************************");
//            break;

//        case "6":
//            var tumPersoneller = personelManager.GetirHepsi();
//            foreach (var personel in tumPersoneller)
//            {
//                Console.WriteLine($"ID: {personel.Id}, Ad: {personel.Ad}, Soyad: {personel.Soyad}, İlçe: {personel.Ilce}");
//            }
//            Console.WriteLine("***********************************************************************************");
//            break;
//        case "0":
//            devam = false;
//            break;

//        default:
//            Console.WriteLine("Geçersiz seçim!");
//            break;
//    }
//}


///*
// * WeatherSimulator
// */

//using WeekendTasks.WeatherSimulator;


//YagisSimulator yagisSimulator = new YagisSimulator();
//yagisSimulator.Baslat();