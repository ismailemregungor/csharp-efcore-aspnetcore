namespace ASP.NETCOREMVCKitap.Models
{
    public class Kitap_VM
    {
        public int KitapID { get; set; }
        public string KitapAdi { get; set; }
        public string Kategori { get; set; }
        public string Yazar { get; set; }
        public double Fiyat { get; set; }

        //Resim için sonradan eklenmiştir...
        public string FilePath { get; set; }
    }
}
