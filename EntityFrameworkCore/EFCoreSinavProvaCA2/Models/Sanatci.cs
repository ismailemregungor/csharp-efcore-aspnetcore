using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSinavProvaCA2.Models
{
    public class Sanatci
    {
        public int SanatciID { get; set; }
        public string SanatciAdi { get; set; }
        public ICollection<Album> Albumler { get; set; }
    }
}
