using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public string GetResult(int input)
        {
            if (InputIsDivisibleByThree(input) && InputIsDivisibleByFive(input))
            {
                return "FizzBuzz";
            }

            if (InputIsDivisibleByFive(input))
            {
                return "Buzz" + WhizOrEmptyString(input);
            }

            if (InputIsDivisibleByThree(input))
            {
                return "Fizz" + WhizOrEmptyString(input);
            }

            return IsPrimeNumber(input) ?  WhizOrEmptyString(input) : InputAsString(input);
        }

        private static string InputAsString(int input)
        {
            return input.ToString();
        }

        private string WhizOrEmptyString(int input)
        {
            if (IsPrimeNumber(input))
            {
                return "Whiz";
            }

            return string.Empty;
        }

        private static bool IsPrimeNumber(int input)
        {
            return Enumerable.Range(1, input)
                .Where(x => input % x == 0)
                .SequenceEqual(new[] {1, input});
        }

        private static bool InputIsDivisibleByFive(int input)
        {
            return input % 5 == 0;
        }

        private static bool InputIsDivisibleByThree(int input)
        {
            return input % 3 == 0;
        }
    }
}
