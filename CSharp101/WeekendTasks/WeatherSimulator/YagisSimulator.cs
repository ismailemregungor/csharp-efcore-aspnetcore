using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekendTasks.WeatherSimulator
{
    internal class YagisSimulator
    {
        Random _random = new Random();
        List<Yagis> _yagislar = new List<Yagis>();
        const int YagisSuresiSaniye = 3;
        Yagis _aktifYagisTuru;
        DateTime _sonYagisDegisikligi;

        public void Baslat()
        {
            while (true)
            {
                Console.Clear(); 
                _yagislar.Clear(); 
                _aktifYagisTuru = YagisTuruSec(); 

                var baslangicZamani = DateTime.Now;
                while ((DateTime.Now - baslangicZamani).TotalSeconds < YagisSuresiSaniye)
                {
                    YagisOlustur();
                    YagislariGoster();
                    Thread.Sleep(100);
                }
            }
        }

        private Yagis YagisTuruSec()
        {
            while (true)
            {
                Console.WriteLine("Lütfen yağış türü seçin: 1- Dolu, 2- Kar, 3- Yağmur");
                var secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        return new Dolu(0, 0);
                    case "2":
                        return new Kar(0, 0);
                    case "3":
                        return new Yagmur(0, 0);
                    default:
                        Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                        break;
                }
            }
        }

        private void YagisOlustur()
        {
            if (_aktifYagisTuru == null)
            {
                YagisTuruDegistir(); 
            }

            int x = _random.Next(0, Console.WindowWidth);
            int y = _random.Next(0, Console.WindowHeight);

            Yagis yeniYagis = null;

            if (_aktifYagisTuru is Dolu)
            {
                yeniYagis = new Dolu(x, y);
            }
            else if (_aktifYagisTuru is Kar)
            {
                yeniYagis = new Kar(x, y);
            }
            else if (_aktifYagisTuru is Yagmur)
            {
                yeniYagis = new Yagmur(x, y);
            }

            _yagislar.Add(yeniYagis);
        }

        private void YagislariGoster()
        {
            Console.Clear();
            foreach (var yagis in _yagislar)
            {
                yagis.Goster();
            }
        }

        private void YagislariTemizle()
        {
            _yagislar.RemoveAll(y => (DateTime.Now - y.OlusturmaZamani).TotalSeconds > YagisSuresiSaniye);
        }

        private void YagisTuruDegistir()
        {
            int yagisTuru = _random.Next(0, 3); 

            if (yagisTuru == 0)
            {
                _aktifYagisTuru = new Dolu(0, 0); 
            }
            else if (yagisTuru == 1)
            {
                _aktifYagisTuru = new Kar(0, 0);
            }
            else
            {
                _aktifYagisTuru = new Yagmur(0, 0);
            }
        }
    }
}
