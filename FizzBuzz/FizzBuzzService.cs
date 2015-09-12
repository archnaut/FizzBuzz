using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class FizzBuzzService : ITransformService
    {
        public string Transform(int value)
        {
            var buzzSpec = new BuzzSpecification();
            var fizzSpec = new FizzSpecification();

            if (fizzSpec.IsMatch(value) && buzzSpec.IsMatch(value)) {
                return "FizzBuzz";
            }

            if (fizzSpec.IsMatch(value)) { 
                return "Fizz";
            }

            if (buzzSpec.IsMatch(value)) { 
                return "Buzz"; 
            }

            return value.ToString();
        }
    }
}
