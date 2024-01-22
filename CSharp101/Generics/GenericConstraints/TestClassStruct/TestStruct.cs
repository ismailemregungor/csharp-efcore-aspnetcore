using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.GenericConstraints.TestClassStruct
{
    internal class TestStruct<T> where T : struct
    {
        public void Calculate()
        {

        }
    }
}
