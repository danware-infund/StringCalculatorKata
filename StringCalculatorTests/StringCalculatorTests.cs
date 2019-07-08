namespace StringCalculatorTests
{
    using FluentAssertions;
    using Xunit;

    public class StringCalculatorTests
    {
        [Fact]
        public void StringCalculator_ClassExists()
        {
            new StringCalculator().Should().NotBeNull();
        }
    }
}
