using System;

namespace FizzBuzz
{
    public class BuzzRule : IRule
    {
        public bool Applies(int number)
        {
            return number % 5 == 0;
        }

        public void Print()
        {
            Console.WriteLine("Buzz");
        }
    }
}