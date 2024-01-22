using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTasks.StokYonetimi.Models
{
    public class Urun
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }

        public Urun(int urunId, string urunAdi)
        {
            UrunId = urunId;
            UrunAdi = urunAdi;
        }
    }
}
