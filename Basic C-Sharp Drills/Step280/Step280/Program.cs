using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step280
{
    class Program
    {
        static void Main(string[] args)
        {
            OptionalParam opt = new OptionalParam();

            //collect 1-2 inputs from user
            Console.WriteLine("Enter two integers. The second may be blank. Your entries will be added and returned:");
            int a = int.Parse(Console.ReadLine());
            string userInputB = Console.ReadLine();

            //check if user gave two inputs
            try
            {
                int b = int.Parse(userInputB);
                Console.WriteLine(opt.AddInputs(a, b));
            }
            //evaluate with one input
            catch(FormatException e)
            {
                Console.WriteLine(opt.AddInputs(a));
            }
            Console.ReadLine();
        }
    }
}
