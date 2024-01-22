using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Events2
{
    public delegate void SuyunKaynamasiHandler(string message);

    internal class Isitici
    {
        public event SuyunKaynamasiHandler KabarciklanmaEvent;
        public event SuyunKaynamasiHandler SesEvent;
        public event SuyunKaynamasiHandler KaynamaEvent;
        public void Isit() 
        {
            Console.WriteLine("Su isitilma işlemi başlıyor...");
            for (int sicaklik = 0; sicaklik < 101; sicaklik++)
            {
                if (sicaklik>=40 && sicaklik<=70)
                {
                    KabarciklanmaEvent?.Invoke("Suda Kabarciklar Oluşuyor..." + sicaklik);
                }
                else if (sicaklik>70 && sicaklik<100)
                {
                    SesEvent?.Invoke("Suda Ses Oluşuyor..." + sicaklik);
                }
                else if (sicaklik >=100)
                {
                    KaynamaEvent?.Invoke("Su Kaynıyor..." + sicaklik);
                }             
            }
            KaynamaEvent?.Invoke("Su Kaynadı...");
        }
    }
}
