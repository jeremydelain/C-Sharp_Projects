using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step306
{
    class Employee : IQuittable
    {
        public void Quit()
        {
            Console.WriteLine("Press ENTER to QUIT:");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
