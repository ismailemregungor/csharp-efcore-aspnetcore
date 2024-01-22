//string strMesaj = "deneme";

//Console.WriteLine(strMesaj.ToUpper());
//Console.WriteLine(strMesaj.ToLower());

//string strPath1 = "c:\\dosyalar\\data\\json.data";
//string strPath2 = "c:/dosyalar/data//json.data";
//string strPath3 = @"c:\dosyalar\data\json.data";

// Dosya adını path içerisinden alan metodu yazınız?


//// 1. yöntem
//string filePath1 = @"C:\Users\Kullanici\Belgeler\ornek.txt";
//string fileName1 = Path.GetFileName(filePath1);
//Console.WriteLine("Dosya Adı: " + fileName1);

////1. yöntemin metod hali
//static string GetFileNameFromPath(string path)
//{
//    return Path.GetFileName(path);
//}

//string filePath2 = @"C:\Users\Kullanici\Belgeler\ornek.txt";
//string fileName2 = GetFileNameFromPath(filePath2);
//Console.WriteLine("Dosya Adı: " + fileName2);

//string filePath = @"C:\Users\Kullanici\Belgeler\json.data";

//string DosyaAdi1 (string path)
//{
//    return path.Substring(path.LastIndexOf('\\')+1);
//}

//string DosyaAdi2(string path)
//{
//    string[] data = path.Split('\\');
//    return data[data.Length - 1];
//}

//Console.WriteLine(DosyaAdi1(filePath));
//Console.WriteLine(DosyaAdi2(filePath));
//Console.WriteLine(Path.GetFileName(filePath));

//string strMesaj = "The brown fox jump the...";
//Console.WriteLine(strMesaj.Replace('o','a'));
//Console.WriteLine(strMesaj.Replace("fox","bear"));

//Console.WriteLine(strMesaj.Remove(10));
//Console.WriteLine(strMesaj.Substring(10));

//Console.WriteLine(strMesaj.Insert(0, "Hey.."));
    








