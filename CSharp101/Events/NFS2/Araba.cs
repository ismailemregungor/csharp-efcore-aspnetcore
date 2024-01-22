using Events.Events1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.NFS2
{
    internal class Araba
    {
        private List<Lastik> _lastikler = new List<Lastik>(4);

        public event OlayYakalayıcı HasarOlustu;
        public Araba()
        {
            _lastikler.Add(new Lastik()
            {
                Konum = "Sağ Ön"
            });
            _lastikler.Add(new Lastik()
            {
                Konum = "Sol Ön"
            });
            _lastikler.Add(new Lastik()
            {
                Konum = "Sağ Arka"
            });
            _lastikler.Add(new Lastik()
            {
                Konum = "Sol Arka"
            });

            foreach (var item in _lastikler)
            {
                
            }
        }
    }
}
