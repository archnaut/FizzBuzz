using System;

namespace FizzBuzz
{
    internal class ConsolePrinter : IPrinter
    {
        public void Print(string value)
        {
            Console.WriteLine(value);
        }
    }
}