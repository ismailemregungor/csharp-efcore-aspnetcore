using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTasks._1
{
    internal class Musteri
    {
        //ad soyad kesin girilmeliyse constructurda olmalı
        public int MusteriId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        //Cinsiyet enum tanımlanmalı
        public int Cinsiyet { get; set; }
    }
}
