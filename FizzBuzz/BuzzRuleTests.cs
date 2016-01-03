using Xunit;

namespace FizzBuzz
{
    public class BuzzRuleTests
    {
        [Fact]
        public void Multiples_of_five_print_Buzz()
        {
            var buzzRule = new BuzzRule();

            Assert.True(buzzRule.Applies(5));
            Assert.True(buzzRule.Applies(10));
            Assert.True(buzzRule.Applies(25));
        }

        [Fact]
        public void No_Multiples_of_five_print_not_Buzz()
        {
            var buzzRule = new BuzzRule();

            Assert.False(buzzRule.Applies(4));
            Assert.False(buzzRule.Applies(9));
            Assert.False(buzzRule.Applies(31));
        }
    }
}