using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //get int from user
            Console.WriteLine("Enter an integer to have math operations performed on:");
            int userInput = int.Parse(Console.ReadLine());
            MathOps math = new MathOps();

            //add 10
            Console.WriteLine(userInput + " + 10 = ");
            Console.WriteLine(math.MathAdd(userInput));

            //multiply by 10
            Console.WriteLine(userInput + " x 10 = ");
            Console.WriteLine(math.MathMultiply(userInput));

            //subtract 10
            Console.WriteLine(userInput + " - 10 = ");
            Console.WriteLine(math.MathSub(userInput));

            Console.ReadLine();
        }
    }
}
