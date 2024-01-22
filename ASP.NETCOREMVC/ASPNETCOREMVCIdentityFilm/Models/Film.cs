namespace ASPNETCOREMVCIdentityFilm.Models
{
    public class Film
    {
        public int FilmID { get; set; }
        public string FilmAdi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public double IMDBPuani { get; set; }
        public string Afis { get; set; }
        public string Ozet { get; set; }
        public int Sure { get; set; }
    }
}
