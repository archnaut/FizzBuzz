using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class FizzSpecification
    {
        public bool IsMatch(int candidate)
        {
            return candidate % 3 == 0;
        }

        public ISpecification<int> And(BuzzSpecification spec)
        {
            throw new NotImplementedException();
        }
    }
}
