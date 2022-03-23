using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step292
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee foo = new Employee();
            foo.FirstName = "Sample";
            foo.LastName = "Student";
            foo.SayName();
            Console.ReadLine();
        }
    }
}
