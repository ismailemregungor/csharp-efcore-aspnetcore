using EFCoreSinavProvaCA2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreSinavProvaCA2.Models
{
    public class Sarki
    {
        public int SarkiID { get; set; }
        public string SarkiAdi { get; set; }
        public int AlbumId { get; set; }
        public Album Album { get; set; }
    }
}
