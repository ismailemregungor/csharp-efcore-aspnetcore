using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BankaDLL
{
    public class Banka
    {
        public Banka()
        {
            BankaIceriginiOlustur();
            TumMusaitVeznelereMusteriAta();
        }

        public MusteriManager Musteriler { get; set; }
        public VezneManager Vezneler { get; set; }
        public PersonelManager Personeller { get; set; }

        private void BankaIceriginiOlustur()
        {
            //Initialize İşlemleri
            Musteriler = new MusteriManager();
            Vezneler = new VezneManager();
            Personeller = new PersonelManager();

            int tekrarSayisi = new Random().Next(1,10);
            for (int i = 0; i < tekrarSayisi; i++)
            {
                Musteriler.Ekle(BankaUtility.MusteriOlustur());
            }

            for (int i = 0; i < 6; i++)
            {
                Personeller.Ekle(BankaUtility.PersonelOlustur());
            }

            for (int i = 0; i < 5; i++)
            {
                Vezne vezne = new Vezne();
                Vezneler.Ekle(BankaUtility.VezneOlustur(Personeller.Listele()[i]));
            }
        }

        private void VezneyeMusteriAl(object sender, EventArgs e)
        {
            
        }

        public void TumMusaitVeznelereMusteriAta()
        {
            foreach (Vezne vezne in Vezneler.Listele())
            {
                if (vezne.VezneDurumu == VezneDurumu.Musait)
                {
                    vezne.Musteri = Musteriler.Cikar();
                    vezne.VezneDurumu = VezneDurumu.Mesgul;
                }
            }
        }
    }
}
