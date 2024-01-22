using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Models.IslemModels
{
    public abstract class Islem
    {
        public abstract int Sure { get; }
        public abstract string IslemAdi { get; }
    }
}
