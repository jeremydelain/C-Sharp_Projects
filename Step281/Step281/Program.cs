using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step281
{
    class Program
    {
        static void Main(string[] args)
        {
            myClass mine = new myClass();
            mine.myMethod(1, 2);
            mine.myMethod(a: 1, b: 2);
        }
    }
}
