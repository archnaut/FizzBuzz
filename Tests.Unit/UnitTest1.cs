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
    }
}
