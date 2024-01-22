using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Models.IslemModels
{
    public class Havale : Islem
    {
        public override int Sure => 5;
        public override string IslemAdi => "Havale";
    }
}
