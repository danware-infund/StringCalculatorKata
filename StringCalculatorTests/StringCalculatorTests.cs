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
    }
}
