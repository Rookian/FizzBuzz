using System;
using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public void Start()
        {
            var rules = new IRule[] { new FizzBuzzRule(), new FizzRule(), new BuzzRule() };
            Enumerable.Range(1, 100).ToList().ForEach(number =>
            {
                var rule = rules.FirstOrDefault(x => x.Applies(number));
                if (rule == null)
                    Console.WriteLine(number);
                else
                    rule.Print();
            });
        }
    }
}