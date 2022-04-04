using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main()
        {
            List<int> integers = new List<int>()
            {
                10, 50, 100, 250, 500, 1000
            };

            Console.WriteLine("Enter non-zero int to divide list elements by:");
            
            try
            {
                int divide = int.Parse(Console.ReadLine());
                for (int i = 0; i < integers.Count; i++)
                {
                    Console.WriteLine(integers[i] / divide);
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("CANNOT DIVIDE BY A STRING");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("CANNOT DIVIDE BY ZERO");
            }
            

            Console.WriteLine("Program continues");
            Console.ReadLine();
        }
    }
}
