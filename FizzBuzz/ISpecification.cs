using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    interface ISpecification<TCandidate>
    {
        bool IsMatch(TCandidate candidate);
    }
}
