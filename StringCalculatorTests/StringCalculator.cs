namespace StringCalculatorTests
{
    public class StringCalculator
    {
        public static int Add(string numbers)
        {
            var total = 0;

            if (!string.IsNullOrEmpty(numbers))
            {
                if (numbers.IndexOf(',') > 0)
                    foreach (string number in numbers.Split(','))
                        total += int.Parse(number);
                else total = int.Parse(numbers);
            }

            return total;
        }
    }
}
