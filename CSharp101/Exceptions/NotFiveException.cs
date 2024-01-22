using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class NotFiveException:Exception
    {
        public override string Message => "5 olamaz...";
    }
}
