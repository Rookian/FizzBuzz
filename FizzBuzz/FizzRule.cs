using System;

namespace FizzBuzz
{
    public class FizzRule : IRule
    {
        public bool Applies(int number)
        {
            return number % 3 == 0;
        }

        public void Print()
        {
            Console.WriteLine("Fizz");
        }
    }
}