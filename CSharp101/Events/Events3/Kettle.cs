using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Events3
{
    public delegate void SicaklikYakalayici();
    internal class Kettle
    {
        public SicaklikYakalayici Kabarciklanma;
        public SicaklikYakalayici SesCikarma;
        public SicaklikYakalayici Kaynama;

        public int Derece { get; set; }

        public void Isit()
        {
            if (Derece>40)
            {
                Kabarciklanma?.Invoke();
            }
            if (Derece > 70)
            {
                SesCikarma?.Invoke();
            }
            if (Derece > 95)
            {
                Kaynama?.Invoke();
            }
            Derece++;
        }
    }
}
