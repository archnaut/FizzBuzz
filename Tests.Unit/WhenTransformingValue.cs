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
            Assert.AreEqual("2", _fizzBuzzService.Transform(2));
            Assert.AreEqual("7", _fizzBuzzService.Transform(7));
        }

        [TestMethod]
        public void GivenValueDivisibleByThreeAndNotDivisibleByFive()
        {
            Assert.AreEqual("Fizz", _fizzBuzzService.Transform(3));
            Assert.AreEqual("Fizz", _fizzBuzzService.Transform(6));
            Assert.AreEqual("Fizz", _fizzBuzzService.Transform(9));

        }

        [TestMethod]
        public void GivenValueDivisibleByFiveAndNotDivisibleByThree()
        {
            Assert.AreEqual("Buzz", _fizzBuzzService.Transform(5));
            Assert.AreEqual("Buzz", _fizzBuzzService.Transform(10));
            Assert.AreEqual("Buzz", _fizzBuzzService.Transform(20));
        }
        
        [TestMethod]
        public void GivenValueDivisibleByThreeAndFive()
        {
            Assert.AreEqual("FizzBuzz", _fizzBuzzService.Transform(15));
            Assert.AreEqual("FizzBuzz", _fizzBuzzService.Transform(30));
            Assert.AreEqual("FizzBuzz", _fizzBuzzService.Transform(45));
        }

        public void GivenValueDivisibleByThree()
        {
            Assert.AreEqual("Fizz", _fizzBuzzService.Transform(3));
            Assert.AreEqual("Fizz", _fizzBuzzService.Transform(6));
            Assert.AreEqual("Fizz", _fizzBuzzService.Transform(9));
        }
    }
}
