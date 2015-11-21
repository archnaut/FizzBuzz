using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace Tests.Unit
{
    [TestClass]
    public class MiscTests
    {
        [TestMethod]
        public void FizzSpecification_Is_A_ISpecification()
        {
            Assert.IsInstanceOfType(new FizzSpecification(), typeof(ISpecification<int>));
        }

        [TestMethod]
        public void BuzzSpecification_Is_A_ISpecification()
        {
            Assert.IsInstanceOfType(new BuzzSpecification(), typeof(ISpecification<int>));
        }

        [TestMethod]
        public void LeftAndRightAreTrue()
        {
            var left = new TrueSpecification();
            var right = new TrueSpecification();

            ISpecification<string> spec = left.And(right);

            Assert.IsTrue(spec.IsMatch("Always True"));
        }

        [TestMethod]
        public void LeftTrueAndRightFalse()
        {
            var left = new TrueSpecification();
            var right = new FalseSpecification();

            ISpecification<string> spec = left.And(right);

            Assert.IsFalse(spec.IsMatch("ignored"));
        }

        [TestMethod]
        public void LeftFalseAndRightTrue()
        {
            var left = new FalseSpecification();
            var right = new TrueSpecification();

            ISpecification<string> spec = left.And(right);

            Assert.IsFalse(spec.IsMatch("ignored"));
        }

        [TestMethod]
        public void LeftFalseAndRightFalse()
        {
            var left = new FalseSpecification();
            var right = new FalseSpecification();

            ISpecification<string> spec = left.And(right);

            Assert.IsFalse(spec.IsMatch("ignored"));
        }

        /// <summary>
        /// For testing will ignore candidate and always return true
        /// </summary>
        private class TrueSpecification : AbstractSpecification<string>
        {
            public override bool IsMatch(string candidate)
            {
                return true;
            }

        }

        /// <summary>
        /// For testing will ignore candidate and always return false
        /// </summary>
        private class FalseSpecification : AbstractSpecification<string>
        {
            public override bool IsMatch(string candidate)
            {
                return false;
            }
        }
    }
}
