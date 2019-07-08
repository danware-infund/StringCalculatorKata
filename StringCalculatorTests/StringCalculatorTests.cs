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
    }
}
