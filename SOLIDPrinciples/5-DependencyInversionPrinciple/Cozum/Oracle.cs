﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_DependencyInversionPrinciple.Cozum
{
    internal class Oracle : ICRUD
    {
        public void Add()
        {
            throw new NotImplementedException();
        }

        public string Read()
        {
            return "Oracle";
        }
    }
}
