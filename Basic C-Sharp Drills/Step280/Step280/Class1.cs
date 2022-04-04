using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step280
{
    class OptionalParam
    {
        //add inputs and return as int
        public int AddInputs(int a, int b = 0)
        {
            return a + b;
        }
    }
}
