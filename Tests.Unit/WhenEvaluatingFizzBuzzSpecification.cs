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
    public class WhenEvaluatingFizzBuzzSpecification
    {
        private ISpecification<int> _fizzBuzzSpec;
        

        [TestInitialize]
        public void Initialize()
        {
            var fizzSpec = new FizzSpecification();
            var buzzSpec = new BuzzSpecification();

            _fizzBuzzSpec = fizzSpec.And(buzzSpec);
        }

        [TestMethod]
        public void GivenValueDivisibleByThreeAndNotFize()
        {
            Assert.IsFalse(_fizzBuzzSpec.IsMatch(3));
            Assert.IsFalse(_fizzBuzzSpec.IsMatch(6));
            Assert.IsFalse(_fizzBuzzSpec.IsMatch(9));
        }

        [TestMethod]
        public void GivenValueDivisibleByFiveAndNotThree()
        {
            Assert.IsFalse(_fizzBuzzSpec.IsMatch(5));
            Assert.IsFalse(_fizzBuzzSpec.IsMatch(10));
            Assert.IsFalse(_fizzBuzzSpec.IsMatch(20));
        }

        [TestMethod]
        public void GivenValueDivisibleByThreeAndFive()
        {
            Assert.IsTrue(_fizzBuzzSpec.IsMatch(15));
            Assert.IsTrue(_fizzBuzzSpec.IsMatch(30));
            Assert.IsTrue(_fizzBuzzSpec.IsMatch(45));
        }
    }
}
