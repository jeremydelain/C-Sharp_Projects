using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step285
{
    class Program
    {
        static void Main(string[] args)
        {
            //input divided by 2
            byTwo math = new byTwo();
            Console.WriteLine("Enter an integer to be divided by 2:");
            int userInput = int.Parse(Console.ReadLine());
            Console.WriteLine(math.Divide(userInput));

            //out params
            Console.WriteLine("Using out paramaters:");
            int x;
            int y;
            OutputParam.Addition(out x, out y);


            //overloaded method
            Console.WriteLine("Overloaded method for adding 2 or 3 paramaters");
            MathOperations add = new MathOperations();
            Console.WriteLine(add.Add(1, 1));
            Console.WriteLine(add.Add(1, 1, 1));

            Console.ReadLine();
        }
    }
}
