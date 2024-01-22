using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LessonTasks.StokYonetimi.Interfaces;

namespace LessonTasks.StokYonetimi.Models
{
    internal class KagitHavlu : Urun, IDeformeOlabilir
    {
        public KagitHavlu(int urunId, string urunAdi) : base(urunId, urunAdi)
        {

        }

        public bool DeformeOlmusMu(string durum)
        {
            throw new NotImplementedException();
        }
    }
}
