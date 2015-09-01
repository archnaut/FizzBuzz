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
            string result = string.Empty;
            if (value % 3 == 0) { result = "Fizz"; }
            if (value % 5 == 0) { result += "Buzz"; }
            if (result == string.Empty) { result = value.ToString(); }
            return result;
        }
    }
}
