﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step285
{
      class MathOperations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        //overloaded method
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
