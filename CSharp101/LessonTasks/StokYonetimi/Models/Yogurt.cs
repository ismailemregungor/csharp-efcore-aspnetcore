using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LessonTasks.StokYonetimi.Interfaces;

namespace LessonTasks.StokYonetimi.Models
{
    internal class Yogurt : Urun, IBozulabilir, ISonKullanimTarihiGecebilir, IDeformeOlabilir
    {
        public DateTime SonKullanimTarihi { get; set; }
        public Yogurt(DateTime SonKullanimTarihi, int urunId, string urunAdi) : base(urunId, urunAdi)
        {
            this.SonKullanimTarihi = SonKullanimTarihi;
        }

        public bool SonKullanmaTarihiGecmisMi(DateTime tarih)
        {
            if (SonKullanimTarihi < tarih)
            {
                return true;
            }
            return false;

        }

        public bool DeformeOlmusMu(string durum)
        {
            throw new NotImplementedException();
        }

        public bool BozukMu(string durum)
        {
            throw new NotImplementedException();
        }
    }
}
