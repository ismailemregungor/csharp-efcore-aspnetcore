using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesingPattern
{

    /*
     * Senaryo:
     * Bir uygulamanın ayarlarını tutan bir sınıf düşünün.
     * Bu ayarlar, uygulama boyunca tek ve sabit olmalıdır 
     * ve her yerden erişilebilir olmalıdır.
     */
    public class Settings
    {
        private static Settings _instance;

        // Ayarlar için özellikler
        public string Language { get; set; }
        public int ScreenWidth { get; set; }

        // Constructor'ı private yaparak dışarıdan nesne üretimini engelliyoruz.
        private Settings()
        {
            // Varsayılan ayarları burada belirleyebiliriz.
            Language = "English";
            ScreenWidth = 1024;
        }

        // Tek örnek için statik metot.
        public static Settings GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Settings();
            }
            return _instance;
        }
    }
}
