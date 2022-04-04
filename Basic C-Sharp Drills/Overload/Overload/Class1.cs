using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload
{
    class MathOperation
    {
        public int AddTen(int input)
        {
            return input + 10;
        }

        public int AddTen(double input)
        {
            return (int)input + 10;
        }

        public int AddTen(string input)
        {
            return int.Parse(input) + 10;
        }
    }
}
