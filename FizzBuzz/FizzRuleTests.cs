using Xunit;

namespace FizzBuzz
{
    public class FizzRuleTests
    {
        [Fact]
        public void Multiples_of_three_print_Fizz()
        {
            var fizzRule = new FizzRule();

            Assert.True(fizzRule.Applies(3));
            Assert.True(fizzRule.Applies(6));
            Assert.True(fizzRule.Applies(99));
        }

        [Fact]
        public void No_Multiples_of_three_print_not_Fizz()
        {
            var fizzRule = new FizzRule();

            Assert.False(fizzRule.Applies(4));
            Assert.False(fizzRule.Applies(7));
            Assert.False(fizzRule.Applies(77));
        }
    }
}