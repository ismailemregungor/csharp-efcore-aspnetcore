using Banka.Models.IslemModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.Models.IslemModels
{
    public class ParaCekme : Islem
    {
        public override int Sure => 7;
        public override string IslemAdi => "Para Çekme";
    }
}
