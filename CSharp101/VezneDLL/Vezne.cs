using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaDLL
{
    public class Vezne
    {
        public string No { get; set; }
        /*
         * Sınavda public Personel Personel { get; set; } gib bir yapı olacak.
         * Mesela Güvenlik diye bir class oslaydı
         * güvenlik class'ına public Personel Personel { get; set; } geçecektik.
         * Her personel her işi yapıyor.
         */
        public Personel Personel { get; set; }
        public Musteri Musteri { get; set; }

        VezneDurumu vezneDurumu;
        public VezneDurumu VezneDurumu 
        { get { return vezneDurumu; }
            set
            {
                if (value == VezneDurumu.Musait)
                {
                    vezneDurumu = value;
                    VezneMusait?.Invoke(this, new EventArgs());
                }
            }
        }

        public override string ToString()
        {
            return $"{No}{VezneDurumu}Personel --> {Personel} Müşteri --> {Musteri}";
        }

        public event EventHandler VezneMusait;
    }
}
