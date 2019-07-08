namespace StringCalculatorTests
{
    using FluentAssertions;
    using Xunit;

    public class StringCalculatorTests
    {
        [Fact(DisplayName = "Given empty string, should return zero")]
        public void GivenEmptyString_ShouldReturnZero()
        {
            StringCalculator.Add("").Should().Be(0);
        }

        [Fact(DisplayName = "Given single number, should return number")]
        public void GivenSingleNumber_ShouldReturnNumber()
        {
            StringCalculator.Add("1").Should().Be(1);
            StringCalculator.Add("7").Should().Be(7);
        }

        [Fact(DisplayName = "Given two numbers, should return sum")]
        public void GivenTwoNumbers_ShouldReturnSum()
        {
            StringCalculator.Add("1,2").Should().Be(3);
            StringCalculator.Add("8,5").Should().Be(13);
        }
    }
}
