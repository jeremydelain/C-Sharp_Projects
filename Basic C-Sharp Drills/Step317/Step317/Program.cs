using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step317
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> one = new Employee<string>();
            one.things = new List<string>()
            {
                "saftey vest",
                "hard hat",
                "steel toe boots",
                "clipboard"
            };

            Employee<int> two = new Employee<int>();
            two.things = new List<int>() { 1, 2, 3, 4, 5 };

            one.print();
            two.print();

            Console.ReadLine();
        }
    }
}
