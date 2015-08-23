using System;
using FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Unit
{
    [TestClass]
    public class WhenTransformingValue
    {
        FizzBuzzService _fizzBuzzService;

        [TestInitialize]
        public void Initialize()
        {
            _fizzBuzzService = new FizzBuzzService();
        }

        [TestMethod]
        public void GivenValueDivisibleByNeitherThreeOrFive()
        {
            Assert.AreEqual("1", _fizzBuzzService.Transform(1));
        }

        [TestMethod]
        public void GivenValueDivisibleByThreeAndNotDivisibleByFive()
        {
            Assert.AreEqual("Fizz", _fizzBuzzService.Transform(3));
        }

        [TestMethod]
        public void GivenValueDivisibleByFiveAndNotDivisibleByThree()
        {
            Assert.AreEqual("Buzz", _fizzBuzzService.Transform(5));
        }
        
        [TestMethod]
        public void GivenValueDivisibleByThreeAndFive()
        {
            Assert.AreEqual("FizzBuzz", _fizzBuzzService.Transform(15));
        }
    }
}
