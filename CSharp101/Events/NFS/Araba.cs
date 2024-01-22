using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.NFS
{
    public delegate void LastikPatlamaHandler(string message);

    internal class Araba
    {
        public event LastikPatlamaHandler LastikPatladiEvent;

        public void YolculukBaslat()
        {
            Random random = new Random();
            int patlamaAni = random.Next(1,10);
            Console.WriteLine("Yolculuk başlıyor...");
            for (int km = 0; km <= 10; km++)
            {
                Console.WriteLine($"Araba {km} km yol aldı.");
                Thread.Sleep(500);

                if (km == patlamaAni)
                {
                    LastikPatladi("Lastik Patladi, Kenara çek!");
                    break;
                }

            }
            LastikPatladi("Lastiği Değiştirmeden Devam Edemezsin!");
        }

        public void LastikPatladi(string lastik)
        {
            LastikPatladiEvent?.Invoke(lastik);
        }
    }
}
