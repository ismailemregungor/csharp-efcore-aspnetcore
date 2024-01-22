using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors.ReadonlyVSConst
{
    internal class Matematik
    {
        /*
         * Const tanımlanan değişkenler sadece tanımlandığı yerde değer alır.
         * Kullanırken static member'lar gibi davranır yani direk Class'tan çağrılır.
         */
        public const double PI = 3.1415;

        public Matematik() 
        {
            // PI = 3.14; --> const constructor içinde değiştirilemez.
        }
    }
}
