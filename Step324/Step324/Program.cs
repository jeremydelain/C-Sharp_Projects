using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step324
{
    class Program
    {
        enum Week
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the current day of the week:");
            string userDay = Console.ReadLine();
            try
            {
                Week week = (Week)Enum.Parse(typeof(Week), userDay);
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
 
            Console.ReadLine();
        }

        
    }
}
