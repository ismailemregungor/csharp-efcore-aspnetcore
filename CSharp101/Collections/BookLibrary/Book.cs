using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.BookLibrary
{
    public class Book
    {
        private int KitapId { get; set; }

        private string KitapAdi { get; set; }

        private string YazarAdi { get; set; }

        private int KitapFiyati { get; set; }


        public Book(int KitapId, string KitapAdi, string YazarAdi, int KitapFiyati)
        {
            this.KitapId = KitapId;
            this.KitapAdi = KitapAdi;
            this.YazarAdi = YazarAdi;
            this.KitapFiyati = KitapFiyati;
        }

        public override string ToString()
        {
            return $"Kitap ID: {KitapId}, Kitap Adı: {KitapAdi}, Yazar Adı: {YazarAdi}, Kitap Fiyatı: {KitapFiyati}";
        }
    }
}
