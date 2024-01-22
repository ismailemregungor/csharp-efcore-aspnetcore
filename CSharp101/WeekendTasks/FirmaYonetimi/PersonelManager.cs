using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekendTasks.FirmaYonetimi
{
    internal class PersonelManager : IPersonelManager
    {

        private List<Personel> _personeller = new List<Personel>();

        public List<Personel> AdreseGorePersoneller(string adres)
        {
            // Henüz LINQ konusu anlatılmadıgından uzun yöntemle yaptık

            List<Personel> _liste = new List<Personel>();

            foreach (Personel personel in _personeller)
            {
                if (personel.Adres == adres)
                {
                    _liste.Add(personel);
                }  
            }
            return _liste;
        }

        public Personel Ara(int id)
        {
            // Henüz delegates konusu anlatılmadıgından uzun yöntemle yaptık

            foreach (Personel personel in _personeller)
            {
                if (personel.Id == id)
                {
                    return personel;
                }
            }
            return null;
        }

        public void Ekle(Personel personel)
        {
            _personeller.Add(personel);
        }

        public void Guncelle(Personel personel)
        {
            _personeller.Remove(Ara(personel.Id));
            _personeller.Add(personel);
            //var mevcutPersonel = Ara(personel.Id);
            //if (mevcutPersonel != null)
            //{
            //    mevcutPersonel.Ad = personel.Ad;
            //    mevcutPersonel.Soyad = personel.Soyad;
            //    mevcutPersonel.Adres = personel.Adres;
            //}
            //else
            //{
            //    Console.WriteLine("Personel Bulunamadı!");
            //}
        }

        public void Sil(int id)
        {
            _personeller.Remove(Ara(id));
        }

        public List<Personel> TumPersoneller()
        {
            return _personeller;
        }
    }
}
