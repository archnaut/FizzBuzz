using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal abstract class AbstractSpecification<TCandidate> : ISpecification<TCandidate>
    {
        public abstract bool IsMatch(TCandidate candidate);

        public ISpecification<TCandidate> And(ISpecification<TCandidate> spec)
        {
            return new AndSpecification<TCandidate>(this, spec);
        }

        public ISpecification<TCandidate> Or(ISpecification<TCandidate> spec)
        {
            return new OrSpecification<TCandidate>(this, spec);
        }

        public ISpecification<TCandidate> Not()
        {
            return new NotSpecification<TCandidate>(this);
        }

        private class AndSpecification<TCandidate> : AbstractSpecification<TCandidate>
        {
            private ISpecification<TCandidate> _left;
            private ISpecification<TCandidate> _right;

            public AndSpecification(ISpecification<TCandidate> left, ISpecification<TCandidate> right)
            {
                _left = left;
                _right = right;
            }

            public override bool IsMatch(TCandidate candidate)
            {
                return _left.IsMatch(candidate) && _right.IsMatch(candidate);
            }
        }

        private class OrSpecification<TCandidate> : AbstractSpecification<TCandidate>
        {
            private ISpecification<TCandidate> _left;
            private ISpecification<TCandidate> _right;

            public OrSpecification(ISpecification<TCandidate> left, ISpecification<TCandidate> right)
            {
                _left = left;
                _right = right;
            }

            public override bool IsMatch(TCandidate candidate)
            {
                return _left.IsMatch(candidate) || _right.IsMatch(candidate);
            }
        }

        private class NotSpecification<TCandidate> : AbstractSpecification<TCandidate>
        {
            private ISpecification<TCandidate> _spec;

            public NotSpecification(ISpecification<TCandidate> spec)
            {
                _spec = spec;
            }

            public override bool IsMatch(TCandidate candidate)
            {
                return !_spec.IsMatch(candidate);
            }
        }

    }
}
