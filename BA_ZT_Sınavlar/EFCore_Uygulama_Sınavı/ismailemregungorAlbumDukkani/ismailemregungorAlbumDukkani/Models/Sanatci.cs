using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ismailemregungorAlbumDukkani.Models
{
    // Sanatci sınıfı, sanatci özellikleri temsil eder.
    public class Sanatci
    {
        public int SanatciID { get; set; }
        public string SanatciAdi { get; set; }

        // Sanatçının sahip olduğu albümler
        public ICollection<Album>? Albumler { get; set; }
    }
}
