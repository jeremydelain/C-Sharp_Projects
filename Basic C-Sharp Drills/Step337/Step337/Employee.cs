using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step337
{
    class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int Id { get; set; }

        public Employee(string first, string last, int id)
        {
            firstName = first;
            lastName = last;
            Id = id;
        }
    }
}
