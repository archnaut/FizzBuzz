using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class BuzzSpecification
    {
        public bool IsMatch(int candidate)
        {
            return candidate % 5 == 0;
        }
    }
}
