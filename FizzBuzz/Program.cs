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
        IEnumerable<int> range;
            
        static void Main(string[] args) 
        {
        }

        public Program(ITransformService transformService, IPrinter printer)
        {
            _transformService = transformService;
            range = Enumerable.Range(1, 100);
        }   

        public void Run()
        {
            foreach (int i in range)
            {
                _transformService.Transform(i);
            }
        }
    }
}
