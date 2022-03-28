using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Current date and time:");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("\n\nEnter an integer:");
            int userInput = int.Parse(Console.ReadLine());
            TimeSpan span = new TimeSpan(userInput, 0, 0);
            Console.WriteLine("\n\nTime in {0} hours: ", userInput);
            Console.WriteLine(DateTime.Now + span);


            Console.ReadLine();
        }
    }
}
