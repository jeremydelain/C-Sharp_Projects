using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step317
{
    class Employee <T>
    {
        public List<T> things { get; set; }

        //print all items in a given 'things' List
        public void print()
        {
            foreach(T item in things)
            {
                Console.WriteLine(item);
            }
        }
    }
}
