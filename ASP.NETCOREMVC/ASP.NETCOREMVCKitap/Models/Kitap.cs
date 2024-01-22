using System.ComponentModel.DataAnnotations;

namespace ASP.NETCOREMVCKitap.Models
{
    public class Kitap
    {
        public int KitapID { get; set; }

        [Display(Name = "Kitap Adı")]
        public string KitapAdi { get; set; }

        [Display(Name = "Kategori")]
        public int KategoriID { get; set; }

        //Duruma gore bu iki kullanımdan biri kullanılır...
        //Model katmanında IFromFile kullanılmamalı..

        public string FilePath { get; set; }
        public IFormFile File { get; set; }

        public int YazarID { get; set; }
        public double Fiyat { get; set; }
    }
}
