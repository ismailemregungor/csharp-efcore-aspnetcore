using Events.Events1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.NFS2
{
    public delegate void OlayYakala(object sender);
    internal class Lastik: ILastikPatlayabilir
    {
        public string Konum { get; set; }

        public bool Saglam { get; set; }

        public event OlayYakala LastikPatladi;
    }
}
