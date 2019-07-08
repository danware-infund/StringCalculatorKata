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
                var customDelimiter = "";
                if (numbers.IndexOf("\\") == 0)
                {
                    customDelimiter = string.Format("\\{0}", numbers.Substring(1, (numbers.IndexOf('\n') - 1)));
                    numbers = numbers.Substring(numbers.IndexOf("\n") + 1);
                }

                string[] numberArray = Regex.Split(numbers, $"[,\n{customDelimiter}]");
                foreach (string number in numberArray)
                    total += int.Parse(number);
            }
            return total;
        }
    }
}
