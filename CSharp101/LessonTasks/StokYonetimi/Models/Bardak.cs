using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LessonTasks.StokYonetimi.Interfaces;

namespace LessonTasks.StokYonetimi.Models
{
    internal class Bardak : Urun, IKirilabilir
    {
        public Bardak(int urunId, string urunAdi) : base(urunId, urunAdi)
        {

        }

        public bool KirikMi(string durum)
        {
            throw new NotImplementedException();
        }
    }
}
