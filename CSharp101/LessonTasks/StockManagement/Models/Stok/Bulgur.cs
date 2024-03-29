﻿using LessonTasks.StockManagement.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTasks.StockManagement.Models.Stok
{
    internal class Bulgur : Urun, IBozulabilir, ITETT
    {
        public bool BozukMu { get; set; }
        public string BozulmaNedeni { get; set; }
        public DateTime TETT { get; set; }

        public override string ToString()
        {
            return $"{UrunId}{UrunAdi}{UrunFiyati}{BozukMu}{BozulmaNedeni}{TETT}";
        }
    }
}
