using System;

namespace Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            //instatiate MathOperation and call 3 overloaded methods
            MathOperation math = new MathOperation();
            Console.WriteLine(math.AddTen(5));
            Console.WriteLine(math.AddTen(5.5));
            Console.WriteLine(math.AddTen("5"));
            
            Console.ReadLine();
        }
    }
}
