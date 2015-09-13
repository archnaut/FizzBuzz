using FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Unit
{
    [TestClass]
    public class WhenEvaluatingBuzzSpecification
    {
        private BuzzSpecification _buzzSpec;

        [TestInitialize]
        public void Initialize()
        {
            _buzzSpec = new BuzzSpecification();
        }

        [TestMethod]
        public void GivenValueDivisibleByThree()
        {
            Assert.IsFalse(_buzzSpec.IsMatch(3));
            Assert.IsFalse(_buzzSpec.IsMatch(6));
            Assert.IsFalse(_buzzSpec.IsMatch(9));
        }

        [TestMethod]
        public void GivenValueDivisibleByFive()
        {
            Assert.IsTrue(_buzzSpec.IsMatch(5));
            Assert.IsTrue(_buzzSpec.IsMatch(10));
            Assert.IsTrue(_buzzSpec.IsMatch(20));
        }
    }
}
