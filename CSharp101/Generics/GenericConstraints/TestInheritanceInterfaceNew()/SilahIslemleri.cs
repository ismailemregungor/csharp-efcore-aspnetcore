﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.GenericConstraints.TestInheritance
{
    internal class SilahIslemleri<T> where T : class, ISilahTasıyabilir 
    {
    }
}