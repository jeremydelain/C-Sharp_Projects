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

            Console.WriteLine("Enter an integer to be divided by 2:");
            int userInput = int.Parse(Console.ReadLine());
            Console.WriteLine(myMath.Divide(userInput));
            Console.ReadLine();
        }
    }
}
