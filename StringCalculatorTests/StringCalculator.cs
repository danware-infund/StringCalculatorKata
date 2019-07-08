namespace StringCalculatorTests
{
    using System.Text.RegularExpressions;

    public class StringCalculator
    {
        public static int Add(string numbers)
        {
            var total = 0;

            if (!string.IsNullOrEmpty(numbers))
            {
                string[] numberArray = Regex.Split(numbers, "[,\n]");
                foreach (string number in numberArray)
                    total += int.Parse(number);
            }
            return total;
        }
    }
}
