using System;
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

        //output params
        public static void Addition(out int a, out int b)
        {
            a = 1;
            b = 2;
            a += a;
            b += b;
        }
    }
}
