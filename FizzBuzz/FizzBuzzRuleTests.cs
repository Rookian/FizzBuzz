using Xunit;

namespace FizzBuzz
{
    public class FizzBuzzRuleTests
    {
        [Fact]
        public void Multiples_of_three_and_five_print_FizzBuzz()
        {
            var fizzBuzzRule = new FizzBuzzRule();

            Assert.True(fizzBuzzRule.Applies(15));
            Assert.True(fizzBuzzRule.Applies(30));
            Assert.True(fizzBuzzRule.Applies(45));
        }

        [Fact]
        public void No_Multiples_of_three_and_five_print_not_FizzBuzz()
        {
            var fizzBuzzRule = new FizzBuzzRule();

            Assert.False(fizzBuzzRule.Applies(3));
            Assert.False(fizzBuzzRule.Applies(5));
            Assert.False(fizzBuzzRule.Applies(77));
        }
    }
}