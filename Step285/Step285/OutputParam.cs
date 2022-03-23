using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step285
{
    static class OutputParam
    {
        //output params, double a and b
        public static void Addition(out int a, out int b)
        {
            a = 1;
            b = 2;
            a += a;
            b += b;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
