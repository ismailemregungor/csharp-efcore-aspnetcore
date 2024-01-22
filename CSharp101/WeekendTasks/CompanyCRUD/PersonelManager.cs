using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekendTasks.CompanyCRUD
{
    internal class PersonelManager : IPersonelManager
    {

        List<Personel> _personeller = new List<Personel>();
        public PersonelManager(List<Personel> personeller)
        {
            _personeller = personeller;
        }

        public void Ekle(Personel personel)
        {
            _personeller.Add(personel);
        }

        public List<Personel> GetirHepsi()
        {
            return _personeller;
        }

        public Personel GetirIdIle(int id)
        {
            foreach (var personel in _personeller)
            {
                if (personel.Id == id)
                {
                    return personel;
                }
            }
            return null;
        }

        public List<Personel> GetirIlceyeGore(string ilce)
        {
            var sonuc = new List<Personel>();
            foreach (var personel in _personeller)
            {
                if (personel.Ilce.ToUpper() == ilce.ToUpper())
                {
                    sonuc.Add(personel);
                }
            }
            return sonuc; 
        }

        public void Guncelle(Personel personel)
        {
            var guncellenecekPersonel = GetirIdIle(personel.Id);
            if (guncellenecekPersonel != null)
            {
                guncellenecekPersonel.Ad = personel.Ad;
                guncellenecekPersonel.Soyad = personel.Soyad;
                guncellenecekPersonel.Ilce = personel.Ilce;
            }
            else
            {
                Console.WriteLine("Personel Bulunamadı!");
            }
        }

        public void Sil(int id)
        {
            var silinecekPersonel = GetirIdIle(id);
            if (silinecekPersonel != null)
            {
                Console.WriteLine("Emin Misiniz? (E / H)");
                var cevap = Console.ReadLine();
                if (cevap.ToUpper() == "E")
                {
                    _personeller.Remove(silinecekPersonel);
                    Console.WriteLine("Personel Silindi.");
                }
            }
            else
            {
                Console.WriteLine("Personel Bulunamadı!");

            }
        }
    }
}
