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
        IEnumerable<int> _range;
        TransformServiceStub _transformService;
        PrinterStub _printer;
        Program _program;

        [TestInitialize]
        public void Initialize()
        {
            _range = Enumerable.Range(1, 100);
            _transformService = new TransformServiceStub();
            _printer = new PrinterStub();
            _program = new Program(_transformService, _printer);

            _program.Run();
        }

        [TestMethod]
        public void ShouldTransformSequence()
        {
            Assert.IsTrue(_range.SequenceEqual(_transformService.Sequence));
        }

        [TestMethod]
        public void ShouldPrintValues()
        {
            Assert.IsTrue(_range.Select(x => x.ToString()).SequenceEqual(_printer.PrintedValues));
        }

        private class TransformServiceStub : ITransformService
        {
            private List<int> _sequence;

            public TransformServiceStub()
            {
                _sequence = new List<int>();
            }

            public string Transform(int value)
            {
                _sequence.Add(value);

                return value.ToString();
            }

            public IEnumerable<int> Sequence
            {
                get{return _sequence.Cast<int>();}
            }
        }

        private class PrinterStub : IPrinter
        {
            private List<string> _values;

            public PrinterStub()
            {
                _values = new List<string>();
            }
        
            public void Print(string value)
            {
                _values.Add(value);
            }

            public IEnumerable<string> PrintedValues
            {
                get{return _values;}
            }
        }
    }
}
