using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreModelFirst3.Models
{
    
    public class EgitmenDers
    {
        public int EgitmenDersID { get; set; }
        public int EgitmenID { get; set; }
        public Egitmen Egitmen { get; set; }
        public int DersID { get; set; }
        public Ders Ders { get; set; }
    }
}
