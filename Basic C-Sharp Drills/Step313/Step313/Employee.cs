using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step313
{
    class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int Id { get; set; }

        public static bool operator ==(Employee emp1, Employee emp2)
        {
            return emp1.Id == emp2.Id;
        }
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return emp1.Id == emp2.Id;
        }
    }
}
