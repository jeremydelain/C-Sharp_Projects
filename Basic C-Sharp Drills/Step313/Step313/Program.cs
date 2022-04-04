using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step313
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee one = new Employee();
            one.firstName = "John";
            one.lastName = "Deere";
            one.Id = 1000;

            Employee two = new Employee();
            two.firstName = "Steve";
            two.lastName = "Rodgers";
            two.Id = 1000;

            Employee three = new Employee();
            three.firstName = "Sarah";
            three.lastName = "Haras";
            three.Id = 1001;

            Console.WriteLine(one == two);
            Console.WriteLine(one == three);
            Console.WriteLine(three == two);
            Console.ReadLine();
        }
    }
}
