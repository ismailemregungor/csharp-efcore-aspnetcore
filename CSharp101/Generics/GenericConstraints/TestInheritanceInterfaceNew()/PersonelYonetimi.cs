using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.GenericConstraints.TestInheritanceInterface
{
    internal class PersonelYonetimi<T> where T: class, new()
    {

    }
}
