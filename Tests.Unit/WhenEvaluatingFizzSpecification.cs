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
    public class WhenEvaluatingFizzSpecification
    {
        private FizzSpecification _fizzSpec;

        [TestInitialize]
        public void Initialize()
        {
            _fizzSpec = new FizzSpecification();
        }

        [TestMethod]
        public void GivenValueDivisibleByThree()
        {
            Assert.IsTrue(_fizzSpec.IsMatch(3));
            Assert.IsTrue(_fizzSpec.IsMatch(6));
            Assert.IsTrue(_fizzSpec.IsMatch(9));
        }

        [TestMethod]
        public void GivenValueDivisibleByFive()
        {
            Assert.IsFalse(_fizzSpec.IsMatch(5));
            Assert.IsFalse(_fizzSpec.IsMatch(10));
            Assert.IsFalse(_fizzSpec.IsMatch(20));
        }
    }
}
