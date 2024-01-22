using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Models.IslemModels
{
    public class ParaYatirma : Islem
    {
        public override int Sure => 2;
        public override string IslemAdi => "Para Yatırma";
    }
}
