namespace StringCalculatorTests
{
    public class StringCalculator
    {
        public static int Add(string numbers)
        {
            var total = 0;

            if (!string.IsNullOrEmpty(numbers))
                total = int.Parse(numbers);

            return total;
        }
    }
}
