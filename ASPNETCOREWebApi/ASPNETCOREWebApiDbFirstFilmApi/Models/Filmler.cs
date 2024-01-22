using System;
using System.Collections.Generic;

namespace ASPNETCOREWebApiDbFirstFilmApi.Models
{
    public partial class Filmler
    {
        public int FilmId { get; set; }
        public string FilmAdi { get; set; } = null!;
        public DateTime CikisTarihi { get; set; }
        public double Imdbpuani { get; set; }
        public string Afis { get; set; } = null!;
        public string Ozet { get; set; } = null!;
        public int Sure { get; set; }
    }
}
