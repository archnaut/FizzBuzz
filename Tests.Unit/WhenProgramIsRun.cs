using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;
using System.Linq;

namespace Tests.Unit
{
    [TestClass]
    public class WhenProgramIsRun
    {
        [TestMethod]
        public void ShouldTransformSequence()
        {
            var transformService = new TransfromServiceStub();
            var program = new Program(transformService);
            var range = Enumerable.Range(1, 100);

            program.Run();

            Assert.IsTrue(range.SequenceEqual(transformService.Sequence));
        }

        private class TransfromServiceStub : ITransformService
        {
            private List<object> _sequence;

            public TransfromServiceStub()
            {
                _sequence = new List<object>();
            }

            public string Transform(object value)
            {
                _sequence.Add(value);

                return value.ToString();
            }

            public IEnumerable<int> Sequence
            {
                get{return _sequence.Cast<int>();}
            }
        }
    }
}
