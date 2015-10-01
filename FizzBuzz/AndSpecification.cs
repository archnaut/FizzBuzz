using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class AndSpecification<TCandidate> : ISpecification<TCandidate>
    {
        public AndSpecification(ISpecification<TCandidate> left, ISpecification<TCandidate> right)
        {
            throw new NotImplementedException();
        }

        public bool IsMatch(TCandidate candidate)
        {
            throw new NotImplementedException();
        }
    }
}
