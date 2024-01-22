//using Classes.Classes1;

//Personel personel = new Personel();
// //personel.id = 1;
// //Console.WriteLine(personel.id);

//// manuel oluşturduğumuz get ve set metodları 
//personel.Set_Id(1);
//Console.WriteLine(personel.Get_Id());

//// property değişken gibi çalışır method değildir!
//personel.Name = "ie";
//Console.WriteLine(personel.Name);

//personel.Surname= "g";
//Console.WriteLine(personel.Surname);

//personel.Salary = 32000;
//Console.WriteLine(personel.Salary);


/*
 * Class Types Örnekleri
 */

//using Classes.ClassTypes1;

//Ucgen ucgen = new Ucgen();
//// Sekil sekil = new Sekil();   --> abstract class newlenemez
//Sekil sekil1 = new Ucgen();
//Sekil sekil2 = new Kare();

//sekil1.SekilAdi = "Üçgen";
//sekil2.SekilAdi = "Kare";

//((Ucgen)sekil2).UcgenTipi = "Dik Üçgen";
//((Kare)sekil2).KenarUzunlugu = 5;

//SekilIslemleri.SekilCiz(new Ucgen());
//SekilIslemleri.SekilCiz(new Kare());

/*
 * Bir uygulamada t anında o nesneden kaç tane oluşturulduğunu
 * gösteren kodu c# ile yazınız.
 */

//using Classes.ClassTypes2;

//Asker asker1 = new Asker();
//Asker asker2 = new Asker();
//Asker asker3 = new Asker();
//Asker asker4 = new Asker();

//using Classes.ClassTypes2;

////Dizi dizi = new Dizi();
////Static method sınıfa aittir sınıf örneğinden değil direk sınıftan çağrılır. dizi'den değil Dizi'den çağrılır.
////Dizi.DiziSirala();


//using Classes.ClassTypes3;

//Ucgen ucgen1 = new Ucgen();
//Kare kare1 = new Kare();
//ucgen1.Ciz();
//kare1.Ciz();

//Sekil ucgen = new Ucgen();
//ucgen.Ciz();

//Sekil kare = new Kare();
//kare.Ciz();

/*
 * Bir satış firmasında çalışan personeller tam zamanlı ve yarı zamanlı
 * olarak çalışmaktadırlar. 
 * Tam zamanlı personellerin maaşı = taban ücret + prim şeklindedir.
 * Prim ise 100.000 TL'ye kadar %1, 100.000 ile 250.000 arası %2
 * 250.000'den büyük ise %3 olarak hesaplanmaktadır.
 * Yarı zamanlı personellerin maaşı ise çalıştığı saat *  saat ücreti + prim şeklindedir.
 * Yarı zamanlı personellerin yaptığı satışın yüzde %1'i prim olarak maaşına yansıtılacaktır.
 * Değişik tipte en az 3 personel için bu maaşları hesaplayan ve gösteren uygulamayı 
 * C# dili ile oop kullanarak yazınız(interface hariç.)
 * Uygulama başlatılınca menü gelsin
 * 1-Menü
 * 2-Personel verileri gir
 * 3-Listele
 * 4-Çıkış
 */

using Classes.ClassTypes4;

MaasYonetimi maasYonetimi = new MaasYonetimi();
maasYonetimi.Baslat();



