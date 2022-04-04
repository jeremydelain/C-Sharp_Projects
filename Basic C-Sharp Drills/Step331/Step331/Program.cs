using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step331
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num = new Number();
            num.Amount = 123;
            Console.WriteLine(num.Amount);

            Console.ReadLine();
        }
    }
}
