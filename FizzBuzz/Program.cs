using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        private ITransformService _transformService;
        private IPrinter _printer;
        private IEnumerable<int> _range;
        
            
        static void Main(string[] args) 
        {
            
        }

        public Program(ITransformService transformService, IPrinter printer)
        {
            _transformService = transformService;
            _range = Enumerable.Range(1, 100);
            _printer = printer;
        }   

        public void Run()
        {
            foreach (int i in _range)
            {
                _printer.Print(_transformService.Transform(i));
            }
        }
    }
}
