using System;

namespace FizzBuzz
{
    public class FizzBuzzRule : IRule
    {
        public bool Applies(int number)
        {
            return number % 3 == 0 && number % 5 == 0;
        }

        public void Print()
        {
            Console.WriteLine("FizzBuzz");
        }
    }
}